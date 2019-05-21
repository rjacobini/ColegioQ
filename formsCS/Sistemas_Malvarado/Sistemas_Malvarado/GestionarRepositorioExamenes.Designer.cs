namespace Sistemas_Malvarado
{
    partial class frmGestionarRepositorioExamenes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvExamenes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.cboSeccion = new System.Windows.Forms.ComboBox();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargaArchivo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProfesores = new System.Windows.Forms.ComboBox();
            this.colCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProfesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profesor:";
            // 
            // dgvExamenes
            // 
            this.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCurso,
            this.colSeccion,
            this.colNombreProfesor,
            this.colExamen,
            this.colEstado});
            this.dgvExamenes.Location = new System.Drawing.Point(12, 276);
            this.dgvExamenes.Name = "dgvExamenes";
            this.dgvExamenes.Size = new System.Drawing.Size(618, 193);
            this.dgvExamenes.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(54, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(203, 228);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(478, 228);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(75, 23);
            this.btnFeedback.TabIndex = 6;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // cboSeccion
            // 
            this.cboSeccion.FormattingEnabled = true;
            this.cboSeccion.Location = new System.Drawing.Point(169, 73);
            this.cboSeccion.Name = "cboSeccion";
            this.cboSeccion.Size = new System.Drawing.Size(384, 21);
            this.cboSeccion.TabIndex = 10;
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(169, 106);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(384, 21);
            this.cboCurso.TabIndex = 11;
            // 
            // txtExamen
            // 
            this.txtExamen.Location = new System.Drawing.Point(169, 182);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(337, 20);
            this.txtExamen.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Examen:";
            // 
            // btnCargaArchivo
            // 
            this.btnCargaArchivo.Location = new System.Drawing.Point(512, 180);
            this.btnCargaArchivo.Name = "btnCargaArchivo";
            this.btnCargaArchivo.Size = new System.Drawing.Size(41, 23);
            this.btnCargaArchivo.TabIndex = 14;
            this.btnCargaArchivo.Text = "...";
            this.btnCargaArchivo.UseVisualStyleBackColor = true;
            this.btnCargaArchivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gestionar repositorio de examenes";
            // 
            // cboProfesores
            // 
            this.cboProfesores.FormattingEnabled = true;
            this.cboProfesores.Location = new System.Drawing.Point(169, 142);
            this.cboProfesores.Name = "cboProfesores";
            this.cboProfesores.Size = new System.Drawing.Size(384, 21);
            this.cboProfesores.TabIndex = 16;
            // 
            // colCurso
            // 
            this.colCurso.HeaderText = "Curso";
            this.colCurso.Name = "colCurso";
            // 
            // colSeccion
            // 
            this.colSeccion.HeaderText = "Grado y Seccion";
            this.colSeccion.Name = "colSeccion";
            this.colSeccion.Width = 60;
            // 
            // colNombreProfesor
            // 
            this.colNombreProfesor.HeaderText = "Nombre Profesor";
            this.colNombreProfesor.Name = "colNombreProfesor";
            this.colNombreProfesor.Width = 200;
            // 
            // colExamen
            // 
            this.colExamen.HeaderText = "Examen";
            this.colExamen.Name = "colExamen";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(343, 228);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmGestionarRepositorioExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 481);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboProfesores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCargaArchivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExamen);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.cboSeccion);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvExamenes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionarRepositorioExamenes";
            this.Text = "Repositorio de examenes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvExamenes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.ComboBox cboSeccion;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargaArchivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ComboBox cboProfesores;
        private System.Windows.Forms.Button btnBuscar;
    }
}