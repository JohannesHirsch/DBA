using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBA_Bewerbe
{
    public partial class FrmTop : Form
    {
        public FrmTop()
        {
            InitializeComponent();
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {

        }


        private void btnTabAnzeigen_Click(object sender, EventArgs e)
        {

            /*Bewerbe
            Teilnehmende Mannschaften
            Mannschaften
            Läufe
            Teilnehmer
            Bahnen
            Typen*/
            //cbTabellen.SelectedIndex = 0;
            switch (cbTabellen.SelectedIndex)
            {
                case 0:
                    FrmBewerb frmBewerb = new FrmBewerb();
                    frmBewerb.ShowDialog();
                    break;
                case 1:
                    FrmTeilnehmendeMannschaft frmMannschaften = new FrmTeilnehmendeMannschaft();
                    frmMannschaften.ShowDialog(); break;
                case 2:
                    FrmMannschaften frm = new FrmMannschaften();
                    frm.ShowDialog(); break;
                case 3:
                    FrmLauf frmLauf = new FrmLauf();
                    frmLauf.ShowDialog();
                        break;
                case 4:
                    FrmTeilnehmer frmTeilnehmer = new FrmTeilnehmer();
                    frmTeilnehmer.ShowDialog();
                        break;
                case 5:
                    FrmBahn frmBahn = new FrmBahn();
                    frmBahn.ShowDialog();
                        break;
                case 6:
                    FrmTyp frmTyp = new FrmTyp();
                    frmTyp.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
