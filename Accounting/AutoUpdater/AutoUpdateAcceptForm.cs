using System;
using System.Windows.Forms;

namespace AutoUpdater
{
    internal partial class AutoUpdateAcceptForm : Form
    {
        /// <summary>
        /// the program to update's info
        /// </summary>
        private IAutoUpdater applicationInfo;
        /// <summary>
        /// the update info from the update.xml
        /// </summary>
        private AutoUpdaterXML updateInfo;
        /// <summary>
        /// the update info display form
        /// </summary>
        private AutoUpdateInfoForm updateInfoForm;
        /// <summary>
        /// Creats a new AutoUpdateAcceptForm
        /// </summary>
        /// <param name="applicationInfo"></param>
        /// <param name="updateInfo"></param>
        public AutoUpdateAcceptForm(IAutoUpdater applicationInfo, AutoUpdaterXML updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName + " - Update Availiable";
            ///assigns the icon if it isn't null
            if (this.applicationInfo.ApplicationIcon != null)
            {
                this.Icon = this.applicationInfo.ApplicationIcon;
            }
            ///Adds the update version # to the form
            lblNewVersion.Text = string.Format("New Version: {0}", this.updateInfo.Version.ToString());
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnDatails_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null)
            {
                this.updateInfoForm = new AutoUpdateInfoForm(this.applicationInfo, this.updateInfo);
            }
            this.updateInfoForm.ShowDialog(this);
        }
    }
}
