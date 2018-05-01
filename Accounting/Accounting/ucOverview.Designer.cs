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
            this.metroTile1.SuspendLayout();
            this.mT_IncomeDetails.SuspendLayout();
            this.mT_ExpensesDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mL_CSA_Customer
            // 
            this.mL_CSA_Customer.AutoSize = true;
            this.mL_CSA_Customer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_CSA_Customer.Location = new System.Drawing.Point(3, 46);
            this.mL_CSA_Customer.Name = "mL_CSA_Customer";
            this.mL_CSA_Customer.Size = new System.Drawing.Size(121, 25);
            this.mL_CSA_Customer.TabIndex = 3;
            this.mL_CSA_Customer.Text = "CSA Customer";
            // 
            // mL_Nieghtbarhood
            // 
            this.mL_Nieghtbarhood.AutoSize = true;
            this.mL_Nieghtbarhood.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_Nieghtbarhood.Location = new System.Drawing.Point(3, 81);
            this.mL_Nieghtbarhood.Name = "mL_Nieghtbarhood";
            this.mL_Nieghtbarhood.Size = new System.Drawing.Size(128, 25);
            this.mL_Nieghtbarhood.TabIndex = 4;
            this.mL_Nieghtbarhood.Text = "Nieghtbarhood";
            // 
            // mL_HorseBarn
            // 
            this.mL_HorseBarn.AutoSize = true;
            this.mL_HorseBarn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_HorseBarn.Location = new System.Drawing.Point(3, 116);
            this.mL_HorseBarn.Name = "mL_HorseBarn";
            this.mL_HorseBarn.Size = new System.Drawing.Size(96, 25);
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
            this.metroTile1.Size = new System.Drawing.Size(250, 250);
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
            this.mL_Customer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_Customer.Location = new System.Drawing.Point(3, 151);
            this.mL_Customer.Name = "mL_Customer";
            this.mL_Customer.Size = new System.Drawing.Size(85, 25);
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
            this.mT_IncomeDetails.Location = new System.Drawing.Point(259, 3);
            this.mT_IncomeDetails.Name = "mT_IncomeDetails";
            this.mT_IncomeDetails.Size = new System.Drawing.Size(250, 250);
            this.mT_IncomeDetails.TabIndex = 2;
            this.mT_IncomeDetails.Text = "Income Details";
            this.mT_IncomeDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mT_IncomeDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_IncomeDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mT_IncomeDetails.UseSelectable = true;
            // 
            // ml_Price_ILY
            // 
            this.ml_Price_ILY.AutoSize = true;
            this.ml_Price_ILY.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_ILY.Location = new System.Drawing.Point(147, 151);
            this.ml_Price_ILY.Name = "ml_Price_ILY";
            this.ml_Price_ILY.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_ILY.TabIndex = 7;
            this.ml_Price_ILY.Text = "Price";
            this.ml_Price_ILY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_ILM
            // 
            this.ml_Price_ILM.AutoSize = true;
            this.ml_Price_ILM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_ILM.Location = new System.Drawing.Point(147, 118);
            this.ml_Price_ILM.Name = "ml_Price_ILM";
            this.ml_Price_ILM.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_ILM.TabIndex = 6;
            this.ml_Price_ILM.Text = "Price";
            this.ml_Price_ILM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_IM
            // 
            this.ml_Price_IM.AutoSize = true;
            this.ml_Price_IM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_IM.Location = new System.Drawing.Point(147, 81);
            this.ml_Price_IM.Name = "ml_Price_IM";
            this.ml_Price_IM.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_IM.TabIndex = 5;
            this.ml_Price_IM.Text = "Price";
            this.ml_Price_IM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_IS
            // 
            this.ml_Price_IS.AutoSize = true;
            this.ml_Price_IS.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_IS.Location = new System.Drawing.Point(147, 46);
            this.ml_Price_IS.Name = "ml_Price_IS";
            this.ml_Price_IS.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_IS.TabIndex = 4;
            this.ml_Price_IS.Text = "Price";
            this.ml_Price_IS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_IncomeLastYear
            // 
            this.mL_IncomeLastYear.AutoSize = true;
            this.mL_IncomeLastYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_IncomeLastYear.Location = new System.Drawing.Point(14, 151);
            this.mL_IncomeLastYear.Name = "mL_IncomeLastYear";
            this.mL_IncomeLastYear.Size = new System.Drawing.Size(110, 25);
            this.mL_IncomeLastYear.TabIndex = 3;
            this.mL_IncomeLastYear.Text = "Income Year:";
            // 
            // mL_IncomeLastMonth
            // 
            this.mL_IncomeLastMonth.AutoSize = true;
            this.mL_IncomeLastMonth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_IncomeLastMonth.Location = new System.Drawing.Point(14, 118);
            this.mL_IncomeLastMonth.Name = "mL_IncomeLastMonth";
            this.mL_IncomeLastMonth.Size = new System.Drawing.Size(127, 25);
            this.mL_IncomeLastMonth.TabIndex = 2;
            this.mL_IncomeLastMonth.Text = "Income Month:";
            // 
            // mL_IncomeMonth
            // 
            this.mL_IncomeMonth.AutoSize = true;
            this.mL_IncomeMonth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_IncomeMonth.Location = new System.Drawing.Point(14, 81);
            this.mL_IncomeMonth.Name = "mL_IncomeMonth";
            this.mL_IncomeMonth.Size = new System.Drawing.Size(127, 25);
            this.mL_IncomeMonth.TabIndex = 1;
            this.mL_IncomeMonth.Text = "Income Month:";
            // 
            // mL_SumIncome
            // 
            this.mL_SumIncome.AutoSize = true;
            this.mL_SumIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_SumIncome.Location = new System.Drawing.Point(14, 46);
            this.mL_SumIncome.Name = "mL_SumIncome";
            this.mL_SumIncome.Size = new System.Drawing.Size(111, 25);
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
            this.mT_ExpensesDetails.Location = new System.Drawing.Point(515, 3);
            this.mT_ExpensesDetails.Name = "mT_ExpensesDetails";
            this.mT_ExpensesDetails.Size = new System.Drawing.Size(250, 250);
            this.mT_ExpensesDetails.TabIndex = 3;
            this.mT_ExpensesDetails.Text = "Expenses Details";
            this.mT_ExpensesDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.mT_ExpensesDetails.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_ExpensesDetails.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mT_ExpensesDetails.UseSelectable = true;
            // 
            // ml_Price_ELY
            // 
            this.ml_Price_ELY.AutoSize = true;
            this.ml_Price_ELY.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_ELY.Location = new System.Drawing.Point(138, 151);
            this.ml_Price_ELY.Name = "ml_Price_ELY";
            this.ml_Price_ELY.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_ELY.TabIndex = 11;
            this.ml_Price_ELY.Text = "Price";
            this.ml_Price_ELY.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_ExpensesLastYear
            // 
            this.mL_ExpensesLastYear.AutoSize = true;
            this.mL_ExpensesLastYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_ExpensesLastYear.Location = new System.Drawing.Point(3, 151);
            this.mL_ExpensesLastYear.Name = "mL_ExpensesLastYear";
            this.mL_ExpensesLastYear.Size = new System.Drawing.Size(118, 25);
            this.mL_ExpensesLastYear.TabIndex = 6;
            this.mL_ExpensesLastYear.Text = "Expenses Year";
            // 
            // ml_Price_ELM
            // 
            this.ml_Price_ELM.AutoSize = true;
            this.ml_Price_ELM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_ELM.Location = new System.Drawing.Point(138, 118);
            this.ml_Price_ELM.Name = "ml_Price_ELM";
            this.ml_Price_ELM.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_ELM.TabIndex = 10;
            this.ml_Price_ELM.Text = "Price";
            this.ml_Price_ELM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_ExpensesLastMonth
            // 
            this.ml_ExpensesLastMonth.AutoSize = true;
            this.ml_ExpensesLastMonth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_ExpensesLastMonth.Location = new System.Drawing.Point(3, 116);
            this.ml_ExpensesLastMonth.Name = "ml_ExpensesLastMonth";
            this.ml_ExpensesLastMonth.Size = new System.Drawing.Size(140, 25);
            this.ml_ExpensesLastMonth.TabIndex = 5;
            this.ml_ExpensesLastMonth.Text = "Expenses Month:";
            // 
            // ml_Price_EM
            // 
            this.ml_Price_EM.AutoSize = true;
            this.ml_Price_EM.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_EM.Location = new System.Drawing.Point(138, 81);
            this.ml_Price_EM.Name = "ml_Price_EM";
            this.ml_Price_EM.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_EM.TabIndex = 9;
            this.ml_Price_EM.Text = "Price";
            this.ml_Price_EM.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ml_Price_ES
            // 
            this.ml_Price_ES.AutoSize = true;
            this.ml_Price_ES.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ml_Price_ES.Location = new System.Drawing.Point(138, 46);
            this.ml_Price_ES.Name = "ml_Price_ES";
            this.ml_Price_ES.Size = new System.Drawing.Size(49, 25);
            this.ml_Price_ES.TabIndex = 8;
            this.ml_Price_ES.Text = "Price";
            this.ml_Price_ES.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mL_ExpensesYear
            // 
            this.mL_ExpensesYear.AutoSize = true;
            this.mL_ExpensesYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_ExpensesYear.Location = new System.Drawing.Point(3, 46);
            this.mL_ExpensesYear.Name = "mL_ExpensesYear";
            this.mL_ExpensesYear.Size = new System.Drawing.Size(124, 25);
            this.mL_ExpensesYear.TabIndex = 3;
            this.mL_ExpensesYear.Text = "Expenses Sum:";
            // 
            // mL_ExpensesMonth
            // 
            this.mL_ExpensesMonth.AutoSize = true;
            this.mL_ExpensesMonth.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_ExpensesMonth.Location = new System.Drawing.Point(3, 81);
            this.mL_ExpensesMonth.Name = "mL_ExpensesMonth";
            this.mL_ExpensesMonth.Size = new System.Drawing.Size(140, 25);
            this.mL_ExpensesMonth.TabIndex = 4;
            this.mL_ExpensesMonth.Text = "Expenses Month:";
            // 
            // ucOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mT_ExpensesDetails);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mT_IncomeDetails);
            this.Name = "ucOverview";
            this.Size = new System.Drawing.Size(790, 510);
            this.Load += new System.EventHandler(this.ucOverview_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.mT_IncomeDetails.ResumeLayout(false);
            this.mT_IncomeDetails.PerformLayout();
            this.mT_ExpensesDetails.ResumeLayout(false);
            this.mT_ExpensesDetails.PerformLayout();
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
    }
}
