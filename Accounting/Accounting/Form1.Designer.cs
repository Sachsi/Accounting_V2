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
            this.mTC_Accounting = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.List_Customer = new MetroFramework.Controls.MetroListView();
            this.CH_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_CSA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Neightbarhood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_HorseBarn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mP_Customer = new MetroFramework.Controls.MetroPanel();
            this.mT_FullName_Customer = new MetroFramework.Controls.MetroTextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mL_Phone_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_FullName_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_Date_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_EMail_Customer = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.mCB_Nieightbarhood_Customer = new MetroFramework.Controls.MetroCheckBox();
            this.mCB_CSA_Customer = new MetroFramework.Controls.MetroCheckBox();
            this.mTB_Phone_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mTB_EMail_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Date_Customer = new MetroFramework.Controls.MetroTextBox();
            this.mTP_Income = new MetroFramework.Controls.MetroTabPage();
            this.List_Income = new MetroFramework.Controls.MetroListView();
            this.CH_Date_Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Customer_Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Payment_Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Price_Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mP_Income = new MetroFramework.Controls.MetroPanel();
            this.mCB_Customer_Income = new MetroFramework.Controls.MetroComboBox();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mL_Price_Income = new MetroFramework.Controls.MetroLabel();
            this.mL_Customer_Income = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mL_Payment_Income = new MetroFramework.Controls.MetroLabel();
            this.mTB_Price_Income = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Payment_Income = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Date_Income = new MetroFramework.Controls.MetroTextBox();
            this.mTP_Products = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.tabPage_Overview = new System.Windows.Forms.TabPage();
            this.mB_Save = new MetroFramework.Controls.MetroButton();
            this.mB_Add_Customer = new MetroFramework.Controls.MetroButton();
            this.mB_Edit_Customer = new MetroFramework.Controls.MetroButton();
            this.mB_Remove = new MetroFramework.Controls.MetroButton();
            this.mTC_Accounting.SuspendLayout();
            this.tabPage_Customer.SuspendLayout();
            this.mP_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.mTP_Income.SuspendLayout();
            this.mP_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.mTP_Products.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTC_Accounting
            // 
            this.mTC_Accounting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTC_Accounting.Controls.Add(this.tabPage_Customer);
            this.mTC_Accounting.Controls.Add(this.mTP_Income);
            this.mTC_Accounting.Controls.Add(this.mTP_Products);
            this.mTC_Accounting.Controls.Add(this.tabPage_Overview);
            this.mTC_Accounting.ItemSize = new System.Drawing.Size(80, 34);
            this.mTC_Accounting.Location = new System.Drawing.Point(23, 63);
            this.mTC_Accounting.Name = "mTC_Accounting";
            this.mTC_Accounting.SelectedIndex = 2;
            this.mTC_Accounting.Size = new System.Drawing.Size(768, 376);
            this.mTC_Accounting.TabIndex = 0;
            this.mTC_Accounting.UseSelectable = true;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.List_Customer);
            this.tabPage_Customer.Controls.Add(this.mP_Customer);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Size = new System.Drawing.Size(760, 334);
            this.tabPage_Customer.TabIndex = 1;
            this.tabPage_Customer.Text = "Customer";
            // 
            // List_Customer
            // 
            this.List_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Date,
            this.CH_Customer,
            this.CH_Email,
            this.CH_Phone,
            this.CH_CSA,
            this.CH_Neightbarhood,
            this.CH_HorseBarn});
            this.List_Customer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.List_Customer.FullRowSelect = true;
            this.List_Customer.Location = new System.Drawing.Point(3, 3);
            this.List_Customer.Name = "List_Customer";
            this.List_Customer.OwnerDraw = true;
            this.List_Customer.Size = new System.Drawing.Size(754, 241);
            this.List_Customer.TabIndex = 6;
            this.List_Customer.UseCompatibleStateImageBehavior = false;
            this.List_Customer.UseSelectable = true;
            this.List_Customer.View = System.Windows.Forms.View.Details;
            // 
            // CH_Date
            // 
            this.CH_Date.Text = "Date";
            this.CH_Date.Width = 80;
            // 
            // CH_Customer
            // 
            this.CH_Customer.Text = "Customer";
            this.CH_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Customer.Width = 140;
            // 
            // CH_Email
            // 
            this.CH_Email.Text = "E-Mail";
            this.CH_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Email.Width = 150;
            // 
            // CH_Phone
            // 
            this.CH_Phone.Text = "Phone";
            this.CH_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Phone.Width = 100;
            // 
            // CH_CSA
            // 
            this.CH_CSA.Text = "CSA";
            this.CH_CSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_CSA.Width = 50;
            // 
            // CH_Neightbarhood
            // 
            this.CH_Neightbarhood.Text = "Neightbarhood";
            this.CH_Neightbarhood.Width = 120;
            // 
            // CH_HorseBarn
            // 
            this.CH_HorseBarn.Text = "Horse Barn";
            this.CH_HorseBarn.Width = 100;
            // 
            // mP_Customer
            // 
            this.mP_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mP_Customer.Size = new System.Drawing.Size(754, 84);
            this.mP_Customer.TabIndex = 1;
            this.mP_Customer.VerticalScrollbarBarColor = true;
            this.mP_Customer.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Customer.VerticalScrollbarSize = 10;
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
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Accounting.Customer);
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
            // mL_FullName_Customer
            // 
            this.mL_FullName_Customer.AutoSize = true;
            this.mL_FullName_Customer.Location = new System.Drawing.Point(3, 47);
            this.mL_FullName_Customer.Name = "mL_FullName_Customer";
            this.mL_FullName_Customer.Size = new System.Drawing.Size(72, 19);
            this.mL_FullName_Customer.TabIndex = 9;
            this.mL_FullName_Customer.Text = "Full Name:";
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
            // mL_EMail_Customer
            // 
            this.mL_EMail_Customer.AutoSize = true;
            this.mL_EMail_Customer.Location = new System.Drawing.Point(260, 8);
            this.mL_EMail_Customer.Name = "mL_EMail_Customer";
            this.mL_EMail_Customer.Size = new System.Drawing.Size(50, 19);
            this.mL_EMail_Customer.TabIndex = 9;
            this.mL_EMail_Customer.Text = "E-Mail:";
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
            // mTP_Income
            // 
            this.mTP_Income.Controls.Add(this.List_Income);
            this.mTP_Income.Controls.Add(this.mP_Income);
            this.mTP_Income.HorizontalScrollbarBarColor = true;
            this.mTP_Income.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Income.HorizontalScrollbarSize = 10;
            this.mTP_Income.Location = new System.Drawing.Point(4, 38);
            this.mTP_Income.Name = "mTP_Income";
            this.mTP_Income.Size = new System.Drawing.Size(760, 334);
            this.mTP_Income.TabIndex = 2;
            this.mTP_Income.Text = "Income";
            this.mTP_Income.VerticalScrollbarBarColor = true;
            this.mTP_Income.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Income.VerticalScrollbarSize = 10;
            // 
            // List_Income
            // 
            this.List_Income.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Income.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Date_Income,
            this.CH_Customer_Income,
            this.CH_Payment_Income,
            this.CH_Price_Income});
            this.List_Income.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.List_Income.FullRowSelect = true;
            this.List_Income.Location = new System.Drawing.Point(3, 3);
            this.List_Income.Name = "List_Income";
            this.List_Income.OwnerDraw = true;
            this.List_Income.Size = new System.Drawing.Size(754, 241);
            this.List_Income.TabIndex = 4;
            this.List_Income.UseCompatibleStateImageBehavior = false;
            this.List_Income.UseSelectable = true;
            this.List_Income.View = System.Windows.Forms.View.Details;
            // 
            // CH_Date_Income
            // 
            this.CH_Date_Income.Text = "Date";
            this.CH_Date_Income.Width = 120;
            // 
            // CH_Customer_Income
            // 
            this.CH_Customer_Income.Text = "Customer";
            this.CH_Customer_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Customer_Income.Width = 200;
            // 
            // CH_Payment_Income
            // 
            this.CH_Payment_Income.Text = "Payment";
            this.CH_Payment_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Payment_Income.Width = 150;
            // 
            // CH_Price_Income
            // 
            this.CH_Price_Income.Text = "Price";
            this.CH_Price_Income.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CH_Price_Income.Width = 80;
            // 
            // mP_Income
            // 
            this.mP_Income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mP_Income.Controls.Add(this.mCB_Customer_Income);
            this.mP_Income.Controls.Add(this.mL_Price_Income);
            this.mP_Income.Controls.Add(this.mL_Customer_Income);
            this.mP_Income.Controls.Add(this.metroLabel3);
            this.mP_Income.Controls.Add(this.mL_Payment_Income);
            this.mP_Income.Controls.Add(this.mTB_Price_Income);
            this.mP_Income.Controls.Add(this.mTB_Payment_Income);
            this.mP_Income.Controls.Add(this.mTB_Date_Income);
            this.mP_Income.HorizontalScrollbarBarColor = true;
            this.mP_Income.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Income.HorizontalScrollbarSize = 10;
            this.mP_Income.Location = new System.Drawing.Point(3, 247);
            this.mP_Income.Name = "mP_Income";
            this.mP_Income.Size = new System.Drawing.Size(754, 84);
            this.mP_Income.TabIndex = 3;
            this.mP_Income.VerticalScrollbarBarColor = true;
            this.mP_Income.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Income.VerticalScrollbarSize = 10;
            // 
            // mCB_Customer_Income
            // 
            this.mCB_Customer_Income.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incomeBindingSource, "Customer_Id", true));
            this.mCB_Customer_Income.DataSource = this.customerBindingSource;
            this.mCB_Customer_Income.DisplayMember = "Full_Name";
            this.mCB_Customer_Income.FormattingEnabled = true;
            this.mCB_Customer_Income.ItemHeight = 23;
            this.mCB_Customer_Income.Location = new System.Drawing.Point(87, 42);
            this.mCB_Customer_Income.Name = "mCB_Customer_Income";
            this.mCB_Customer_Income.Size = new System.Drawing.Size(122, 29);
            this.mCB_Customer_Income.TabIndex = 10;
            this.mCB_Customer_Income.UseSelectable = true;
            this.mCB_Customer_Income.ValueMember = "Id";
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(Accounting.Income);
            // 
            // mL_Price_Income
            // 
            this.mL_Price_Income.AutoSize = true;
            this.mL_Price_Income.Location = new System.Drawing.Point(260, 47);
            this.mL_Price_Income.Name = "mL_Price_Income";
            this.mL_Price_Income.Size = new System.Drawing.Size(41, 19);
            this.mL_Price_Income.TabIndex = 9;
            this.mL_Price_Income.Text = "Price:";
            // 
            // mL_Customer_Income
            // 
            this.mL_Customer_Income.AutoSize = true;
            this.mL_Customer_Income.Location = new System.Drawing.Point(3, 47);
            this.mL_Customer_Income.Name = "mL_Customer_Income";
            this.mL_Customer_Income.Size = new System.Drawing.Size(70, 19);
            this.mL_Customer_Income.TabIndex = 9;
            this.mL_Customer_Income.Text = "Customer:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Date:";
            // 
            // mL_Payment_Income
            // 
            this.mL_Payment_Income.AutoSize = true;
            this.mL_Payment_Income.Location = new System.Drawing.Point(260, 8);
            this.mL_Payment_Income.Name = "mL_Payment_Income";
            this.mL_Payment_Income.Size = new System.Drawing.Size(62, 19);
            this.mL_Payment_Income.TabIndex = 9;
            this.mL_Payment_Income.Text = "Payment:";
            // 
            // mTB_Price_Income
            // 
            // 
            // 
            // 
            this.mTB_Price_Income.CustomButton.Image = null;
            this.mTB_Price_Income.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Price_Income.CustomButton.Name = "";
            this.mTB_Price_Income.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Price_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Price_Income.CustomButton.TabIndex = 1;
            this.mTB_Price_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Price_Income.CustomButton.UseSelectable = true;
            this.mTB_Price_Income.CustomButton.Visible = false;
            this.mTB_Price_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Price", true));
            this.mTB_Price_Income.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Price_Income.Lines = new string[] {
        "10,23"};
            this.mTB_Price_Income.Location = new System.Drawing.Point(347, 42);
            this.mTB_Price_Income.MaxLength = 32767;
            this.mTB_Price_Income.Name = "mTB_Price_Income";
            this.mTB_Price_Income.PasswordChar = '\0';
            this.mTB_Price_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Price_Income.SelectedText = "";
            this.mTB_Price_Income.SelectionLength = 0;
            this.mTB_Price_Income.SelectionStart = 0;
            this.mTB_Price_Income.ShortcutsEnabled = true;
            this.mTB_Price_Income.Size = new System.Drawing.Size(122, 29);
            this.mTB_Price_Income.TabIndex = 5;
            this.mTB_Price_Income.Text = "10,23";
            this.mTB_Price_Income.UseSelectable = true;
            this.mTB_Price_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Price_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Payment_Income
            // 
            // 
            // 
            // 
            this.mTB_Payment_Income.CustomButton.Image = null;
            this.mTB_Payment_Income.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Payment_Income.CustomButton.Name = "";
            this.mTB_Payment_Income.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Payment_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Payment_Income.CustomButton.TabIndex = 1;
            this.mTB_Payment_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Payment_Income.CustomButton.UseSelectable = true;
            this.mTB_Payment_Income.CustomButton.Visible = false;
            this.mTB_Payment_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Payment", true));
            this.mTB_Payment_Income.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Payment_Income.Lines = new string[] {
        "Chash"};
            this.mTB_Payment_Income.Location = new System.Drawing.Point(347, 3);
            this.mTB_Payment_Income.MaxLength = 32767;
            this.mTB_Payment_Income.Name = "mTB_Payment_Income";
            this.mTB_Payment_Income.PasswordChar = '\0';
            this.mTB_Payment_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Payment_Income.SelectedText = "";
            this.mTB_Payment_Income.SelectionLength = 0;
            this.mTB_Payment_Income.SelectionStart = 0;
            this.mTB_Payment_Income.ShortcutsEnabled = true;
            this.mTB_Payment_Income.Size = new System.Drawing.Size(122, 29);
            this.mTB_Payment_Income.TabIndex = 3;
            this.mTB_Payment_Income.Text = "Chash";
            this.mTB_Payment_Income.UseSelectable = true;
            this.mTB_Payment_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Payment_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Date_Income
            // 
            // 
            // 
            // 
            this.mTB_Date_Income.CustomButton.Image = null;
            this.mTB_Date_Income.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Date_Income.CustomButton.Name = "";
            this.mTB_Date_Income.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Date_Income.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Date_Income.CustomButton.TabIndex = 1;
            this.mTB_Date_Income.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Date_Income.CustomButton.UseSelectable = true;
            this.mTB_Date_Income.CustomButton.Visible = false;
            this.mTB_Date_Income.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Date", true));
            this.mTB_Date_Income.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Date_Income.Lines = new string[] {
        "01.01.2018"};
            this.mTB_Date_Income.Location = new System.Drawing.Point(87, 3);
            this.mTB_Date_Income.MaxLength = 32767;
            this.mTB_Date_Income.Name = "mTB_Date_Income";
            this.mTB_Date_Income.PasswordChar = '\0';
            this.mTB_Date_Income.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Date_Income.SelectedText = "";
            this.mTB_Date_Income.SelectionLength = 0;
            this.mTB_Date_Income.SelectionStart = 0;
            this.mTB_Date_Income.ShortcutsEnabled = true;
            this.mTB_Date_Income.Size = new System.Drawing.Size(122, 29);
            this.mTB_Date_Income.TabIndex = 2;
            this.mTB_Date_Income.Text = "01.01.2018";
            this.mTB_Date_Income.UseSelectable = true;
            this.mTB_Date_Income.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Date_Income.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTP_Products
            // 
            this.mTP_Products.Controls.Add(this.metroPanel1);
            this.mTP_Products.HorizontalScrollbarBarColor = true;
            this.mTP_Products.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Products.HorizontalScrollbarSize = 10;
            this.mTP_Products.Location = new System.Drawing.Point(4, 38);
            this.mTP_Products.Name = "mTP_Products";
            this.mTP_Products.Size = new System.Drawing.Size(760, 334);
            this.mTP_Products.TabIndex = 3;
            this.mTP_Products.Text = "Products";
            this.mTP_Products.VerticalScrollbarBarColor = true;
            this.mTP_Products.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Products.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroTextBox2);
            this.metroPanel1.Controls.Add(this.metroTextBox3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 247);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 84);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.incomeBindingSource, "Customer_Id", true));
            this.metroComboBox1.DataSource = this.customerBindingSource;
            this.metroComboBox1.DisplayMember = "Full_Name";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(87, 42);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(122, 29);
            this.metroComboBox1.TabIndex = 10;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Id";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(260, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Price:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Product:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Date:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(260, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Price:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Price", true));
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "10,23"};
            this.metroTextBox1.Location = new System.Drawing.Point(347, 42);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(122, 29);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Text = "10,23";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Payment", true));
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[] {
        "Chash"};
            this.metroTextBox2.Location = new System.Drawing.Point(347, 3);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(122, 29);
            this.metroTextBox2.TabIndex = 3;
            this.metroTextBox2.Text = "Chash";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.incomeBindingSource, "Date", true));
            this.metroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox3.Lines = new string[] {
        "01.01.2018"};
            this.metroTextBox3.Location = new System.Drawing.Point(87, 3);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(122, 29);
            this.metroTextBox3.TabIndex = 2;
            this.metroTextBox3.Text = "01.01.2018";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPage_Overview
            // 
            this.tabPage_Overview.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Overview.Name = "tabPage_Overview";
            this.tabPage_Overview.Size = new System.Drawing.Size(760, 334);
            this.tabPage_Overview.TabIndex = 0;
            this.tabPage_Overview.Text = "Overview";
            // 
            // mB_Save
            // 
            this.mB_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Save.Location = new System.Drawing.Point(687, 454);
            this.mB_Save.Name = "mB_Save";
            this.mB_Save.Size = new System.Drawing.Size(100, 25);
            this.mB_Save.TabIndex = 1;
            this.mB_Save.Text = "&Save";
            this.mB_Save.UseSelectable = true;
            this.mB_Save.Click += new System.EventHandler(this.mB_Save_Tables_Click);
            // 
            // mB_Add_Customer
            // 
            this.mB_Add_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Add_Customer.Location = new System.Drawing.Point(369, 454);
            this.mB_Add_Customer.Name = "mB_Add_Customer";
            this.mB_Add_Customer.Size = new System.Drawing.Size(100, 25);
            this.mB_Add_Customer.TabIndex = 2;
            this.mB_Add_Customer.Text = "&Add";
            this.mB_Add_Customer.UseSelectable = true;
            this.mB_Add_Customer.Click += new System.EventHandler(this.mB_Add_Customer_Click);
            // 
            // mB_Edit_Customer
            // 
            this.mB_Edit_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Edit_Customer.Location = new System.Drawing.Point(475, 454);
            this.mB_Edit_Customer.Name = "mB_Edit_Customer";
            this.mB_Edit_Customer.Size = new System.Drawing.Size(100, 25);
            this.mB_Edit_Customer.TabIndex = 3;
            this.mB_Edit_Customer.Text = "&Edit";
            this.mB_Edit_Customer.UseSelectable = true;
            this.mB_Edit_Customer.Click += new System.EventHandler(this.mB_Edit_Customer_Click);
            // 
            // mB_Remove
            // 
            this.mB_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Remove.Location = new System.Drawing.Point(581, 454);
            this.mB_Remove.Name = "mB_Remove";
            this.mB_Remove.Size = new System.Drawing.Size(100, 25);
            this.mB_Remove.TabIndex = 4;
            this.mB_Remove.Text = "&Remove";
            this.mB_Remove.UseSelectable = true;
            this.mB_Remove.Click += new System.EventHandler(this.mB_Remove_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 502);
            this.Controls.Add(this.mB_Remove);
            this.Controls.Add(this.mB_Edit_Customer);
            this.Controls.Add(this.mB_Add_Customer);
            this.Controls.Add(this.mB_Save);
            this.Controls.Add(this.mTC_Accounting);
            this.Name = "Form_Main";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.mTC_Accounting.ResumeLayout(false);
            this.tabPage_Customer.ResumeLayout(false);
            this.mP_Customer.ResumeLayout(false);
            this.mP_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.mTP_Income.ResumeLayout(false);
            this.mP_Income.ResumeLayout(false);
            this.mP_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.mTP_Products.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTC_Accounting;
        private System.Windows.Forms.TabPage tabPage_Overview;
        private System.Windows.Forms.TabPage tabPage_Customer;
        private MetroFramework.Controls.MetroButton mB_Save;
        private MetroFramework.Controls.MetroPanel mP_Customer;
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
        private MetroFramework.Controls.MetroTextBox mT_FullName_Customer;
        private MetroFramework.Controls.MetroButton mB_Edit_Customer;
        private MetroFramework.Controls.MetroTabPage mTP_Income;
        private MetroFramework.Controls.MetroPanel mP_Income;
        private MetroFramework.Controls.MetroComboBox mCB_Customer_Income;
        private MetroFramework.Controls.MetroLabel mL_Price_Income;
        private MetroFramework.Controls.MetroLabel mL_Customer_Income;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mL_Payment_Income;
        private MetroFramework.Controls.MetroTextBox mTB_Price_Income;
        private MetroFramework.Controls.MetroTextBox mTB_Payment_Income;
        private MetroFramework.Controls.MetroTextBox mTB_Date_Income;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private MetroFramework.Controls.MetroTabPage mTP_Products;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroListView List_Customer;
        private System.Windows.Forms.ColumnHeader CH_Date;
        private System.Windows.Forms.ColumnHeader CH_Customer;
        private System.Windows.Forms.ColumnHeader CH_Email;
        private System.Windows.Forms.ColumnHeader CH_Phone;
        private System.Windows.Forms.ColumnHeader CH_CSA;
        private System.Windows.Forms.ColumnHeader CH_Neightbarhood;
        private System.Windows.Forms.ColumnHeader CH_HorseBarn;
        private MetroFramework.Controls.MetroListView List_Income;
        private MetroFramework.Controls.MetroButton mB_Remove;
        private System.Windows.Forms.ColumnHeader CH_Date_Income;
        private System.Windows.Forms.ColumnHeader CH_Customer_Income;
        private System.Windows.Forms.ColumnHeader CH_Payment_Income;
        private System.Windows.Forms.ColumnHeader CH_Price_Income;
    }
}

