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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.pbOverall = new System.Windows.Forms.ProgressBar();
            this.SettingButton = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.WatchedFolderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WatchedFolderTextBox = new System.Windows.Forms.TextBox();
            this.TempFolderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AllowTabloidCheckBox = new System.Windows.Forms.CheckBox();
            this.PrinterListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TempFolderTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.WatchedFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TempFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(93, 9);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(220, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(321, 9);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(220, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(547, 9);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear Temp";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(12, 41);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(610, 255);
            this.MainRichTextBox.TabIndex = 3;
            this.MainRichTextBox.Text = "";
            // 
            // pbOverall
            // 
            this.pbOverall.Location = new System.Drawing.Point(12, 302);
            this.pbOverall.Name = "pbOverall";
            this.pbOverall.Size = new System.Drawing.Size(610, 23);
            this.pbOverall.TabIndex = 4;
            // 
            // SettingButton
            // 
            this.SettingButton.Location = new System.Drawing.Point(12, 9);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(75, 23);
            this.SettingButton.TabIndex = 6;
            this.SettingButton.Text = "Settings";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.CancelButton);
            this.SettingsPanel.Controls.Add(this.SaveButton);
            this.SettingsPanel.Controls.Add(this.WatchedFolderButton);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.WatchedFolderTextBox);
            this.SettingsPanel.Controls.Add(this.TempFolderButton);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.AllowTabloidCheckBox);
            this.SettingsPanel.Controls.Add(this.PrinterListComboBox);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.TempFolderTextBox);
            this.SettingsPanel.Enabled = false;
            this.SettingsPanel.Location = new System.Drawing.Point(12, 41);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(610, 255);
            this.SettingsPanel.TabIndex = 7;
            this.SettingsPanel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(438, 216);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(519, 216);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // WatchedFolderButton
            // 
            this.WatchedFolderButton.Location = new System.Drawing.Point(569, 11);
            this.WatchedFolderButton.Name = "WatchedFolderButton";
            this.WatchedFolderButton.Size = new System.Drawing.Size(25, 23);
            this.WatchedFolderButton.TabIndex = 8;
            this.WatchedFolderButton.Text = "...";
            this.WatchedFolderButton.UseVisualStyleBackColor = true;
            this.WatchedFolderButton.Click += new System.EventHandler(this.WatchedFolderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Watched Folder";
            // 
            // WatchedFolderTextBox
            // 
            this.WatchedFolderTextBox.Location = new System.Drawing.Point(109, 11);
            this.WatchedFolderTextBox.Name = "WatchedFolderTextBox";
            this.WatchedFolderTextBox.Size = new System.Drawing.Size(454, 23);
            this.WatchedFolderTextBox.TabIndex = 6;
            // 
            // TempFolderButton
            // 
            this.TempFolderButton.Location = new System.Drawing.Point(569, 42);
            this.TempFolderButton.Name = "TempFolderButton";
            this.TempFolderButton.Size = new System.Drawing.Size(25, 23);
            this.TempFolderButton.TabIndex = 5;
            this.TempFolderButton.Text = "...";
            this.TempFolderButton.UseVisualStyleBackColor = true;
            this.TempFolderButton.Click += new System.EventHandler(this.TempFolderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Printer";
            // 
            // AllowTabloidCheckBox
            // 
            this.AllowTabloidCheckBox.AutoSize = true;
            this.AllowTabloidCheckBox.Location = new System.Drawing.Point(109, 100);
            this.AllowTabloidCheckBox.Name = "AllowTabloidCheckBox";
            this.AllowTabloidCheckBox.Size = new System.Drawing.Size(97, 19);
            this.AllowTabloidCheckBox.TabIndex = 3;
            this.AllowTabloidCheckBox.Text = "Allow Tabloid";
            this.AllowTabloidCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrinterListComboBox
            // 
            this.PrinterListComboBox.FormattingEnabled = true;
            this.PrinterListComboBox.Location = new System.Drawing.Point(109, 71);
            this.PrinterListComboBox.Name = "PrinterListComboBox";
            this.PrinterListComboBox.Size = new System.Drawing.Size(454, 23);
            this.PrinterListComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temp Folder";
            // 
            // TempFolderTextBox
            // 
            this.TempFolderTextBox.Location = new System.Drawing.Point(109, 42);
            this.TempFolderTextBox.Name = "TempFolderTextBox";
            this.TempFolderTextBox.Size = new System.Drawing.Size(454, 23);
            this.TempFolderTextBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 340);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.pbOverall);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows Printer Hotfolder";
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button ClearButton;
        private RichTextBox MainRichTextBox;
        private ProgressBar pbOverall;
        private Button SettingButton;
        private Panel SettingsPanel;
        private CheckBox AllowTabloidCheckBox;
        private ComboBox PrinterListComboBox;
        private Label label1;
        private TextBox TempFolderTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Button TempFolderButton;
        private Button WatchedFolderButton;
        private Label label3;
        private TextBox WatchedFolderTextBox;
        private Button SaveButton;
        private Button CancelButton;
        private FolderBrowserDialog WatchedFolderDialog;
        private FolderBrowserDialog TempFolderDialog;
        private BindingSource bindingSource1;
    }
}