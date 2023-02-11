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
using System.Drawing.Printing;
using System.DirectoryServices.ActiveDirectory;
using static iTextSharp.text.pdf.PdfDocument;
using System.Runtime;

namespace WindowsPrinterHotfolder
{
    public partial class Form1 : Form
    {
        List<string> hotfolderFiles = new();

        public Form1()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            SettingCheck();
            MainTimer.Tick += new EventHandler(hotFolderParse);
        }

        private void SettingCheck()
        {
            StartButton.Enabled = true;
            if (!Directory.Exists(Settings.Default.TempFolder))
            {
                StartButton.Enabled = false;
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText(DateTime.Now + " | " + "Set Temp Folder...\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);

            }
            if (!Directory.Exists(Settings.Default.HotFolder))
            {
                StartButton.Enabled = false;
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText(DateTime.Now + " | " + "Set HotFolder...\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);

            }
            if (Settings.Default.Printer.Equals(""))
            {
                StartButton.Enabled = false;
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText(DateTime.Now + " | " + "Set Printer...\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            }
        }

        private void hotFolderParse(Object source, EventArgs e)
        {
            MainTimer.Stop();
            hotfolderFiles = new();
            try
            {
                DirectoryInfo dinfo = new DirectoryInfo(Settings.Default.HotFolder);
                FileInfo[] Files = dinfo.GetFiles("*.pdf").ToArray();

                foreach (FileInfo file in Files)
                {
                    hotfolderFiles.Add(file.Name);
                }

                for (int i = 0; i < hotfolderFiles.Count; i++)
                {
                    MainRichTextBox.AppendText(DateTime.Now + " | Added file: " + hotfolderFiles[i] + "\r\n", Color.Black, FontStyle.Regular);
                }

                MainTimer.Stop();

                if (hotfolderFiles.Count != 0 && !MainBGW.IsBusy)
                {
                    object[] hotfolderArgs = { hotfolderFiles.ToArray(), hotfolderFiles.Count() };
                    MainBGW.RunWorkerAsync(hotfolderArgs);
                    hotfolderFiles.Clear();
                }

                MainTimer.Start();
            }
            catch (Exception ex)
            {
                MainRichTextBox.AppendText(DateTime.Now + " | " + ex.Message + "\r\n", Color.Red, FontStyle.Regular);
                hotfolderFiles.Clear();
                MainTimer.Start();
            }
        }

        public void MakePrintPdf(string passedFile)
        {
            Form mainForm = new Form1();
            //passedFile = Settings.Default.hotFolder + "\\" + passedFile;         
            string gillRFont = "Fonts\\GIL_____.TTF";
            BaseFont GillSansR = BaseFont.CreateFont(gillRFont, BaseFont.CP1252, BaseFont.EMBEDDED);
            FileStream fs1 = new FileStream(Path.Combine(Settings.Default.TempFolder, Path.GetFileName(passedFile)), FileMode.Create, FileAccess.Write, FileShare.None);
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

            SendToPrinter(Path.Combine(Settings.Default.TempFolder, Path.GetFileName(passedFile)), false, tabloid);

        }
        public void SendToPrinter(string printFile, bool fit, bool tabloid)
        {            
            GhostscriptVersionInfo gvi = new GhostscriptVersionInfo(new Version(0, 0, 0), System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "References", "gsdll64.dll"), string.Empty, GhostscriptLicense.GPL);
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
                if (fit)
                {
                    switches.Add("-dPDFFitPage");

                }
                switches.Add("-dNumCopies=1");
                switches.Add("-sDEVICE=mswinpr2");
                switches.Add(Convert.ToString("-sOutputFile=%printer%") + Settings.Default.Printer);
                switches.Add("-f");
                switches.Add(printFile);
                processor.StartProcessing(switches.ToArray(), null);
            }
        }
        public bool IsFileLocked(FileInfo file)
        {
            try
            {
                using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true;
            }

            return false;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Enabled = true;
            SettingsPanel.Visible = true;
            WatchedFolderTextBox.Text = Settings.Default.HotFolder;
            SettingsFilePath(WatchedFolderTextBox, WatchedFolderDialog);
            TempFolderTextBox.Text = Settings.Default.TempFolder;
            SettingsFilePath(TempFolderTextBox, TempFolderDialog);
            PrinterListComboBox.Text = Settings.Default.Printer;

            string listOfPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                listOfPrinters = PrinterSettings.InstalledPrinters[i];
                PrinterListComboBox.Items.Add(listOfPrinters);
            }
            AllowTabloidCheckBox.Checked = Settings.Default.AllowTabloid;

            
        }
        public void SettingsFilePath(TextBox textBox, FolderBrowserDialog folderBrowserDialog)
        {
            if (textBox.Text == "")
            {
                textBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        public void SettingsClick(TextBox textBox, FolderBrowserDialog folderBrowserDialog)
        {
            if (Directory.Exists(textBox.Text))
            {
                folderBrowserDialog.SelectedPath = textBox.Text;
            }
            else
            {
                folderBrowserDialog.SelectedPath = Settings.Default.LastFolder;
            }

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = folderBrowserDialog.SelectedPath;
                Settings.Default.LastFolder = folderBrowserDialog.SelectedPath;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            SettingsPanel.Enabled = false;
            SettingsPanel.Visible = false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.Default.AllowTabloid = AllowTabloidCheckBox.Checked;
            Settings.Default.HotFolder = WatchedFolderTextBox.Text;
            Settings.Default.TempFolder = TempFolderTextBox.Text;
            Settings.Default.Printer = PrinterListComboBox.Text;
            Settings.Default.Save();
            SettingsPanel.Enabled = false;
            SettingsPanel.Visible = false;
            SettingCheck();
            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText(DateTime.Now + " | " + "Settings Saved...\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
        }

        private void WatchedFolderButton_Click(object sender, EventArgs e)
        {
            SettingsClick(WatchedFolderTextBox, WatchedFolderDialog);
        }

        private void TempFolderButton_Click(object sender, EventArgs e)
        {
            SettingsClick(TempFolderTextBox, TempFolderDialog);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Settings.Default.TempFolder))
            {
                Directory.Delete(Settings.Default.TempFolder, true);
                Directory.CreateDirectory(Settings.Default.TempFolder);
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText(DateTime.Now + " | " + "Clearing Temp Folder...\r\n", Color.Black, FontStyle.Regular);
                MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ClearButton.Enabled = false;
            ClearButton.Visible = false;
            StartButton.Visible = false;
            StopButton.Visible = true;
            StopButton.Enabled = true;
            SettingButton.Enabled = false;

            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText(DateTime.Now + " | HotFolder Parsing Started...\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            MainTimer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {            
            ClearButton.Enabled = true;
            ClearButton.Visible = true;
            StopButton.Visible = false;
            StopButton.Enabled = false;
            StartButton.Visible = true;
            StartButton.Enabled = true;
            SettingButton.Enabled = true;
            MainBGW.CancelAsync();
            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText(DateTime.Now + " | HotFolder Parsing Stopped...\r\n", Color.Black, FontStyle.Regular);
            MainRichTextBox.AppendText("-------------------------------------------------------------\r\n", Color.Black, FontStyle.Regular);
            MainTimer.Stop();
        }

        private void MainBGW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Invoke(new Action(() => { MainProgressBar.Value = 0; }));
            MainTimer.Stop();
            object[] arg = e.Argument as object[];
            string[] passedArray = (string[])arg[0];
            List<string> passedList = passedArray.ToList();
            int fileProgressStep = (int)Math.Ceiling(((double)100) / (int)arg[1]);

            foreach (string runfile in passedList)
            {
                try
                {
                    MakePrintPdf(Path.Combine(Settings.Default.HotFolder, runfile));

                    if (File.Exists(Path.Combine(Settings.Default.HotFolder, runfile)))
                    {
                        File.Delete(Path.Combine(Settings.Default.HotFolder, runfile));
                    }

                    MainBGW.ReportProgress(fileProgressStep);
                }
                catch (Exception workerError)
                {
                    Invoke(new Action(() => { MainRichTextBox.AppendText(DateTime.Now + " | " + workerError.Message + ". \r\n", Color.Red, FontStyle.Regular); }));
                    MainBGW.ReportProgress(fileProgressStep);
                }

                if (passedList.Count > 0)
                {
                    e.Result = "Done";
                }
            }

        }

        private void MainBGW_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            MainProgressBar.Step = e.ProgressPercentage;
            MainProgressBar.PerformStep();
        }

        private void MainBGW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Invoke(new Action(() => { MainRichTextBox.AppendText(DateTime.Now + " | " + (string)e.Error.Message + "Error. \r\n\r\n", Color.Red, FontStyle.Regular); }));
                MainTimer.Start();
            }
            else
            {
                if ((string)e.Result == "Done")
                {
                    Invoke(new Action(() => { MainRichTextBox.AppendText(DateTime.Now + " | " + "Files Processed. \r\n\r\n", Color.Black, FontStyle.Regular); }));
                }
                MainTimer.Start();
            }
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionStart = MainRichTextBox.Text.Length;
            MainRichTextBox.ScrollToCaret();
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, FontStyle style)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionFont = new System.Drawing.Font(box.Font, style);
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}