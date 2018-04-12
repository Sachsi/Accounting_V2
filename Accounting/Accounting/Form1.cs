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
            _instance = this;
            ucDashboard uc = new ucDashboard();
            //ucDatabase uc = new ucDatabase();
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
