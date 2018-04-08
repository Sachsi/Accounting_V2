using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class ucSetting : MetroFramework.Controls.MetroUserControl
    {
        

        public ucSetting()
        {
            InitializeComponent();

            metroStyleManager1.Owner = Form_Main.Instance;
        }

        private void mCB_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)mCB_Style.SelectedIndex;
        }

        private void mCB_Theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Theme = (MetroFramework.MetroThemeStyle)mCB_Theme.SelectedIndex;
        }
    }
}