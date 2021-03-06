﻿using System;
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
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {

        }

        private void mTile_Database_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MetroLink.Visible = true;

            if (!Form_Main.Instance.MetroPanel.Controls.ContainsKey("ucDatabase"))
            {
                ucDatabase uc = new ucDatabase();
                uc.Dock = DockStyle.Fill;
                Form_Main.Instance.MetroPanel.Controls.Add(uc);   
            }
            Form_Main.Instance.MetroPanel.Controls["ucDatabase"].BringToFront();
        }

        private void mT_Overview_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MetroLink.Visible = true;

            if (!Form_Main.Instance.MetroPanel.Controls.ContainsKey("ucOverview"))
            {
                ucOverview uc = new ucOverview();
                uc.Dock = DockStyle.Fill;
                Form_Main.Instance.MetroPanel.Controls.Add(uc);
            }
            Form_Main.Instance.MetroPanel.Controls["ucOverview"].BringToFront();
        }

        private void mTile_Search_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MetroLink.Visible = true;

            if (!Form_Main.Instance.MetroPanel.Controls.ContainsKey("ucOverview"))
            {
                ucOverview uc = new ucOverview();
                uc.Dock = DockStyle.Fill;
                Form_Main.Instance.MetroPanel.Controls.Add(uc);
            }
            Form_Main.Instance.MetroPanel.Controls["ucOverview"].BringToFront();
        }

        private void mTile_Settings_Click(object sender, EventArgs e)
        {
            Form_Main.Instance.MetroLink.Visible = true;

            if (!Form_Main.Instance.MetroPanel.Controls.ContainsKey("ucSetting"))
            {
                ucSetting uc = new ucSetting();
                uc.Dock = DockStyle.Fill;
                Form_Main.Instance.MetroPanel.Controls.Add(uc);
            }
            Form_Main.Instance.MetroPanel.Controls["ucSetting"].BringToFront();
        }
    }
}
