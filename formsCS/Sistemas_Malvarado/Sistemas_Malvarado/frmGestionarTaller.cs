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
    public partial class frmGestionarTaller : Form
    {
        public frmGestionarTaller()
        {
            InitializeComponent();
        }



        public void estadoComponentes(EstadosR estado)
        {
            switch (estado)
            {
                case EstadosR.Nuevo:
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    textBox2.Enabled = true;
                    break;
                case EstadosR.Guardar:
                    comboBox1.Enabled = true;
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = true;
                    textBox2.Enabled = true;
                    break;
            }
        }

   

        private void FrmGestionarTaller_Load(object sender, EventArgs e)
        {

        }



        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            frmBuscarTaller frmBuscarTaller = new frmBuscarTaller();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            estadoComponentes(EstadosR.Nuevo);
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            estadoComponentes(EstadosR.Guardar);
        }
    }
}
