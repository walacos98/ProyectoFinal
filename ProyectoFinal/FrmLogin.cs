using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Boton salir
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            //Creamos y asignamos las variables user y pass
            string user, pass;
            //Usuario
            user = TxtUser.Text.TrimEnd();
            //Contraseña
            pass = TxtPass.Text.TrimEnd();
            try
            {
                if (user == "AA23053" && pass == "123456")
                {
                    MessageBox.Show(string.Format("Bienvenido {0}...", user));
                    this.Hide();
                    Principal Fp = new Principal();
                    Fp.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrertos...\n\nIntente de nuevo...");
                    TxtUser.Text = "";
                    TxtPass.Text = "";
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}
