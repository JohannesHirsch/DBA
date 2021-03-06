﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DBA_Bewerbe
{    
    public partial class FrmBewerb : Form
    {

        #region Membervariablen

        Model_FeuerwehrbewerbContainer context;

        #endregion

        #region Konstruktor

        public FrmBewerb()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.context = new Model_FeuerwehrbewerbContainer();
            
            this.context.tBewerbSet.Load();

            this.tBewerbBindingSource.DataSource = context.tBewerbSet.Local.ToBindingList();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.context.SaveChanges();

            this.dgvBewerbe.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.context.Dispose();
        }

        private void btnTeilnehmer_Click(object sender, EventArgs e)
        {
            FrmTeilnehmendeMannschaft frmTeilnehmendeMannschaften = new FrmTeilnehmendeMannschaft();

            frmTeilnehmendeMannschaften.ShowDialog();

            if (frmTeilnehmendeMannschaften.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("done");
            }
        }
        
        #endregion
    }
}
