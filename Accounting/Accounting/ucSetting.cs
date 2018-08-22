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
        Settings settings = new Settings();

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
            Form_Main.Instance.Text = "       Accounting of " + Settings.Default["BusinessName"].ToString();
            currencyDefault = (System.Globalization.CultureInfo)Settings.Default["Currency"];

            mTB_Street.Text = Settings.Default["CompanyStreet"].ToString();
            mTB_Postcode.Text = Settings.Default["CompanyPostcode"].ToString();
            mTB_Phone.Text = Settings.Default["CompanyPhone"].ToString();
            mTB_EMail.Text = Settings.Default["CompanyEMail"].ToString();
            mTB_Country.Text = Settings.Default["CompanyCountry"].ToString();
            mTB_Province.Text = Settings.Default["CompanyCity"].ToString();
            mTB_Owner.Text = Settings.Default["CompanyOwner"].ToString();
            mTB_Title.Text = Settings.Default["CompanyTitle"].ToString();

            mL_AppTitle.Text = Application.ProductName;
            mL_CompanyName.Text = CompanyName;
            mL_AppDev.Text = "Tobias Sachse";
            mL_AppVersion.Text = Application.ProductVersion;
            
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

        private void mTB_Owner_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyOwner"].ToString() == mTB_Owner.Text.ToString())
            {
                return;
            }
            
            Settings.Default["CompanyOwner"] = mTB_Owner.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Street_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyStreet"].ToString() == mTB_Street.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyStreet"] = mTB_Street.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Province_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyCity"].ToString() == mTB_Province.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyCity"] = mTB_Province.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Country_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyCountry"].ToString() == mTB_Country.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyCountry"] = mTB_Country.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Postcode_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyPostcode"].ToString() == mTB_Postcode.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyPostcode"] = mTB_Postcode.Text;
            Settings.Default.Save();

            MessageInfo();
        }

 

        private void mTB_EMail_TextChanged_1(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyEMail"].ToString() == mTB_EMail.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyEMail"] = mTB_EMail.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Phone_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyPhone"].ToString() == mTB_Phone.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyPhone"] = mTB_Phone.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mTB_Title_TextChanged(object sender, EventArgs e)
        {
            if (Settings.Default["CompanyTitle"].ToString() == mTB_Title.Text.ToString())
            {
                return;
            }

            Settings.Default["CompanyTitle"] = mTB_Title.Text;
            Settings.Default.Save();

            MessageInfo();
        }

        private void mCB_DeleteDatabase_Click(object sender, EventArgs e)
        {
            if (mCB_DeleteDatabase.Checked)
                mCB_DeleteDatabase.Text = "Yes";
            else
                mCB_DeleteDatabase.Text = "No";

            Form_Main.Instance.DialogResult = MetroMessageBox.Show(this, "This will delete your database after a restart the application. \n\r" +
                "Are you sure to do it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Form_Main.Instance.DialogResult == DialogResult.Yes)
            {
                Settings.Default.FirstStart = true;
                Settings.Default.Save();
                Application.Exit();
            }
            else
            {
                Settings.Default.FirstStart = false;
                Settings.Default.Save();
                mCB_DeleteDatabase.Text = "No";
                mCB_DeleteDatabase.CheckState = CheckState.Unchecked;
            }
        }
    }
}