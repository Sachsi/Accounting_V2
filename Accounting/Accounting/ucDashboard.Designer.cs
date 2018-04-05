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
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.mTile_Database = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(319, 38);
            this.metroTile4.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(262, 128);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "&Settings";
            this.metroTile4.TileImage = global::Accounting.Properties.Resources.settings128;
            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.UseTileImage = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(171, 172);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(128, 128);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "&Search";
            this.metroTile3.TileImage = global::Accounting.Properties.Resources.AppListIcon_targetsize_64;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(37, 38);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(262, 128);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "&Overview";
            this.metroTile1.TileImage = global::Accounting.Properties.Resources.pulse_box128;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            // 
            // ucDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.mTile_Database);
            this.Controls.Add(this.metroTile1);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(886, 591);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.UseStyleColors = true;
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mTile_Database;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile4;
    }
}
