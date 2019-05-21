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
    public partial class FormInscribirUsuario : Form
    {
        int nCb = 0;
        public FormInscribirUsuario()
        {
            InitializeComponent();
            nCb = 0;
        }

        private void createComboBox()
        {
            if (nCb < 6)
            {
                nCb++;
                ComboBox cb = new ComboBox();
                //cb.DataSource = controller.queryALL();
                cb.Items.Add("Matemáticas");
                //cb.autos
                //cb.DisplayMember = "Name";
                //cb.ValueMember = "IdCourse";
                flpCursos.Controls.Add(cb);
            }
            else
            {
                MessageBox.Show("Excedió el limite de cursos aceptado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AñadirCurso_Click(object sender, EventArgs e)
        {
            createComboBox();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
