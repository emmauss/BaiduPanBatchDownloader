using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

namespace BaiduPanBatchDownloader.WinForm
{
    public partial class AddItemForm : Form
    {
        public List<DownloadItem> DownloadItems
        {
            get
            {
                var list = new List<DownloadItem>();
                foreach (var line in itemsTextBox.Lines)
                {
                    list.Add(new DownloadItem
                    {
                        Url = line.Trim(),
                        SaveTo = saveToComboBox.Text.Trim()
                    });
                }
                return list;
            }
        }

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ConfigInfoManager.ConfigInfo.SaveToList.Contains(saveToComboBox.Text))
                ConfigInfoManager.ConfigInfo.SaveToList.Add(saveToComboBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            var list = ConfigInfoManager.ConfigInfo.SaveToList;
            list.Reverse();
            saveToComboBox.DataSource = list;
            itemsTextBox.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void saveToComboBox_TextUpdate(object sender, EventArgs e)
        {
            var text = saveToComboBox.Text.Trim();
            if (text.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase))
            {
                var path = HttpUtility.UrlDecode(HttpUtility.ParseQueryString(new Uri(text).Fragment)["path"]);
                saveToComboBox.Text = path;
            }
        }

        private void itemsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (itemsTextBox.Lines.Length > 0)
            {
                var line = HttpUtility.UrlDecode(itemsTextBox.Lines[0].Trim());
                var regex = new Regex(@"\|file\|(.+?)\.(.+?)\.(S\d+)E\d+", RegexOptions.IgnoreCase);
                if (regex.IsMatch(line))
                {
                    var match = regex.Match(line);
                    var title = match.Groups[1].Value;
                    var englishTitle = match.Groups[2].Value;
                    var season = match.Groups[3].Value;
                    saveToComboBox.Text = String.Format("/Movies/美剧/连载中/{0}/{0}.{1}.{2}(F)(S)", title, englishTitle, season);
                    saveToComboBox.Focus();
                    saveToComboBox.Select(saveToComboBox.Text.LastIndexOf("(F)(S)"), "(F)(S)".Length);
                }
            }
        }
    }
}
