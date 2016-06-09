namespace DBA_Bewerbe
{
    partial class FrmBewerb
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
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUbernehmen = new System.Windows.Forms.Button();
            this.btnAbbrechen = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBewerbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).BeginInit();
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
            this.dgvBewerbe.DataSource = this.tBewerbBindingSource;
            this.dgvBewerbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBewerbe.Location = new System.Drawing.Point(4, 4);
            this.dgvBewerbe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBewerbe.Name = "dgvBewerbe";
            this.dgvBewerbe.Size = new System.Drawing.Size(851, 404);
            this.dgvBewerbe.TabIndex = 0;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpeichern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSpeichern.Location = new System.Drawing.Point(60, 10);
            this.btnSpeichern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(150, 35);
            this.btnSpeichern.TabIndex = 1;
            this.btnSpeichern.Text = "OK";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBewerbe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(859, 473);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.60784F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.39216F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel2.Controls.Add(this.btnSpeichern, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUbernehmen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAbbrechen, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(853, 55);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnUbernehmen
            // 
            this.btnUbernehmen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUbernehmen.Location = new System.Drawing.Point(364, 10);
            this.btnUbernehmen.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbernehmen.Name = "btnUbernehmen";
            this.btnUbernehmen.Size = new System.Drawing.Size(150, 35);
            this.btnUbernehmen.TabIndex = 1;
            this.btnUbernehmen.Text = "Übernehmen";
            this.btnUbernehmen.UseVisualStyleBackColor = true;
            this.btnUbernehmen.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // btnAbbrechen
            // 
            this.btnAbbrechen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAbbrechen.Location = new System.Drawing.Point(655, 10);
            this.btnAbbrechen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbbrechen.Name = "btnAbbrechen";
            this.btnAbbrechen.Size = new System.Drawing.Size(150, 35);
            this.btnAbbrechen.TabIndex = 1;
            this.btnAbbrechen.Text = "Abbrechen";
            this.btnAbbrechen.UseVisualStyleBackColor = true;
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
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // tBewerbBindingSource
            // 
            this.tBewerbBindingSource.DataSource = typeof(DBA_Bewerbe.tBewerb);
            // 
            // FrmBewerb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBewerb";
            this.Text = "Bewerbe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBewerbe)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tBewerbBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBewerbe;
        private System.Windows.Forms.BindingSource tBewerbBindingSource;
        private System.Windows.Forms.Button btnSpeichern;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnUbernehmen;
        private System.Windows.Forms.Button btnAbbrechen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
    }
}

