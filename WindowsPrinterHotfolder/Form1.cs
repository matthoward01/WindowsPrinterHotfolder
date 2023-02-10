using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Drawing;
using Ghostscript.NET;
using Ghostscript.NET.Processor;
using WindowsPrinterHotfolder.Properties;

namespace WindowsPrinterHotfolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void PreflightPdfPrint(string passedFile)
        {
            Form mainForm = new Form1();
            //passedFile = Settings.Default.hotFolder + "\\" + passedFile;         
            string gillRFont = "Fonts\\GIL_____.TTF";
            BaseFont GillSansR = BaseFont.CreateFont(gillRFont, BaseFont.CP1252, BaseFont.EMBEDDED);
            FileStream fs1 = new FileStream(Path.GetFileName(passedFile), FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc1 = new Document();
            PdfReader inputFile = new PdfReader(passedFile);
            PdfWriter writer1 = PdfWriter.GetInstance(doc1, fs1);
            writer1.PdfVersion = PdfWriter.VERSION_1_3;
            int pageCount = inputFile.NumberOfPages;
            int fileProgressStep = (int)Math.Ceiling(((double)100) / pageCount);
            bool tabloid = false;
            float paperWidth = 792;
            float paperHeight = 1224;
            doc1.Open();
            for (int i = 1; i <= pageCount; i++)
            {
                PdfImportedPage page = writer1.GetImportedPage(inputFile, i);
                iTextSharp.text.Rectangle fileSize = inputFile.GetBoxSize(i, "media");
                doc1.SetMargins(0, 0, 0, 0);
                bool rotate = false;
                float scalePercent = 1;
                paperWidth = 612;
                paperHeight = 792;
                doc1.SetPageSize(new iTextSharp.text.Rectangle(paperWidth, paperHeight));

                if (((fileSize.Width * fileSize.Height) < 414720) || 
                    ((fileSize.Width == 612) && fileSize.Height == 792) || 
                    ((fileSize.Width == 792) && fileSize.Height == 612))
                {
                    //mainForm.BeginInvoke(new Action(() => { mainForm.rtMain.AppendText(DateTime.Now + "| " + tabloid +"\r\n", Color.Red, FontStyle.Regular); }));
                    
                }
                else if (Settings.Default.AllowTabloid)
                {
                    tabloid = true;
                    paperWidth = 792;
                    paperHeight = 1224;
                    doc1.SetPageSize(new iTextSharp.text.Rectangle(paperWidth, paperHeight));
                }

                float widthScale = fileSize.Width;
                float heightScale = fileSize.Height;
                float xPosition = (paperWidth - fileSize.Width) / 2;
                float yPosition = (paperHeight - fileSize.Height) / 2;

                if (fileSize.Width > fileSize.Height)
                {
                    rotate = true;
                    xPosition = (((paperWidth - fileSize.Height) / 2) + fileSize.Height);
                    yPosition = (paperHeight - fileSize.Width) / 2;
                }
                if ((fileSize.Width > paperWidth || fileSize.Height > paperHeight) && !rotate)
                {
                    widthScale = paperWidth / fileSize.Width;
                    heightScale = paperHeight / fileSize.Height;

                    if (widthScale < heightScale)
                    {
                        scalePercent = widthScale;
                    }
                    else
                    {
                        scalePercent = heightScale;
                    }
                    scalePercent = scalePercent - .05f;
                    xPosition = ((paperWidth - (fileSize.Width * scalePercent)) / 2) / scalePercent;
                    yPosition = ((paperHeight - (fileSize.Height * scalePercent)) / 2) / scalePercent;
                }
                if ((fileSize.Width > paperHeight || fileSize.Height > paperWidth) && rotate)
                {
                    widthScale = paperHeight / fileSize.Width;
                    heightScale = paperWidth / fileSize.Height;
                    if (widthScale < heightScale)
                    {
                        scalePercent = widthScale;
                    }
                    else
                    {
                        scalePercent = heightScale;
                    }
                    scalePercent = scalePercent - .05f;
                    xPosition = (((paperWidth - (fileSize.Height * scalePercent)) / 2) + (fileSize.Height * scalePercent)) / scalePercent;
                    yPosition = ((paperHeight - (fileSize.Width * scalePercent)) / 2) / scalePercent;
                    //xPosition = (paperHeight - (fileSizeTrim.Height * scalePercent));
                    //yPosition = (paperWidth - (fileSizeTrim.Width * scalePercent));
                }
                doc1.NewPage();
                PdfReader pdfFile = new PdfReader(passedFile);
                PdfImportedPage pdfPage = writer1.GetImportedPage(pdfFile, i);
                PdfContentByte cb = writer1.DirectContent;
                var placePdf = new System.Drawing.Drawing2D.Matrix();
                placePdf.Scale(scalePercent, scalePercent);
                placePdf.Translate(xPosition, yPosition);
                if (rotate)
                {
                    placePdf.Rotate(90);
                }
                writer1.DirectContent.AddTemplate(pdfPage, placePdf);
                //mainForm.BeginInvoke(new Action(() => { mainForm.pbIndividual.Step = fileProgressStep; }));
                //mainForm.BeginInvoke(new Action(() => { mainForm.pbIndividual.PerformStep(); }));
                cb.BeginText();
                cb.SetFontAndSize(GillSansR, 12);
                cb.SetTextMatrix(36, 36);
                cb.ShowText(Path.GetFileNameWithoutExtension(passedFile) + " - Pg: " + i);
                cb.EndText();
            }
            doc1.Close();

            SendToPrinter(Settings.Default.tempFolder + "\\" + Path.GetFileName(passedFile), false, tabloid);

        }
        public void SendToPrinter(string printFile, bool ticket, bool tabloid)
        {            
            GhostscriptVersionInfo gvi = new GhostscriptVersionInfo(new Version(0, 0, 0), System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "gsdll32.dll"), string.Empty, GhostscriptLicense.GPL);
            using (GhostscriptProcessor processor = new GhostscriptProcessor(gvi))
            {
                List<string> switches = new List<string>();
                switches.Add("-dPrinted");
                switches.Add("-dBATCH");
                switches.Add("-dNOPAUSE");
                switches.Add("-dNOSAFER");
                if (tabloid)
                {
                    switches.Add("-g792x1224");
                }
                if (ticket)
                {
                    switches.Add("-dPDFFitPage");

                }
                switches.Add("-dNumCopies=1");
                switches.Add("-sDEVICE=mswinpr2");
                switches.Add(Convert.ToString("-sOutputFile=%printer%") + Settings.Default.printer);
                switches.Add("-f");
                switches.Add(printFile);
                processor.StartProcessing(switches.ToArray(), null);
            }
        }
    }
}