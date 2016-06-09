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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUebernehmen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.tBewerbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTeilnehmendeMannschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMannschaftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platzierungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBewerbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tMannschaftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmendeMannschaft)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmendeMannschaftBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMannschaftBindingSource)).BeginInit();
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
            this.dgvTeilnehmendeMannschaft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeilnehmendeMannschaft.Location = new System.Drawing.Point(4, 4);
            this.dgvTeilnehmendeMannschaft.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTeilnehmendeMannschaft.Name = "dgvTeilnehmendeMannschaft";
            this.dgvTeilnehmendeMannschaft.Size = new System.Drawing.Size(851, 388);
            this.dgvTeilnehmendeMannschaft.TabIndex = 0;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSpeichern.Location = new System.Drawing.Point(59, 18);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(150, 35);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTeilnehmendeMannschaft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.72093F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27907F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 473);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.4716F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5284F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel2.Controls.Add(this.btnSpeichern, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUebernehmen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAbbrechen, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 399);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(853, 71);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnUebernehmen
            // 
            this.btnUebernehmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUebernehmen.Location = new System.Drawing.Point(349, 18);
            this.btnUebernehmen.Margin = new System.Windows.Forms.Padding(4);
            this.btnUebernehmen.Name = "btnUebernehmen";
            this.btnUebernehmen.Size = new System.Drawing.Size(150, 35);
            this.btnUebernehmen.TabIndex = 1;
            this.btnUebernehmen.Text = "Übernehmen";
            this.btnUebernehmen.UseVisualStyleBackColor = true;
            this.btnUebernehmen.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(641, 18);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(150, 35);
            this.btnAbbrechen.TabIndex = 1;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
            // 
            // tBewerbBindingSource
            // 
            this.tBewerbBindingSource.DataSource = typeof(DBA_Bewerbe.tBewerb);
            // 
            // tTeilnehmendeMannschaftBindingSource
            // 
            this.tTeilnehmendeMannschaftBindingSource.DataSource = typeof(DBA_Bewerbe.tTeilnehmendeMannschaft);
            // 
            // tMannschaftBindingSource
            // 
            this.tMannschaftBindingSource.DataSource = typeof(DBA_Bewerbe.tMannschaft);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
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
            this.tBewerbDataGridViewTextBoxColumn.DataSource = this.tBewerbBindingSource;
            this.tBewerbDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.tBewerbDataGridViewTextBoxColumn.HeaderText = "Bewerb";
            this.tBewerbDataGridViewTextBoxColumn.Name = "tBewerbDataGridViewTextBoxColumn";
            this.tBewerbDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tBewerbDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tBewerbDataGridViewTextBoxColumn.ValueMember = "Id";
            this.tBewerbDataGridViewTextBoxColumn.Width = 250;
            // 
            // tMannschaftDataGridViewTextBoxColumn
            // 
            this.tMannschaftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tMannschaftDataGridViewTextBoxColumn.DataPropertyName = "tMannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.DataSource = this.tMannschaftBindingSource;
            this.tMannschaftDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.tMannschaftDataGridViewTextBoxColumn.HeaderText = "Mannschaft";
            this.tMannschaftDataGridViewTextBoxColumn.Name = "tMannschaftDataGridViewTextBoxColumn";
            this.tMannschaftDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tMannschaftDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tMannschaftDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // FrmTeilnehmendeMannschaft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTeilnehmendeMannschaft";
            this.Text = "Teilnehmende Mannschaften";
            this.Load += new System.EventHandler(this.FrmTeilnehmendeMannschaft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeilnehmendeMannschaft)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTeilnehmendeMannschaftBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMannschaftBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeilnehmendeMannschaft;
        private System.Windows.Forms.BindingSource tTeilnehmendeMannschaftBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnUebernehmen;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.BindingSource tBewerbBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platzierungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tBewerbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tMannschaftDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tMannschaftBindingSource;
    }
}