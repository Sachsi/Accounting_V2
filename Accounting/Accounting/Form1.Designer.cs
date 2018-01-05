namespace Accounting
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
    private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Overview = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.mP_Customer = new MetroFramework.Controls.MetroPanel();
            this.mTB_Date_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mG_Customer = new MetroFramework.Controls.MetroGrid();
            this.mB_Save = new MetroFramework.Controls.MetroButton();
            this.mB_Add_Customer = new MetroFramework.Controls.MetroButton();
            this.mTB_EMail_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Phone_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mCB_CSA_Customer = new MetroFramework.Controls.MetroCheckBox();
            this.mCB_Nieightbarhood_Customer = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.mL_EMail_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_Date_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_FullName_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_Phone_Customer = new MetroFramework.Controls.MetroLabel();
            this.mT_FullName_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mB_Edit_Customer = new MetroFramework.Controls.MetroButton();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.neighbarhoodDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horsBarnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.tabPage_Customer.SuspendLayout();
            this.mP_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mG_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage_Overview);
            this.metroTabControl1.Controls.Add(this.tabPage_Customer);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(80, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(764, 373);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage_Overview
            // 
            this.tabPage_Overview.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Overview.Name = "tabPage_Overview";
            this.tabPage_Overview.Size = new System.Drawing.Size(756, 331);
            this.tabPage_Overview.TabIndex = 0;
            this.tabPage_Overview.Text = "Overview";
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.mP_Customer);
            this.tabPage_Customer.Controls.Add(this.mG_Customer);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Size = new System.Drawing.Size(756, 331);
            this.tabPage_Customer.TabIndex = 1;
            this.tabPage_Customer.Text = "Customer";
            // 
            // mP_Customer
            // 
            this.mP_Customer.Controls.Add(this.mT_FullName_Customer);
            this.mP_Customer.Controls.Add(this.mL_Phone_Customer);
            this.mP_Customer.Controls.Add(this.mL_FullName_Customer);
            this.mP_Customer.Controls.Add(this.mL_Date_Customer);
            this.mP_Customer.Controls.Add(this.mL_EMail_Customer);
            this.mP_Customer.Controls.Add(this.metroCheckBox3);
            this.mP_Customer.Controls.Add(this.mCB_Nieightbarhood_Customer);
            this.mP_Customer.Controls.Add(this.mCB_CSA_Customer);
            this.mP_Customer.Controls.Add(this.mTB_Phone_Customer);
            this.mP_Customer.Controls.Add(this.mTB_EMail_Customer);
            this.mP_Customer.Controls.Add(this.mTB_Date_Customer);
            this.mP_Customer.HorizontalScrollbarBarColor = true;
            this.mP_Customer.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Customer.HorizontalScrollbarSize = 10;
            this.mP_Customer.Location = new System.Drawing.Point(3, 247);
            this.mP_Customer.Name = "mP_Customer";
            this.mP_Customer.Size = new System.Drawing.Size(750, 81);
            this.mP_Customer.TabIndex = 1;
            this.mP_Customer.VerticalScrollbarBarColor = true;
            this.mP_Customer.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Customer.VerticalScrollbarSize = 10;
            // 
            // mTB_Date_Customer
            // 
            // 
            // 
            // 
            this.mTB_Date_Customer.CustomButton.Image = null;
            this.mTB_Date_Customer.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Date_Customer.CustomButton.Name = "";
            this.mTB_Date_Customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Date_Customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Date_Customer.CustomButton.TabIndex = 1;
            this.mTB_Date_Customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Date_Customer.CustomButton.UseSelectable = true;
            this.mTB_Date_Customer.CustomButton.Visible = false;
            this.mTB_Date_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Date", true));
            this.mTB_Date_Customer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Date_Customer.Lines = new string[] {
        "01.01.2018"};
            this.mTB_Date_Customer.Location = new System.Drawing.Point(87, 3);
            this.mTB_Date_Customer.MaxLength = 32767;
            this.mTB_Date_Customer.Name = "mTB_Date_Customer";
            this.mTB_Date_Customer.PasswordChar = '\0';
            this.mTB_Date_Customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Date_Customer.SelectedText = "";
            this.mTB_Date_Customer.SelectionLength = 0;
            this.mTB_Date_Customer.SelectionStart = 0;
            this.mTB_Date_Customer.ShortcutsEnabled = true;
            this.mTB_Date_Customer.Size = new System.Drawing.Size(122, 29);
            this.mTB_Date_Customer.TabIndex = 2;
            this.mTB_Date_Customer.Text = "01.01.2018";
            this.mTB_Date_Customer.UseSelectable = true;
            this.mTB_Date_Customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Date_Customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mG_Customer
            // 
            this.mG_Customer.AllowUserToAddRows = false;
            this.mG_Customer.AllowUserToDeleteRows = false;
            this.mG_Customer.AllowUserToResizeRows = false;
            this.mG_Customer.AutoGenerateColumns = false;
            this.mG_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mG_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mG_Customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mG_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mG_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mG_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mG_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.phoneNrDataGridViewTextBoxColumn,
            this.cSADataGridViewCheckBoxColumn,
            this.neighbarhoodDataGridViewCheckBoxColumn,
            this.horsBarnDataGridViewCheckBoxColumn});
            this.mG_Customer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mG_Customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.mG_Customer.EnableHeadersVisualStyles = false;
            this.mG_Customer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mG_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mG_Customer.Location = new System.Drawing.Point(3, 3);
            this.mG_Customer.Name = "mG_Customer";
            this.mG_Customer.ReadOnly = true;
            this.mG_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mG_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mG_Customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mG_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mG_Customer.Size = new System.Drawing.Size(750, 241);
            this.mG_Customer.TabIndex = 0;
            // 
            // mB_Save
            // 
            this.mB_Save.Location = new System.Drawing.Point(683, 451);
            this.mB_Save.Name = "mB_Save";
            this.mB_Save.Size = new System.Drawing.Size(100, 25);
            this.mB_Save.TabIndex = 1;
            this.mB_Save.Text = "&Save";
            this.mB_Save.UseSelectable = true;
            this.mB_Save.Click += new System.EventHandler(this.mB_Save_Tables_Click);
            // 
            // mB_Add_Customer
            // 
            this.mB_Add_Customer.Location = new System.Drawing.Point(471, 451);
            this.mB_Add_Customer.Name = "mB_Add_Customer";
            this.mB_Add_Customer.Size = new System.Drawing.Size(100, 25);
            this.mB_Add_Customer.TabIndex = 2;
            this.mB_Add_Customer.Text = "&Add";
            this.mB_Add_Customer.UseSelectable = true;
            this.mB_Add_Customer.Click += new System.EventHandler(this.mB_Add_Customer_Click);
            // 
            // mTB_EMail_Customer
            // 
            // 
            // 
            // 
            this.mTB_EMail_Customer.CustomButton.Image = null;
            this.mTB_EMail_Customer.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_EMail_Customer.CustomButton.Name = "";
            this.mTB_EMail_Customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_EMail_Customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_EMail_Customer.CustomButton.TabIndex = 1;
            this.mTB_EMail_Customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_EMail_Customer.CustomButton.UseSelectable = true;
            this.mTB_EMail_Customer.CustomButton.Visible = false;
            this.mTB_EMail_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "E_Mail", true));
            this.mTB_EMail_Customer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_EMail_Customer.Lines = new string[] {
        "eMail@msn.com"};
            this.mTB_EMail_Customer.Location = new System.Drawing.Point(347, 3);
            this.mTB_EMail_Customer.MaxLength = 32767;
            this.mTB_EMail_Customer.Name = "mTB_EMail_Customer";
            this.mTB_EMail_Customer.PasswordChar = '\0';
            this.mTB_EMail_Customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_EMail_Customer.SelectedText = "";
            this.mTB_EMail_Customer.SelectionLength = 0;
            this.mTB_EMail_Customer.SelectionStart = 0;
            this.mTB_EMail_Customer.ShortcutsEnabled = true;
            this.mTB_EMail_Customer.Size = new System.Drawing.Size(122, 29);
            this.mTB_EMail_Customer.TabIndex = 3;
            this.mTB_EMail_Customer.Text = "eMail@msn.com";
            this.mTB_EMail_Customer.UseSelectable = true;
            this.mTB_EMail_Customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_EMail_Customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Phone_Customer
            // 
            // 
            // 
            // 
            this.mTB_Phone_Customer.CustomButton.Image = null;
            this.mTB_Phone_Customer.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Phone_Customer.CustomButton.Name = "";
            this.mTB_Phone_Customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Phone_Customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Phone_Customer.CustomButton.TabIndex = 1;
            this.mTB_Phone_Customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Phone_Customer.CustomButton.UseSelectable = true;
            this.mTB_Phone_Customer.CustomButton.Visible = false;
            this.mTB_Phone_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "PhoneNr", true));
            this.mTB_Phone_Customer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Phone_Customer.Lines = new string[] {
        "0123456789"};
            this.mTB_Phone_Customer.Location = new System.Drawing.Point(347, 42);
            this.mTB_Phone_Customer.MaxLength = 32767;
            this.mTB_Phone_Customer.Name = "mTB_Phone_Customer";
            this.mTB_Phone_Customer.PasswordChar = '\0';
            this.mTB_Phone_Customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Phone_Customer.SelectedText = "";
            this.mTB_Phone_Customer.SelectionLength = 0;
            this.mTB_Phone_Customer.SelectionStart = 0;
            this.mTB_Phone_Customer.ShortcutsEnabled = true;
            this.mTB_Phone_Customer.Size = new System.Drawing.Size(122, 29);
            this.mTB_Phone_Customer.TabIndex = 5;
            this.mTB_Phone_Customer.Text = "0123456789";
            this.mTB_Phone_Customer.UseSelectable = true;
            this.mTB_Phone_Customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Phone_Customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mCB_CSA_Customer
            // 
            this.mCB_CSA_Customer.AutoSize = true;
            this.mCB_CSA_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.customerBindingSource, "CSA", true));
            this.mCB_CSA_Customer.Location = new System.Drawing.Point(518, 6);
            this.mCB_CSA_Customer.Name = "mCB_CSA_Customer";
            this.mCB_CSA_Customer.Size = new System.Drawing.Size(45, 15);
            this.mCB_CSA_Customer.TabIndex = 6;
            this.mCB_CSA_Customer.Text = "CSA";
            this.mCB_CSA_Customer.UseSelectable = true;
            // 
            // mCB_Nieightbarhood_Customer
            // 
            this.mCB_Nieightbarhood_Customer.AutoSize = true;
            this.mCB_Nieightbarhood_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.customerBindingSource, "Neighbarhood", true));
            this.mCB_Nieightbarhood_Customer.Location = new System.Drawing.Point(518, 31);
            this.mCB_Nieightbarhood_Customer.Name = "mCB_Nieightbarhood_Customer";
            this.mCB_Nieightbarhood_Customer.Size = new System.Drawing.Size(104, 15);
            this.mCB_Nieightbarhood_Customer.TabIndex = 7;
            this.mCB_Nieightbarhood_Customer.Text = "Neightbarhood";
            this.mCB_Nieightbarhood_Customer.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.customerBindingSource, "Hors_Barn", true));
            this.metroCheckBox3.Location = new System.Drawing.Point(518, 56);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(81, 15);
            this.metroCheckBox3.TabIndex = 8;
            this.metroCheckBox3.Text = "Horse Barn";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // mL_EMail_Customer
            // 
            this.mL_EMail_Customer.AutoSize = true;
            this.mL_EMail_Customer.Location = new System.Drawing.Point(260, 8);
            this.mL_EMail_Customer.Name = "mL_EMail_Customer";
            this.mL_EMail_Customer.Size = new System.Drawing.Size(50, 19);
            this.mL_EMail_Customer.TabIndex = 9;
            this.mL_EMail_Customer.Text = "E-Mail:";
            // 
            // mL_Date_Customer
            // 
            this.mL_Date_Customer.AutoSize = true;
            this.mL_Date_Customer.Location = new System.Drawing.Point(3, 8);
            this.mL_Date_Customer.Name = "mL_Date_Customer";
            this.mL_Date_Customer.Size = new System.Drawing.Size(39, 19);
            this.mL_Date_Customer.TabIndex = 9;
            this.mL_Date_Customer.Text = "Date:";
            // 
            // mL_FullName_Customer
            // 
            this.mL_FullName_Customer.AutoSize = true;
            this.mL_FullName_Customer.Location = new System.Drawing.Point(3, 47);
            this.mL_FullName_Customer.Name = "mL_FullName_Customer";
            this.mL_FullName_Customer.Size = new System.Drawing.Size(72, 19);
            this.mL_FullName_Customer.TabIndex = 9;
            this.mL_FullName_Customer.Text = "Full Name:";
            // 
            // mL_Phone_Customer
            // 
            this.mL_Phone_Customer.AutoSize = true;
            this.mL_Phone_Customer.Location = new System.Drawing.Point(260, 47);
            this.mL_Phone_Customer.Name = "mL_Phone_Customer";
            this.mL_Phone_Customer.Size = new System.Drawing.Size(69, 19);
            this.mL_Phone_Customer.TabIndex = 9;
            this.mL_Phone_Customer.Text = "Phone Nr:";
            // 
            // mT_FullName_Customer
            // 
            // 
            // 
            // 
            this.mT_FullName_Customer.CustomButton.Image = null;
            this.mT_FullName_Customer.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mT_FullName_Customer.CustomButton.Name = "";
            this.mT_FullName_Customer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mT_FullName_Customer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_FullName_Customer.CustomButton.TabIndex = 1;
            this.mT_FullName_Customer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mT_FullName_Customer.CustomButton.UseSelectable = true;
            this.mT_FullName_Customer.CustomButton.Visible = false;
            this.mT_FullName_Customer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Full_Name", true));
            this.mT_FullName_Customer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mT_FullName_Customer.Lines = new string[] {
        "Max Muster"};
            this.mT_FullName_Customer.Location = new System.Drawing.Point(87, 42);
            this.mT_FullName_Customer.MaxLength = 32767;
            this.mT_FullName_Customer.Name = "mT_FullName_Customer";
            this.mT_FullName_Customer.PasswordChar = '\0';
            this.mT_FullName_Customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mT_FullName_Customer.SelectedText = "";
            this.mT_FullName_Customer.SelectionLength = 0;
            this.mT_FullName_Customer.SelectionStart = 0;
            this.mT_FullName_Customer.ShortcutsEnabled = true;
            this.mT_FullName_Customer.Size = new System.Drawing.Size(122, 29);
            this.mT_FullName_Customer.TabIndex = 10;
            this.mT_FullName_Customer.Text = "Max Muster";
            this.mT_FullName_Customer.UseSelectable = true;
            this.mT_FullName_Customer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mT_FullName_Customer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mB_Edit_Customer
            // 
            this.mB_Edit_Customer.Location = new System.Drawing.Point(577, 451);
            this.mB_Edit_Customer.Name = "mB_Edit_Customer";
            this.mB_Edit_Customer.Size = new System.Drawing.Size(100, 25);
            this.mB_Edit_Customer.TabIndex = 3;
            this.mB_Edit_Customer.Text = "&Edit";
            this.mB_Edit_Customer.UseSelectable = true;
            this.mB_Edit_Customer.Click += new System.EventHandler(this.mB_Edit_Customer_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Accounting.Customer);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.ToolTipText = "01.01.2000";
            this.dateDataGridViewTextBoxColumn.Width = 80;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            this.eMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            this.phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.HeaderText = "Phone Nr.";
            this.phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            this.phoneNrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cSADataGridViewCheckBoxColumn
            // 
            this.cSADataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cSADataGridViewCheckBoxColumn.DataPropertyName = "CSA";
            this.cSADataGridViewCheckBoxColumn.HeaderText = "CSA";
            this.cSADataGridViewCheckBoxColumn.Name = "cSADataGridViewCheckBoxColumn";
            this.cSADataGridViewCheckBoxColumn.ReadOnly = true;
            this.cSADataGridViewCheckBoxColumn.Width = 31;
            // 
            // neighbarhoodDataGridViewCheckBoxColumn
            // 
            this.neighbarhoodDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.neighbarhoodDataGridViewCheckBoxColumn.DataPropertyName = "Neighbarhood";
            this.neighbarhoodDataGridViewCheckBoxColumn.HeaderText = "Neighbarhood";
            this.neighbarhoodDataGridViewCheckBoxColumn.Name = "neighbarhoodDataGridViewCheckBoxColumn";
            this.neighbarhoodDataGridViewCheckBoxColumn.ReadOnly = true;
            this.neighbarhoodDataGridViewCheckBoxColumn.Width = 87;
            // 
            // horsBarnDataGridViewCheckBoxColumn
            // 
            this.horsBarnDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.horsBarnDataGridViewCheckBoxColumn.DataPropertyName = "Hors_Barn";
            this.horsBarnDataGridViewCheckBoxColumn.HeaderText = "Horse Barn";
            this.horsBarnDataGridViewCheckBoxColumn.Name = "horsBarnDataGridViewCheckBoxColumn";
            this.horsBarnDataGridViewCheckBoxColumn.ReadOnly = true;
            this.horsBarnDataGridViewCheckBoxColumn.Width = 68;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 499);
            this.Controls.Add(this.mB_Edit_Customer);
            this.Controls.Add(this.mB_Add_Customer);
            this.Controls.Add(this.mB_Save);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form_Main";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage_Customer.ResumeLayout(false);
            this.mP_Customer.ResumeLayout(false);
            this.mP_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mG_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage_Overview;
        private System.Windows.Forms.TabPage tabPage_Customer;
        private MetroFramework.Controls.MetroGrid mG_Customer;
        private MetroFramework.Controls.MetroButton mB_Save;
        private MetroFramework.Controls.MetroPanel mP_Customer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MetroFramework.Controls.MetroTextBox mTB_Date_Customer;
        private MetroFramework.Controls.MetroButton mB_Add_Customer;
        private MetroFramework.Controls.MetroLabel mL_Phone_Customer;
        private MetroFramework.Controls.MetroLabel mL_FullName_Customer;
        private MetroFramework.Controls.MetroLabel mL_Date_Customer;
        private MetroFramework.Controls.MetroLabel mL_EMail_Customer;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox mCB_Nieightbarhood_Customer;
        private MetroFramework.Controls.MetroCheckBox mCB_CSA_Customer;
        private MetroFramework.Controls.MetroTextBox mTB_Phone_Customer;
        private MetroFramework.Controls.MetroTextBox mTB_EMail_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cSADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn neighbarhoodDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn horsBarnDataGridViewCheckBoxColumn;
        private MetroFramework.Controls.MetroTextBox mT_FullName_Customer;
        private MetroFramework.Controls.MetroButton mB_Edit_Customer;
    }
}

