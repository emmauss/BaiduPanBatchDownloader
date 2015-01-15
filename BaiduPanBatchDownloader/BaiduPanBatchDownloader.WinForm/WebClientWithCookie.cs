using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace BaiduPanBatchDownloader.WinForm
{
    public class WebClientWithCookie: WebClient
    {
        private readonly CookieContainer container = new CookieContainer();

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            HttpWebRequest webRequest = request as HttpWebRequest;
            if (webRequest != null)
            {
                webRequest.CookieContainer = container;
            }
            return request;
        }

    }
}
