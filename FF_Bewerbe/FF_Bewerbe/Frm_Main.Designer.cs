namespace FF_Bewerbe
{
    partial class Frm_Main
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
            this.dgvBewerbe = new System.Windows.Forms.DataGridView();
            this.tBewerbSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bewerbDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tBewerbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBewerbe
            // 
            this.dgvBewerbe.AutoGenerateColumns = false;
            this.dgvBewerbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBewerbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn});
            this.dgvBewerbe.DataSource = this.tBewerbBindingSource;
            this.dgvBewerbe.Location = new System.Drawing.Point(12, 12);
            this.dgvBewerbe.Name = "dgvBewerbe";
            this.dgvBewerbe.Size = new System.Drawing.Size(488, 231);
            this.dgvBewerbe.TabIndex = 0;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(622, 394);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tBewerbBindingSource
            // 
            this.tBewerbBindingSource.DataSource = typeof(FF_Bewerbe.tBewerb);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn3.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // zOTBewerbMannschaftDataGridViewTextBoxColumn
            // 
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.DataPropertyName = "ZOT_Bewerb_Mannschaft";
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.HeaderText = "ZOT_Bewerb_Mannschaft";
            this.zOTBewerbMannschaftDataGridViewTextBoxColumn.Name = "zOTBewerbMannschaftDataGridViewTextBoxColumn";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvBewerbe);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBewerbe;
        private System.Windows.Forms.BindingSource bewerbDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource tBewerbSetBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn zOTBewerbMannschaftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBewerbBindingSource;
    }
}

