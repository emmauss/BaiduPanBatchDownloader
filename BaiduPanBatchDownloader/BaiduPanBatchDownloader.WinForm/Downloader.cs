using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace BaiduPanBatchDownloader.WinForm
{
    public class Downloader
    {
        public static bool Download(string url, string saveTo)
        {
            if (!saveTo.EndsWith("/")) saveTo = String.Format("{0}/", saveTo);
            try
            {
                var client = GetClient();
                var home = client.DownloadString("/disk/home");
                var bdstoken = Regex.Match(home, "yunData.MYBDSTOKEN\\s*=\\s*\"(.+?)\"").Groups[1].Value;

                client = GetClient();
                var result = client.UploadString(String.Format("/rest/2.0/services/cloud_dl?bdstoken={0}", bdstoken), String.Format("method=add_task&app_id=250528&source_url={0}&save_path={1}&type=3", HttpUtility.UrlEncode(url), HttpUtility.UrlEncode(saveTo)));
                var json = JObject.Parse(result);
                if (json["rapid_download"].ToString() == "1")
                {
                    OnMessage(String.Format("Download {0} successful: {1}", url, result));
                    return true;
                }
                else
                {
                    OnMessage(String.Format("Download {0} Failed: {1}", url, result));
                    string taskId = json["task_id"].ToString();
                    Thread.Sleep(2000);
                    client = GetClient();
                    client.DownloadString(String.Format("/rest/2.0/services/cloud_dl?bdstoken={0}&task_id={1}&method=cancel_task&app_id=250528&t=1398846113059&channel=chunlei&clienttype=0&web=1", bdstoken, taskId));
                    return false;
                }
            }
            catch (Exception ex)
            {
                OnMessage(String.Format("Download {0} Failed: {1}", url, ex.Message));
                return false;
            }
        }

        protected static void OnMessage(string msg)
        {
            var handler = Message;
            if (handler != null) handler(msg);
        }
        public static event Action<string> Message;
        private static WebClient GetClient()
        {
            var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.Cookie, ConfigInfoManager.ConfigInfo.Cookie);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
            client.Headers.Add(HttpRequestHeader.Referer, "http://pan.baidu.com");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0");
            //_client.Headers.Add(HttpRequestHeader.UserAgent, "netdisk;4.6.1.0;PC;PC-Windows;6.2.9200;WindowsBaiduYunGuanJia");
            client.BaseAddress = "http://pan.baidu.com/";
            return client;
        }

    }
}
