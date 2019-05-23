using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Malvarado
{
    public partial class frmTalleresxAlumno : Form
    {
        public frmTalleresxAlumno()
        {
            InitializeComponent();
        }

   
    

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmTalleresxAlumno_Load(object sender, EventArgs e)
        {

        }




        private void InscribirEnUnTallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionTalleres frmInscripcionTalleres = new frmInscripcionTalleres();
            if (frmInscripcionTalleres.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
