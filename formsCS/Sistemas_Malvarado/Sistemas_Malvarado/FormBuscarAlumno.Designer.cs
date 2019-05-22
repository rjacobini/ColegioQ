namespace Sistemas_Malvarado
{
    partial class FormBuscarAlumno
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gdFiltros = new System.Windows.Forms.GroupBox();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGrado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(654, 486);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 23);
            this.btnAceptar.TabIndex = 34;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gdFiltros
            // 
            this.gdFiltros.Controls.Add(this.cbCondicion);
            this.gdFiltros.Controls.Add(this.label6);
            this.gdFiltros.Controls.Add(this.cbGrado);
            this.gdFiltros.Controls.Add(this.label1);
            this.gdFiltros.Controls.Add(this.txtApMat);
            this.gdFiltros.Controls.Add(this.txtApPat);
            this.gdFiltros.Controls.Add(this.txtNombre);
            this.gdFiltros.Controls.Add(this.txtDNI);
            this.gdFiltros.Controls.Add(this.label5);
            this.gdFiltros.Controls.Add(this.label4);
            this.gdFiltros.Controls.Add(this.label3);
            this.gdFiltros.Controls.Add(this.label2);
            this.gdFiltros.Location = new System.Drawing.Point(24, 22);
            this.gdFiltros.Name = "gdFiltros";
            this.gdFiltros.Size = new System.Drawing.Size(495, 219);
            this.gdFiltros.TabIndex = 33;
            this.gdFiltros.TabStop = false;
            this.gdFiltros.Text = "Filtros";
            // 
            // cbCondicion
            // 
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(112, 186);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(184, 21);
            this.cbCondicion.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Condición";
            // 
            // cbGrado
            // 
            this.cbGrado.FormattingEnabled = true;
            this.cbGrado.Location = new System.Drawing.Point(112, 152);
            this.cbGrado.Name = "cbGrado";
            this.cbGrado.Size = new System.Drawing.Size(184, 21);
            this.cbGrado.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grado";
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(112, 119);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(342, 20);
            this.txtApMat.TabIndex = 9;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(112, 86);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(342, 20);
            this.txtApPat.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(342, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(112, 20);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(342, 20);
            this.txtDNI.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
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
            this.DNI,
            this.Nombre,
            this.ApPat,
            this.ApMat,
            this.Grado,
            this.Condicion,
            this.Sección,
            this.phone,
            this.email});
            this.dgvUsuarios.Location = new System.Drawing.Point(24, 256);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.Size = new System.Drawing.Size(740, 216);
            this.dgvUsuarios.TabIndex = 31;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.HeaderText = "Condición";
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            // 
            // Sección
            // 
            this.Sección.HeaderText = "Sección";
            this.Sección.Name = "Sección";
            this.Sección.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "e-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // FormBuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 522);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gdFiltros);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FormBuscarAlumno";
            this.Text = "FormBuscarAlumno";
            this.gdFiltros.ResumeLayout(false);
            this.gdFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gdFiltros;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sección;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.ComboBox cbGrado;
    }
}