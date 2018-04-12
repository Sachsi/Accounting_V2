using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Properties;

namespace Accounting
{
    public partial class ucSetting : MetroFramework.Controls.MetroUserControl
    {
        

        public ucSetting()
        {
            InitializeComponent();
            metroStyleManager1.Owner = Form_Main.Instance;

            mCB_Theme.SelectedIndex = Settings.Default["Theme"].GetHashCode();
            mCB_Style.SelectedIndex = Settings.Default["Style"].GetHashCode();
            mTB_BusinessName.Text = Settings.Default["BusinessName"].ToString();
            
        }

        private void mCB_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)mCB_Style.SelectedIndex;

            Settings.Default["Style"] = (MetroFramework.MetroColorStyle)mCB_Style.SelectedIndex;
            Settings.Default.Save();
        }

        private void mCB_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)mCB_Theme.SelectedIndex;

            Settings.Default["Theme"] = (MetroFramework.MetroThemeStyle)mCB_Theme.SelectedIndex;
            Settings.Default.Save();
        }

        private void ucSetting_Load(object sender, EventArgs e)
        {
            //metroStyleManager1.Owner = this;
            //metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Settings.Default["Style"];
            //metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)Settings.Default["Theme"];

            //metroStyleManager1.Owner = ucDatabase.Instance;
            //metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Settings.Default["Style"].GetHashCode();
            //metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)Settings.Default["Theme"].GetHashCode();
        }

        private void mTB_BusinessName_TextChanged(object sender, EventArgs e)
        {
            Form_Main.Instance.Text = "       Accounting of "+ mTB_BusinessName.Text;
            Settings.Default["BusinessName"] = mTB_BusinessName.Text;
            Settings.Default.Save();
        }
    }
}