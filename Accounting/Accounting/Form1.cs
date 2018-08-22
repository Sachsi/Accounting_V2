using Accounting;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Migrations;
using System.Globalization;
using Accounting.Properties;

namespace Accounting
{
    public partial class Form_Main : MetroFramework.Forms.MetroForm
    {
        static Form_Main _instance;

        public static Form_Main Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form_Main();
                }
                return _instance;
            } }

        public MetroPanel MetroPanel  {
            get { return mP_Dashboard; } set { mP_Dashboard = value; } }

        public MetroLink MetroLink {
            get { return mLink_Back; } set { mLink_Back = value; } }

        Settings settings = new Settings();

        public Form_Main()
        {
            
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
           
            if (Settings.Default.FirstStart == true)
            {
                DialogResult = MetroMessageBox.Show(this, "Are you sure to delete the complete database?. You can not undo it!\n\r To delete your database you can do it unter setting, as well.",
                            "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.No)
                {
                    Settings.Default.FirstStart = false;
                    Settings.Default.Save();
                }
            }


            _instance = this;
            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;

            mP_Dashboard.Controls.Add(uc);

            mLink_Back.Visible = false;
        }

        private void mLink_Back_Click(object sender, EventArgs e)
        {
            mLink_Back.Visible = false;
            mP_Dashboard.Controls["ucDashboard"].BringToFront();
        }
    }
}
