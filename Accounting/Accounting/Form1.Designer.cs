namespace Accounting
{
    partial class Form1
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
            this.mTC_Accounting = new MetroFramework.Controls.MetroTabControl();
            this.mTP_Overview = new MetroFramework.Controls.MetroTabPage();
            this.mTC_Accounting.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTC_Accounting
            // 
            this.mTC_Accounting.Controls.Add(this.mTP_Overview);
            this.mTC_Accounting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTC_Accounting.Location = new System.Drawing.Point(20, 60);
            this.mTC_Accounting.Name = "mTC_Accounting";
            this.mTC_Accounting.SelectedIndex = 0;
            this.mTC_Accounting.Size = new System.Drawing.Size(768, 393);
            this.mTC_Accounting.TabIndex = 0;
            this.mTC_Accounting.UseSelectable = true;
            // 
            // mTP_Overview
            // 
            this.mTP_Overview.HorizontalScrollbarBarColor = true;
            this.mTP_Overview.HorizontalScrollbarHighlightOnWheel = false;
            this.mTP_Overview.HorizontalScrollbarSize = 10;
            this.mTP_Overview.Location = new System.Drawing.Point(4, 38);
            this.mTP_Overview.Name = "mTP_Overview";
            this.mTP_Overview.Size = new System.Drawing.Size(760, 351);
            this.mTP_Overview.TabIndex = 0;
            this.mTP_Overview.Text = "Overview";
            this.mTP_Overview.VerticalScrollbarBarColor = true;
            this.mTP_Overview.VerticalScrollbarHighlightOnWheel = false;
            this.mTP_Overview.VerticalScrollbarSize = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 473);
            this.Controls.Add(this.mTC_Accounting);
            this.Name = "Form1";
            this.Text = "Accounting";
            this.mTC_Accounting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTC_Accounting;
        private MetroFramework.Controls.MetroTabPage mTP_Overview;
    }
}

