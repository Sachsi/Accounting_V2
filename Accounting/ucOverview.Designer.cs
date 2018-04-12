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
            this.metroTile1.SuspendLayout();
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
            // ucOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile1);
            this.Name = "ucOverview";
            this.Size = new System.Drawing.Size(790, 510);
            this.Load += new System.EventHandler(this.ucOverview_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel mL_CSA_Customer;
        private MetroFramework.Controls.MetroLabel mL_HorseBarn;
        private MetroFramework.Controls.MetroLabel mL_Nieghtbarhood;
        private System.Windows.Forms.Timer Timer_Overview;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel mL_Customer;
    }
}
