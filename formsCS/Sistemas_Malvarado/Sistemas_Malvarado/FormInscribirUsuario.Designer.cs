namespace Sistemas_Malvarado
{
    partial class FormInscribirUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscribirUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.ckApoderado = new System.Windows.Forms.CheckBox();
            this.ckAlumno = new System.Windows.Forms.CheckBox();
            this.ckPrincipal = new System.Windows.Forms.CheckBox();
            this.ckAuxiliar = new System.Windows.Forms.CheckBox();
            this.ckSecretaria = new System.Windows.Forms.CheckBox();
            this.ckProfesor = new System.Windows.Forms.CheckBox();
            this.gbDatosGenerales = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabApoderado = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuscarAlumno = new System.Windows.Forms.Button();
            this.tabAlumno = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buscarApoderado = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProfesor = new System.Windows.Forms.TabPage();
            this.AñadirCurso = new System.Windows.Forms.PictureBox();
            this.flpCursos = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbDatosGenerales.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabApoderado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabProfesor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AñadirCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Usuario:";
            // 
            // ckApoderado
            // 
            this.ckApoderado.AutoSize = true;
            this.ckApoderado.Location = new System.Drawing.Point(30, 48);
            this.ckApoderado.Name = "ckApoderado";
            this.ckApoderado.Size = new System.Drawing.Size(78, 17);
            this.ckApoderado.TabIndex = 1;
            this.ckApoderado.Text = "Apoderado";
            this.ckApoderado.UseVisualStyleBackColor = true;
            // 
            // ckAlumno
            // 
            this.ckAlumno.AutoSize = true;
            this.ckAlumno.Location = new System.Drawing.Point(30, 71);
            this.ckAlumno.Name = "ckAlumno";
            this.ckAlumno.Size = new System.Drawing.Size(61, 17);
            this.ckAlumno.TabIndex = 2;
            this.ckAlumno.Text = "Alumno";
            this.ckAlumno.UseVisualStyleBackColor = true;
            // 
            // ckPrincipal
            // 
            this.ckPrincipal.AutoSize = true;
            this.ckPrincipal.Location = new System.Drawing.Point(139, 48);
            this.ckPrincipal.Name = "ckPrincipal";
            this.ckPrincipal.Size = new System.Drawing.Size(66, 17);
            this.ckPrincipal.TabIndex = 3;
            this.ckPrincipal.Text = "Principal";
            this.ckPrincipal.UseVisualStyleBackColor = true;
            // 
            // ckAuxiliar
            // 
            this.ckAuxiliar.AutoSize = true;
            this.ckAuxiliar.Location = new System.Drawing.Point(139, 71);
            this.ckAuxiliar.Name = "ckAuxiliar";
            this.ckAuxiliar.Size = new System.Drawing.Size(59, 17);
            this.ckAuxiliar.TabIndex = 4;
            this.ckAuxiliar.Text = "Auxiliar";
            this.ckAuxiliar.UseVisualStyleBackColor = true;
            // 
            // ckSecretaria
            // 
            this.ckSecretaria.AutoSize = true;
            this.ckSecretaria.Location = new System.Drawing.Point(253, 48);
            this.ckSecretaria.Name = "ckSecretaria";
            this.ckSecretaria.Size = new System.Drawing.Size(74, 17);
            this.ckSecretaria.TabIndex = 5;
            this.ckSecretaria.Text = "Secretaria";
            this.ckSecretaria.UseVisualStyleBackColor = true;
            // 
            // ckProfesor
            // 
            this.ckProfesor.AutoSize = true;
            this.ckProfesor.Location = new System.Drawing.Point(253, 71);
            this.ckProfesor.Name = "ckProfesor";
            this.ckProfesor.Size = new System.Drawing.Size(65, 17);
            this.ckProfesor.TabIndex = 6;
            this.ckProfesor.Text = "Profesor";
            this.ckProfesor.UseVisualStyleBackColor = true;
            // 
            // gbDatosGenerales
            // 
            this.gbDatosGenerales.Controls.Add(this.textBox4);
            this.gbDatosGenerales.Controls.Add(this.btnBuscarUsuario);
            this.gbDatosGenerales.Controls.Add(this.textBox6);
            this.gbDatosGenerales.Controls.Add(this.textBox3);
            this.gbDatosGenerales.Controls.Add(this.label8);
            this.gbDatosGenerales.Controls.Add(this.label7);
            this.gbDatosGenerales.Controls.Add(this.textBox5);
            this.gbDatosGenerales.Controls.Add(this.label6);
            this.gbDatosGenerales.Controls.Add(this.textBox2);
            this.gbDatosGenerales.Controls.Add(this.textBox7);
            this.gbDatosGenerales.Controls.Add(this.textBox1);
            this.gbDatosGenerales.Controls.Add(this.label5);
            this.gbDatosGenerales.Controls.Add(this.label4);
            this.gbDatosGenerales.Controls.Add(this.label3);
            this.gbDatosGenerales.Controls.Add(this.label2);
            this.gbDatosGenerales.Location = new System.Drawing.Point(30, 104);
            this.gbDatosGenerales.Name = "gbDatosGenerales";
            this.gbDatosGenerales.Size = new System.Drawing.Size(496, 298);
            this.gbDatosGenerales.TabIndex = 7;
            this.gbDatosGenerales.TabStop = false;
            this.gbDatosGenerales.Text = "Datos Generales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dirección";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 223);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(337, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(125, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(337, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 191);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(337, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(125, 63);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(337, 20);
            this.textBox7.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabApoderado);
            this.tabControl.Controls.Add(this.tabAlumno);
            this.tabControl.Controls.Add(this.tabProfesor);
            this.tabControl.Location = new System.Drawing.Point(22, 424);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(504, 301);
            this.tabControl.TabIndex = 23;
            // 
            // tabApoderado
            // 
            this.tabApoderado.Controls.Add(this.label11);
            this.tabApoderado.Controls.Add(this.dataGridView1);
            this.tabApoderado.Controls.Add(this.BuscarAlumno);
            this.tabApoderado.Location = new System.Drawing.Point(4, 22);
            this.tabApoderado.Name = "tabApoderado";
            this.tabApoderado.Padding = new System.Windows.Forms.Padding(3);
            this.tabApoderado.Size = new System.Drawing.Size(506, 275);
            this.tabApoderado.TabIndex = 0;
            this.tabApoderado.Text = "Apoderado";
            this.tabApoderado.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Alumnos a cargo :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(25, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 101);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cod";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn6.HeaderText = "ApPat";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn7.HeaderText = "ApMat";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // BuscarAlumno
            // 
            this.BuscarAlumno.Location = new System.Drawing.Point(25, 201);
            this.BuscarAlumno.Name = "BuscarAlumno";
            this.BuscarAlumno.Size = new System.Drawing.Size(75, 23);
            this.BuscarAlumno.TabIndex = 22;
            this.BuscarAlumno.Text = "Buscar";
            this.BuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // tabAlumno
            // 
            this.tabAlumno.Controls.Add(this.label12);
            this.tabAlumno.Controls.Add(this.comboBox3);
            this.tabAlumno.Controls.Add(this.comboBox2);
            this.tabAlumno.Controls.Add(this.label10);
            this.tabAlumno.Controls.Add(this.label9);
            this.tabAlumno.Controls.Add(this.buscarApoderado);
            this.tabAlumno.Controls.Add(this.dataGridView2);
            this.tabAlumno.Location = new System.Drawing.Point(4, 22);
            this.tabAlumno.Name = "tabAlumno";
            this.tabAlumno.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumno.Size = new System.Drawing.Size(496, 275);
            this.tabAlumno.TabIndex = 1;
            this.tabAlumno.Text = "Alumno";
            this.tabAlumno.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Apoderado/a(s):";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 53);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 47;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Condición";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Grado";
            // 
            // buscarApoderado
            // 
            this.buscarApoderado.Location = new System.Drawing.Point(27, 232);
            this.buscarApoderado.Name = "buscarApoderado";
            this.buscarApoderado.Size = new System.Drawing.Size(75, 23);
            this.buscarApoderado.TabIndex = 21;
            this.buscarApoderado.Text = "Buscar";
            this.buscarApoderado.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.Location = new System.Drawing.Point(27, 115);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(454, 101);
            this.dataGridView2.TabIndex = 20;
            // 
            // Cod
            // 
            this.Cod.FillWeight = 60.9137F;
            this.Cod.HeaderText = "Cod";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn3.HeaderText = "ApPat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 113.0288F;
            this.dataGridViewTextBoxColumn4.HeaderText = "ApMat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabProfesor
            // 
            this.tabProfesor.Controls.Add(this.AñadirCurso);
            this.tabProfesor.Controls.Add(this.flpCursos);
            this.tabProfesor.Controls.Add(this.label13);
            this.tabProfesor.Location = new System.Drawing.Point(4, 22);
            this.tabProfesor.Name = "tabProfesor";
            this.tabProfesor.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesor.Size = new System.Drawing.Size(506, 275);
            this.tabProfesor.TabIndex = 2;
            this.tabProfesor.Text = "Profesor";
            this.tabProfesor.UseVisualStyleBackColor = true;
            // 
            // AñadirCurso
            // 
            this.AñadirCurso.Image = ((System.Drawing.Image)(resources.GetObject("AñadirCurso.Image")));
            this.AñadirCurso.Location = new System.Drawing.Point(105, 18);
            this.AñadirCurso.Name = "AñadirCurso";
            this.AñadirCurso.Size = new System.Drawing.Size(32, 32);
            this.AñadirCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AñadirCurso.TabIndex = 3;
            this.AñadirCurso.TabStop = false;
            this.AñadirCurso.Click += new System.EventHandler(this.AñadirCurso_Click);
            // 
            // flpCursos
            // 
            this.flpCursos.Location = new System.Drawing.Point(22, 56);
            this.flpCursos.Name = "flpCursos";
            this.flpCursos.Size = new System.Drawing.Size(150, 195);
            this.flpCursos.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Cursos a dictar:";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarUsuario.Image")));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(431, 268);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(65, 30);
            this.btnBuscarUsuario.TabIndex = 24;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 759);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(155, 759);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormInscribirUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 808);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.gbDatosGenerales);
            this.Controls.Add(this.ckProfesor);
            this.Controls.Add(this.ckSecretaria);
            this.Controls.Add(this.ckAuxiliar);
            this.Controls.Add(this.ckPrincipal);
            this.Controls.Add(this.ckAlumno);
            this.Controls.Add(this.ckApoderado);
            this.Controls.Add(this.label1);
            this.Name = "FormInscribirUsuario";
            this.Text = "Inscribir Usuario";
            this.gbDatosGenerales.ResumeLayout(false);
            this.gbDatosGenerales.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabApoderado.ResumeLayout(false);
            this.tabApoderado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAlumno.ResumeLayout(false);
            this.tabAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabProfesor.ResumeLayout(false);
            this.tabProfesor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AñadirCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckApoderado;
        private System.Windows.Forms.CheckBox ckAlumno;
        private System.Windows.Forms.CheckBox ckPrincipal;
        private System.Windows.Forms.CheckBox ckAuxiliar;
        private System.Windows.Forms.CheckBox ckSecretaria;
        private System.Windows.Forms.CheckBox ckProfesor;
        private System.Windows.Forms.GroupBox gbDatosGenerales;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabApoderado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button BuscarAlumno;
        private System.Windows.Forms.TabPage tabAlumno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buscarApoderado;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabPage tabProfesor;
        private System.Windows.Forms.PictureBox AñadirCurso;
        private System.Windows.Forms.FlowLayoutPanel flpCursos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}