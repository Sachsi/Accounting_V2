namespace Accounting
{
    partial class ucDashboard
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
            this.mTile_Settings = new MetroFramework.Controls.MetroTile();
            this.mTile_Search = new MetroFramework.Controls.MetroTile();
            this.mTile_Database = new MetroFramework.Controls.MetroTile();
            this.mT_Overview = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mTile_Settings
            // 
            this.mTile_Settings.ActiveControl = null;
            this.mTile_Settings.Location = new System.Drawing.Point(319, 38);
            this.mTile_Settings.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.mTile_Settings.Name = "mTile_Settings";
            this.mTile_Settings.Size = new System.Drawing.Size(262, 128);
            this.mTile_Settings.TabIndex = 3;
            this.mTile_Settings.Text = "&Settings";
            this.mTile_Settings.TileImage = global::Accounting.Properties.Resources.settings128;
            this.mTile_Settings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTile_Settings.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTile_Settings.UseSelectable = true;
            this.mTile_Settings.UseTileImage = true;
            this.mTile_Settings.Click += new System.EventHandler(this.mTile_Settings_Click);
            // 
            // mTile_Search
            // 
            this.mTile_Search.ActiveControl = null;
            this.mTile_Search.Location = new System.Drawing.Point(171, 172);
            this.mTile_Search.Name = "mTile_Search";
            this.mTile_Search.Size = new System.Drawing.Size(128, 128);
            this.mTile_Search.TabIndex = 2;
            this.mTile_Search.Text = "&Search";
            this.mTile_Search.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTile_Search.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTile_Search.UseSelectable = true;
            this.mTile_Search.UseTileImage = true;
            this.mTile_Search.Click += new System.EventHandler(this.mTile_Search_Click);
            // 
            // mTile_Database
            // 
            this.mTile_Database.ActiveControl = null;
            this.mTile_Database.Location = new System.Drawing.Point(37, 172);
            this.mTile_Database.Name = "mTile_Database";
            this.mTile_Database.Size = new System.Drawing.Size(128, 128);
            this.mTile_Database.TabIndex = 1;
            this.mTile_Database.Text = "&Database";
            this.mTile_Database.TileImage = global::Accounting.Properties.Resources.database_icon64;
            this.mTile_Database.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTile_Database.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mTile_Database.UseSelectable = true;
            this.mTile_Database.UseTileImage = true;
            this.mTile_Database.Click += new System.EventHandler(this.mTile_Database_Click);
            // 
            // mT_Overview
            // 
            this.mT_Overview.ActiveControl = null;
            this.mT_Overview.Location = new System.Drawing.Point(37, 38);
            this.mT_Overview.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.mT_Overview.Name = "mT_Overview";
            this.mT_Overview.Size = new System.Drawing.Size(262, 128);
            this.mT_Overview.TabIndex = 0;
            this.mT_Overview.Text = "&Overview";
            this.mT_Overview.TileImage = global::Accounting.Properties.Resources.pulse_box128;
            this.mT_Overview.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mT_Overview.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mT_Overview.UseSelectable = true;
            this.mT_Overview.UseTileImage = true;
            this.mT_Overview.Click += new System.EventHandler(this.mT_Overview_Click);
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mTile_Settings);
            this.Controls.Add(this.mTile_Search);
            this.Controls.Add(this.mTile_Database);
            this.Controls.Add(this.mT_Overview);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(886, 591);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.UseStyleColors = true;
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mT_Overview;
        private MetroFramework.Controls.MetroTile mTile_Database;
        private MetroFramework.Controls.MetroTile mTile_Search;
        private MetroFramework.Controls.MetroTile mTile_Settings;
    }
}
