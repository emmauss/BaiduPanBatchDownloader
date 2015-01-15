using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiduPanBatchDownloader.WinForm
{
    public class DownloadItem
    {
        public string Url { get; set; }

        public string SaveTo { get; set; }

        public DownloadStatus Status { get; set; }

        public DownloadItem()
        {
            Status = DownloadStatus.Added;
        }
    }

    public enum DownloadStatus
    {
        Added = 0,
        Started = 1,
        Success = 2,
        Fail = 3,
    }
}
