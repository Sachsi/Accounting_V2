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
            this.mTP_Customer = new System.Windows.Forms.TabPage();
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
            this.mTP_Expenses = new MetroFramework.Controls.MetroTabPage();
            this.List_Expenses = new MetroFramework.Controls.MetroListView();
            this.CH_Date_Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Dealer_Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Payment_Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Price_Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Details_Expenses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mP_Expenses = new MetroFramework.Controls.MetroPanel();
            this.mTB_Dealer_Expenses = new MetroFramework.Controls.MetroTextBox();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mL_Dealer_Expenses = new MetroFramework.Controls.MetroLabel();
            this.mL_Date_Expenses = new MetroFramework.Controls.MetroLabel();
            this.mL_Payment_Expenses = new MetroFramework.Controls.MetroLabel();
            this.mTB_Price_Expenses = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Payment_Expenses = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Date_Expenses = new MetroFramework.Controls.MetroTextBox();
            this.mTP_Overview = new System.Windows.Forms.TabPage();
            this.mTP_Produkts = new MetroFramework.Controls.MetroTabPage();
            this.List_Produkts = new MetroFramework.Controls.MetroListView();
            this.CH_Produkts_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Produkts_Farmer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Produkts_Produce = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Produkts_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Produkts_Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Produkts_Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mP_Produkts = new MetroFramework.Controls.MetroPanel();
            this.mL_Produkts_Unit = new MetroFramework.Controls.MetroLabel();
            this.mCB_Produkts_Unit = new MetroFramework.Controls.MetroComboBox();
            this.ml_Unit = new MetroFramework.Controls.MetroLabel();
            this.mL_Produkts_Quantity = new MetroFramework.Controls.MetroLabel();
            this.mTB_Produkts_Quantity = new MetroFramework.Controls.MetroTextBox();
            this.produktBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTB_Produkts_Dealer = new MetroFramework.Controls.MetroTextBox();
            this.mL_Produkts_Price = new MetroFramework.Controls.MetroLabel();
            this.mL_Produkts_Farmer = new MetroFramework.Controls.MetroLabel();
            this.mL_Produkts_Date = new MetroFramework.Controls.MetroLabel();
            this.mL_Produkts_Produkt = new MetroFramework.Controls.MetroLabel();
            this.mTB_Produkts_Price = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Produkts_Produkt = new MetroFramework.Controls.MetroTextBox();
            this.mTB_Produkts_Date = new MetroFramework.Controls.MetroTextBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mB_Save = new MetroFramework.Controls.MetroButton();
            this.mB_Add_Customer = new MetroFramework.Controls.MetroButton();
            this.mB_Edit_Customer = new MetroFramework.Controls.MetroButton();
            this.mB_Remove = new MetroFramework.Controls.MetroButton();
            this.mTC_Accounting.SuspendLayout();
            this.mTP_Customer.SuspendLayout();
            this.mP_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.mTP_Income.SuspendLayout();
            this.mP_Income.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.mTP_Expenses.SuspendLayout();
            this.mP_Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            this.mTP_Produkts.SuspendLayout();
            this.mP_Produkts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mTC_Accounting
            // 
            this.mTC_Accounting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mTC_Accounting.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mTC_Accounting.Controls.Add(this.mTP_Customer);
            this.mTC_Accounting.Controls.Add(this.mTP_Income);
            this.mTC_Accounting.Controls.Add(this.mTP_Expenses);
            this.mTC_Accounting.Controls.Add(this.mTP_Overview);
            this.mTC_Accounting.Controls.Add(this.mTP_Produkts);
            this.mTC_Accounting.HotTrack = true;
            this.mTC_Accounting.ItemSize = new System.Drawing.Size(120, 34);
            this.mTC_Accounting.Location = new System.Drawing.Point(23, 63);
            this.mTC_Accounting.Name = "mTC_Accounting";
            this.mTC_Accounting.SelectedIndex = 4;
            this.mTC_Accounting.Size = new System.Drawing.Size(769, 376);
            this.mTC_Accounting.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mTC_Accounting.TabIndex = 0;
            this.mTC_Accounting.UseSelectable = true;
            // 
            // mTP_Customer
            // 
            this.mTP_Customer.Controls.Add(this.List_Customer);
            this.mTP_Customer.Controls.Add(this.mP_Customer);
            this.mTP_Customer.Location = new System.Drawing.Point(4, 38);
            this.mTP_Customer.Name = "mTP_Customer";
            this.mTP_Customer.Size = new System.Drawing.Size(761, 334);
            this.mTP_Customer.TabIndex = 1;
            this.mTP_Customer.Text = "Customer";
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
            this.CH_Customer.Width = 140;
            // 
            // CH_Email
            // 
            this.CH_Email.Text = "E-Mail";
            this.CH_Email.Width = 150;
            // 
            // CH_Phone
            // 
            this.CH_Phone.Text = "Phone";
            this.CH_Phone.Width = 100;
            // 
            // CH_CSA
            // 
            this.CH_CSA.Text = "CSA";
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
            this.mTP_Income.Size = new System.Drawing.Size(761, 334);
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
            this.CH_Customer_Income.Width = 200;
            // 
            // CH_Payment_Income
            // 
            this.CH_Payment_Income.Text = "Payment";
            this.CH_Payment_Income.Width = 150;
            // 
            // CH_Price_Income
            // 
            this.CH_Price_Income.Text = "Price";
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
            // mTP_Expenses
            // 
            this.mTP_Expenses.Controls.Add(this.List_Expenses);
            this.mTP_Expenses.Controls.Add(this.mP_Expenses);
            this.mTP_Expenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTP_Expenses.HorizontalScrollbarBarColor = true;
            this.mTP_Expenses.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Expenses.HorizontalScrollbarSize = 10;
            this.mTP_Expenses.Location = new System.Drawing.Point(4, 38);
            this.mTP_Expenses.Name = "mTP_Expenses";
            this.mTP_Expenses.Size = new System.Drawing.Size(761, 334);
            this.mTP_Expenses.TabIndex = 3;
            this.mTP_Expenses.Text = "Expenses";
            this.mTP_Expenses.VerticalScrollbarBarColor = true;
            this.mTP_Expenses.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Expenses.VerticalScrollbarSize = 10;
            // 
            // List_Expenses
            // 
            this.List_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Expenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Date_Expenses,
            this.CH_Dealer_Expenses,
            this.CH_Payment_Expenses,
            this.CH_Price_Expenses,
            this.CH_Details_Expenses});
            this.List_Expenses.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.List_Expenses.FullRowSelect = true;
            this.List_Expenses.Location = new System.Drawing.Point(3, 3);
            this.List_Expenses.Name = "List_Expenses";
            this.List_Expenses.OwnerDraw = true;
            this.List_Expenses.Size = new System.Drawing.Size(754, 241);
            this.List_Expenses.TabIndex = 5;
            this.List_Expenses.UseCompatibleStateImageBehavior = false;
            this.List_Expenses.UseSelectable = true;
            this.List_Expenses.View = System.Windows.Forms.View.Details;
            // 
            // CH_Date_Expenses
            // 
            this.CH_Date_Expenses.Text = "Date";
            this.CH_Date_Expenses.Width = 120;
            // 
            // CH_Dealer_Expenses
            // 
            this.CH_Dealer_Expenses.Text = "Dealer";
            this.CH_Dealer_Expenses.Width = 200;
            // 
            // CH_Payment_Expenses
            // 
            this.CH_Payment_Expenses.Text = "Payment";
            this.CH_Payment_Expenses.Width = 150;
            // 
            // CH_Price_Expenses
            // 
            this.CH_Price_Expenses.Text = "Price";
            this.CH_Price_Expenses.Width = 80;
            // 
            // CH_Details_Expenses
            // 
            this.CH_Details_Expenses.Text = "Details";
            this.CH_Details_Expenses.Width = 150;
            // 
            // mP_Expenses
            // 
            this.mP_Expenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mP_Expenses.Controls.Add(this.mTB_Dealer_Expenses);
            this.mP_Expenses.Controls.Add(this.metroLabel1);
            this.mP_Expenses.Controls.Add(this.mL_Dealer_Expenses);
            this.mP_Expenses.Controls.Add(this.mL_Date_Expenses);
            this.mP_Expenses.Controls.Add(this.mL_Payment_Expenses);
            this.mP_Expenses.Controls.Add(this.mTB_Price_Expenses);
            this.mP_Expenses.Controls.Add(this.mTB_Payment_Expenses);
            this.mP_Expenses.Controls.Add(this.mTB_Date_Expenses);
            this.mP_Expenses.HorizontalScrollbarBarColor = true;
            this.mP_Expenses.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Expenses.HorizontalScrollbarSize = 10;
            this.mP_Expenses.Location = new System.Drawing.Point(3, 247);
            this.mP_Expenses.Name = "mP_Expenses";
            this.mP_Expenses.Size = new System.Drawing.Size(754, 84);
            this.mP_Expenses.TabIndex = 4;
            this.mP_Expenses.VerticalScrollbarBarColor = true;
            this.mP_Expenses.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Expenses.VerticalScrollbarSize = 10;
            // 
            // mTB_Dealer_Expenses
            // 
            // 
            // 
            // 
            this.mTB_Dealer_Expenses.CustomButton.Image = null;
            this.mTB_Dealer_Expenses.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Dealer_Expenses.CustomButton.Name = "";
            this.mTB_Dealer_Expenses.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Dealer_Expenses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Dealer_Expenses.CustomButton.TabIndex = 1;
            this.mTB_Dealer_Expenses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Dealer_Expenses.CustomButton.UseSelectable = true;
            this.mTB_Dealer_Expenses.CustomButton.Visible = false;
            this.mTB_Dealer_Expenses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Dealer", true));
            this.mTB_Dealer_Expenses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Dealer_Expenses.Lines = new string[] {
        "Dealer"};
            this.mTB_Dealer_Expenses.Location = new System.Drawing.Point(87, 42);
            this.mTB_Dealer_Expenses.MaxLength = 32767;
            this.mTB_Dealer_Expenses.Name = "mTB_Dealer_Expenses";
            this.mTB_Dealer_Expenses.PasswordChar = '\0';
            this.mTB_Dealer_Expenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Dealer_Expenses.SelectedText = "";
            this.mTB_Dealer_Expenses.SelectionLength = 0;
            this.mTB_Dealer_Expenses.SelectionStart = 0;
            this.mTB_Dealer_Expenses.ShortcutsEnabled = true;
            this.mTB_Dealer_Expenses.Size = new System.Drawing.Size(122, 29);
            this.mTB_Dealer_Expenses.TabIndex = 10;
            this.mTB_Dealer_Expenses.Text = "Dealer";
            this.mTB_Dealer_Expenses.UseSelectable = true;
            this.mTB_Dealer_Expenses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Dealer_Expenses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataSource = typeof(Accounting.Expense);
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
            // mL_Dealer_Expenses
            // 
            this.mL_Dealer_Expenses.AutoSize = true;
            this.mL_Dealer_Expenses.Location = new System.Drawing.Point(3, 47);
            this.mL_Dealer_Expenses.Name = "mL_Dealer_Expenses";
            this.mL_Dealer_Expenses.Size = new System.Drawing.Size(51, 19);
            this.mL_Dealer_Expenses.TabIndex = 9;
            this.mL_Dealer_Expenses.Text = "Dealer:";
            // 
            // mL_Date_Expenses
            // 
            this.mL_Date_Expenses.AutoSize = true;
            this.mL_Date_Expenses.Location = new System.Drawing.Point(3, 8);
            this.mL_Date_Expenses.Name = "mL_Date_Expenses";
            this.mL_Date_Expenses.Size = new System.Drawing.Size(39, 19);
            this.mL_Date_Expenses.TabIndex = 9;
            this.mL_Date_Expenses.Text = "Date:";
            // 
            // mL_Payment_Expenses
            // 
            this.mL_Payment_Expenses.AutoSize = true;
            this.mL_Payment_Expenses.Location = new System.Drawing.Point(260, 8);
            this.mL_Payment_Expenses.Name = "mL_Payment_Expenses";
            this.mL_Payment_Expenses.Size = new System.Drawing.Size(62, 19);
            this.mL_Payment_Expenses.TabIndex = 9;
            this.mL_Payment_Expenses.Text = "Payment:";
            // 
            // mTB_Price_Expenses
            // 
            // 
            // 
            // 
            this.mTB_Price_Expenses.CustomButton.Image = null;
            this.mTB_Price_Expenses.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Price_Expenses.CustomButton.Name = "";
            this.mTB_Price_Expenses.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Price_Expenses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Price_Expenses.CustomButton.TabIndex = 1;
            this.mTB_Price_Expenses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Price_Expenses.CustomButton.UseSelectable = true;
            this.mTB_Price_Expenses.CustomButton.Visible = false;
            this.mTB_Price_Expenses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Price", true));
            this.mTB_Price_Expenses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Price_Expenses.Lines = new string[] {
        "10,23"};
            this.mTB_Price_Expenses.Location = new System.Drawing.Point(347, 42);
            this.mTB_Price_Expenses.MaxLength = 32767;
            this.mTB_Price_Expenses.Name = "mTB_Price_Expenses";
            this.mTB_Price_Expenses.PasswordChar = '\0';
            this.mTB_Price_Expenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Price_Expenses.SelectedText = "";
            this.mTB_Price_Expenses.SelectionLength = 0;
            this.mTB_Price_Expenses.SelectionStart = 0;
            this.mTB_Price_Expenses.ShortcutsEnabled = true;
            this.mTB_Price_Expenses.Size = new System.Drawing.Size(122, 29);
            this.mTB_Price_Expenses.TabIndex = 5;
            this.mTB_Price_Expenses.Text = "10,23";
            this.mTB_Price_Expenses.UseSelectable = true;
            this.mTB_Price_Expenses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Price_Expenses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Payment_Expenses
            // 
            // 
            // 
            // 
            this.mTB_Payment_Expenses.CustomButton.Image = null;
            this.mTB_Payment_Expenses.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Payment_Expenses.CustomButton.Name = "";
            this.mTB_Payment_Expenses.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Payment_Expenses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Payment_Expenses.CustomButton.TabIndex = 1;
            this.mTB_Payment_Expenses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Payment_Expenses.CustomButton.UseSelectable = true;
            this.mTB_Payment_Expenses.CustomButton.Visible = false;
            this.mTB_Payment_Expenses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Payment", true));
            this.mTB_Payment_Expenses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Payment_Expenses.Lines = new string[] {
        "Chash"};
            this.mTB_Payment_Expenses.Location = new System.Drawing.Point(347, 3);
            this.mTB_Payment_Expenses.MaxLength = 32767;
            this.mTB_Payment_Expenses.Name = "mTB_Payment_Expenses";
            this.mTB_Payment_Expenses.PasswordChar = '\0';
            this.mTB_Payment_Expenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Payment_Expenses.SelectedText = "";
            this.mTB_Payment_Expenses.SelectionLength = 0;
            this.mTB_Payment_Expenses.SelectionStart = 0;
            this.mTB_Payment_Expenses.ShortcutsEnabled = true;
            this.mTB_Payment_Expenses.Size = new System.Drawing.Size(122, 29);
            this.mTB_Payment_Expenses.TabIndex = 3;
            this.mTB_Payment_Expenses.Text = "Chash";
            this.mTB_Payment_Expenses.UseSelectable = true;
            this.mTB_Payment_Expenses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Payment_Expenses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Date_Expenses
            // 
            // 
            // 
            // 
            this.mTB_Date_Expenses.CustomButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Date", true));
            this.mTB_Date_Expenses.CustomButton.Image = null;
            this.mTB_Date_Expenses.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Date_Expenses.CustomButton.Name = "";
            this.mTB_Date_Expenses.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Date_Expenses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Date_Expenses.CustomButton.TabIndex = 1;
            this.mTB_Date_Expenses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Date_Expenses.CustomButton.UseSelectable = true;
            this.mTB_Date_Expenses.CustomButton.Visible = false;
            this.mTB_Date_Expenses.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Date", true));
            this.mTB_Date_Expenses.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Date_Expenses.Lines = new string[] {
        "01.01.2018"};
            this.mTB_Date_Expenses.Location = new System.Drawing.Point(87, 3);
            this.mTB_Date_Expenses.MaxLength = 32767;
            this.mTB_Date_Expenses.Name = "mTB_Date_Expenses";
            this.mTB_Date_Expenses.PasswordChar = '\0';
            this.mTB_Date_Expenses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Date_Expenses.SelectedText = "";
            this.mTB_Date_Expenses.SelectionLength = 0;
            this.mTB_Date_Expenses.SelectionStart = 0;
            this.mTB_Date_Expenses.ShortcutsEnabled = true;
            this.mTB_Date_Expenses.Size = new System.Drawing.Size(122, 29);
            this.mTB_Date_Expenses.TabIndex = 2;
            this.mTB_Date_Expenses.Text = "01.01.2018";
            this.mTB_Date_Expenses.UseSelectable = true;
            this.mTB_Date_Expenses.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Date_Expenses.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTP_Overview
            // 
            this.mTP_Overview.Location = new System.Drawing.Point(4, 38);
            this.mTP_Overview.Name = "mTP_Overview";
            this.mTP_Overview.Size = new System.Drawing.Size(761, 334);
            this.mTP_Overview.TabIndex = 0;
            this.mTP_Overview.Text = "Overview";
            // 
            // mTP_Produkts
            // 
            this.mTP_Produkts.Controls.Add(this.List_Produkts);
            this.mTP_Produkts.Controls.Add(this.mP_Produkts);
            this.mTP_Produkts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTP_Produkts.HorizontalScrollbarBarColor = true;
            this.mTP_Produkts.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Produkts.HorizontalScrollbarSize = 10;
            this.mTP_Produkts.Location = new System.Drawing.Point(4, 38);
            this.mTP_Produkts.Name = "mTP_Produkts";
            this.mTP_Produkts.Size = new System.Drawing.Size(761, 334);
            this.mTP_Produkts.TabIndex = 4;
            this.mTP_Produkts.Text = "Produkts";
            this.mTP_Produkts.VerticalScrollbarBarColor = true;
            this.mTP_Produkts.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Produkts.VerticalScrollbarSize = 10;
            // 
            // List_Produkts
            // 
            this.List_Produkts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.List_Produkts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Produkts_Date,
            this.CH_Produkts_Farmer,
            this.CH_Produkts_Produce,
            this.CH_Produkts_Price,
            this.CH_Produkts_Quantity,
            this.CH_Produkts_Unit});
            this.List_Produkts.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.List_Produkts.FullRowSelect = true;
            this.List_Produkts.Location = new System.Drawing.Point(3, 3);
            this.List_Produkts.Name = "List_Produkts";
            this.List_Produkts.OwnerDraw = true;
            this.List_Produkts.Size = new System.Drawing.Size(754, 241);
            this.List_Produkts.TabIndex = 7;
            this.List_Produkts.UseCompatibleStateImageBehavior = false;
            this.List_Produkts.UseSelectable = true;
            this.List_Produkts.View = System.Windows.Forms.View.Details;
            // 
            // CH_Produkts_Date
            // 
            this.CH_Produkts_Date.Text = "Date";
            this.CH_Produkts_Date.Width = 120;
            // 
            // CH_Produkts_Farmer
            // 
            this.CH_Produkts_Farmer.Text = "Farmer";
            this.CH_Produkts_Farmer.Width = 200;
            // 
            // CH_Produkts_Produce
            // 
            this.CH_Produkts_Produce.Text = "Produce";
            this.CH_Produkts_Produce.Width = 150;
            // 
            // CH_Produkts_Price
            // 
            this.CH_Produkts_Price.Text = "Price";
            this.CH_Produkts_Price.Width = 80;
            // 
            // CH_Produkts_Quantity
            // 
            this.CH_Produkts_Quantity.Text = "Quanitiy";
            this.CH_Produkts_Quantity.Width = 100;
            // 
            // CH_Produkts_Unit
            // 
            this.CH_Produkts_Unit.Text = "Unit";
            this.CH_Produkts_Unit.Width = 50;
            // 
            // mP_Produkts
            // 
            this.mP_Produkts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Unit);
            this.mP_Produkts.Controls.Add(this.mCB_Produkts_Unit);
            this.mP_Produkts.Controls.Add(this.ml_Unit);
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Quantity);
            this.mP_Produkts.Controls.Add(this.mTB_Produkts_Quantity);
            this.mP_Produkts.Controls.Add(this.mTB_Produkts_Dealer);
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Price);
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Farmer);
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Date);
            this.mP_Produkts.Controls.Add(this.mL_Produkts_Produkt);
            this.mP_Produkts.Controls.Add(this.mTB_Produkts_Price);
            this.mP_Produkts.Controls.Add(this.mTB_Produkts_Produkt);
            this.mP_Produkts.Controls.Add(this.mTB_Produkts_Date);
            this.mP_Produkts.HorizontalScrollbarBarColor = true;
            this.mP_Produkts.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Produkts.HorizontalScrollbarSize = 10;
            this.mP_Produkts.Location = new System.Drawing.Point(3, 247);
            this.mP_Produkts.Name = "mP_Produkts";
            this.mP_Produkts.Size = new System.Drawing.Size(754, 84);
            this.mP_Produkts.TabIndex = 6;
            this.mP_Produkts.VerticalScrollbarBarColor = true;
            this.mP_Produkts.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Produkts.VerticalScrollbarSize = 10;
            // 
            // mL_Produkts_Unit
            // 
            this.mL_Produkts_Unit.AutoSize = true;
            this.mL_Produkts_Unit.Location = new System.Drawing.Point(516, 8);
            this.mL_Produkts_Unit.Name = "mL_Produkts_Unit";
            this.mL_Produkts_Unit.Size = new System.Drawing.Size(35, 19);
            this.mL_Produkts_Unit.TabIndex = 15;
            this.mL_Produkts_Unit.Text = "Unit:";
            // 
            // mCB_Produkts_Unit
            // 
            this.mCB_Produkts_Unit.FormattingEnabled = true;
            this.mCB_Produkts_Unit.ItemHeight = 23;
            this.mCB_Produkts_Unit.Location = new System.Drawing.Point(603, 3);
            this.mCB_Produkts_Unit.Name = "mCB_Produkts_Unit";
            this.mCB_Produkts_Unit.Size = new System.Drawing.Size(95, 29);
            this.mCB_Produkts_Unit.TabIndex = 14;
            this.mCB_Produkts_Unit.UseSelectable = true;
            this.mCB_Produkts_Unit.SelectedIndexChanged += new System.EventHandler(this.mCB_Produkts_Unit_SelectedIndexChanged);
            // 
            // ml_Unit
            // 
            this.ml_Unit.AutoSize = true;
            this.ml_Unit.Location = new System.Drawing.Point(703, 47);
            this.ml_Unit.Name = "ml_Unit";
            this.ml_Unit.Size = new System.Drawing.Size(29, 19);
            this.ml_Unit.TabIndex = 13;
            this.ml_Unit.Text = "mg";
            // 
            // mL_Produkts_Quantity
            // 
            this.mL_Produkts_Quantity.AutoSize = true;
            this.mL_Produkts_Quantity.Location = new System.Drawing.Point(516, 47);
            this.mL_Produkts_Quantity.Name = "mL_Produkts_Quantity";
            this.mL_Produkts_Quantity.Size = new System.Drawing.Size(61, 19);
            this.mL_Produkts_Quantity.TabIndex = 12;
            this.mL_Produkts_Quantity.Text = "Quantity:";
            // 
            // mTB_Produkts_Quantity
            // 
            // 
            // 
            // 
            this.mTB_Produkts_Quantity.CustomButton.Image = null;
            this.mTB_Produkts_Quantity.CustomButton.Location = new System.Drawing.Point(66, 1);
            this.mTB_Produkts_Quantity.CustomButton.Name = "";
            this.mTB_Produkts_Quantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Produkts_Quantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Produkts_Quantity.CustomButton.TabIndex = 1;
            this.mTB_Produkts_Quantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Produkts_Quantity.CustomButton.UseSelectable = true;
            this.mTB_Produkts_Quantity.CustomButton.Visible = false;
            this.mTB_Produkts_Quantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Quantity", true));
            this.mTB_Produkts_Quantity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Produkts_Quantity.Lines = new string[] {
        "100"};
            this.mTB_Produkts_Quantity.Location = new System.Drawing.Point(603, 42);
            this.mTB_Produkts_Quantity.MaxLength = 32767;
            this.mTB_Produkts_Quantity.Name = "mTB_Produkts_Quantity";
            this.mTB_Produkts_Quantity.PasswordChar = '\0';
            this.mTB_Produkts_Quantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Produkts_Quantity.SelectedText = "";
            this.mTB_Produkts_Quantity.SelectionLength = 0;
            this.mTB_Produkts_Quantity.SelectionStart = 0;
            this.mTB_Produkts_Quantity.ShortcutsEnabled = true;
            this.mTB_Produkts_Quantity.Size = new System.Drawing.Size(94, 29);
            this.mTB_Produkts_Quantity.TabIndex = 11;
            this.mTB_Produkts_Quantity.Text = "100";
            this.mTB_Produkts_Quantity.UseSelectable = true;
            this.mTB_Produkts_Quantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Produkts_Quantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // produktBindingSource
            // 
            this.produktBindingSource.DataSource = typeof(Accounting.Produkt);
            // 
            // mTB_Produkts_Dealer
            // 
            // 
            // 
            // 
            this.mTB_Produkts_Dealer.CustomButton.Image = null;
            this.mTB_Produkts_Dealer.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Produkts_Dealer.CustomButton.Name = "";
            this.mTB_Produkts_Dealer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Produkts_Dealer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Produkts_Dealer.CustomButton.TabIndex = 1;
            this.mTB_Produkts_Dealer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Produkts_Dealer.CustomButton.UseSelectable = true;
            this.mTB_Produkts_Dealer.CustomButton.Visible = false;
            this.mTB_Produkts_Dealer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Farmer", true));
            this.mTB_Produkts_Dealer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Produkts_Dealer.Lines = new string[] {
        "Pinsch of Soil"};
            this.mTB_Produkts_Dealer.Location = new System.Drawing.Point(87, 42);
            this.mTB_Produkts_Dealer.MaxLength = 32767;
            this.mTB_Produkts_Dealer.Name = "mTB_Produkts_Dealer";
            this.mTB_Produkts_Dealer.PasswordChar = '\0';
            this.mTB_Produkts_Dealer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Produkts_Dealer.SelectedText = "";
            this.mTB_Produkts_Dealer.SelectionLength = 0;
            this.mTB_Produkts_Dealer.SelectionStart = 0;
            this.mTB_Produkts_Dealer.ShortcutsEnabled = true;
            this.mTB_Produkts_Dealer.Size = new System.Drawing.Size(122, 29);
            this.mTB_Produkts_Dealer.TabIndex = 10;
            this.mTB_Produkts_Dealer.Text = "Pinsch of Soil";
            this.mTB_Produkts_Dealer.UseSelectable = true;
            this.mTB_Produkts_Dealer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Produkts_Dealer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mL_Produkts_Price
            // 
            this.mL_Produkts_Price.AutoSize = true;
            this.mL_Produkts_Price.Location = new System.Drawing.Point(260, 47);
            this.mL_Produkts_Price.Name = "mL_Produkts_Price";
            this.mL_Produkts_Price.Size = new System.Drawing.Size(41, 19);
            this.mL_Produkts_Price.TabIndex = 9;
            this.mL_Produkts_Price.Text = "Price:";
            // 
            // mL_Produkts_Farmer
            // 
            this.mL_Produkts_Farmer.AutoSize = true;
            this.mL_Produkts_Farmer.Location = new System.Drawing.Point(3, 47);
            this.mL_Produkts_Farmer.Name = "mL_Produkts_Farmer";
            this.mL_Produkts_Farmer.Size = new System.Drawing.Size(55, 19);
            this.mL_Produkts_Farmer.TabIndex = 9;
            this.mL_Produkts_Farmer.Text = "Farmer:";
            // 
            // mL_Produkts_Date
            // 
            this.mL_Produkts_Date.AutoSize = true;
            this.mL_Produkts_Date.Location = new System.Drawing.Point(3, 8);
            this.mL_Produkts_Date.Name = "mL_Produkts_Date";
            this.mL_Produkts_Date.Size = new System.Drawing.Size(39, 19);
            this.mL_Produkts_Date.TabIndex = 9;
            this.mL_Produkts_Date.Text = "Date:";
            // 
            // mL_Produkts_Produkt
            // 
            this.mL_Produkts_Produkt.AutoSize = true;
            this.mL_Produkts_Produkt.Location = new System.Drawing.Point(260, 8);
            this.mL_Produkts_Produkt.Name = "mL_Produkts_Produkt";
            this.mL_Produkts_Produkt.Size = new System.Drawing.Size(58, 19);
            this.mL_Produkts_Produkt.TabIndex = 9;
            this.mL_Produkts_Produkt.Text = "Produkt:";
            // 
            // mTB_Produkts_Price
            // 
            // 
            // 
            // 
            this.mTB_Produkts_Price.CustomButton.Image = null;
            this.mTB_Produkts_Price.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Produkts_Price.CustomButton.Name = "";
            this.mTB_Produkts_Price.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Produkts_Price.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Produkts_Price.CustomButton.TabIndex = 1;
            this.mTB_Produkts_Price.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Produkts_Price.CustomButton.UseSelectable = true;
            this.mTB_Produkts_Price.CustomButton.Visible = false;
            this.mTB_Produkts_Price.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Price", true));
            this.mTB_Produkts_Price.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Produkts_Price.Lines = new string[] {
        "1,00"};
            this.mTB_Produkts_Price.Location = new System.Drawing.Point(347, 42);
            this.mTB_Produkts_Price.MaxLength = 32767;
            this.mTB_Produkts_Price.Name = "mTB_Produkts_Price";
            this.mTB_Produkts_Price.PasswordChar = '\0';
            this.mTB_Produkts_Price.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Produkts_Price.SelectedText = "";
            this.mTB_Produkts_Price.SelectionLength = 0;
            this.mTB_Produkts_Price.SelectionStart = 0;
            this.mTB_Produkts_Price.ShortcutsEnabled = true;
            this.mTB_Produkts_Price.Size = new System.Drawing.Size(122, 29);
            this.mTB_Produkts_Price.TabIndex = 5;
            this.mTB_Produkts_Price.Text = "1,00";
            this.mTB_Produkts_Price.UseSelectable = true;
            this.mTB_Produkts_Price.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Produkts_Price.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Produkts_Produkt
            // 
            // 
            // 
            // 
            this.mTB_Produkts_Produkt.CustomButton.Image = null;
            this.mTB_Produkts_Produkt.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Produkts_Produkt.CustomButton.Name = "";
            this.mTB_Produkts_Produkt.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Produkts_Produkt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Produkts_Produkt.CustomButton.TabIndex = 1;
            this.mTB_Produkts_Produkt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Produkts_Produkt.CustomButton.UseSelectable = true;
            this.mTB_Produkts_Produkt.CustomButton.Visible = false;
            this.mTB_Produkts_Produkt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Produce", true));
            this.mTB_Produkts_Produkt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Produkts_Produkt.Lines = new string[] {
        "Veggie"};
            this.mTB_Produkts_Produkt.Location = new System.Drawing.Point(347, 3);
            this.mTB_Produkts_Produkt.MaxLength = 32767;
            this.mTB_Produkts_Produkt.Name = "mTB_Produkts_Produkt";
            this.mTB_Produkts_Produkt.PasswordChar = '\0';
            this.mTB_Produkts_Produkt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Produkts_Produkt.SelectedText = "";
            this.mTB_Produkts_Produkt.SelectionLength = 0;
            this.mTB_Produkts_Produkt.SelectionStart = 0;
            this.mTB_Produkts_Produkt.ShortcutsEnabled = true;
            this.mTB_Produkts_Produkt.Size = new System.Drawing.Size(122, 29);
            this.mTB_Produkts_Produkt.TabIndex = 3;
            this.mTB_Produkts_Produkt.Text = "Veggie";
            this.mTB_Produkts_Produkt.UseSelectable = true;
            this.mTB_Produkts_Produkt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Produkts_Produkt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mTB_Produkts_Date
            // 
            // 
            // 
            // 
            this.mTB_Produkts_Date.CustomButton.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Date", true));
            this.mTB_Produkts_Date.CustomButton.Image = null;
            this.mTB_Produkts_Date.CustomButton.Location = new System.Drawing.Point(94, 1);
            this.mTB_Produkts_Date.CustomButton.Name = "";
            this.mTB_Produkts_Date.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mTB_Produkts_Date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTB_Produkts_Date.CustomButton.TabIndex = 1;
            this.mTB_Produkts_Date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTB_Produkts_Date.CustomButton.UseSelectable = true;
            this.mTB_Produkts_Date.CustomButton.Visible = false;
            this.mTB_Produkts_Date.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produktBindingSource, "Date", true));
            this.mTB_Produkts_Date.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTB_Produkts_Date.Lines = new string[] {
        "01.01.2018"};
            this.mTB_Produkts_Date.Location = new System.Drawing.Point(87, 3);
            this.mTB_Produkts_Date.MaxLength = 32767;
            this.mTB_Produkts_Date.Name = "mTB_Produkts_Date";
            this.mTB_Produkts_Date.PasswordChar = '\0';
            this.mTB_Produkts_Date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTB_Produkts_Date.SelectedText = "";
            this.mTB_Produkts_Date.SelectionLength = 0;
            this.mTB_Produkts_Date.SelectionStart = 0;
            this.mTB_Produkts_Date.ShortcutsEnabled = true;
            this.mTB_Produkts_Date.Size = new System.Drawing.Size(122, 29);
            this.mTB_Produkts_Date.TabIndex = 2;
            this.mTB_Produkts_Date.Text = "01.01.2018";
            this.mTB_Produkts_Date.UseSelectable = true;
            this.mTB_Produkts_Date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTB_Produkts_Date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.produktBindingSource;
            // 
            // mB_Save
            // 
            this.mB_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mB_Save.Location = new System.Drawing.Point(688, 454);
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
            this.mB_Add_Customer.Location = new System.Drawing.Point(370, 454);
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
            this.mB_Edit_Customer.Location = new System.Drawing.Point(476, 454);
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
            this.mB_Remove.Location = new System.Drawing.Point(582, 454);
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
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.mB_Remove);
            this.Controls.Add(this.mB_Edit_Customer);
            this.Controls.Add(this.mB_Add_Customer);
            this.Controls.Add(this.mB_Save);
            this.Controls.Add(this.mTC_Accounting);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Main";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.mTC_Accounting.ResumeLayout(false);
            this.mTP_Customer.ResumeLayout(false);
            this.mP_Customer.ResumeLayout(false);
            this.mP_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.mTP_Income.ResumeLayout(false);
            this.mP_Income.ResumeLayout(false);
            this.mP_Income.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.mTP_Expenses.ResumeLayout(false);
            this.mP_Expenses.ResumeLayout(false);
            this.mP_Expenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            this.mTP_Produkts.ResumeLayout(false);
            this.mP_Produkts.ResumeLayout(false);
            this.mP_Produkts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produktBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTC_Accounting;
        private System.Windows.Forms.TabPage mTP_Overview;
        private System.Windows.Forms.TabPage mTP_Customer;
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
        private MetroFramework.Controls.MetroTabPage mTP_Expenses;
        private MetroFramework.Controls.MetroPanel mP_Expenses;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel mL_Dealer_Expenses;
        private MetroFramework.Controls.MetroLabel mL_Date_Expenses;
        private MetroFramework.Controls.MetroLabel mL_Payment_Expenses;
        private MetroFramework.Controls.MetroTextBox mTB_Price_Expenses;
        private MetroFramework.Controls.MetroTextBox mTB_Payment_Expenses;
        private MetroFramework.Controls.MetroTextBox mTB_Date_Expenses;
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
        private MetroFramework.Controls.MetroListView List_Expenses;
        private System.Windows.Forms.ColumnHeader CH_Date_Expenses;
        private System.Windows.Forms.ColumnHeader CH_Dealer_Expenses;
        private System.Windows.Forms.ColumnHeader CH_Payment_Expenses;
        private System.Windows.Forms.ColumnHeader CH_Price_Expenses;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private System.Windows.Forms.ColumnHeader CH_Details_Expenses;
        private MetroFramework.Controls.MetroTextBox mTB_Dealer_Expenses;
        private MetroFramework.Controls.MetroTabPage mTP_Produkts;
        private MetroFramework.Controls.MetroListView List_Produkts;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Date;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Farmer;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Produce;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Price;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Quantity;
        private MetroFramework.Controls.MetroPanel mP_Produkts;
        private MetroFramework.Controls.MetroLabel ml_Unit;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Quantity;
        private MetroFramework.Controls.MetroTextBox mTB_Produkts_Quantity;
        private MetroFramework.Controls.MetroTextBox mTB_Produkts_Dealer;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Price;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Farmer;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Date;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Produkt;
        private MetroFramework.Controls.MetroTextBox mTB_Produkts_Price;
        private MetroFramework.Controls.MetroTextBox mTB_Produkts_Produkt;
        private MetroFramework.Controls.MetroTextBox mTB_Produkts_Date;
        private System.Windows.Forms.BindingSource produktBindingSource;
        private System.Windows.Forms.ColumnHeader CH_Produkts_Unit;
        private MetroFramework.Controls.MetroLabel mL_Produkts_Unit;
        private MetroFramework.Controls.MetroComboBox mCB_Produkts_Unit;
        private System.Windows.Forms.BindingSource unitsBindingSource;
    }
}

