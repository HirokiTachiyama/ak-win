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

        private string logViewer_logFile;
        private string logViewer_formatFile;
        private string logViewer_Status;


        public MainWindow() {
            InitializeComponent();

            // デフォルトでチェックしておく
            Radio_LogKind_FormPDFMaker.Checked = true;

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


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

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
            }

        }


        private void toolStripStatusLabel_Click(object sender, EventArgs e) {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            Console.WriteLine("item1 clicked");
        }

        private void ほげToolStripMenuItem_Click(object sender, EventArgs e) {
            Console.WriteLine("hoge clicked");
        }

        private void LogViewerTab_Click(object sender, EventArgs e) {

        }

        private void todoSaveButton_Click(object sender, EventArgs e) {

        }

        private void ToolStripMenuItem_SelectLogFormat_Click(object sender, EventArgs e) {
            Console.WriteLine("ToolStripMenuItem_SelectLogFormat clicked");
            var ofd = new OpenFileDialog {
                Title = "Select Log Format File",
                InitialDirectory = @".\"
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                LogFilePathLabel.Text = logViewer_formatFile = ofd.FileName;
            }
        }

        private void ToolStripMenuItem_Howtouse_Click(object sender, EventArgs e) {
            Console.WriteLine("How to use clicked");
        }

        private void ToolStripMenuItem_Version_Click(object sender, EventArgs e) {
            Console.WriteLine("Version clicked");
        }
    }
}
