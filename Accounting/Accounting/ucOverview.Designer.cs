namespace Accounting
{
    partial class ucOverview
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mL_CSA_Customer = new MetroFramework.Controls.MetroLabel();
            this.mL_Nieghtbarhood = new MetroFramework.Controls.MetroLabel();
            this.mL_HorseBarn = new MetroFramework.Controls.MetroLabel();
            this.Timer_Overview = new System.Windows.Forms.Timer(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mL_Customer = new MetroFramework.Controls.MetroLabel();
            this.mT_IncomeDetails = new MetroFramework.Controls.MetroTile();
            this.ml_Price_ILY = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_ILM = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_IM = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_IS = new MetroFramework.Controls.MetroLabel();
            this.mL_IncomeLastYear = new MetroFramework.Controls.MetroLabel();
            this.mL_IncomeLastMonth = new MetroFramework.Controls.MetroLabel();
            this.mL_IncomeMonth = new MetroFramework.Controls.MetroLabel();
            this.mL_SumIncome = new MetroFramework.Controls.MetroLabel();
            this.mT_ExpensesDetails = new MetroFramework.Controls.MetroTile();
            this.ml_Price_ELY = new MetroFramework.Controls.MetroLabel();
            this.mL_ExpensesLastYear = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_ELM = new MetroFramework.Controls.MetroLabel();
            this.ml_ExpensesLastMonth = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_EM = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_ES = new MetroFramework.Controls.MetroLabel();
            this.mL_ExpensesYear = new MetroFramework.Controls.MetroLabel();
            this.mL_ExpensesMonth = new MetroFramework.Controls.MetroLabel();
            this.InfoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mT_VolumeOfSale = new MetroFramework.Controls.MetroTile();
            this.ml_Price_VSLY = new MetroFramework.Controls.MetroLabel();
            this.ml_VolumeLastYear = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_VSLM = new MetroFramework.Controls.MetroLabel();
            this.ml_VolumeLastMonth = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_VSM = new MetroFramework.Controls.MetroLabel();
            this.ml_Price_VSY = new MetroFramework.Controls.MetroLabel();
            this.ml_VolumeYear = new MetroFramework.Controls.MetroLabel();
            this.ml_VolumeMonth = new MetroFramework.Controls.MetroLabel();
            this.metroTile1.SuspendLayout();
            this.mT_IncomeDetails.SuspendLayout();
            this.mT_ExpensesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoChart)).BeginInit();
            this.mT_VolumeOfSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // mL_CSA_Customer
            // 
            this.mL_CSA_Customer.AutoSize = true;
            this.mL_CSA_Customer.Location = new System.Drawing.Point(6, 46);
            this.mL_CSA_Customer.Name = "mL_CSA_Customer";
            this.mL_CSA_Customer.Size = new System.Drawing.Size(95, 19);
            this.mL_CSA_Customer.TabIndex = 3;
            this.mL_CSA_Customer.Text = "CSA Customer";
            // 
            // mL_Nieghtbarhood
            // 
            this.mL_Nieghtbarhood.AutoSize = true;
            this.mL_Nieghtbarhood.Location = new System.Drawing.Point(6, 81);
            this.mL_Nieghtbarhood.Name = "mL_Nieghtbarhood";
            this.mL_Nieghtbarhood.Size = new System.Drawing.Size(99, 19);
            this.mL_Nieghtbarhood.TabIndex = 4;
            this.mL_Nieghtbarhood.Text = "Nieghtbarhood";
            // 
            // mL_HorseBarn
            // 
            this.mL_HorseBarn.AutoSize = true;
            this.mL_HorseBarn.Location = new System.Drawing.Point(6, 116);
            this.mL_HorseBarn.Name = "mL_HorseBarn";
            this.mL_HorseBarn.Size = new System.Drawing.Size(74, 19);
            this.mL_HorseBarn.TabIndex = 5;
            this.mL_HorseBarn.Text = "Horse Barn";
            // 
            // Timer_Overview
            // 
            this.Timer_Overview.Enabled = true;
            this.Timer_Overview.Tick += new System.EventHandler(this.Timer_Overview_Tick);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Controls.Add(this.mL_Customer);
            this.metroTile1.Controls.Add(this.mL_HorseBarn);
            this.metroTile1.Controls.Add(this.mL_CSA_Customer);
            this.metroTile1.Controls.Add(this.mL_Nieghtbarhood);
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(200, 200);
            this.metroTile1.TabIndex = 1;
            this.metroTile1.Text = "Customer Details";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // mL_Customer
            // 
            this.mL_Customer.AutoSize = true;
            this.mL_Customer.Location = new System.Drawing.Point(6, 151);
            this.mL_Customer.Name = "mL_Customer";
            this.mL_Customer.Size = new System.Drawing.Size(66, 19);
            this.mL_Customer.TabIndex = 6;
            this.mL_Customer.Text = "Customer";
            // 
            // mT_IncomeDetails
            // 
            this.mT_IncomeDetails.ActiveControl = null;
            this.mT_IncomeDetails.Controls.Add(this.ml_Price_ILY);
            this.mT_IncomeDetails.Controls.Add(this.ml_Price_ILM);
            this.mT_IncomeDetails.Controls.Add(this.ml_Price_IM);
            this.mT_IncomeDetails.Controls.Add(this.ml_Price_IS);
            this.mT_IncomeDetails.Controls.Add(this.mL_IncomeLastYear);
            this.mT_IncomeDetails.Controls.Add(this.mL_IncomeLastMonth);
            this.mT_IncomeDetails.Controls.Add(this.mL_IncomeMonth);
            this.mT_IncomeDetails.Controls.Add(this.mL_SumIncome);
            this.mT_IncomeDetails.Location = new System.Drawing.Point(211, 3);
            this.mT_IncomeDetails.Name = "mT_IncomeDetails";
            this.mT_IncomeDetails.Size = new System.Drawing.Size(200, 200);
            this.mT_IncomeDetails.TabIndex = 2;
            this.mT_IncomeDetails.Text = "Income Details";
            this.mT_IncomeDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mT_IncomeDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_IncomeDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mT_IncomeDetails.UseSelectable = true;
            this.mT_IncomeDetails.Click += new System.EventHandler(this.mT_IncomeDetails_Click);
            // 
            // ml_Price_ILY
            // 
            this.ml_Price_ILY.AutoSize = true;
            this.ml_Price_ILY.Location = new System.Drawing.Point(118, 151);
            this.ml_Price_ILY.Name = "ml_Price_ILY";
            this.ml_Price_ILY.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_ILY.TabIndex = 7;
            this.ml_Price_ILY.Text = "Price";
            this.ml_Price_ILY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_ILM
            // 
            this.ml_Price_ILM.AutoSize = true;
            this.ml_Price_ILM.Location = new System.Drawing.Point(118, 118);
            this.ml_Price_ILM.Name = "ml_Price_ILM";
            this.ml_Price_ILM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_ILM.TabIndex = 6;
            this.ml_Price_ILM.Text = "Price";
            this.ml_Price_ILM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_IM
            // 
            this.ml_Price_IM.AutoSize = true;
            this.ml_Price_IM.Location = new System.Drawing.Point(118, 81);
            this.ml_Price_IM.Name = "ml_Price_IM";
            this.ml_Price_IM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_IM.TabIndex = 5;
            this.ml_Price_IM.Text = "Price";
            this.ml_Price_IM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_IS
            // 
            this.ml_Price_IS.AutoSize = true;
            this.ml_Price_IS.Location = new System.Drawing.Point(118, 46);
            this.ml_Price_IS.Name = "ml_Price_IS";
            this.ml_Price_IS.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_IS.TabIndex = 4;
            this.ml_Price_IS.Text = "Price";
            this.ml_Price_IS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_IncomeLastYear
            // 
            this.mL_IncomeLastYear.AutoSize = true;
            this.mL_IncomeLastYear.Location = new System.Drawing.Point(14, 151);
            this.mL_IncomeLastYear.Name = "mL_IncomeLastYear";
            this.mL_IncomeLastYear.Size = new System.Drawing.Size(85, 19);
            this.mL_IncomeLastYear.TabIndex = 3;
            this.mL_IncomeLastYear.Text = "Income Year:";
            // 
            // mL_IncomeLastMonth
            // 
            this.mL_IncomeLastMonth.AutoSize = true;
            this.mL_IncomeLastMonth.Location = new System.Drawing.Point(14, 118);
            this.mL_IncomeLastMonth.Name = "mL_IncomeLastMonth";
            this.mL_IncomeLastMonth.Size = new System.Drawing.Size(97, 19);
            this.mL_IncomeLastMonth.TabIndex = 2;
            this.mL_IncomeLastMonth.Text = "Income Month:";
            // 
            // mL_IncomeMonth
            // 
            this.mL_IncomeMonth.AutoSize = true;
            this.mL_IncomeMonth.Location = new System.Drawing.Point(14, 81);
            this.mL_IncomeMonth.Name = "mL_IncomeMonth";
            this.mL_IncomeMonth.Size = new System.Drawing.Size(97, 19);
            this.mL_IncomeMonth.TabIndex = 1;
            this.mL_IncomeMonth.Text = "Income Month:";
            // 
            // mL_SumIncome
            // 
            this.mL_SumIncome.AutoSize = true;
            this.mL_SumIncome.Location = new System.Drawing.Point(14, 46);
            this.mL_SumIncome.Name = "mL_SumIncome";
            this.mL_SumIncome.Size = new System.Drawing.Size(85, 19);
            this.mL_SumIncome.TabIndex = 0;
            this.mL_SumIncome.Text = "Income Sum:";
            // 
            // mT_ExpensesDetails
            // 
            this.mT_ExpensesDetails.ActiveControl = null;
            this.mT_ExpensesDetails.Controls.Add(this.ml_Price_ELY);
            this.mT_ExpensesDetails.Controls.Add(this.mL_ExpensesLastYear);
            this.mT_ExpensesDetails.Controls.Add(this.ml_Price_ELM);
            this.mT_ExpensesDetails.Controls.Add(this.ml_ExpensesLastMonth);
            this.mT_ExpensesDetails.Controls.Add(this.ml_Price_EM);
            this.mT_ExpensesDetails.Controls.Add(this.ml_Price_ES);
            this.mT_ExpensesDetails.Controls.Add(this.mL_ExpensesYear);
            this.mT_ExpensesDetails.Controls.Add(this.mL_ExpensesMonth);
            this.mT_ExpensesDetails.Location = new System.Drawing.Point(419, 3);
            this.mT_ExpensesDetails.Name = "mT_ExpensesDetails";
            this.mT_ExpensesDetails.Size = new System.Drawing.Size(200, 200);
            this.mT_ExpensesDetails.TabIndex = 3;
            this.mT_ExpensesDetails.Text = "Expenses Details";
            this.mT_ExpensesDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mT_ExpensesDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_ExpensesDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mT_ExpensesDetails.UseSelectable = true;
            this.mT_ExpensesDetails.Click += new System.EventHandler(this.mT_ExpensesDetails_Click);
            // 
            // ml_Price_ELY
            // 
            this.ml_Price_ELY.AutoSize = true;
            this.ml_Price_ELY.Location = new System.Drawing.Point(119, 151);
            this.ml_Price_ELY.Name = "ml_Price_ELY";
            this.ml_Price_ELY.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_ELY.TabIndex = 11;
            this.ml_Price_ELY.Text = "Price";
            this.ml_Price_ELY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_ExpensesLastYear
            // 
            this.mL_ExpensesLastYear.AutoSize = true;
            this.mL_ExpensesLastYear.Location = new System.Drawing.Point(5, 151);
            this.mL_ExpensesLastYear.Name = "mL_ExpensesLastYear";
            this.mL_ExpensesLastYear.Size = new System.Drawing.Size(90, 19);
            this.mL_ExpensesLastYear.TabIndex = 6;
            this.mL_ExpensesLastYear.Text = "Expenses Year";
            // 
            // ml_Price_ELM
            // 
            this.ml_Price_ELM.AutoSize = true;
            this.ml_Price_ELM.Location = new System.Drawing.Point(119, 118);
            this.ml_Price_ELM.Name = "ml_Price_ELM";
            this.ml_Price_ELM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_ELM.TabIndex = 10;
            this.ml_Price_ELM.Text = "Price";
            this.ml_Price_ELM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_ExpensesLastMonth
            // 
            this.ml_ExpensesLastMonth.AutoSize = true;
            this.ml_ExpensesLastMonth.Location = new System.Drawing.Point(5, 116);
            this.ml_ExpensesLastMonth.Name = "ml_ExpensesLastMonth";
            this.ml_ExpensesLastMonth.Size = new System.Drawing.Size(106, 19);
            this.ml_ExpensesLastMonth.TabIndex = 5;
            this.ml_ExpensesLastMonth.Text = "Expenses Month:";
            // 
            // ml_Price_EM
            // 
            this.ml_Price_EM.AutoSize = true;
            this.ml_Price_EM.Location = new System.Drawing.Point(119, 81);
            this.ml_Price_EM.Name = "ml_Price_EM";
            this.ml_Price_EM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_EM.TabIndex = 9;
            this.ml_Price_EM.Text = "Price";
            this.ml_Price_EM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_ES
            // 
            this.ml_Price_ES.AutoSize = true;
            this.ml_Price_ES.Location = new System.Drawing.Point(119, 46);
            this.ml_Price_ES.Name = "ml_Price_ES";
            this.ml_Price_ES.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_ES.TabIndex = 8;
            this.ml_Price_ES.Text = "Price";
            this.ml_Price_ES.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_ExpensesYear
            // 
            this.mL_ExpensesYear.AutoSize = true;
            this.mL_ExpensesYear.Location = new System.Drawing.Point(5, 46);
            this.mL_ExpensesYear.Name = "mL_ExpensesYear";
            this.mL_ExpensesYear.Size = new System.Drawing.Size(94, 19);
            this.mL_ExpensesYear.TabIndex = 3;
            this.mL_ExpensesYear.Text = "Expenses Sum:";
            // 
            // mL_ExpensesMonth
            // 
            this.mL_ExpensesMonth.AutoSize = true;
            this.mL_ExpensesMonth.Location = new System.Drawing.Point(5, 81);
            this.mL_ExpensesMonth.Name = "mL_ExpensesMonth";
            this.mL_ExpensesMonth.Size = new System.Drawing.Size(106, 19);
            this.mL_ExpensesMonth.TabIndex = 4;
            this.mL_ExpensesMonth.Text = "Expenses Month:";
            // 
            // InfoChart
            // 
            this.InfoChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea6.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea6.Area3DStyle.Inclination = 20;
            chartArea6.Area3DStyle.Rotation = 10;
            chartArea6.Area3DStyle.WallWidth = 20;
            chartArea6.Name = "Income";
            this.InfoChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.InfoChart.Legends.Add(legend6);
            this.InfoChart.Location = new System.Drawing.Point(6, 229);
            this.InfoChart.Name = "InfoChart";
            series16.ChartArea = "Income";
            series16.Legend = "Legend1";
            series16.Name = "Income";
            series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series17.ChartArea = "Income";
            series17.Legend = "Legend1";
            series17.Name = "Expenses";
            series17.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series18.ChartArea = "Income";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series18.Name = "Volume of Sale";
            series18.YValuesPerPoint = 4;
            this.InfoChart.Series.Add(series16);
            this.InfoChart.Series.Add(series17);
            this.InfoChart.Series.Add(series18);
            this.InfoChart.Size = new System.Drawing.Size(821, 264);
            this.InfoChart.TabIndex = 4;
            this.InfoChart.Text = "chart";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            title6.Name = "ChartOverview";
            title6.Text = "Chart Overview";
            this.InfoChart.Titles.Add(title6);
            // 
            // mT_VolumeOfSale
            // 
            this.mT_VolumeOfSale.ActiveControl = null;
            this.mT_VolumeOfSale.Controls.Add(this.ml_Price_VSLY);
            this.mT_VolumeOfSale.Controls.Add(this.ml_VolumeLastYear);
            this.mT_VolumeOfSale.Controls.Add(this.ml_Price_VSLM);
            this.mT_VolumeOfSale.Controls.Add(this.ml_VolumeLastMonth);
            this.mT_VolumeOfSale.Controls.Add(this.ml_Price_VSM);
            this.mT_VolumeOfSale.Controls.Add(this.ml_Price_VSY);
            this.mT_VolumeOfSale.Controls.Add(this.ml_VolumeYear);
            this.mT_VolumeOfSale.Controls.Add(this.ml_VolumeMonth);
            this.mT_VolumeOfSale.Location = new System.Drawing.Point(627, 3);
            this.mT_VolumeOfSale.Name = "mT_VolumeOfSale";
            this.mT_VolumeOfSale.Size = new System.Drawing.Size(200, 200);
            this.mT_VolumeOfSale.TabIndex = 5;
            this.mT_VolumeOfSale.Text = "Volume of Sales";
            this.mT_VolumeOfSale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mT_VolumeOfSale.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_VolumeOfSale.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mT_VolumeOfSale.UseSelectable = true;
            this.mT_VolumeOfSale.Click += new System.EventHandler(this.mT_VolumeOfSale_Click);
            // 
            // ml_Price_VSLY
            // 
            this.ml_Price_VSLY.AutoSize = true;
            this.ml_Price_VSLY.Location = new System.Drawing.Point(118, 151);
            this.ml_Price_VSLY.Name = "ml_Price_VSLY";
            this.ml_Price_VSLY.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_VSLY.TabIndex = 11;
            this.ml_Price_VSLY.Text = "Price";
            this.ml_Price_VSLY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_VolumeLastYear
            // 
            this.ml_VolumeLastYear.AutoSize = true;
            this.ml_VolumeLastYear.Location = new System.Drawing.Point(5, 151);
            this.ml_VolumeLastYear.Name = "ml_VolumeLastYear";
            this.ml_VolumeLastYear.Size = new System.Drawing.Size(90, 19);
            this.ml_VolumeLastYear.TabIndex = 6;
            this.ml_VolumeLastYear.Text = "V of Sale Year";
            // 
            // ml_Price_VSLM
            // 
            this.ml_Price_VSLM.AutoSize = true;
            this.ml_Price_VSLM.Location = new System.Drawing.Point(118, 118);
            this.ml_Price_VSLM.Name = "ml_Price_VSLM";
            this.ml_Price_VSLM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_VSLM.TabIndex = 10;
            this.ml_Price_VSLM.Text = "Price";
            this.ml_Price_VSLM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_VolumeLastMonth
            // 
            this.ml_VolumeLastMonth.AutoSize = true;
            this.ml_VolumeLastMonth.Location = new System.Drawing.Point(5, 116);
            this.ml_VolumeLastMonth.Name = "ml_VolumeLastMonth";
            this.ml_VolumeLastMonth.Size = new System.Drawing.Size(106, 19);
            this.ml_VolumeLastMonth.TabIndex = 5;
            this.ml_VolumeLastMonth.Text = "V of Sale Month:";
            // 
            // ml_Price_VSM
            // 
            this.ml_Price_VSM.AutoSize = true;
            this.ml_Price_VSM.Location = new System.Drawing.Point(118, 81);
            this.ml_Price_VSM.Name = "ml_Price_VSM";
            this.ml_Price_VSM.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_VSM.TabIndex = 9;
            this.ml_Price_VSM.Text = "Price";
            this.ml_Price_VSM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_VSY
            // 
            this.ml_Price_VSY.AutoSize = true;
            this.ml_Price_VSY.Location = new System.Drawing.Point(118, 46);
            this.ml_Price_VSY.Name = "ml_Price_VSY";
            this.ml_Price_VSY.Size = new System.Drawing.Size(38, 19);
            this.ml_Price_VSY.TabIndex = 8;
            this.ml_Price_VSY.Text = "Price";
            this.ml_Price_VSY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_VolumeYear
            // 
            this.ml_VolumeYear.AutoSize = true;
            this.ml_VolumeYear.Location = new System.Drawing.Point(5, 46);
            this.ml_VolumeYear.Name = "ml_VolumeYear";
            this.ml_VolumeYear.Size = new System.Drawing.Size(94, 19);
            this.ml_VolumeYear.TabIndex = 3;
            this.ml_VolumeYear.Text = "V of Sale Sum:";
            // 
            // ml_VolumeMonth
            // 
            this.ml_VolumeMonth.AutoSize = true;
            this.ml_VolumeMonth.Location = new System.Drawing.Point(5, 81);
            this.ml_VolumeMonth.Name = "ml_VolumeMonth";
            this.ml_VolumeMonth.Size = new System.Drawing.Size(111, 19);
            this.ml_VolumeMonth.TabIndex = 4;
            this.ml_VolumeMonth.Text = "V of Sales Month:";
            // 
            // ucOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mT_VolumeOfSale);
            this.Controls.Add(this.InfoChart);
            this.Controls.Add(this.mT_ExpensesDetails);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mT_IncomeDetails);
            this.Name = "ucOverview";
            this.Size = new System.Drawing.Size(836, 510);
            this.Load += new System.EventHandler(this.ucOverview_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.mT_IncomeDetails.ResumeLayout(false);
            this.mT_IncomeDetails.PerformLayout();
            this.mT_ExpensesDetails.ResumeLayout(false);
            this.mT_ExpensesDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoChart)).EndInit();
            this.mT_VolumeOfSale.ResumeLayout(false);
            this.mT_VolumeOfSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mL_CSA_Customer;
        private MetroFramework.Controls.MetroLabel mL_HorseBarn;
        private MetroFramework.Controls.MetroLabel mL_Nieghtbarhood;
        private System.Windows.Forms.Timer Timer_Overview;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mL_Customer;
        private MetroFramework.Controls.MetroTile mT_IncomeDetails;
        private MetroFramework.Controls.MetroTile mT_ExpensesDetails;
        private MetroFramework.Controls.MetroLabel mL_ExpensesLastYear;
        private MetroFramework.Controls.MetroLabel ml_ExpensesLastMonth;
        private MetroFramework.Controls.MetroLabel mL_ExpensesYear;
        private MetroFramework.Controls.MetroLabel mL_ExpensesMonth;
        private MetroFramework.Controls.MetroLabel mL_SumIncome;
        private MetroFramework.Controls.MetroLabel mL_IncomeLastYear;
        private MetroFramework.Controls.MetroLabel mL_IncomeLastMonth;
        private MetroFramework.Controls.MetroLabel mL_IncomeMonth;
        private MetroFramework.Controls.MetroLabel ml_Price_ILY;
        private MetroFramework.Controls.MetroLabel ml_Price_ILM;
        private MetroFramework.Controls.MetroLabel ml_Price_IM;
        private MetroFramework.Controls.MetroLabel ml_Price_IS;
        private MetroFramework.Controls.MetroLabel ml_Price_ELY;
        private MetroFramework.Controls.MetroLabel ml_Price_ELM;
        private MetroFramework.Controls.MetroLabel ml_Price_EM;
        private MetroFramework.Controls.MetroLabel ml_Price_ES;
        private System.Windows.Forms.DataVisualization.Charting.Chart InfoChart;
        private MetroFramework.Controls.MetroTile mT_VolumeOfSale;
        private MetroFramework.Controls.MetroLabel ml_Price_VSLY;
        private MetroFramework.Controls.MetroLabel ml_VolumeLastYear;
        private MetroFramework.Controls.MetroLabel ml_Price_VSLM;
        private MetroFramework.Controls.MetroLabel ml_VolumeLastMonth;
        private MetroFramework.Controls.MetroLabel ml_Price_VSM;
        private MetroFramework.Controls.MetroLabel ml_Price_VSY;
        private MetroFramework.Controls.MetroLabel ml_VolumeYear;
        private MetroFramework.Controls.MetroLabel ml_VolumeMonth;
    }
}
