namespace Sistemas_Malvarado
{
    partial class frmRegistrarNotas
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEx2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grado y seccion:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombreAlumno,
            this.colPC1,
            this.colPC2,
            this.colEx1,
            this.colPC3,
            this.colPC4,
            this.colEx2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 199);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(175, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // colNombreAlumno
            // 
            this.colNombreAlumno.HeaderText = "Nombre";
            this.colNombreAlumno.Name = "colNombreAlumno";
            this.colNombreAlumno.ReadOnly = true;
            this.colNombreAlumno.Width = 300;
            // 
            // colPC1
            // 
            this.colPC1.HeaderText = "PC1";
            this.colPC1.Name = "colPC1";
            this.colPC1.Width = 30;
            // 
            // colPC2
            // 
            this.colPC2.HeaderText = "PC2";
            this.colPC2.Name = "colPC2";
            this.colPC2.Width = 30;
            // 
            // colEx1
            // 
            this.colEx1.HeaderText = "EX1";
            this.colEx1.Name = "colEx1";
            this.colEx1.Width = 30;
            // 
            // colPC3
            // 
            this.colPC3.HeaderText = "PC3";
            this.colPC3.Name = "colPC3";
            this.colPC3.Width = 30;
            // 
            // colPC4
            // 
            this.colPC4.HeaderText = "PC4";
            this.colPC4.Name = "colPC4";
            this.colPC4.Width = 30;
            // 
            // colEx2
            // 
            this.colEx2.HeaderText = "EX2";
            this.colEx2.Name = "colEx2";
            this.colEx2.Width = 30;
            // 
            // frmRegistrarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 421);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarNotas";
            this.Text = "frmRegistrarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPC4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEx2;
    }
}