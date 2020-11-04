namespace ak_win {
    partial class MainWindow {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.logListBox = new System.Windows.Forms.ListBox();
            this.Radio_LogKind_FormPDFMaker = new System.Windows.Forms.RadioButton();
            this.Radio_LogKind_SkyPDFAddIn = new System.Windows.Forms.RadioButton();
            this.LogReadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogFileSelectButton = new System.Windows.Forms.Button();
            this.LogFilePathLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SelectLogFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Howtouse = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Version = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.LogViewerTab = new System.Windows.Forms.TabPage();
            this.KifuTab = new System.Windows.Forms.TabPage();
            this.DevTodoTab = new System.Windows.Forms.TabPage();
            this.todoSaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.LogViewerTab.SuspendLayout();
            this.DevTodoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 12;
            this.logListBox.Location = new System.Drawing.Point(0, 31);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(792, 340);
            this.logListBox.TabIndex = 0;
            this.logListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Radio_LogKind_FormPDFMaker
            // 
            this.Radio_LogKind_FormPDFMaker.AutoSize = true;
            this.Radio_LogKind_FormPDFMaker.Location = new System.Drawing.Point(349, 6);
            this.Radio_LogKind_FormPDFMaker.Name = "Radio_LogKind_FormPDFMaker";
            this.Radio_LogKind_FormPDFMaker.Size = new System.Drawing.Size(119, 16);
            this.Radio_LogKind_FormPDFMaker.TabIndex = 1;
            this.Radio_LogKind_FormPDFMaker.TabStop = true;
            this.Radio_LogKind_FormPDFMaker.Text = "FormPDFmaker.log";
            this.Radio_LogKind_FormPDFMaker.UseVisualStyleBackColor = true;
            this.Radio_LogKind_FormPDFMaker.CheckedChanged += new System.EventHandler(this.Radio_LogKind_CheckedChanged);
            // 
            // Radio_LogKind_SkyPDFAddIn
            // 
            this.Radio_LogKind_SkyPDFAddIn.AutoSize = true;
            this.Radio_LogKind_SkyPDFAddIn.Location = new System.Drawing.Point(233, 9);
            this.Radio_LogKind_SkyPDFAddIn.Name = "Radio_LogKind_SkyPDFAddIn";
            this.Radio_LogKind_SkyPDFAddIn.Size = new System.Drawing.Size(110, 16);
            this.Radio_LogKind_SkyPDFAddIn.TabIndex = 2;
            this.Radio_LogKind_SkyPDFAddIn.TabStop = true;
            this.Radio_LogKind_SkyPDFAddIn.Text = "SkyPDFAddIn.log";
            this.Radio_LogKind_SkyPDFAddIn.UseVisualStyleBackColor = true;
            // 
            // LogReadButton
            // 
            this.LogReadButton.Location = new System.Drawing.Point(8, 6);
            this.LogReadButton.Name = "LogReadButton";
            this.LogReadButton.Size = new System.Drawing.Size(59, 19);
            this.LogReadButton.TabIndex = 3;
            this.LogReadButton.Text = "Read";
            this.LogReadButton.UseVisualStyleBackColor = true;
            this.LogReadButton.Click += new System.EventHandler(this.LogReadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "LogFile : ";
            // 
            // LogFileSelectButton
            // 
            this.LogFileSelectButton.Location = new System.Drawing.Point(474, 8);
            this.LogFileSelectButton.Name = "LogFileSelectButton";
            this.LogFileSelectButton.Size = new System.Drawing.Size(59, 19);
            this.LogFileSelectButton.TabIndex = 5;
            this.LogFileSelectButton.Text = "Select";
            this.LogFileSelectButton.UseVisualStyleBackColor = true;
            this.LogFileSelectButton.Click += new System.EventHandler(this.LogFileSelectButton_Click);
            // 
            // LogFilePathLabel
            // 
            this.LogFilePathLabel.AutoSize = true;
            this.LogFilePathLabel.Location = new System.Drawing.Point(131, 9);
            this.LogFilePathLabel.Name = "LogFilePathLabel";
            this.LogFilePathLabel.Size = new System.Drawing.Size(72, 12);
            this.LogFilePathLabel.TabIndex = 6;
            this.LogFilePathLabel.Text = "non-selected";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Menu,
            this.ToolStripMenuItem_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_Menu
            // 
            this.ToolStripMenuItem_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SelectLogFormat});
            this.ToolStripMenuItem_Menu.Name = "ToolStripMenuItem_Menu";
            this.ToolStripMenuItem_Menu.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItem_Menu.Text = "メニュー";
            this.ToolStripMenuItem_Menu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem_SelectLogFormat
            // 
            this.ToolStripMenuItem_SelectLogFormat.Name = "ToolStripMenuItem_SelectLogFormat";
            this.ToolStripMenuItem_SelectLogFormat.Size = new System.Drawing.Size(165, 22);
            this.ToolStripMenuItem_SelectLogFormat.Text = "ログフォーマット選択";
            this.ToolStripMenuItem_SelectLogFormat.Click += new System.EventHandler(this.ToolStripMenuItem_SelectLogFormat_Click);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Howtouse,
            this.ToolStripMenuItem_Version});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_Help.Text = "ヘルプ";
            // 
            // ToolStripMenuItem_Howtouse
            // 
            this.ToolStripMenuItem_Howtouse.Name = "ToolStripMenuItem_Howtouse";
            this.ToolStripMenuItem_Howtouse.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Howtouse.Text = "How To Use";
            this.ToolStripMenuItem_Howtouse.Click += new System.EventHandler(this.ToolStripMenuItem_Howtouse_Click);
            // 
            // ToolStripMenuItem_Version
            // 
            this.ToolStripMenuItem_Version.Name = "ToolStripMenuItem_Version";
            this.ToolStripMenuItem_Version.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_Version.Text = "Version";
            this.ToolStripMenuItem_Version.Click += new System.EventHandler(this.ToolStripMenuItem_Version_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "status";
            this.toolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.LogViewerTab);
            this.tabControl1.Controls.Add(this.KifuTab);
            this.tabControl1.Controls.Add(this.DevTodoTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 398);
            this.tabControl1.TabIndex = 9;
            // 
            // LogViewerTab
            // 
            this.LogViewerTab.Controls.Add(this.label1);
            this.LogViewerTab.Controls.Add(this.LogFileSelectButton);
            this.LogViewerTab.Controls.Add(this.LogReadButton);
            this.LogViewerTab.Controls.Add(this.logListBox);
            this.LogViewerTab.Controls.Add(this.Radio_LogKind_FormPDFMaker);
            this.LogViewerTab.Controls.Add(this.Radio_LogKind_SkyPDFAddIn);
            this.LogViewerTab.Controls.Add(this.LogFilePathLabel);
            this.LogViewerTab.Location = new System.Drawing.Point(4, 22);
            this.LogViewerTab.Name = "LogViewerTab";
            this.LogViewerTab.Padding = new System.Windows.Forms.Padding(3);
            this.LogViewerTab.Size = new System.Drawing.Size(792, 372);
            this.LogViewerTab.TabIndex = 0;
            this.LogViewerTab.Text = "LogViewer";
            this.LogViewerTab.UseVisualStyleBackColor = true;
            this.LogViewerTab.Click += new System.EventHandler(this.LogViewerTab_Click);
            // 
            // KifuTab
            // 
            this.KifuTab.Location = new System.Drawing.Point(4, 22);
            this.KifuTab.Name = "KifuTab";
            this.KifuTab.Padding = new System.Windows.Forms.Padding(3);
            this.KifuTab.Size = new System.Drawing.Size(792, 372);
            this.KifuTab.TabIndex = 2;
            this.KifuTab.Text = "Kifu";
            this.KifuTab.UseVisualStyleBackColor = true;
            // 
            // DevTodoTab
            // 
            this.DevTodoTab.Controls.Add(this.todoSaveButton);
            this.DevTodoTab.Controls.Add(this.textBox1);
            this.DevTodoTab.Location = new System.Drawing.Point(4, 22);
            this.DevTodoTab.Name = "DevTodoTab";
            this.DevTodoTab.Padding = new System.Windows.Forms.Padding(3);
            this.DevTodoTab.Size = new System.Drawing.Size(792, 372);
            this.DevTodoTab.TabIndex = 1;
            this.DevTodoTab.Text = "DevTodo";
            this.DevTodoTab.UseVisualStyleBackColor = true;
            // 
            // todoSaveButton
            // 
            this.todoSaveButton.Location = new System.Drawing.Point(422, 282);
            this.todoSaveButton.Name = "todoSaveButton";
            this.todoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.todoSaveButton.TabIndex = 1;
            this.todoSaveButton.Text = "Save";
            this.todoSaveButton.UseVisualStyleBackColor = true;
            this.todoSaveButton.Click += new System.EventHandler(this.todoSaveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 248);
            this.textBox1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ArmyKnife";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.LogViewerTab.ResumeLayout(false);
            this.LogViewerTab.PerformLayout();
            this.DevTodoTab.ResumeLayout(false);
            this.DevTodoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.RadioButton Radio_LogKind_FormPDFMaker;
        private System.Windows.Forms.RadioButton Radio_LogKind_SkyPDFAddIn;
        private System.Windows.Forms.Button LogReadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogFileSelectButton;
        private System.Windows.Forms.Label LogFilePathLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SelectLogFormat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage LogViewerTab;
        private System.Windows.Forms.TabPage DevTodoTab;
        private System.Windows.Forms.TabPage KifuTab;
        private System.Windows.Forms.Button todoSaveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Howtouse;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Version;
    }
}

