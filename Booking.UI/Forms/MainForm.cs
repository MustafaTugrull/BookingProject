using Booking.UI.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void oTELToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Otel fOtel = new Frm_Otel();
            FormControl(fOtel);
        }

        private void FormControl(Form fOtel)
        {
            fOtel.MdiParent = this;

            if (FormUtils.IsFormOpen(fOtel))
            {
                MessageBox.Show("Form zaten açık.");
            }
            else
            {
                fOtel.Show();
            }
        }

        private void mISAFIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Misafir fMis = new Frm_Misafir();
            FormControl(fMis);
        }

        private void rEZERVASYONtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Rezervasyon fRez = new Frm_Rezervasyon();
            FormControl(fRez);
        }

        private void oDAKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Oda fOda = new Frm_Oda();
            FormControl(fOda);
        }

        private void oDATİPKAYITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_OdaTip fOdaTip = new Frm_OdaTip();
            FormControl(fOdaTip);
        }
    }
}
