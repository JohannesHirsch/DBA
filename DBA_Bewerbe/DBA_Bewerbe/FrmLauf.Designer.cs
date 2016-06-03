namespace DBA_Bewerbe
{
    partial class FrmLauf
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
            this.components = new System.ComponentModel.Container();
            this.dgvLauf = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nettozeitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strafsekundenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBahnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLaufBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLauf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLaufBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLauf
            // 
            this.dgvLauf.AutoGenerateColumns = false;
            this.dgvLauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLauf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nettozeitDataGridViewTextBoxColumn,
            this.strafsekundenDataGridViewTextBoxColumn,
            this.tBahnDataGridViewTextBoxColumn,
            this.tTypDataGridViewTextBoxColumn,
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn});
            this.dgvLauf.DataSource = this.tLaufBindingSource;
            this.dgvLauf.Location = new System.Drawing.Point(13, 13);
            this.dgvLauf.Name = "dgvLauf";
            this.dgvLauf.Size = new System.Drawing.Size(650, 150);
            this.dgvLauf.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nettozeitDataGridViewTextBoxColumn
            // 
            this.nettozeitDataGridViewTextBoxColumn.DataPropertyName = "Nettozeit";
            this.nettozeitDataGridViewTextBoxColumn.HeaderText = "Nettozeit";
            this.nettozeitDataGridViewTextBoxColumn.Name = "nettozeitDataGridViewTextBoxColumn";
            // 
            // strafsekundenDataGridViewTextBoxColumn
            // 
            this.strafsekundenDataGridViewTextBoxColumn.DataPropertyName = "Strafsekunden";
            this.strafsekundenDataGridViewTextBoxColumn.HeaderText = "Strafsekunden";
            this.strafsekundenDataGridViewTextBoxColumn.Name = "strafsekundenDataGridViewTextBoxColumn";
            // 
            // tBahnDataGridViewTextBoxColumn
            // 
            this.tBahnDataGridViewTextBoxColumn.DataPropertyName = "tBahn";
            this.tBahnDataGridViewTextBoxColumn.HeaderText = "tBahn";
            this.tBahnDataGridViewTextBoxColumn.Name = "tBahnDataGridViewTextBoxColumn";
            // 
            // tTypDataGridViewTextBoxColumn
            // 
            this.tTypDataGridViewTextBoxColumn.DataPropertyName = "tTyp";
            this.tTypDataGridViewTextBoxColumn.HeaderText = "tTyp";
            this.tTypDataGridViewTextBoxColumn.Name = "tTypDataGridViewTextBoxColumn";
            // 
            // zOTBewerbMannschaftDataGridViewTextBoxColumn
            // 
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.DataPropertyName = "ZOT_Bewerb_Mannschaft";
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.HeaderText = "ZOT_Bewerb_Mannschaft";
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.Name = "zOTBewerbMannschaftDataGridViewTextBoxColumn";
            // 
            // tLaufBindingSource
            // 
            this.tLaufBindingSource.DataSource = typeof(DBA_Bewerbe.tLauf);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(588, 227);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // FrmLauf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 262);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvLauf);
            this.Name = "FrmLauf";
            this.Text = "Läufe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLauf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tLaufBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLauf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nettozeitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strafsekundenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBahnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTypDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zOTBewerbMannschaftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tLaufBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
    }
}