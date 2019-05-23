namespace Sistemas_Malvarado
{
    partial class FormSeccionesACargo
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
            this.labelSeccion = new System.Windows.Forms.Label();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.labelAlumno = new System.Windows.Forms.Label();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.labelGrade = new System.Windows.Forms.Label();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Location = new System.Drawing.Point(36, 75);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(46, 13);
            this.labelSeccion.TabIndex = 0;
            this.labelSeccion.Text = "Sección";
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(140, 72);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeccion.TabIndex = 1;
            this.comboBoxSeccion.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeccion_SelectedIndexChanged);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(21, 109);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(310, 313);
            this.dataGridViewCursos.TabIndex = 2;
            this.dataGridViewCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCursos_CellContentClick);
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(473, 52);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(42, 13);
            this.labelAlumno.TabIndex = 3;
            this.labelAlumno.Text = "Alumno";
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(597, 49);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlumno.TabIndex = 4;
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(455, 109);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(320, 313);
            this.dataGridViewAlumnos.TabIndex = 5;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(39, 37);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "Grado";
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(140, 34);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrado.TabIndex = 7;
            this.comboBoxGrado.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrado_SelectedIndexChanged);
            // 
            // FormSeccionesACargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxGrado);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.labelAlumno);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.labelSeccion);
            this.Name = "FormSeccionesACargo";
            this.Text = "Secciones a Cargo";
            this.Load += new System.EventHandler(this.FormSeccionesACargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ComboBox comboBoxGrado;
    }
}