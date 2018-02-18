using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace AutoUpdater
{
    internal partial class AutoUpdateDownloadFrom : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private WebClient webClient;

        private BackgroundWorker bgworker;

        private string tempFile;

        private string md5;

        internal string TempFilePath
        {
        get { return this.tempFile; }
        }


        internal AutoUpdateDownloadFrom(Uri location, string md5, Icon programIcon)
        {
            InitializeComponent();

            if (programIcon != null)
                this.Icon = programIcon;

            tempFile = Path.GetTempFileName();

            this.md5 = md5;

            webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(webClient_DownloadPrograssChanged);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(webClient_DownloadFileCompled);

            bgworker = new BackgroundWorker();
            bgworker.DoWork += new DoWorkEventHandler(bgworker_DoWork);
            bgworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgworker_RunWorkerCompleted);

            try
            {
                webClient.DownloadFileAsync(location, this.tempFile);
            }
            catch 
            {
                this.DialogResult = DialogResult.No; this.Close();
            }
        }

        private void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = (DialogResult)e.Result;
            this.Close();
        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            string file = ((string[])e.Argument)[0];
            string updateMd5 = ((string[])e.Argument)[1];

            if (Hasher.Hashfile(file, HashType.MD5) != updateMd5 )
            {
                e.Result = DialogResult.No;
            }
            else
            {
                e.Result = DialogResult.OK;
            }
        }

        private void webClient_DownloadFileCompled(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.DialogResult = DialogResult.No;
                this.Close();
            }
            else if (e.Cancelled)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            else
            {
                lblProgress.Text = "Verifying Download...";
                progressBar.Style = ProgressBarStyle.Marquee;

                bgworker.RunWorkerAsync(new string[] { this.tempFile, this.md5 });
            }

        }

        private void webClient_DownloadPrograssChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.progressBar.Value = e.ProgressPercentage;
            this.lblProgress.Text = String.Format("Download {0} of {1}", FormatBytes(e.BytesReceived, 1, true), FormatBytes(e.TotalBytesToReceive, 1, true));
        }

        private string FormatBytes(long bytes, int decimalPlaces, bool showByteType)
        {
            double newBytes = bytes;
            string formatString = "{0";
            string byteType = "B";

            if(newBytes > 1024 && newBytes < 1048576)
            {
                newBytes /= 1024;
                byteType = "KB";
            }
            else if(newBytes > 1048576 && newBytes < 1073741824)
            {
                newBytes /= 1048576;
                byteType = "MB";
            }
            else
            {
                newBytes /= 1073741824;
                byteType = "GB";
            }

            if (decimalPlaces > 0)
                formatString += ":0.";

            for (int i = 0; i < decimalPlaces; i++)
            {
                formatString = "0";
            }

            formatString += "}";

            if (showByteType)
                formatString += byteType;

            return string.Format(formatString,newBytes);
        }

        private void AutoUpdateDownloadFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
                this.DialogResult = DialogResult.Abort;
            }
            if (bgworker.IsBusy)
            {
                bgworker.CancelAsync();
                this.DialogResult = DialogResult.Abort;
            }
        }
    }
}
