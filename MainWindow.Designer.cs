using System.Runtime.CompilerServices;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ToolStripStatusLabel_AK = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControl_AK = new System.Windows.Forms.TabControl();
            this.DevTodoTab = new System.Windows.Forms.TabPage();
            this.devtodoUserPassLabel = new System.Windows.Forms.Label();
            this.devtodoUrlLabel = new System.Windows.Forms.Label();
            this.devTodoLoadButton = new System.Windows.Forms.Button();
            this.devTodoSaveButton = new System.Windows.Forms.Button();
            this.devTodoTextBox = new System.Windows.Forms.TextBox();
            this.ShogiTab = new System.Windows.Forms.TabPage();
            this.shogi_testlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C_9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogViewerTab = new System.Windows.Forms.TabPage();
            this.RedmineTab = new System.Windows.Forms.TabPage();
            this.redmineButton = new System.Windows.Forms.Button();
            this.RedmineTextBox = new System.Windows.Forms.TextBox();
            this.RedmineLabel = new System.Windows.Forms.Label();
            this.Timer_AK = new System.Windows.Forms.Timer(this.components);
            this.Timer_AK_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TabControl_AK.SuspendLayout();
            this.DevTodoTab.SuspendLayout();
            this.ShogiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LogViewerTab.SuspendLayout();
            this.RedmineTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // logListBox
            // 
            this.logListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logListBox.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 15;
            this.logListBox.Location = new System.Drawing.Point(0, 31);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(792, 334);
            this.logListBox.TabIndex = 0;
            this.logListBox.SelectedIndexChanged += new System.EventHandler(this.logListBox_SelectedIndexChanged);
            // 
            // Radio_LogKind_FormPDFMaker
            // 
            this.Radio_LogKind_FormPDFMaker.AutoSize = true;
            this.Radio_LogKind_FormPDFMaker.Location = new System.Drawing.Point(349, 9);
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
            this.ToolStripMenuItem_Menu.Size = new System.Drawing.Size(50, 20);
            this.ToolStripMenuItem_Menu.Text = "Menu";
            this.ToolStripMenuItem_Menu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem_SelectLogFormat
            // 
            this.ToolStripMenuItem_SelectLogFormat.Name = "ToolStripMenuItem_SelectLogFormat";
            this.ToolStripMenuItem_SelectLogFormat.Size = new System.Drawing.Size(165, 22);
            this.ToolStripMenuItem_SelectLogFormat.Text = "ログフォーマット選択";
            this.ToolStripMenuItem_SelectLogFormat.Click += new System.EventHandler(this.ToolStripMenuItem_SelectLogFormat_Clicked);
            // 
            // ToolStripMenuItem_Help
            // 
            this.ToolStripMenuItem_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Howtouse,
            this.ToolStripMenuItem_Version});
            this.ToolStripMenuItem_Help.Name = "ToolStripMenuItem_Help";
            this.ToolStripMenuItem_Help.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem_Help.Text = "Help";
            // 
            // ToolStripMenuItem_Howtouse
            // 
            this.ToolStripMenuItem_Howtouse.Name = "ToolStripMenuItem_Howtouse";
            this.ToolStripMenuItem_Howtouse.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_Howtouse.Text = "How To Use";
            this.ToolStripMenuItem_Howtouse.Click += new System.EventHandler(this.ToolStripMenuItem_Howtouse_Clicked);
            // 
            // ToolStripMenuItem_Version
            // 
            this.ToolStripMenuItem_Version.Name = "ToolStripMenuItem_Version";
            this.ToolStripMenuItem_Version.Size = new System.Drawing.Size(136, 22);
            this.ToolStripMenuItem_Version.Text = "Version";
            this.ToolStripMenuItem_Version.Click += new System.EventHandler(this.ToolStripMenuItem_Version_Clicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel_AK});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // ToolStripStatusLabel_AK
            // 
            this.ToolStripStatusLabel_AK.Name = "ToolStripStatusLabel_AK";
            this.ToolStripStatusLabel_AK.Size = new System.Drawing.Size(38, 17);
            this.ToolStripStatusLabel_AK.Text = "status";
            this.ToolStripStatusLabel_AK.Click += new System.EventHandler(this.toolStripStatusLabel_Click);
            // 
            // TabControl_AK
            // 
            this.TabControl_AK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_AK.Controls.Add(this.DevTodoTab);
            this.TabControl_AK.Controls.Add(this.ShogiTab);
            this.TabControl_AK.Controls.Add(this.LogViewerTab);
            this.TabControl_AK.Controls.Add(this.RedmineTab);
            this.TabControl_AK.Location = new System.Drawing.Point(0, 27);
            this.TabControl_AK.Name = "TabControl_AK";
            this.TabControl_AK.SelectedIndex = 0;
            this.TabControl_AK.Size = new System.Drawing.Size(800, 398);
            this.TabControl_AK.TabIndex = 9;
            this.TabControl_AK.SelectedIndexChanged += new System.EventHandler(this.TabControl_AK_Selected);
            // 
            // DevTodoTab
            // 
            this.DevTodoTab.Controls.Add(this.devtodoUserPassLabel);
            this.DevTodoTab.Controls.Add(this.devtodoUrlLabel);
            this.DevTodoTab.Controls.Add(this.devTodoLoadButton);
            this.DevTodoTab.Controls.Add(this.devTodoSaveButton);
            this.DevTodoTab.Controls.Add(this.devTodoTextBox);
            this.DevTodoTab.Location = new System.Drawing.Point(4, 22);
            this.DevTodoTab.Name = "DevTodoTab";
            this.DevTodoTab.Padding = new System.Windows.Forms.Padding(3);
            this.DevTodoTab.Size = new System.Drawing.Size(792, 372);
            this.DevTodoTab.TabIndex = 1;
            this.DevTodoTab.Text = "DevTodo";
            this.DevTodoTab.UseVisualStyleBackColor = true;
            this.DevTodoTab.Click += new System.EventHandler(this.DevTodoTab_Area_Clicked);
            // 
            // devtodoUserPassLabel
            // 
            this.devtodoUserPassLabel.AutoSize = true;
            this.devtodoUserPassLabel.Location = new System.Drawing.Point(504, 31);
            this.devtodoUserPassLabel.Name = "devtodoUserPassLabel";
            this.devtodoUserPassLabel.Size = new System.Drawing.Size(51, 12);
            this.devtodoUserPassLabel.TabIndex = 4;
            this.devtodoUserPassLabel.Text = "userpass";
            // 
            // devtodoUrlLabel
            // 
            this.devtodoUrlLabel.AutoSize = true;
            this.devtodoUrlLabel.Location = new System.Drawing.Point(504, 9);
            this.devtodoUrlLabel.Name = "devtodoUrlLabel";
            this.devtodoUrlLabel.Size = new System.Drawing.Size(27, 12);
            this.devtodoUrlLabel.TabIndex = 3;
            this.devtodoUrlLabel.Text = "URL";
            // 
            // devTodoLoadButton
            // 
            this.devTodoLoadButton.Location = new System.Drawing.Point(506, 59);
            this.devTodoLoadButton.Name = "devTodoLoadButton";
            this.devTodoLoadButton.Size = new System.Drawing.Size(75, 23);
            this.devTodoLoadButton.TabIndex = 2;
            this.devTodoLoadButton.Text = "Load";
            this.devTodoLoadButton.UseVisualStyleBackColor = true;
            this.devTodoLoadButton.Click += new System.EventHandler(this.devTodoLoadButton_Click);
            // 
            // devTodoSaveButton
            // 
            this.devTodoSaveButton.Location = new System.Drawing.Point(506, 88);
            this.devTodoSaveButton.Name = "devTodoSaveButton";
            this.devTodoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.devTodoSaveButton.TabIndex = 1;
            this.devTodoSaveButton.Text = "Save";
            this.devTodoSaveButton.UseVisualStyleBackColor = true;
            this.devTodoSaveButton.Click += new System.EventHandler(this.devTodoSaveButton_Clicked);
            // 
            // devTodoTextBox
            // 
            this.devTodoTextBox.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.devTodoTextBox.Location = new System.Drawing.Point(6, 6);
            this.devTodoTextBox.Multiline = true;
            this.devTodoTextBox.Name = "devTodoTextBox";
            this.devTodoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.devTodoTextBox.Size = new System.Drawing.Size(490, 360);
            this.devTodoTextBox.TabIndex = 0;
            this.devTodoTextBox.TextChanged += new System.EventHandler(this.devTodoTextBox_TextChanged);
            // 
            // ShogiTab
            // 
            this.ShogiTab.Controls.Add(this.shogi_testlabel);
            this.ShogiTab.Controls.Add(this.dataGridView1);
            this.ShogiTab.Location = new System.Drawing.Point(4, 22);
            this.ShogiTab.Name = "ShogiTab";
            this.ShogiTab.Padding = new System.Windows.Forms.Padding(3);
            this.ShogiTab.Size = new System.Drawing.Size(792, 372);
            this.ShogiTab.TabIndex = 2;
            this.ShogiTab.Text = "Shogi";
            this.ShogiTab.UseVisualStyleBackColor = true;
            this.ShogiTab.Click += new System.EventHandler(this.KifuTab_Area_Clicked);
            // 
            // shogi_testlabel
            // 
            this.shogi_testlabel.AutoSize = true;
            this.shogi_testlabel.Location = new System.Drawing.Point(536, 17);
            this.shogi_testlabel.Name = "shogi_testlabel";
            this.shogi_testlabel.Size = new System.Drawing.Size(49, 12);
            this.shogi_testlabel.TabIndex = 1;
            this.shogi_testlabel.Text = "testlabel";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_9,
            this.Column8,
            this.Column7,
            this.Column6,
            this.Column5,
            this.Column4,
            this.Column3,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 17);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(493, 322);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // C_9
            // 
            this.C_9.HeaderText = "9";
            this.C_9.Name = "C_9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
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
            this.LogViewerTab.Click += new System.EventHandler(this.LogViewerTab_Area_Clicked);
            // 
            // RedmineTab
            // 
            this.RedmineTab.Controls.Add(this.redmineButton);
            this.RedmineTab.Controls.Add(this.RedmineTextBox);
            this.RedmineTab.Controls.Add(this.RedmineLabel);
            this.RedmineTab.Location = new System.Drawing.Point(4, 22);
            this.RedmineTab.Name = "RedmineTab";
            this.RedmineTab.Padding = new System.Windows.Forms.Padding(3);
            this.RedmineTab.Size = new System.Drawing.Size(792, 372);
            this.RedmineTab.TabIndex = 3;
            this.RedmineTab.Text = "Redmine";
            this.RedmineTab.UseVisualStyleBackColor = true;
            // 
            // redmineButton
            // 
            this.redmineButton.Location = new System.Drawing.Point(9, 34);
            this.redmineButton.Name = "redmineButton";
            this.redmineButton.Size = new System.Drawing.Size(75, 23);
            this.redmineButton.TabIndex = 2;
            this.redmineButton.Text = "connect";
            this.redmineButton.UseVisualStyleBackColor = true;
            this.redmineButton.Click += new System.EventHandler(this.redmineButton_Click);
            // 
            // RedmineTextBox
            // 
            this.RedmineTextBox.Location = new System.Drawing.Point(522, 7);
            this.RedmineTextBox.Multiline = true;
            this.RedmineTextBox.Name = "RedmineTextBox";
            this.RedmineTextBox.Size = new System.Drawing.Size(264, 165);
            this.RedmineTextBox.TabIndex = 1;
            // 
            // RedmineLabel
            // 
            this.RedmineLabel.AutoSize = true;
            this.RedmineLabel.Location = new System.Drawing.Point(7, 7);
            this.RedmineLabel.Name = "RedmineLabel";
            this.RedmineLabel.Size = new System.Drawing.Size(25, 12);
            this.RedmineLabel.TabIndex = 0;
            this.RedmineLabel.Text = "text";
            // 
            // Timer_AK
            // 
            this.Timer_AK.Tick += new System.EventHandler(this.Timer_AK_Tick);
            // 
            // Timer_AK_Label
            // 
            this.Timer_AK_Label.AutoSize = true;
            this.Timer_AK_Label.Location = new System.Drawing.Point(692, 12);
            this.Timer_AK_Label.Name = "Timer_AK_Label";
            this.Timer_AK_Label.Size = new System.Drawing.Size(45, 12);
            this.Timer_AK_Label.TabIndex = 10;
            this.Timer_AK_Label.Text = "00:00:00";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Timer_AK_Label);
            this.Controls.Add(this.TabControl_AK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "ArmyKnife";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShogiTab_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabControl_AK.ResumeLayout(false);
            this.DevTodoTab.ResumeLayout(false);
            this.DevTodoTab.PerformLayout();
            this.ShogiTab.ResumeLayout(false);
            this.ShogiTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LogViewerTab.ResumeLayout(false);
            this.LogViewerTab.PerformLayout();
            this.RedmineTab.ResumeLayout(false);
            this.RedmineTab.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel_AK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Menu;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SelectLogFormat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Help;
        private System.Windows.Forms.TabControl TabControl_AK;
        private System.Windows.Forms.TabPage LogViewerTab;
        private System.Windows.Forms.TabPage DevTodoTab;
        private System.Windows.Forms.TabPage ShogiTab;
        private System.Windows.Forms.Button devTodoSaveButton;
        private System.Windows.Forms.TextBox devTodoTextBox;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Howtouse;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Version;
        private Timer Timer_AK;
        private Label Timer_AK_Label;
        private Button devTodoLoadButton;
        private TabPage RedmineTab;
        private Label devtodoUrlLabel;
        private Label devtodoUserPassLabel;
        private TextBox RedmineTextBox;
        private Label RedmineLabel;
        private Button redmineButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn C_9;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Label shogi_testlabel;
    }
}

