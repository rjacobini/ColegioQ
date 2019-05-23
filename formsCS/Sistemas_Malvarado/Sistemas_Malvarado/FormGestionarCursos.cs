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
    public partial class FormGestionarCursos : Form
    {
        public FormGestionarCursos()
        {
            InitializeComponent();
        }

        private void FormGestionarCursos_Load(object sender, EventArgs e)
        {
            tempCurso curso = new tempCurso("Historia", 4);
            BindingList<tempCurso> listaCursos = new BindingList<tempCurso>();
            listaCursos.Add(curso);
            dataGridViewGestionarCursos.DataSource = listaCursos;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seccionesACargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSeccionesACargo seccionesACargo = new FormSeccionesACargo();
            seccionesACargo.Show();
        }

        private void btnAgregarGestionarCurso_Click(object sender, EventArgs e)
        {
            BindingList<tempCurso> listaCursos = new BindingList<tempCurso>();
            listaCursos = (BindingList<tempCurso>)dataGridViewGestionarCursos.DataSource;
            tempCurso curso = new tempCurso(textBoxCursoNombre.Text, Int32.Parse(comboBoxGrado.Text));
            listaCursos.Add(curso);
            dataGridViewGestionarCursos.DataSource = listaCursos;
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            int count;
            count = dataGridViewGestionarCursos.CurrentCell.RowIndex;
            BindingList<tempCurso> listaCursos = new BindingList<tempCurso>();
            listaCursos = (BindingList<tempCurso>)dataGridViewGestionarCursos.DataSource;
            listaCursos.RemoveAt(count);
            dataGridViewGestionarCursos.DataSource = listaCursos;
        }

        private void gestionarCursoPorHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionarCursoPorHorario ventanaCursosXHorario = new FormGestionarCursoPorHorario();
            ventanaCursosXHorario.Show();
        }
    }

    public class tempCurso
    {
        private String course;
        private int grade;

        public tempCurso(string course, int grade)
        {
            this.course = course;
            this.grade = grade;
        }

        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        public String Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
    }

}
