﻿using System;
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
    public partial class frmGestionarAsistencia : Form
    {
        public frmGestionarAsistencia()
        {
            InitializeComponent();
        }



        private void FrmGestionarAsistencia_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAsistencia frmAsistencia = new frmAsistencia();
            if (frmAsistencia.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
