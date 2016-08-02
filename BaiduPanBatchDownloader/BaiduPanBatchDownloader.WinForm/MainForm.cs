using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BaiduPanBatchDownloader.WinForm
{
    public partial class MainForm : Form
    {
        private BindingList<DownloadItem> _downloadItems = new BindingList<DownloadItem>();

        public MainForm()
        {
            InitializeComponent();
            Downloader.Message += (m) =>
            {
                this.Invoke(new Action<string>((msg) =>
                {
                    tradeTextBox.Text += msg + "\r\n";
                    tradeTextBox.Select(tradeTextBox.Text.Length - 1, 0);
                    tradeTextBox.ScrollToCaret();
                }), m);
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _downloadItems = new BindingList<DownloadItem>(ConfigInfoManager.ConfigInfo.DownloadItems);
            //dataGridView1.DataSource = _downloadItems;
            downloadItemBindingSource.DataSource = _downloadItems;
            cookieTextBox.Text = ConfigInfoManager.ConfigInfo.Cookie;
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            using (AddItemForm addItemForm = new AddItemForm())
            {
                var result = addItemForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    lock (ConfigInfoManager.ConfigInfo)
                    {
                        foreach (DownloadItem downloadItem in addItemForm.DownloadItems)
                        {
                            _downloadItems.Add(downloadItem);
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConfigInfoManager.ConfigInfo.Cookie = cookieTextBox.Text.Trim();
            while (true)
            {
                if (backgroundWorker1.CancellationPending) return;
                var item = _downloadItems.FirstOrDefault(i => i.Status == DownloadStatus.Added);
                if (item != null)
                {
                    var success = Downloader.Download(item.Url, item.SaveTo);
                    if (success)
                    {
                        Invoke(new Action(() =>
                        {
                            lock (ConfigInfoManager.ConfigInfo)
                            {
                                _downloadItems.Remove(item);
                                _downloadItems.ResetBindings();
                            }
                        }));
                        ConfigInfoManager.WriteConfig();
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        item.Status = DownloadStatus.Fail;
                        Invoke(new Action(() =>
                        {
                            lock (ConfigInfoManager.ConfigInfo)
                            {
                                _downloadItems.ResetBindings();
                            }
                        }));
                        Thread.Sleep(2000);
                    }
                }
                Thread.Sleep(500);
            }
        }

        private void startToolStripButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cookieTextBox.Text))
            {
                MessageBox.Show("Please enter Cookie");
                return;
            }
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void stopToolStripButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var cookie = cookieTextBox.Text;
            ConfigInfoManager.ConfigInfo.Cookie = cookieTextBox.Text;
            ConfigInfoManager.ConfigInfo.DownloadItems = _downloadItems.ToList();
            ConfigInfoManager.WriteConfig();
        }

        private void SetAllAddedToolStripButton_Click(object sender, EventArgs e)
        {
            lock (ConfigInfoManager.ConfigInfo)
            {
                foreach (DownloadItem downloadItem in _downloadItems)
                {
                    downloadItem.Status = DownloadStatus.Added;
                }
            }
            Invoke(new Action(() => _downloadItems.ResetBindings()));
        }

        private void removeStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?", "Confirm delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    _downloadItems.Remove(selectedRow.DataBoundItem as DownloadItem);
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            ConfigInfoManager.WriteConfig();
        }
    }
}
