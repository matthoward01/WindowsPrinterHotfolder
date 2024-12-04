namespace WindowsPrinterHotfolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StartButton = new Button();
            StopButton = new Button();
            ClearButton = new Button();
            MainProgressBar = new ProgressBar();
            SettingButton = new Button();
            SettingsPanel = new Panel();
            PrintFileInfoCheckBox2 = new CheckBox();
            WatchedFolderButton2 = new Button();
            label4 = new Label();
            WatchedFolderTextBox2 = new TextBox();
            TempFolderButton2 = new Button();
            label5 = new Label();
            AllowTabloidCheckBox2 = new CheckBox();
            PrinterListComboBox2 = new ComboBox();
            label6 = new Label();
            TempFolderTextBox2 = new TextBox();
            PrintFileInfoCheckBox = new CheckBox();
            CancelButton = new Button();
            SaveButton = new Button();
            WatchedFolderButton = new Button();
            label3 = new Label();
            WatchedFolderTextBox = new TextBox();
            TempFolderButton = new Button();
            label2 = new Label();
            AllowTabloidCheckBox = new CheckBox();
            PrinterListComboBox = new ComboBox();
            label1 = new Label();
            TempFolderTextBox = new TextBox();
            MainBGW = new System.ComponentModel.BackgroundWorker();
            WatchedFolderDialog = new FolderBrowserDialog();
            TempFolderDialog = new FolderBrowserDialog();
            MainTimer = new System.Windows.Forms.Timer(components);
            TrayIcon = new NotifyIcon(components);
            MainTimer2 = new System.Windows.Forms.Timer(components);
            TempFolderDialog2 = new FolderBrowserDialog();
            WatchedFolderDialog2 = new FolderBrowserDialog();
            MainBGW2 = new System.ComponentModel.BackgroundWorker();
            MainProgressBar2 = new ProgressBar();
            MainRichTextBox = new RichTextBox();
            MainRichTextBox2 = new RichTextBox();
            SettingsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(93, 9);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(220, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Location = new Point(321, 9);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(220, 23);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Visible = false;
            StopButton.Click += StopButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(547, 9);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "Clear Temp";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MainProgressBar
            // 
            MainProgressBar.Location = new Point(12, 302);
            MainProgressBar.Name = "MainProgressBar";
            MainProgressBar.Size = new Size(610, 12);
            MainProgressBar.TabIndex = 4;
            // 
            // SettingButton
            // 
            SettingButton.Location = new Point(12, 9);
            SettingButton.Name = "SettingButton";
            SettingButton.Size = new Size(75, 23);
            SettingButton.TabIndex = 6;
            SettingButton.Text = "Settings";
            SettingButton.UseVisualStyleBackColor = true;
            SettingButton.Click += SettingButton_Click;
            // 
            // SettingsPanel
            // 
            SettingsPanel.Controls.Add(PrintFileInfoCheckBox2);
            SettingsPanel.Controls.Add(WatchedFolderButton2);
            SettingsPanel.Controls.Add(label4);
            SettingsPanel.Controls.Add(WatchedFolderTextBox2);
            SettingsPanel.Controls.Add(TempFolderButton2);
            SettingsPanel.Controls.Add(label5);
            SettingsPanel.Controls.Add(AllowTabloidCheckBox2);
            SettingsPanel.Controls.Add(PrinterListComboBox2);
            SettingsPanel.Controls.Add(label6);
            SettingsPanel.Controls.Add(TempFolderTextBox2);
            SettingsPanel.Controls.Add(PrintFileInfoCheckBox);
            SettingsPanel.Controls.Add(CancelButton);
            SettingsPanel.Controls.Add(SaveButton);
            SettingsPanel.Controls.Add(WatchedFolderButton);
            SettingsPanel.Controls.Add(label3);
            SettingsPanel.Controls.Add(WatchedFolderTextBox);
            SettingsPanel.Controls.Add(TempFolderButton);
            SettingsPanel.Controls.Add(label2);
            SettingsPanel.Controls.Add(AllowTabloidCheckBox);
            SettingsPanel.Controls.Add(PrinterListComboBox);
            SettingsPanel.Controls.Add(label1);
            SettingsPanel.Controls.Add(TempFolderTextBox);
            SettingsPanel.Enabled = false;
            SettingsPanel.Location = new Point(12, 42);
            SettingsPanel.Name = "SettingsPanel";
            SettingsPanel.Size = new Size(610, 255);
            SettingsPanel.TabIndex = 7;
            SettingsPanel.Visible = false;
            // 
            // PrintFileInfoCheckBox2
            // 
            PrintFileInfoCheckBox2.AutoSize = true;
            PrintFileInfoCheckBox2.Location = new Point(212, 214);
            PrintFileInfoCheckBox2.Name = "PrintFileInfoCheckBox2";
            PrintFileInfoCheckBox2.Size = new Size(96, 19);
            PrintFileInfoCheckBox2.TabIndex = 20;
            PrintFileInfoCheckBox2.Text = "Print File Info";
            PrintFileInfoCheckBox2.UseVisualStyleBackColor = true;
            // 
            // WatchedFolderButton2
            // 
            WatchedFolderButton2.Location = new Point(569, 125);
            WatchedFolderButton2.Name = "WatchedFolderButton2";
            WatchedFolderButton2.Size = new Size(25, 23);
            WatchedFolderButton2.TabIndex = 19;
            WatchedFolderButton2.Text = "...";
            WatchedFolderButton2.UseVisualStyleBackColor = true;
            WatchedFolderButton2.Click += WatchedFolderButton2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 133);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 18;
            label4.Text = "Watched Folder 2";
            // 
            // WatchedFolderTextBox2
            // 
            WatchedFolderTextBox2.Location = new Point(109, 125);
            WatchedFolderTextBox2.Name = "WatchedFolderTextBox2";
            WatchedFolderTextBox2.Size = new Size(454, 23);
            WatchedFolderTextBox2.TabIndex = 17;
            // 
            // TempFolderButton2
            // 
            TempFolderButton2.Location = new Point(569, 156);
            TempFolderButton2.Name = "TempFolderButton2";
            TempFolderButton2.Size = new Size(25, 23);
            TempFolderButton2.TabIndex = 16;
            TempFolderButton2.Text = "...";
            TempFolderButton2.UseVisualStyleBackColor = true;
            TempFolderButton2.Click += TempFolderButton2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 193);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 15;
            label5.Text = "Printer 2";
            // 
            // AllowTabloidCheckBox2
            // 
            AllowTabloidCheckBox2.AutoSize = true;
            AllowTabloidCheckBox2.Location = new Point(109, 214);
            AllowTabloidCheckBox2.Name = "AllowTabloidCheckBox2";
            AllowTabloidCheckBox2.Size = new Size(97, 19);
            AllowTabloidCheckBox2.TabIndex = 14;
            AllowTabloidCheckBox2.Text = "Allow Tabloid";
            AllowTabloidCheckBox2.UseVisualStyleBackColor = true;
            // 
            // PrinterListComboBox2
            // 
            PrinterListComboBox2.FormattingEnabled = true;
            PrinterListComboBox2.Location = new Point(109, 185);
            PrinterListComboBox2.Name = "PrinterListComboBox2";
            PrinterListComboBox2.Size = new Size(454, 23);
            PrinterListComboBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 164);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 12;
            label6.Text = "Temp Folder 2";
            // 
            // TempFolderTextBox2
            // 
            TempFolderTextBox2.Location = new Point(109, 156);
            TempFolderTextBox2.Name = "TempFolderTextBox2";
            TempFolderTextBox2.Size = new Size(454, 23);
            TempFolderTextBox2.TabIndex = 11;
            // 
            // PrintFileInfoCheckBox
            // 
            PrintFileInfoCheckBox.AutoSize = true;
            PrintFileInfoCheckBox.Location = new Point(212, 100);
            PrintFileInfoCheckBox.Name = "PrintFileInfoCheckBox";
            PrintFileInfoCheckBox.Size = new Size(96, 19);
            PrintFileInfoCheckBox.TabIndex = 10;
            PrintFileInfoCheckBox.Text = "Print File Info";
            PrintFileInfoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(438, 216);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(519, 216);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // WatchedFolderButton
            // 
            WatchedFolderButton.Location = new Point(569, 11);
            WatchedFolderButton.Name = "WatchedFolderButton";
            WatchedFolderButton.Size = new Size(25, 23);
            WatchedFolderButton.TabIndex = 8;
            WatchedFolderButton.Text = "...";
            WatchedFolderButton.UseVisualStyleBackColor = true;
            WatchedFolderButton.Click += WatchedFolderButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "Watched Folder";
            // 
            // WatchedFolderTextBox
            // 
            WatchedFolderTextBox.Location = new Point(109, 11);
            WatchedFolderTextBox.Name = "WatchedFolderTextBox";
            WatchedFolderTextBox.Size = new Size(454, 23);
            WatchedFolderTextBox.TabIndex = 6;
            // 
            // TempFolderButton
            // 
            TempFolderButton.Location = new Point(569, 42);
            TempFolderButton.Name = "TempFolderButton";
            TempFolderButton.Size = new Size(25, 23);
            TempFolderButton.TabIndex = 5;
            TempFolderButton.Text = "...";
            TempFolderButton.UseVisualStyleBackColor = true;
            TempFolderButton.Click += TempFolderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 79);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Printer";
            // 
            // AllowTabloidCheckBox
            // 
            AllowTabloidCheckBox.AutoSize = true;
            AllowTabloidCheckBox.Location = new Point(109, 100);
            AllowTabloidCheckBox.Name = "AllowTabloidCheckBox";
            AllowTabloidCheckBox.Size = new Size(97, 19);
            AllowTabloidCheckBox.TabIndex = 3;
            AllowTabloidCheckBox.Text = "Allow Tabloid";
            AllowTabloidCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrinterListComboBox
            // 
            PrinterListComboBox.FormattingEnabled = true;
            PrinterListComboBox.Location = new Point(109, 71);
            PrinterListComboBox.Name = "PrinterListComboBox";
            PrinterListComboBox.Size = new Size(454, 23);
            PrinterListComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Temp Folder";
            // 
            // TempFolderTextBox
            // 
            TempFolderTextBox.Location = new Point(109, 42);
            TempFolderTextBox.Name = "TempFolderTextBox";
            TempFolderTextBox.Size = new Size(454, 23);
            TempFolderTextBox.TabIndex = 0;
            // 
            // MainBGW
            // 
            MainBGW.WorkerReportsProgress = true;
            MainBGW.WorkerSupportsCancellation = true;
            MainBGW.DoWork += MainBGW_DoWork;
            MainBGW.ProgressChanged += MainBGW_ProgressChanged;
            MainBGW.RunWorkerCompleted += MainBGW_RunWorkerCompleted;
            // 
            // MainTimer
            // 
            MainTimer.Interval = 600000;
            MainTimer.Tick += hotFolderParse;
            // 
            // TrayIcon
            // 
            TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            TrayIcon.Text = "Windows Printer Hotfolder";
            TrayIcon.MouseDoubleClick += TrayIcon_MouseDoubleClick;
            // 
            // MainTimer2
            // 
            MainTimer2.Interval = 600000;
            MainTimer2.Tick += hotFolderParse2;
            // 
            // MainBGW2
            // 
            MainBGW2.WorkerReportsProgress = true;
            MainBGW2.WorkerSupportsCancellation = true;
            MainBGW2.DoWork += MainBGW2_DoWork;
            MainBGW2.ProgressChanged += MainBGW2_ProgressChanged;
            MainBGW2.RunWorkerCompleted += MainBGW2_RunWorkerCompleted;
            // 
            // MainProgressBar2
            // 
            MainProgressBar2.Location = new Point(12, 316);
            MainProgressBar2.Name = "MainProgressBar2";
            MainProgressBar2.Size = new Size(610, 12);
            MainProgressBar2.TabIndex = 8;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Location = new Point(12, 41);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(610, 126);
            MainRichTextBox.TabIndex = 3;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // MainRichTextBox2
            // 
            MainRichTextBox2.Location = new Point(12, 171);
            MainRichTextBox2.Name = "MainRichTextBox2";
            MainRichTextBox2.Size = new Size(610, 126);
            MainRichTextBox2.TabIndex = 12;
            MainRichTextBox2.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 340);
            Controls.Add(SettingsPanel);
            Controls.Add(MainProgressBar2);
            Controls.Add(SettingButton);
            Controls.Add(MainProgressBar);
            Controls.Add(ClearButton);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(MainRichTextBox);
            Controls.Add(MainRichTextBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Windows Printer Hotfolder";
            Resize += Form1_Resize;
            SettingsPanel.ResumeLayout(false);
            SettingsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button ClearButton;
        private ProgressBar MainProgressBar;
        private Button SettingButton;
        private Panel SettingsPanel;
        private CheckBox AllowTabloidCheckBox;
        private ComboBox PrinterListComboBox;
        private Label label1;
        private TextBox TempFolderTextBox;
        private System.ComponentModel.BackgroundWorker MainBGW;
        private Label label2;
        private Button TempFolderButton;
        private Button WatchedFolderButton;
        private Label label3;
        private TextBox WatchedFolderTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private FolderBrowserDialog WatchedFolderDialog;
        private FolderBrowserDialog TempFolderDialog;
        private System.Windows.Forms.Timer MainTimer;
        private NotifyIcon TrayIcon;
        private CheckBox PrintFileInfoCheckBox;
        private CheckBox PrintFileInfoCheckBox2;
        private Button WatchedFolderButton2;
        private Label label4;
        private TextBox WatchedFolderTextBox2;
        private Button TempFolderButton2;
        private Label label5;
        private CheckBox AllowTabloidCheckBox2;
        private ComboBox PrinterListComboBox2;
        private Label label6;
        private TextBox TempFolderTextBox2;
        private System.Windows.Forms.Timer MainTimer2;
        private FolderBrowserDialog TempFolderDialog2;
        private FolderBrowserDialog WatchedFolderDialog2;
        private System.ComponentModel.BackgroundWorker MainBGW2;
        private ProgressBar MainProgressBar2;
        private RichTextBox MainRichTextBox;
        private RichTextBox MainRichTextBox2;
    }
}