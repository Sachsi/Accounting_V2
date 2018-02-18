using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AutoUpdater
{   /// <summary>
/// Provides application updatte support in C#
/// </summary>
    public class AutoUpdater
    {   /// <summary>
        ///holds the programm's to updates's infos 
        /// </summary>
        private IAutoUpdater applicationInfo;
        /// <summary>
        /// thread to find update
        /// </summary>
        private BackgroundWorker bgWorker;
        /// <summary>
        /// Create a new AutoUpdater Object
        /// </summary>
        /// <param name="applicationInfo"></param>
        public AutoUpdater(IAutoUpdater applicationInfo)
        {
            this.applicationInfo = applicationInfo;
            ///setup Backgroundworker
            this.bgWorker = new BackgroundWorker();
            this.bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BgWorker_RunWorkerCompleted);
        }
        /// <summary>
        /// Checks for an Update for the programm passed
        /// if there is an update, a dialoge asking to download wiil appear
        /// </summary>
        public void doUpdate()
        {
            if (!this.bgWorker.IsBusy)
            {
                this.bgWorker.RunWorkerAsync(this.applicationInfo);
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                AutoUpdaterXML update = (AutoUpdaterXML)e.Result;

                if (update != null && update.IsNewThan(this.applicationInfo.ApplicationAssembly.GetName().Version))
                {
                    if (new AutoUpdateAcceptForm(this.applicationInfo, update).ShowDialog(this.applicationInfo.Context) == DialogResult.Yes)
                    {
                        this.DownloadUpdate(update);
                    }
                }
            }
        }

        private void DownloadUpdate(AutoUpdaterXML update)
        {
            AutoUpdateDownloadFrom form = new AutoUpdateDownloadFrom(update.Uri, update.MD5, this.applicationInfo.ApplicationIcon);
            DialogResult result = form.ShowDialog(this.applicationInfo.Context);

            if (result == DialogResult.OK)
            {
                string currentPath = this.applicationInfo.ApplicationAssembly.Location;
                string newPath = Path.GetDirectoryName(currentPath) + "\\" + update.FileName;

                UpdateApplication(form.TempFilePath, currentPath, newPath, update.LaunchArgs);

                Application.Exit();
            }
            else if(result == DialogResult.Abort)
            {
                MessageBox.Show("The update download was cancelled. \n This programm has not been modified.", "Update Download Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There was a problem downloading to update. \n Please try it later.", "Update Download Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateApplication(string tempFilePath, string currentPath, string newPath, string launchArgs)
        {
            string argument = "/C Choice /C Y /N /D Y /T 4 & Del /F /Q \"{0}\" & Choice /C Y /N /D Y /T 2 & Move /Y \"{1}\" \"{2}\" & Start \"\" /D \"{3}\" \"{4}\" {5}";

            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = string.Format(argument, currentPath, tempFilePath, newPath, Path.GetDirectoryName(newPath), Path.GetFileName(newPath), launchArgs);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            Process.Start(info);
        }
        /// <summary>
        /// Checks for /parses update.xml on server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            IAutoUpdater application = (IAutoUpdater)e.Argument;

            if (!AutoUpdaterXML.ExistsOnServer(application.UpdateXmlLocation))
                e.Cancel = true;
            else
                e.Result = AutoUpdaterXML.Parse(application.UpdateXmlLocation, application.ApplicationID);      
        }

    }
}
