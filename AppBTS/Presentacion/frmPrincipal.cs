using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.ShowDialog();

            if (fl.MiUsuario.Id_usuario == 0)
            {
                this.Close();
            }
            else
            {
                this.Text += " - Usuario: " + fl.MiUsuario.Nombre;
            }
            fl.Dispose();
        }
    }
}
