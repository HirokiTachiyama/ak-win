using Newtonsoft.Json;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        private string configFile = "../../config.json";
        private Config conf;

        DokuwikiPageManager dpm;

        // LogViewer 関連変数
        private string logViewer_logFile;
        private string logViewer_formatFile;
        private string logViewer_status = "Format: NONE, LogFile: NONE";

        // 棋譜 関連変数
        private string kifu_status = "棋譜";

        // Todo 関連変数
        private string devTodo_status = "DevTodo";

        // Redmine 関連変数
        private string redmine_status = "Redmine";

        public MainWindow() {
            InitializeComponent();

            // Config読み込み
            string configFileStr = System.IO.File.ReadAllText(configFile);
            conf = JsonConvert.DeserializeObject<Config>(configFileStr);

            // デフォルトでチェックしておく
            Radio_LogKind_FormPDFMaker.Checked = true;

            // DokuWikiへのログイン
            dpm = new DokuwikiPageManager(conf.todoUrl, conf.todoUser, conf.todoPass);
            devtodoUrlLabel.Text = "URL : " + conf.todoUrl + conf.todoPage;
            devtodoUserPassLabel.Text = "User : " + conf.todoUser + ", Pass : ************";

            // DevTodoのテキスト読み込み
            devTodoTextBox.Text = dpm.GetPageStr(conf.todoPage);
            devTodo_status = $"{conf.todoUrl}{conf.todoPage} loaded.";

            // Timer_AK 始動
            this.Timer_AK.Start();

            // ログの表示
            ShowLog("../../logs/FormPDFMaker_Excel.log");

        }

        private void ShowLog(String _fileName) {
            // クリア
            logListBox.Items.Clear();
            string[] logs = System.IO.File.ReadAllLines(_fileName);

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
                case 3:
                    RedmineTab_Selected();
                    break;
                default:
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

        private void RedmineTab_Selected() {
            Console.WriteLine("Redmine");

            var rm = new RedmineManager(conf.redmineUrl, conf.redmineApiKey);
            var param = new NameValueCollection { { "status_id", "*" } };

            var issue = rm.GetObject<Issue>("18481", param);
            RedmineTextBox.Text = issue.ToString();

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
            // 現在のタブに応じて分岐
            switch (TabControl_AK.SelectedIndex) {
                case 0: // LogViewer
                    ToolStripStatusLabel_AK.Text = logViewer_status;
                    break;
                case 1: // Kifu
                    ToolStripStatusLabel_AK.Text = kifu_status;
                    break;
                case 2: // DevTodo
                    ToolStripStatusLabel_AK.Text = devTodo_status;
                    break;
                case 3: // Redmine
                    ToolStripStatusLabel_AK.Text = redmine_status;
                    break;
                default:
                    break;
            }

        }

        private void devTodoTextBox_TextChanged(object sender, EventArgs e) {
            devTodo_status = "modified.";
            UpdateStatusLabel();
        }


        private void Timer_AK_Tick(object sender, EventArgs e) {
            Timer_AK_Label.Text = DateTime.UtcNow.ToString();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            Console.WriteLine("hogefuga");
        }

        private void devTodoLoadButton_Click(object sender, EventArgs e) {
            //devTodoTextBox.Text = File.ReadAllText(devTodo_file);
            // Dokuwikiから取得
            devTodoTextBox.Text = dpm.GetPageStr(conf.todoPage);
            devTodo_status = $"{conf.todoUrl}{conf.todoPage} loaded.";
            UpdateStatusLabel();
        }

        private void devTodoSaveButton_Clicked(object sender, EventArgs e) {
            //File.WriteAllText(devTodo_file, devTodoTextBox.Text);
            //devTodo_status = $"{devTodo_file} saved.";

            bool ret = dpm.PutPage(devTodoTextBox.Text, conf.todoPage);

            if (ret)
            {
                devTodo_status = "put success.";
            } else
            {
                devTodo_status = "put failed.";
            }
            UpdateStatusLabel();
        }
    }
}
