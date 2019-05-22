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
            this.tabApoderado.Parent = null;
            this.tabAlumno.Parent = null;
            this.tabProfesor.Parent = null;
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
            //Instancia del usuario
            //User u = new User();
            //if (u is Profesor)
            //u.Department = (Department)cboEspecialidades.SelectedItem;
            //u.student.Dni = txtDNI.Text;
            MessageBox.Show("Se ha realizado con exito el registro", "Mensaje de Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            FormBuscarUsuario fbuscar = new FormBuscarUsuario();
            if(fbuscar.ShowDialog() == DialogResult.OK)
            {
                //Editar los parametros de los textBox según el usuario elegido
                
            }
        }

        private void ckApoderado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckApoderado.Checked == true)
            {
                this.tabApoderado.Parent = this.tabUsers;
            }
        }

        private void ckAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if(ckAlumno.Checked == true)
            {
                this.tabAlumno.Parent = this.tabUsers;
            }
        }

        private void ckProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if(ckProfesor.Checked == true)
            {
                this.tabProfesor.Parent = this.tabUsers;
            }
        }

        private void BuscarAlumno_Click(object sender, EventArgs e)
        {
            FormBuscarAlumno fbuscarA = new FormBuscarAlumno();
            if (fbuscarA.ShowDialog() == DialogResult.OK)
            {
                //Editar los parametros de los textBox según el alumno elegido

            }
        }

        private void buscarApoderado_Click(object sender, EventArgs e)
        {
            
        }
    }
}
