namespace FF_Bewerbe
{
    partial class Frm_Mannschaften
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
            this.dgvMannschaften = new System.Windows.Forms.DataGridView();
            this.tMannschaftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMannschaften)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMannschaftSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMannschaften
            // 
            this.dgvMannschaften.AutoGenerateColumns = false;
            this.dgvMannschaften.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMannschaften.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvMannschaften.DataSource = this.tMannschaftSetBindingSource;
            this.dgvMannschaften.Location = new System.Drawing.Point(12, 12);
            this.dgvMannschaften.Name = "dgvMannschaften";
            this.dgvMannschaften.Size = new System.Drawing.Size(453, 245);
            this.dgvMannschaften.TabIndex = 0;
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
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(544, 327);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // Frm_Mannschaften
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 362);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvMannschaften);
            this.Name = "Frm_Mannschaften";
            this.Text = "Frm_Mannschaften";
            this.Load += new System.EventHandler(this.Frm_Mannschaften_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMannschaften)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMannschaftSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMannschaften;
        private System.Windows.Forms.BindingSource tMannschaftSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSpeichern;
    }
}