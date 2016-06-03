namespace DBA_Bewerbe
{
    partial class FrmTeilnehmer
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
            this.dgvTeilnehmer = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMannschaftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTeilnehmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSpeichern = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeilnehmer
            // 
            this.dgvTeilnehmer.AutoGenerateColumns = false;
            this.dgvTeilnehmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeilnehmer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.tMannschaftDataGridViewTextBoxColumn});
            this.dgvTeilnehmer.DataSource = this.tTeilnehmerBindingSource;
            this.dgvTeilnehmer.Location = new System.Drawing.Point(13, 13);
            this.dgvTeilnehmer.Name = "dgvTeilnehmer";
            this.dgvTeilnehmer.Size = new System.Drawing.Size(449, 150);
            this.dgvTeilnehmer.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // vornameDataGridViewTextBoxColumn
            // 
            this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
            this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
            this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
            // 
            // nachnameDataGridViewTextBoxColumn
            // 
            this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
            this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
            // 
            // tMannschaftDataGridViewTextBoxColumn
            // 
            this.tMannschaftDataGridViewTextBoxColumn.DataPropertyName = "tMannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.HeaderText = "tMannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.Name = "tMannschaftDataGridViewTextBoxColumn";
            // 
            // tTeilnehmerBindingSource
            // 
            this.tTeilnehmerBindingSource.DataSource = typeof(DBA_Bewerbe.tTeilnehmer);
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(405, 227);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // FrmTeilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 262);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvTeilnehmer);
            this.Name = "FrmTeilnehmer";
            this.Text = "Teilnehmer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeilnehmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMannschaftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTeilnehmerBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
    }
}