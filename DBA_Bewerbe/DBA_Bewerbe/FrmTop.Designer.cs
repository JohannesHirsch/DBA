namespace DBA_Bewerbe
{
    partial class FrmTop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTabellen = new System.Windows.Forms.ComboBox();
            this.btnTabAnzeigen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTabAnzeigen);
            this.groupBox1.Controls.Add(this.cbTabellen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabellen anzeigen";
            // 
            // cbTabellen
            // 
            this.cbTabellen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabellen.FormattingEnabled = true;
            this.cbTabellen.Items.AddRange(new object[] {
            "Bewerbe",
            "Teilnehmende Mannschaften",
            "Mannschaften",
            "Läufe",
            "Teilnehmer",
            "Bahnen",
            "Typen"});
            this.cbTabellen.Location = new System.Drawing.Point(6, 30);
            this.cbTabellen.Name = "cbTabellen";
            this.cbTabellen.Size = new System.Drawing.Size(246, 24);
            this.cbTabellen.TabIndex = 0;
            //this.cbTabellen.SelectedIndexChanged += new System.EventHandler(this.cbTabellen_SelectedIndexChanged);
            // 
            // btnTabAnzeigen
            // 
            this.btnTabAnzeigen.Location = new System.Drawing.Point(273, 26);
            this.btnTabAnzeigen.Name = "btnTabAnzeigen";
            this.btnTabAnzeigen.Size = new System.Drawing.Size(101, 31);
            this.btnTabAnzeigen.TabIndex = 1;
            this.btnTabAnzeigen.Text = "anzeigen";
            this.btnTabAnzeigen.UseVisualStyleBackColor = true;
            this.btnTabAnzeigen.Click += new System.EventHandler(this.btnTabAnzeigen_Click);
            // 
            // FrmTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTop";
            this.Text = "FrmTop";
            this.Load += new System.EventHandler(this.FrmTop_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTabellen;
        private System.Windows.Forms.Button btnTabAnzeigen;
    }
}