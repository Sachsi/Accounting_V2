namespace Accounting
{
    partial class Updater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mB_UpdateStart = new MetroFramework.Controls.MetroButton();
            this.mL_CurrentVersion = new MetroFramework.Controls.MetroLabel();
            this.ml_Version = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mB_UpdateStart
            // 
            this.mB_UpdateStart.Location = new System.Drawing.Point(129, 213);
            this.mB_UpdateStart.Name = "mB_UpdateStart";
            this.mB_UpdateStart.Size = new System.Drawing.Size(92, 34);
            this.mB_UpdateStart.TabIndex = 0;
            this.mB_UpdateStart.Text = "Update Start";
            this.mB_UpdateStart.UseSelectable = true;
            // 
            // mL_CurrentVersion
            // 
            this.mL_CurrentVersion.AutoSize = true;
            this.mL_CurrentVersion.Location = new System.Drawing.Point(23, 60);
            this.mL_CurrentVersion.Name = "mL_CurrentVersion";
            this.mL_CurrentVersion.Size = new System.Drawing.Size(102, 19);
            this.mL_CurrentVersion.TabIndex = 1;
            this.mL_CurrentVersion.Text = "Current Version:";
            // 
            // ml_Version
            // 
            this.ml_Version.AutoSize = true;
            this.ml_Version.Location = new System.Drawing.Point(131, 60);
            this.ml_Version.Name = "ml_Version";
            this.ml_Version.Size = new System.Drawing.Size(40, 19);
            this.ml_Version.TabIndex = 2;
            this.ml_Version.Text = "Label";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.ml_Version);
            this.Controls.Add(this.mL_CurrentVersion);
            this.Controls.Add(this.mB_UpdateStart);
            this.Name = "Updater";
            this.Text = "Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mB_UpdateStart;
        private MetroFramework.Controls.MetroLabel mL_CurrentVersion;
        private MetroFramework.Controls.MetroLabel ml_Version;
    }
}