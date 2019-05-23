namespace Sistemas_Malvarado
{
    partial class FormGestionarCursoPorHorario
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
            this.labelGrado = new System.Windows.Forms.Label();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.comboBoxSeccion = new System.Windows.Forms.ComboBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGrado
            // 
            this.labelGrado.AutoSize = true;
            this.labelGrado.Location = new System.Drawing.Point(51, 25);
            this.labelGrado.Name = "labelGrado";
            this.labelGrado.Size = new System.Drawing.Size(36, 13);
            this.labelGrado.TabIndex = 0;
            this.labelGrado.Text = "Grado";
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Location = new System.Drawing.Point(50, 72);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(46, 13);
            this.labelSeccion.TabIndex = 1;
            this.labelSeccion.Text = "Seccion";
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(171, 25);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(385, 21);
            this.comboBoxGrado.TabIndex = 2;
            this.comboBoxGrado.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrado_SelectedIndexChanged);
            // 
            // comboBoxSeccion
            // 
            this.comboBoxSeccion.FormattingEnabled = true;
            this.comboBoxSeccion.Location = new System.Drawing.Point(171, 72);
            this.comboBoxSeccion.Name = "comboBoxSeccion";
            this.comboBoxSeccion.Size = new System.Drawing.Size(385, 21);
            this.comboBoxSeccion.TabIndex = 3;
            this.comboBoxSeccion.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeccion_SelectedIndexChanged);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Location = new System.Drawing.Point(12, 185);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(573, 253);
            this.dataGridViewCursos.TabIndex = 4;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(171, 135);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(355, 135);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FormGestionarCursoPorHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.comboBoxSeccion);
            this.Controls.Add(this.comboBoxGrado);
            this.Controls.Add(this.labelSeccion);
            this.Controls.Add(this.labelGrado);
            this.Name = "FormGestionarCursoPorHorario";
            this.Text = "FormGestionarCursoPorHorario";
            this.Load += new System.EventHandler(this.FormGestionarCursoPorHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGrado;
        private System.Windows.Forms.Label labelSeccion;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        private System.Windows.Forms.ComboBox comboBoxSeccion;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}