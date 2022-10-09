using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FillSystemDownloader.Project
{
    public class HttpInfo
    {
        private string Url;
        private string FileName;
        internal bool IsCancel;

        private WebClient webClient = new WebClient();
        /// <summary>
        /// 下载进度改变事件
        /// </summary>
        public event Action<int> ProgressChangedEvent;
        /// <summary>
        /// 下载完成事件
        /// </summary>
        public event Action<HttpInfo, string> DownCompletedEvent;
        /// <summary>
        /// 开始下载事件
        /// </summary>
        public event Action<string> StartDownloadEvent;

        public HttpInfo(string url, string fileName)
        {
            this.Url = url;
            this.FileName = fileName;
        }

        public void Download()
        {
            Uri uri = new Uri(Url);
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

            StartDownloadEvent(FileName);
            webClient.DownloadFileTaskAsync(uri, FileName);
  
        }

        private void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DownCompletedEvent?.Invoke(this, FileName);
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressChangedEvent?.Invoke(e.ProgressPercentage);
        }

        public void Cancel()
        {
            IsCancel = true;
            webClient.CancelAsync();
        }
    }
}
