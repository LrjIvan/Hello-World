using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace FillSystemDownloader.Project
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// 检测网络状态
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="ReservedValue"></param>
        /// <returns></returns>
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(int Description, int ReservedValue);

        /// <summary>
        /// 下载地址
        /// </summary>
        private string DownloadUrl = "http://14.23.87.18:8089/";

        /// <summary>
        /// 下载文件集合
        /// </summary>
        private List<string> DownloadFiles = new List<string>();

        /// <summary>
        /// 当前下载请求对象
        /// </summary>
        HttpInfo httpInfo;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StartNetworkCheck();
        }

        #region 跨线程操作
        private void OperationControl(Action action)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        #endregion

        #region CheckBox勾选
        private void ckbCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            btnDownload.Enabled = ckbCheckAll.Checked;

            foreach (CheckBox ckb in flpCkbs.Controls)
            {
                ckb.Checked = ckbCheckAll.Checked;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            if (c.Checked)
            {
                btnDownload.Enabled = true;
            }
            else
            {
                bool isExistsCheck = false;
                foreach (CheckBox ckb in flpCkbs.Controls)
                {
                    if (ckb.Checked)
                    {
                        isExistsCheck = true;
                        break;
                    }
                }
                btnDownload.Enabled = isExistsCheck;
            }
        }
        #endregion

        #region 网络检测
        private void StartNetworkCheck()
        {
            Task.Run(() =>
            {
                bool lastConnectedState = true;
                while (true)
                {
                    try
                    {
                        //如果网络不可访问
                        if (!InternetGetConnectedState(0, 0))
                        {
                            if (lastConnectedState)
                            {
                                OperationControl(() =>
                                {
                                    Console("网络异常，请修复好网络再进行下载.");
                                });
                                lastConnectedState = false;
                            }
                        }
                        else
                        {
                            if (!lastConnectedState)
                            {
                                OperationControl(() =>
                                {
                                    Console("网络恢复正常，可以正常下载.");
                                });
                                lastConnectedState = true;
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                    Thread.Sleep(3000);
                }
            });
        }
        #endregion

        #region 下载

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (btnDownload.Text == "下载")
            {
                if (!InternetGetConnectedState(0, 0))
                {
                    Console("网络异常，请修复好网络再进行下载.");
                    return;
                }
                CreateAndReturnDirectory();

                btnDownload.Text = "取消";

                foreach (CheckBox ckb in flpCkbs.Controls)
                {
                    if (ckb.Checked)
                    {
                        DownloadFiles.Add($"{ckb.Text}.zip");
                    }
                }
                Download();
            }
            else
            {
                httpInfo.Cancel();
            }
        }

        private void Download()
        {
            if (DownloadFiles.Count > 0)
            {
                string fileName = DownloadFiles[0];
                string url = Path.Combine(DownloadUrl, fileName);

                fileName = DownloadFiles[0] = Path.Combine(txtDownloadPath.Text.Trim(), fileName);

                httpInfo = new HttpInfo(url, fileName);
                //HttpInfos.Add(httpInfo);
                httpInfo.ProgressChangedEvent += HttpInfo_ProgressChangedEvent;
                httpInfo.DownCompletedEvent += HttpInfo_DownCompletedEvent;
                httpInfo.StartDownloadEvent += HttpInfo_StartDownloadEvent;

                httpInfo.Download();
            }
        }

        private void HttpInfo_StartDownloadEvent(string fileName)
        {
            Console($"{fileName} 正在下载......");
        }

        private void HttpInfo_DownCompletedEvent(HttpInfo httpInfo, string fileName)
        {
            DownloadFiles.Remove(fileName);

            if (!httpInfo.IsCancel)
            {
                Console($"{fileName} 下载完成！\r\n");
                //CompressHelper.Decompression(fileName);
                //File.Delete(fileName);
                //Download();
            }
            else
            {
                DownloadFiles.Clear();
                OperationControl(() =>
                {
                    tsProgressBar.Value = 0;
                    btnDownload.Text = "下载";
                });
                Console($"{fileName} 取消下载！\r\n");
                File.Delete(fileName);
            }

            if (DownloadFiles.Count == 0)
            {
                OperationControl(() =>
                {
                    btnDownload.Text = "下载";
                });
            }
        }

        private void HttpInfo_ProgressChangedEvent(int obj)
        {
            OperationControl(() =>
            {
                tsProgressBar.Value = obj;
            });
        }

        /// <summary>
        /// 创建并返回目录
        /// </summary>
        /// <returns></returns>
        private string CreateAndReturnDirectory()
        {
            string path = txtDownloadPath.Text.Trim();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        #endregion

        #region 浏览&打开

        private void btnOpen_Click(object sender, EventArgs e)
        {
            CreateAndReturnDirectory();
            Process.Start("explorer.exe", txtDownloadPath.Text);
        }

        private void btnBrowe_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = txtDownloadPath.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDownloadPath.Text = folderBrowserDialog.SelectedPath;
            }
        }
        #endregion

        #region 输出
        private void Console(string info)
        {
            txtLog.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}：{info}\r\n");
            txtLog.ScrollToCaret();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            HttpInfo hi = new HttpInfo("http://file.wlego.cn/setup/czzf.apk", @"G:\download\czzf.apk");
            //HttpInfos.Add(httpInfo);
            hi.ProgressChangedEvent += HttpInfo_ProgressChangedEvent;
            hi.DownCompletedEvent += HttpInfo_DownCompletedEvent;
            hi.StartDownloadEvent += HttpInfo_StartDownloadEvent;

            hi.Download();
        }
    }
}
