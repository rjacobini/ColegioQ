using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_Malvarado
{
    public partial class frmGestionarRepositorioExamenes : Form
    {

        private OpenFileDialog frmOpenFile;

        public frmGestionarRepositorioExamenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOpenFile = new OpenFileDialog();

            if(frmOpenFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(frmOpenFile.FileName);
                    txtExamen.Text = frmOpenFile.SafeFileName;
                }
                catch(SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            frmFeedback feed = new frmFeedback();

            feed.ShowDialog();
        }
    }
}
