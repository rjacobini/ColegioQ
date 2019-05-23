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
    public partial class FormSeccionesACargo : Form
    {
        FormGestionarCursos refParent;

        public FormSeccionesACargo()
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

        }

        public class tempAlumn
        {
            private int id;
            private String nombre;
            private int claseSeccionID;
            private float nota1;
            private float nota2;

            public tempAlumn(int id, string nombre, int claseSeccionID)
            {
                this.id = id;
                this.nombre = nombre;
                this.claseSeccionID = claseSeccionID;
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

            public int ClaseSeccionID
            {
                get
                {
                    return claseSeccionID;
                }
                set
                {
                    claseSeccionID = value;
                }
            }

            public float Nota1
            {
                get
                {
                    return nota1;
                }
                set
                {
                    nota1 = value;
                }
            }

            public float Nota2
            {
                get
                {
                    return nota2;
                }
                set
                {
                    nota2 = value;
                }
            }
        }

        private void FormSeccionesACargo_Load(object sender, EventArgs e)
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

        private void comboBoxGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBoxGrado.GetItemText(comboBoxGrado.SelectedItem);
            //MessageBox.Show(selected);
            
            if(selected == "1")
            {
                comboBoxSeccion.Items.Clear();
                comboBoxSeccion.ResetText();
                comboBoxSeccion.Items.Add("A");
                comboBoxSeccion.Items.Add("B");
            }
            if(selected == "2")
            {
                comboBoxSeccion.Items.Clear();
                comboBoxSeccion.ResetText();
                comboBoxSeccion.Items.Add("-"); //Indica solo hay una seccion.
            }
        }

        private void comboBoxSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempCurso curso1 = new tempCurso("Historia", 1);
            curso1.ID = 1;
            tempCurso curso2 = new tempCurso("Mate 1", 1);
            curso2.ID = 2;
            tempCurso curso3 = new tempCurso("Geografia", 2);
            curso3.ID = 3;
            List<tempCurso> listaCursos1 = new List<tempCurso>();
            listaCursos1.Add(curso1);
            listaCursos1.Add(curso2);
            List<tempCurso> listaCursos2 = new List<tempCurso>();
            listaCursos2.Add(curso3);

            string selected = comboBoxSeccion.GetItemText(comboBoxSeccion.SelectedItem);
            if(selected == "A")
            {
                dataGridViewCursos.DataSource = listaCursos1;
            }
            else if(selected == "B")
            {
                dataGridViewCursos.DataSource = listaCursos1;
            }
            else if(selected == "-")
            {
                dataGridViewCursos.DataSource = listaCursos2;
            }
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempAlumn alumno1 = new tempAlumn(1, "Renato", 1);
            tempAlumn alumno2 = new tempAlumn(2, "Johanna", 1);
            tempAlumn alumno3 = new tempAlumn(3, "Joel", 2);
            tempAlumn alumno4 = new tempAlumn(4, "Sebastian", 3);
            tempAlumn alumno5 = new tempAlumn(5, "Jaco", 3);
            List<tempAlumn> listaPrimeroA = new List<tempAlumn>();
            listaPrimeroA.Add(alumno1);
            listaPrimeroA.Add(alumno2);
            List<tempAlumn> listaPrimeroB = new List<tempAlumn>();
            listaPrimeroB.Add(alumno3);
            List<tempAlumn> listaSegundo = new List<tempAlumn>();
            listaSegundo.Add(alumno4);
            listaSegundo.Add(alumno5);

            //Aqui se verificaria la lista de alumnos del curso
            string selected = comboBoxSeccion.GetItemText(comboBoxSeccion.SelectedItem);
            if (selected == "A")
            {
                dataGridViewAlumnos.DataSource = listaPrimeroA;
            }
            else if (selected == "B")
            {
                dataGridViewAlumnos.DataSource = listaPrimeroB;
            }
            else if (selected == "-")
            {
                dataGridViewAlumnos.DataSource = listaSegundo;
            }
        }
    }
}
