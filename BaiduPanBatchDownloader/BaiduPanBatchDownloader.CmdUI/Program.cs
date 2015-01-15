using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using BaiduPanBatchDownloader.WinForm;

namespace BaiduPanBatchDownloader.CmdUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * http://pan.baidu.com/rest/2.0/services/cloud_dl?app_id=250528&clienttype=8&devuid=BDIMXV2-O_E91356836CB34BF3B09DD78654B96A89-C_0-D_202020202020202020202020335a595431545447-M_00CFE01F598B-V_606FA9C4&channel=00000000000000000000000000000000&version=4.6.1.0&logid=JwAxADQAMAA3ADQANgA0ADgAMwA1ACwAMQAwAC4AMQAxAC4AMwAuADEANwA3ACwAMgAwADkA%0AJwA%3D
             */
            ConfigInfoManager.ConfigInfo.Cookie = "PANWEB=1; BAIDUID=1A74F202A18D0A72E9D3063023E655FB:FG=1; bdshare_firstime=1396228121704; Hm_lvt_b181fb73f90936ebd334d457c848c8b5=1404374059; BDUSS=g5SjEzdW5pejdNS0s2VnpQUnpteGFLS2cyMFV0WERNRVZrUnpDeXJtczltZHhUQVFBQUFBJCQAAAAAAAAAAAEAAAChATYlenlmODYxMDA3AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD0MtVM9DLVTT2; locale=zh; MCITY=-%3A; Hm_lvt_773fea2ac036979ebb5fcc768d8beb67=1406860472,1407401808,1407464803,1407466644; Hm_lpvt_773fea2ac036979ebb5fcc768d8beb67=1407466715; Hm_lvt_adf736c22cd6bcc36a1d27e5af30949e=1406860472,1407401808,1407464803,1407466644; Hm_lpvt_adf736c22cd6bcc36a1d27e5af30949e=1407466715; cflag=65535%3A1; PANPSC=6121097777839602250%3Au2C8FyuEb6jVxEpKOraEJN3rS9rSY1IpLTR9hcbwdPgwwo4y0uRbvZhOfTxtZzQK8XEvJjRAmTM%3D";
            var testUrl = "ed2k://|file|%E6%9A%B4%E5%90%9B.Tyrant.S01E01.%E4%B8%AD%E8%8B%B1%E5%AD%97%E5%B9%95.WEB-HR.AC3.1024X576.x264.mkv|682775495|b47b1be60e2ce9eed80d98c2e8402ca7|h=sjqgehekqz6wslbq6lamz4e7x3b3tomq|/";
            var saveTo = "test/";
            var success = Downloader.Download(testUrl, saveTo);

        }
    }
}
