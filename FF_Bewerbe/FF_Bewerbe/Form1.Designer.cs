namespace FF_Bewerbe
{
    partial class Form1
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
            this.bewerbDBDataSet = new FF_Bewerbe.BewerbDBDataSet();
            this.bewerbDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_BewerbDataSet = new FF_Bewerbe.DB_BewerbDataSet();
            this.tBewerbSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBewerbSetTableAdapter = new FF_Bewerbe.DB_BewerbDataSetTableAdapters.tBewerbSetTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BewerbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBewerbe
            // 
            this.dgvBewerbe.AutoGenerateColumns = false;
            this.dgvBewerbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBewerbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dgvBewerbe.DataSource = this.tBewerbSetBindingSource;
            this.dgvBewerbe.Location = new System.Drawing.Point(12, 12);
            this.dgvBewerbe.Name = "dgvBewerbe";
            this.dgvBewerbe.Size = new System.Drawing.Size(488, 231);
            this.dgvBewerbe.TabIndex = 0;
            // 
            // bewerbDBDataSet
            // 
            this.bewerbDBDataSet.DataSetName = "BewerbDBDataSet";
            this.bewerbDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bewerbDBDataSetBindingSource
            // 
            this.bewerbDBDataSetBindingSource.DataSource = this.bewerbDBDataSet;
            this.bewerbDBDataSetBindingSource.Position = 0;
            // 
            // dB_BewerbDataSet
            // 
            this.dB_BewerbDataSet.DataSetName = "DB_BewerbDataSet";
            this.dB_BewerbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBewerbSetBindingSource
            // 
            this.tBewerbSetBindingSource.DataMember = "tBewerbSet";
            this.tBewerbSetBindingSource.DataSource = this.dB_BewerbDataSet;
            // 
            // tBewerbSetTableAdapter
            // 
            this.tBewerbSetTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 429);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvBewerbe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bewerbDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BewerbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBewerbe;
        private System.Windows.Forms.BindingSource bewerbDBDataSetBindingSource;
        private BewerbDBDataSet bewerbDBDataSet;
        private DB_BewerbDataSet dB_BewerbDataSet;
        private System.Windows.Forms.BindingSource tBewerbSetBindingSource;
        private DB_BewerbDataSetTableAdapters.tBewerbSetTableAdapter tBewerbSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSpeichern;
    }
}

