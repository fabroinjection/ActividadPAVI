using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppBTS.Negocio;

namespace AppBTS
{
    public partial class frmLogin : Form
    {
        //private string user = "admin";
        //private string pass = "1234";
        private Usuario miUsuario = new Usuario();

        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Logueo :(";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (this.txtUsuario.Text == "")
            if(string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario!");
                this.txtUsuario.Focus();
                return;
            }

            if (this.txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña!");
                this.txtContrasena.Focus();
                return;

            }

            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Password = this.txtContrasena.Text;

            this.miUsuario.Id_usuario = this.miUsuario.validarUsuario(miUsuario.Nombre, miUsuario.Password);

            //if (this.txtUsuario.Text == this.user && this.txtContrasena.Text == this.pass)
            if(miUsuario.Id_usuario != 0)
            {
                MessageBox.Show("Login OK","Ingreso al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtContrasena.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }
        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
