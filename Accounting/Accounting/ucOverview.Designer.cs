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
            this.mT_ExpensesDetails = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.mL_SumIncome = new MetroFramework.Controls.MetroLabel();
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
            this.mL_Nieghtbarhood.Location = new System.Drawing.Point(3, 71);
            this.mL_Nieghtbarhood.Name = "mL_Nieghtbarhood";
            this.mL_Nieghtbarhood.Size = new System.Drawing.Size(128, 25);
            this.mL_Nieghtbarhood.TabIndex = 4;
            this.mL_Nieghtbarhood.Text = "Nieghtbarhood";
            // 
            // mL_HorseBarn
            // 
            this.mL_HorseBarn.AutoSize = true;
            this.mL_HorseBarn.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_HorseBarn.Location = new System.Drawing.Point(3, 96);
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
            this.mL_Customer.Location = new System.Drawing.Point(3, 142);
            this.mL_Customer.Name = "mL_Customer";
            this.mL_Customer.Size = new System.Drawing.Size(85, 25);
            this.mL_Customer.TabIndex = 6;
            this.mL_Customer.Text = "Customer";
            // 
            // mT_IncomeDetails
            // 
            this.mT_IncomeDetails.ActiveControl = null;
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
            // mT_ExpensesDetails
            // 
            this.mT_ExpensesDetails.ActiveControl = null;
            this.mT_ExpensesDetails.Controls.Add(this.metroLabel5);
            this.mT_ExpensesDetails.Controls.Add(this.metroLabel6);
            this.mT_ExpensesDetails.Controls.Add(this.metroLabel7);
            this.mT_ExpensesDetails.Controls.Add(this.metroLabel8);
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(3, 142);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(85, 25);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Customer";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(3, 96);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(96, 25);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Horse Barn";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(3, 46);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(121, 25);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "CSA Customer";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(3, 71);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(128, 25);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Nieghtbarhood";
            // 
            // mL_SumIncome
            // 
            this.mL_SumIncome.AutoSize = true;
            this.mL_SumIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mL_SumIncome.Location = new System.Drawing.Point(15, 46);
            this.mL_SumIncome.Name = "mL_SumIncome";
            this.mL_SumIncome.Size = new System.Drawing.Size(111, 25);
            this.mL_SumIncome.TabIndex = 0;
            this.mL_SumIncome.Text = "Income Sum:";
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
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel mL_SumIncome;
    }
}
