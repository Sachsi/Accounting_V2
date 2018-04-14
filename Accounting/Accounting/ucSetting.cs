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
using System.Globalization;
using MetroFramework;

namespace Accounting
{
    /// <summary>
    /// Define cultures whose formatting conventions are to be used.
    /// </summary>
    public partial class ucSetting : MetroFramework.Controls.MetroUserControl
    {
        public static CultureInfo CurrencyDefault
        {
            get { return currencyDefault; }
            set
            {
                currencyDefault = value;
            }
        }
        static CultureInfo currencyDefault;

        // Define cultures whose formatting conventions are to be used.
        static CultureInfo[] cultures = {CultureInfo.CreateSpecificCulture("en-US"),
                          CultureInfo.CreateSpecificCulture("fr-FR"),
                          CultureInfo.CreateSpecificCulture("ja-JP"),
                          };

        public ucSetting()
        {
            InitializeComponent();
            metroStyleManager1.Owner = Form_Main.Instance;

            mCB_Theme.SelectedIndex = Settings.Default["Theme"].GetHashCode();
            mCB_Style.SelectedIndex = Settings.Default["Style"].GetHashCode();
            mTB_BusinessName.Text = Settings.Default["BusinessName"].ToString();

            currencyDefault = (System.Globalization.CultureInfo)Settings.Default["Currency"];

            //mCB_Currency.Text = Settings.Default["Currency"].ToString();
            
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
        }

        private void mTB_BusinessName_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["BusinessName"].ToString() == mTB_BusinessName.Text.ToString())
            {
                return;
            }
            Form_Main.Instance.Text = "       Accounting of "+ mTB_BusinessName.Text;
            Settings.Default["BusinessName"] = mTB_BusinessName.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mCB_Currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Settings.Default["Currency"] == cultures[mCB_Currency.SelectedIndex])
            {
                return;
            }
            Settings.Default["Currency"] = cultures[mCB_Currency.SelectedIndex];
            Settings.Default.Save();
            MessageInfo();
        }

        private void MessageInfo()
        {
            mL_Setting_Info.Text = "Plaese restart your Application for settings to take effect!";
         }
    }
}