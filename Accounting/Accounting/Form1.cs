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

        public MetroFramework.Controls.MetroPanel MetroPanel  {
            get { return mP_Dashboard; } set { mP_Dashboard = value; } }

        //public MetroFramework.Forms.MetroForm MetroForm { get { return this; } set {  = value; } }

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
            ucDatabase uc = new ucDatabase();
            uc.Dock = DockStyle.Fill;
            
            mP_Dashboard.Controls.Add(uc);
        }

    }
}
