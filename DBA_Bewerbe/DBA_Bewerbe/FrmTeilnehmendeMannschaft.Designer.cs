namespace DBA_Bewerbe
{
    partial class FrmTeilnehmendeMannschaft
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
            this.dgvTeilnehmendeMannschaft = new System.Windows.Forms.DataGridView();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platzierungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBewerbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tMannschaftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTeilnehmendeMannschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmendeMannschaft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmendeMannschaftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeilnehmendeMannschaft
            // 
            this.dgvTeilnehmendeMannschaft.AutoGenerateColumns = false;
            this.dgvTeilnehmendeMannschaft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeilnehmendeMannschaft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.startnummerDataGridViewTextBoxColumn,
            this.platzierungDataGridViewTextBoxColumn,
            this.tBewerbDataGridViewTextBoxColumn,
            this.tMannschaftDataGridViewTextBoxColumn});
            this.dgvTeilnehmendeMannschaft.DataSource = this.tTeilnehmendeMannschaftBindingSource;
            this.dgvTeilnehmendeMannschaft.Location = new System.Drawing.Point(13, 13);
            this.dgvTeilnehmendeMannschaft.Name = "dgvTeilnehmendeMannschaft";
            this.dgvTeilnehmendeMannschaft.Size = new System.Drawing.Size(571, 150);
            this.dgvTeilnehmendeMannschaft.TabIndex = 0;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSpeichern.Location = new System.Drawing.Point(641, 227);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(75, 23);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // startnummerDataGridViewTextBoxColumn
            // 
            this.startnummerDataGridViewTextBoxColumn.DataPropertyName = "Startnummer";
            this.startnummerDataGridViewTextBoxColumn.HeaderText = "Startnummer";
            this.startnummerDataGridViewTextBoxColumn.Name = "startnummerDataGridViewTextBoxColumn";
            // 
            // platzierungDataGridViewTextBoxColumn
            // 
            this.platzierungDataGridViewTextBoxColumn.DataPropertyName = "Platzierung";
            this.platzierungDataGridViewTextBoxColumn.HeaderText = "Platzierung";
            this.platzierungDataGridViewTextBoxColumn.Name = "platzierungDataGridViewTextBoxColumn";
            // 
            // tBewerbDataGridViewTextBoxColumn
            // 
            this.tBewerbDataGridViewTextBoxColumn.DataPropertyName = "tBewerb";
            this.tBewerbDataGridViewTextBoxColumn.HeaderText = "tBewerb";
            this.tBewerbDataGridViewTextBoxColumn.Name = "tBewerbDataGridViewTextBoxColumn";
            // 
            // tMannschaftDataGridViewTextBoxColumn
            // 
            this.tMannschaftDataGridViewTextBoxColumn.DataPropertyName = "tMannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.HeaderText = "tMannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.Name = "tMannschaftDataGridViewTextBoxColumn";
            // 
            // tTeilnehmendeMannschaftBindingSource
            // 
            this.tTeilnehmendeMannschaftBindingSource.DataSource = typeof(DBA_Bewerbe.tTeilnehmendeMannschaft);
            // 
            // FrmTeilnehmendeMannschaft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 262);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.dgvTeilnehmendeMannschaft);
            this.Name = "FrmTeilnehmendeMannschaft";
            this.Text = "Teilnehmende Mannschaften";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmendeMannschaft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmendeMannschaftBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeilnehmendeMannschaft;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platzierungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBewerbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tMannschaftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tTeilnehmendeMannschaftBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
    }
}