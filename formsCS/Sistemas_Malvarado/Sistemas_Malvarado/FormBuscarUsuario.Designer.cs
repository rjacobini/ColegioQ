namespace Sistemas_Malvarado
{
    partial class FormBuscarUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.ckProfesor = new System.Windows.Forms.CheckBox();
            this.ckSecretaria = new System.Windows.Forms.CheckBox();
            this.ckAuxiliar = new System.Windows.Forms.CheckBox();
            this.ckPrincipal = new System.Windows.Forms.CheckBox();
            this.ckAlumno = new System.Windows.Forms.CheckBox();
            this.ckApoderado = new System.Windows.Forms.CheckBox();
            this.gdFiltros = new System.Windows.Forms.GroupBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbTipoUsuario.SuspendLayout();
            this.gdFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoUsuario,
            this.DNI,
            this.ApPat,
            this.ApMat,
            this.email,
            this.phone,
            this.Nombre});
            this.dgvUsuarios.Location = new System.Drawing.Point(28, 290);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(740, 216);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "Tipo";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // ApPat
            // 
            this.ApPat.HeaderText = "Ap. Paterno";
            this.ApPat.Name = "ApPat";
            this.ApPat.ReadOnly = true;
            // 
            // ApMat
            // 
            this.ApMat.HeaderText = "Ap. Materno";
            this.ApMat.Name = "ApMat";
            this.ApMat.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "e-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // gbTipoUsuario
            // 
            this.gbTipoUsuario.Controls.Add(this.ckProfesor);
            this.gbTipoUsuario.Controls.Add(this.ckSecretaria);
            this.gbTipoUsuario.Controls.Add(this.ckAuxiliar);
            this.gbTipoUsuario.Controls.Add(this.ckPrincipal);
            this.gbTipoUsuario.Controls.Add(this.ckAlumno);
            this.gbTipoUsuario.Controls.Add(this.ckApoderado);
            this.gbTipoUsuario.Location = new System.Drawing.Point(28, 22);
            this.gbTipoUsuario.Name = "gbTipoUsuario";
            this.gbTipoUsuario.Size = new System.Drawing.Size(727, 53);
            this.gbTipoUsuario.TabIndex = 28;
            this.gbTipoUsuario.TabStop = false;
            this.gbTipoUsuario.Text = "Tipo Usuario";
            this.gbTipoUsuario.Enter += new System.EventHandler(this.gbTipoUsuario_Enter);
            // 
            // ckProfesor
            // 
            this.ckProfesor.AutoSize = true;
            this.ckProfesor.Location = new System.Drawing.Point(597, 19);
            this.ckProfesor.Name = "ckProfesor";
            this.ckProfesor.Size = new System.Drawing.Size(65, 17);
            this.ckProfesor.TabIndex = 13;
            this.ckProfesor.Text = "Profesor";
            this.ckProfesor.UseVisualStyleBackColor = true;
            // 
            // ckSecretaria
            // 
            this.ckSecretaria.AutoSize = true;
            this.ckSecretaria.Location = new System.Drawing.Point(238, 19);
            this.ckSecretaria.Name = "ckSecretaria";
            this.ckSecretaria.Size = new System.Drawing.Size(74, 17);
            this.ckSecretaria.TabIndex = 12;
            this.ckSecretaria.Text = "Secretaria";
            this.ckSecretaria.UseVisualStyleBackColor = true;
            // 
            // ckAuxiliar
            // 
            this.ckAuxiliar.AutoSize = true;
            this.ckAuxiliar.Location = new System.Drawing.Point(469, 19);
            this.ckAuxiliar.Name = "ckAuxiliar";
            this.ckAuxiliar.Size = new System.Drawing.Size(59, 17);
            this.ckAuxiliar.TabIndex = 11;
            this.ckAuxiliar.Text = "Auxiliar";
            this.ckAuxiliar.UseVisualStyleBackColor = true;
            // 
            // ckPrincipal
            // 
            this.ckPrincipal.AutoSize = true;
            this.ckPrincipal.Location = new System.Drawing.Point(136, 19);
            this.ckPrincipal.Name = "ckPrincipal";
            this.ckPrincipal.Size = new System.Drawing.Size(66, 17);
            this.ckPrincipal.TabIndex = 10;
            this.ckPrincipal.Text = "Principal";
            this.ckPrincipal.UseVisualStyleBackColor = true;
            // 
            // ckAlumno
            // 
            this.ckAlumno.AutoSize = true;
            this.ckAlumno.Location = new System.Drawing.Point(353, 19);
            this.ckAlumno.Name = "ckAlumno";
            this.ckAlumno.Size = new System.Drawing.Size(61, 17);
            this.ckAlumno.TabIndex = 9;
            this.ckAlumno.Text = "Alumno";
            this.ckAlumno.UseVisualStyleBackColor = true;
            // 
            // ckApoderado
            // 
            this.ckApoderado.AutoSize = true;
            this.ckApoderado.Location = new System.Drawing.Point(18, 19);
            this.ckApoderado.Name = "ckApoderado";
            this.ckApoderado.Size = new System.Drawing.Size(78, 17);
            this.ckApoderado.TabIndex = 8;
            this.ckApoderado.Text = "Apoderado";
            this.ckApoderado.UseVisualStyleBackColor = true;
            // 
            // gdFiltros
            // 
            this.gdFiltros.Controls.Add(this.txtApMat);
            this.gdFiltros.Controls.Add(this.txtApPat);
            this.gdFiltros.Controls.Add(this.txtNombre);
            this.gdFiltros.Controls.Add(this.txtDNI);
            this.gdFiltros.Controls.Add(this.label5);
            this.gdFiltros.Controls.Add(this.label4);
            this.gdFiltros.Controls.Add(this.label3);
            this.gdFiltros.Controls.Add(this.label2);
            this.gdFiltros.Location = new System.Drawing.Point(28, 93);
            this.gdFiltros.Name = "gdFiltros";
            this.gdFiltros.Size = new System.Drawing.Size(495, 171);
            this.gdFiltros.TabIndex = 29;
            this.gdFiltros.TabStop = false;
            this.gdFiltros.Text = "Filtros";
            this.gdFiltros.Enter += new System.EventHandler(this.gdFiltros_Enter);
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(125, 127);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(337, 20);
            this.txtApMat.TabIndex = 9;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(125, 95);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(337, 20);
            this.txtApPat.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(337, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(125, 31);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(337, 20);
            this.txtDNI.TabIndex = 4;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(693, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FormBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gdFiltros);
            this.Controls.Add(this.gbTipoUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormBuscarUsuario";
            this.Text = "FormBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbTipoUsuario.ResumeLayout(false);
            this.gbTipoUsuario.PerformLayout();
            this.gdFiltros.ResumeLayout(false);
            this.gdFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbTipoUsuario;
        private System.Windows.Forms.CheckBox ckProfesor;
        private System.Windows.Forms.CheckBox ckSecretaria;
        private System.Windows.Forms.CheckBox ckAuxiliar;
        private System.Windows.Forms.CheckBox ckPrincipal;
        private System.Windows.Forms.CheckBox ckAlumno;
        private System.Windows.Forms.CheckBox ckApoderado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.GroupBox gdFiltros;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
    }
}