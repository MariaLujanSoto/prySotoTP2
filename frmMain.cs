using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySotoTP2
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        clsUsuario objUsuario = new clsUsuario();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            clsUsuario objUsuario = new clsUsuario();

            objUsuario.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);

            if (objUsuario.estadoConexion == "Usuario EXISTE")
            {
                MessageBox.Show("Ingreso Correcto");


            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseñas no coinciden");
                objUsuario.RegistroLogInicioSesion();
            }

        }
    }
    
   }

