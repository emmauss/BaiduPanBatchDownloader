using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BaiduPanBatchDownloader.WinForm
{
    public class ConfigInfo
    {
        public string Cookie { get; set; }
        
        public List<DownloadItem> DownloadItems { get; set; }
        
        public List<string> SaveToList { get; set; }
        public ConfigInfo()
        {
            Cookie = String.Empty;
            SaveToList = new List<string>();
            DownloadItems = new List<DownloadItem>();
        }
    }

    public static class ConfigInfoManager
    {
        private const string ConfigInfoFileName = "configinfo.xml";
        // Fields...
        private static ConfigInfo _configInfo;

        public static ConfigInfo ConfigInfo
        {
            get { return _configInfo; }
        }
        
        static ConfigInfoManager()
        {
            if (File.Exists(ConfigInfoFileName))
            {
                var xmlSerializer = new XmlSerializer(typeof(ConfigInfo));
                _configInfo = xmlSerializer.Deserialize(File.OpenRead(ConfigInfoFileName)) as ConfigInfo;
            }
            else
                _configInfo = new ConfigInfo();
        }

        public static void WriteConfig()
        {
            var xmlSerializer = new XmlSerializer(typeof(ConfigInfo));
            using (FileStream stream = new FileStream(ConfigInfoFileName, FileMode.Truncate, FileAccess.Write))
            {
                xmlSerializer.Serialize(stream, _configInfo);                
            }
        }
    }
}
