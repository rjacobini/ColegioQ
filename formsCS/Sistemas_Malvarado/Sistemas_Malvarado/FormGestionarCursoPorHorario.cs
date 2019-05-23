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
    public partial class FormGestionarCursoPorHorario : Form
    {
        FormGestionarCursos refParent;

        public FormGestionarCursoPorHorario()
        {
            InitializeComponent();
        }

        public void SetParent(FormGestionarCursos form)
        {
            refParent = form;
        }



        public class tempGrado
        {
            private int id;
            private int grado;
            private int totalAlumn;
            private String seccion;

            public tempGrado(int grado, int totalAlumn, string seccion)
            {
                this.grado = grado;
                this.totalAlumn = totalAlumn;
                this.seccion = seccion;
            }

            public int ID
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public int Grado
            {
                get
                {
                    return grado;
                }
                set
                {
                    grado = value;
                }
            }

            public int TotalAlumn
            {
                get
                {
                    return totalAlumn;
                }
                set
                {
                    totalAlumn = value;
                }
            }

            public String Seccion
            {
                get
                {
                    return seccion;
                }
                set
                {
                    seccion = value;
                }
            }
        }

        public class tempCurso
        {
            private int id;
            private String nombre;
            private int grado;
            private DateTime horaInicio;
            private DateTime horaFin;

            public tempCurso(string nombre, int grado)
            {
                this.nombre = nombre;
                this.grado = grado;
            }

            public int ID
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }

            public String Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public int Grado
            {
                get
                {
                    return grado;
                }
                set
                {
                    grado = value;
                }
            }

            public DateTime HoraInicio
            {
                get
                {
                    return horaInicio;
                }
                set
                {
                    horaInicio = value;
                }
            }

            public DateTime HoraFin
            {
                get
                {
                    return horaFin;
                }
                set
                {
                    horaFin = value;
                }
            }
        }



        private void comboBoxGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxGrado.GetItemText(comboBoxGrado.SelectedItem);
            //MessageBox.Show(selected);

            if (selected == "1")
            {
                comboBoxSeccion.Items.Clear();
                comboBoxSeccion.ResetText();
                comboBoxSeccion.Items.Add("A");
                comboBoxSeccion.Items.Add("B");
            }
            if (selected == "2")
            {
                comboBoxSeccion.Items.Clear();
                comboBoxSeccion.ResetText();
                comboBoxSeccion.Items.Add("-"); //Indica solo hay una seccion.
            }
        }

        private void FormGestionarCursoPorHorario_Load(object sender, EventArgs e)
        {
            //Cargando datos prueba.
            tempGrado primerGradoA = new tempGrado(1, 27, "A");
            primerGradoA.ID = 1;
            tempGrado primerGradoB = new tempGrado(1, 24, "B");
            primerGradoB.ID = 2;
            tempGrado segundoGrado = new tempGrado(2, 20, "-1");
            segundoGrado.ID = 3;
            List<tempGrado> listaGrados = new List<tempGrado>();
            listaGrados.Add(primerGradoA);
            listaGrados.Add(primerGradoB);
            listaGrados.Add(segundoGrado);

            comboBoxGrado.Items.Add(primerGradoA.Grado);
            comboBoxGrado.Items.Add(segundoGrado.Grado);
        }

        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempCurso curso1 = new tempCurso("Historia", 1);
            curso1.ID = 1;
            curso1.HoraInicio = new DateTime(2019, 5, 3, 8, 0, 0);
            curso1.HoraFin = new DateTime(2019, 5, 3, 10, 0, 0);
            tempCurso curso2 = new tempCurso("Mate 1", 1);
            curso2.ID = 2;
            curso2.HoraInicio = new DateTime(2019, 5, 3, 10, 0, 0);
            curso2.HoraFin = new DateTime(2019, 5, 3, 12, 0, 0);
            tempCurso curso3 = new tempCurso("Geografia", 2);
            curso3.ID = 3;
            curso3.HoraInicio = new DateTime(2019, 5, 3, 1, 0, 0);
            curso3.HoraFin = new DateTime(2019, 5, 3, 3, 0, 0);
            List<tempCurso> listaCursos1 = new List<tempCurso>();
            listaCursos1.Add(curso1);
            listaCursos1.Add(curso2);
            List<tempCurso> listaCursos2 = new List<tempCurso>();
            listaCursos2.Add(curso3);

            string selected = comboBoxSeccion.GetItemText(comboBoxSeccion.SelectedItem);
            if (selected == "A")
            {
                dataGridViewCursos.DataSource = listaCursos1;
            }
            else if (selected == "B")
            {
                dataGridViewCursos.DataSource = listaCursos1;
            }
            else if (selected == "-")
            {
                dataGridViewCursos.DataSource = listaCursos2;
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por implementar debido a estructura no compatible con ejemplo.");
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por implementar debido a estructura no compatible con ejemplo.");
        }
    }
}
