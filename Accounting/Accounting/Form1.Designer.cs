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
            this.mP_Dashboard = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // mP_Dashboard
            // 
            this.mP_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mP_Dashboard.HorizontalScrollbarBarColor = true;
            this.mP_Dashboard.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Dashboard.HorizontalScrollbarSize = 10;
            this.mP_Dashboard.Location = new System.Drawing.Point(20, 60);
            this.mP_Dashboard.Name = "mP_Dashboard";
            this.mP_Dashboard.Size = new System.Drawing.Size(966, 543);
            this.mP_Dashboard.TabIndex = 0;
            this.mP_Dashboard.VerticalScrollbarBarColor = true;
            this.mP_Dashboard.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Dashboard.VerticalScrollbarSize = 10;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 623);
            this.Controls.Add(this.mP_Dashboard);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form_Main";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mP_Dashboard;
    }
}

