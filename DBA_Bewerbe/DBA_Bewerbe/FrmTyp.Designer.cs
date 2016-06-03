namespace DBA_Bewerbe
{
    partial class FrmTyp
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
            this.dgvTyp = new System.Windows.Forms.DataGridView();
            this.kuerzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezeichnungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTypBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTyp
            // 
            this.dgvTyp.AutoGenerateColumns = false;
            this.dgvTyp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTyp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kuerzelDataGridViewTextBoxColumn,
            this.bezeichnungDataGridViewTextBoxColumn});
            this.dgvTyp.DataSource = this.tTypBindingSource;
            this.dgvTyp.Location = new System.Drawing.Point(13, 13);
            this.dgvTyp.Name = "dgvTyp";
            this.dgvTyp.Size = new System.Drawing.Size(259, 150);
            this.dgvTyp.TabIndex = 0;
            // 
            // kuerzelDataGridViewTextBoxColumn
            // 
            this.kuerzelDataGridViewTextBoxColumn.DataPropertyName = "Kuerzel";
            this.kuerzelDataGridViewTextBoxColumn.HeaderText = "Kuerzel";
            this.kuerzelDataGridViewTextBoxColumn.Name = "kuerzelDataGridViewTextBoxColumn";
            // 
            // bezeichnungDataGridViewTextBoxColumn
            // 
            this.bezeichnungDataGridViewTextBoxColumn.DataPropertyName = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.HeaderText = "Bezeichnung";
            this.bezeichnungDataGridViewTextBoxColumn.Name = "bezeichnungDataGridViewTextBoxColumn";
            // 
            // tTypBindingSource
            // 
            this.tTypBindingSource.DataSource = typeof(DBA_Bewerbe.tTyp);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(197, 227);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // FrmTyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvTyp);
            this.Name = "FrmTyp";
            this.Text = "Typen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTyp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTypBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuerzelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezeichnungDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTypBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
    }
}