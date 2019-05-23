using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistemas_Malvarado
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelFormularios.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            //base.OnPaint(e);
            //ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }
        

        
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //captura de  posicion y tamaño  antes de maximizar para restaurar
        int lx, ly, sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
                MenuVertical.Width = 72;
            else
                MenuVertical.Width = 250;
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        //Metodo para abrir formularios dentro del panel
        private void OpenForm<MiForm>() where  MiForm : Form , new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la coleccion  el formulario
            //Si el formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelFormularios.Controls.Add(formulario) ;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario existe
            else
            {
                formulario.BringToFront();
            }
        }


        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            OpenForm<FormAlumnos>();
        }
    }
}
