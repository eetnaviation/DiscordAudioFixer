namespace DiscordAudioFixer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.runningProcesses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.visualLog = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attachToProcessBtn = new System.Windows.Forms.Button();
            this.verboseMode = new System.Windows.Forms.CheckBox();
            this.inputChoices = new System.Windows.Forms.ComboBox();
            this.outputChoices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scanDevicesBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runningProcesses
            // 
            this.runningProcesses.FormattingEnabled = true;
            this.runningProcesses.Location = new System.Drawing.Point(76, 12);
            this.runningProcesses.Name = "runningProcesses";
            this.runningProcesses.Size = new System.Drawing.Size(712, 23);
            this.runningProcesses.TabIndex = 0;
            this.runningProcesses.SelectedIndexChanged += new System.EventHandler(this.runningProcesses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Processes";
            // 
            // visualLog
            // 
            this.visualLog.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.visualLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualLog.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.visualLog.Location = new System.Drawing.Point(12, 251);
            this.visualLog.Name = "visualLog";
            this.visualLog.Size = new System.Drawing.Size(1563, 397);
            this.visualLog.TabIndex = 2;
            this.visualLog.Text = "";
            this.visualLog.TextChanged += new System.EventHandler(this.visualLog_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Log";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // attachToProcessBtn
            // 
            this.attachToProcessBtn.Location = new System.Drawing.Point(794, 12);
            this.attachToProcessBtn.Name = "attachToProcessBtn";
            this.attachToProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.attachToProcessBtn.TabIndex = 4;
            this.attachToProcessBtn.Text = "ATTACH";
            this.attachToProcessBtn.UseVisualStyleBackColor = true;
            this.attachToProcessBtn.Click += new System.EventHandler(this.attachToProcessBtn_Click);
            // 
            // verboseMode
            // 
            this.verboseMode.AutoSize = true;
            this.verboseMode.BackColor = System.Drawing.Color.Transparent;
            this.verboseMode.Location = new System.Drawing.Point(1452, 14);
            this.verboseMode.Name = "verboseMode";
            this.verboseMode.Size = new System.Drawing.Size(123, 19);
            this.verboseMode.TabIndex = 5;
            this.verboseMode.Text = "Verbose mode (-v)";
            this.verboseMode.UseVisualStyleBackColor = false;
            // 
            // inputChoices
            // 
            this.inputChoices.FormattingEnabled = true;
            this.inputChoices.Location = new System.Drawing.Point(76, 69);
            this.inputChoices.Name = "inputChoices";
            this.inputChoices.Size = new System.Drawing.Size(344, 23);
            this.inputChoices.TabIndex = 6;
            // 
            // outputChoices
            // 
            this.outputChoices.FormattingEnabled = true;
            this.outputChoices.Location = new System.Drawing.Point(76, 98);
            this.outputChoices.Name = "outputChoices";
            this.outputChoices.Size = new System.Drawing.Size(344, 23);
            this.outputChoices.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "INPUT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "OUTPUT";
            // 
            // scanDevicesBtn
            // 
            this.scanDevicesBtn.Location = new System.Drawing.Point(76, 127);
            this.scanDevicesBtn.Name = "scanDevicesBtn";
            this.scanDevicesBtn.Size = new System.Drawing.Size(75, 23);
            this.scanDevicesBtn.TabIndex = 10;
            this.scanDevicesBtn.Text = "RESCAN";
            this.scanDevicesBtn.UseVisualStyleBackColor = true;
            this.scanDevicesBtn.Click += new System.EventHandler(this.scanDevicesBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(875, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "If there are multiple processes with the same name choose any one of them.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiscordAudioFixer.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1587, 660);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scanDevicesBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputChoices);
            this.Controls.Add(this.inputChoices);
            this.Controls.Add(this.verboseMode);
            this.Controls.Add(this.attachToProcessBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visualLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runningProcesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "DiscordAudioFixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox runningProcesses;
        private Label label1;
        private RichTextBox visualLog;
        private Label label2;
        private Button attachToProcessBtn;
        private CheckBox verboseMode;
        private ComboBox inputChoices;
        private ComboBox outputChoices;
        private Label label3;
        private Label label4;
        private Button scanDevicesBtn;
        private Label label5;
    }
}