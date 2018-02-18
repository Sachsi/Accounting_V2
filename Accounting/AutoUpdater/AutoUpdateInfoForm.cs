using System;
using System.Windows.Forms;

namespace AutoUpdater
{
    /// <summary>
    /// Form to shoe the details about the update
    /// </summary>
    public partial class AutoUpdateInfoForm : Form
    {/// <summary>
    /// Create a new AutoUpdateInfoForm
    /// </summary>
    /// <param name="applicationInfo"></param>
    /// <param name="updateInfo"></param>
        public AutoUpdateInfoForm(IAutoUpdater applicationInfo, AutoUpdaterXML updateInfo)
        {
            InitializeComponent();
            ///Sets the icon if it's not null
            if (applicationInfo.ApplicationIcon != null)
            {
                this.Icon = applicationInfo.ApplicationIcon;
            }
            ///Fill in the UI
            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersion.Text = String.Format("Current Version: {0}\nUpdate Version: {1}", applicationInfo.ApplicationAssembly.GetName().Version.ToString(),
                                                                updateInfo.Version.ToString());
            this.txtDescription.Text = updateInfo.Description;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            ///Only allow Cntrl - C to copy text
            if (!(e.Control && e.KeyCode == Keys.C))
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
