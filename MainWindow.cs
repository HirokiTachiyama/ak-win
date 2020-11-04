using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ak_win {
    public partial class MainWindow : Form {

        // LogViewer 関連変数
        private string logViewer_logFile;
        private string logViewer_formatFile;
        private string logViewer_status = "Format: NONE, LogFile: NONE";

        // 棋譜 関連変数
        private string kifu_status = "棋譜";

        // Todo 関連変数
        private string devTodo_status = "DevTodo";



        public MainWindow() {
            InitializeComponent();

            // デフォルトでチェックしておく
            Radio_LogKind_FormPDFMaker.Checked = true;

            // DevTodoのテキスト読み込み
            devTodoTextBox.Text = File.ReadAllText("../../todo.txt");
            devTodo_status = "Read ../../todo.txt";

            // ログの表示
            ShowLog("../../logs/FormPDFMaker_Excel.log");

        }

        private void ShowLog(String _fileName) {
            // クリア
            logListBox.Items.Clear();
            string[] logs = File.ReadAllLines(_fileName);

            foreach (string log in logs) {
                var item = new ListViewItem();
                item.Text = log;
                logListBox.Items.Add(item);
            }

        }


        private void logListBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Radio_LogKind_CheckedChanged(object sender, EventArgs e) {
            Console.WriteLine("Radio_LogKind changed");

            // Radio_logKind で選ばれたログファイル形式でlogListBox の項目を変更

            // 

        }

        private void LogReadButton_Click(object sender, EventArgs e) {
            ShowLog(logViewer_logFile);
        }

        private void LogFileSelectButton_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog {
                Title = "Select Log File",
                InitialDirectory = @".\"
            };

            if (ofd.ShowDialog() == DialogResult.OK) {
                LogFilePathLabel.Text = logViewer_logFile = ofd.FileName;
                logViewer_status = $"Format: NONE, LogFile: {ofd.FileName}";
                UpdateStatusLabel();
            }

        }


        private void toolStripStatusLabel_Click(object sender, EventArgs e) {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            Console.WriteLine("item1 clicked");
        }


        private void ToolStripMenuItem_SelectLogFormat_Clicked(object sender, EventArgs e) {
            Console.WriteLine("ToolStripMenuItem_SelectLogFormat clicked");
            var ofd = new OpenFileDialog {
                Title = "Select Log Format File",
                InitialDirectory = @".\"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                LogFilePathLabel.Text = logViewer_formatFile = ofd.FileName;
            }
        }

        private void ToolStripMenuItem_Howtouse_Clicked(object sender, EventArgs e) {
            Console.WriteLine("How to use clicked");
        }

        private void ToolStripMenuItem_Version_Clicked(object sender, EventArgs e) {
            Console.WriteLine("Version clicked");
        }


        // タブ関連
        private void TabControl_AK_Selected(object sender, EventArgs e) {

            // 選択されたタブに応じて分岐
            switch (this.TabControl_AK.SelectedIndex) {
                case 0:
                    LogViewerTab_Selected();
                    break;
                case 1:
                    KifuTab_Selected();
                    break;
                case 2:
                    DevTodoTab_Selected();
                    break;
            }
        }

        private void LogViewerTab_Selected() {
            Console.WriteLine("LogViewer");
            UpdateStatusLabel();
        }

        private void KifuTab_Selected() {
            Console.WriteLine("Kifu");
            UpdateStatusLabel();
        }

        private void DevTodoTab_Selected() {
            Console.WriteLine("DevTodo");
            UpdateStatusLabel();
        }

        private void LogViewerTab_Area_Clicked(object sender, EventArgs e) {
            Console.WriteLine("logViewerTab clicked");
        }

        private void KifuTab_Area_Clicked(object sender, EventArgs e) {
            Console.WriteLine("KifuTab clicked");
        }

        private void DevTodoTab_Area_Clicked(object sender, EventArgs e) {
            Console.WriteLine("DevTodoTab clicked");

        }

        // ステータステキストのアップデート
        private void UpdateStatusLabel() {
            // 選択されたタブに応じて分岐
            switch (this.TabControl_AK.SelectedIndex) {
                case 0: // LogViewer
                    this.ToolStripStatusLabel_AK.Text = this.logViewer_status;
                    break;
                case 1: // Kifu
                    this.ToolStripStatusLabel_AK.Text = this.kifu_status;
                    break;
                case 2: // DevTodo
                    this.ToolStripStatusLabel_AK.Text = this.devTodo_status;
                    break;
                default:
                    break;
            }

        }

        private void devTodoTextBox_TextChanged(object sender, EventArgs e) {
            devTodo_status = "modified.";
            UpdateStatusLabel();
        }

        private void devTodoSaveButton_Clicked(object sender, EventArgs e) {
            File.WriteAllText("../../todo.txt", devTodoTextBox.Text);
            devTodo_status = "../../todo.txt saved.";
            UpdateStatusLabel();
        }


    }
}
