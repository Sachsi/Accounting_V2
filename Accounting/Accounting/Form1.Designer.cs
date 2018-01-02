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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Overview = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.mG_Customer = new MetroFramework.Controls.MetroGrid();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.neighbarhoodDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.horsBarnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mB_Save = new MetroFramework.Controls.MetroButton();
            this.mP_Customer = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1.SuspendLayout();
            this.tabPage_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mG_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage_Overview);
            this.metroTabControl1.Controls.Add(this.tabPage_Customer);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(80, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(764, 373);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage_Overview
            // 
            this.tabPage_Overview.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Overview.Name = "tabPage_Overview";
            this.tabPage_Overview.Size = new System.Drawing.Size(756, 331);
            this.tabPage_Overview.TabIndex = 0;
            this.tabPage_Overview.Text = "Overview";
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.mP_Customer);
            this.tabPage_Customer.Controls.Add(this.mG_Customer);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Size = new System.Drawing.Size(756, 331);
            this.tabPage_Customer.TabIndex = 1;
            this.tabPage_Customer.Text = "Customer";
            // 
            // mG_Customer
            // 
            this.mG_Customer.AllowUserToResizeRows = false;
            this.mG_Customer.AutoGenerateColumns = false;
            this.mG_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mG_Customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mG_Customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mG_Customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mG_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mG_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mG_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.eMailDataGridViewTextBoxColumn,
            this.phoneNrDataGridViewTextBoxColumn,
            this.cSADataGridViewCheckBoxColumn,
            this.neighbarhoodDataGridViewCheckBoxColumn,
            this.horsBarnDataGridViewCheckBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.mG_Customer.DataSource = this.customerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mG_Customer.DefaultCellStyle = dataGridViewCellStyle2;
            this.mG_Customer.EnableHeadersVisualStyles = false;
            this.mG_Customer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mG_Customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mG_Customer.Location = new System.Drawing.Point(3, 3);
            this.mG_Customer.Name = "mG_Customer";
            this.mG_Customer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mG_Customer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mG_Customer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mG_Customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mG_Customer.Size = new System.Drawing.Size(750, 201);
            this.mG_Customer.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // eMailDataGridViewTextBoxColumn
            // 
            this.eMailDataGridViewTextBoxColumn.DataPropertyName = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.HeaderText = "E_Mail";
            this.eMailDataGridViewTextBoxColumn.Name = "eMailDataGridViewTextBoxColumn";
            // 
            // phoneNrDataGridViewTextBoxColumn
            // 
            this.phoneNrDataGridViewTextBoxColumn.DataPropertyName = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.HeaderText = "PhoneNr";
            this.phoneNrDataGridViewTextBoxColumn.Name = "phoneNrDataGridViewTextBoxColumn";
            // 
            // cSADataGridViewCheckBoxColumn
            // 
            this.cSADataGridViewCheckBoxColumn.DataPropertyName = "CSA";
            this.cSADataGridViewCheckBoxColumn.HeaderText = "CSA";
            this.cSADataGridViewCheckBoxColumn.Name = "cSADataGridViewCheckBoxColumn";
            // 
            // neighbarhoodDataGridViewCheckBoxColumn
            // 
            this.neighbarhoodDataGridViewCheckBoxColumn.DataPropertyName = "Neighbarhood";
            this.neighbarhoodDataGridViewCheckBoxColumn.HeaderText = "Neighbarhood";
            this.neighbarhoodDataGridViewCheckBoxColumn.Name = "neighbarhoodDataGridViewCheckBoxColumn";
            // 
            // horsBarnDataGridViewCheckBoxColumn
            // 
            this.horsBarnDataGridViewCheckBoxColumn.DataPropertyName = "Hors_Barn";
            this.horsBarnDataGridViewCheckBoxColumn.HeaderText = "Hors_Barn";
            this.horsBarnDataGridViewCheckBoxColumn.Name = "horsBarnDataGridViewCheckBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Accounting.Customer);
            // 
            // mB_Save
            // 
            this.mB_Save.Location = new System.Drawing.Point(683, 451);
            this.mB_Save.Name = "mB_Save";
            this.mB_Save.Size = new System.Drawing.Size(100, 25);
            this.mB_Save.TabIndex = 1;
            this.mB_Save.Text = "&Save";
            this.mB_Save.UseSelectable = true;
            this.mB_Save.Click += new System.EventHandler(this.mB_Save_Tables_Click);
            // 
            // mP_Customer
            // 
            this.mP_Customer.HorizontalScrollbarBarColor = true;
            this.mP_Customer.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Customer.HorizontalScrollbarSize = 10;
            this.mP_Customer.Location = new System.Drawing.Point(3, 210);
            this.mP_Customer.Name = "mP_Customer";
            this.mP_Customer.Size = new System.Drawing.Size(750, 118);
            this.mP_Customer.TabIndex = 1;
            this.mP_Customer.VerticalScrollbarBarColor = true;
            this.mP_Customer.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Customer.VerticalScrollbarSize = 10;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 499);
            this.Controls.Add(this.mB_Save);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form_Main";
            this.Text = "Accounting";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mG_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage_Overview;
        private System.Windows.Forms.TabPage tabPage_Customer;
        private MetroFramework.Controls.MetroGrid mG_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cSADataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn neighbarhoodDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn horsBarnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MetroFramework.Controls.MetroButton mB_Save;
        private MetroFramework.Controls.MetroPanel mP_Customer;
    }
}

