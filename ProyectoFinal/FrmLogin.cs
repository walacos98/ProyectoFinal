using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregando MySQL para uso de la base...
using MySql.Data.MySqlClient;

namespace ProyectoFinal
{
    public partial class FrmLogin : Form
    {
        //Agregando la clase Conexion...
        static private Clases.Conexion Con = new Clases.Conexion();

        //Asignando la cadena de conexion...
        static string Cadena = "Database = " + Con.bd + "; Data Source =" + Con.server + " ; User Id =" + Con.user + " ; Password = " + Con.pass;

        //Creando instancia para conecion de base de datos...
        static MySqlConnection ConexionBD = new MySqlConnection(Cadena);

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
            //Abrimos conexion...
            ConexionBD.Open();
            //Inicializar nueva consulta con MySqlCommand...
            MySqlCommand Consulta = new MySqlCommand();
            Clases.Usuarios Usuario = new Clases.Usuarios();

            string user = TxtUser.Text;
            string pass = TxtPass.Text;

            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select * From usuarios Where Usuario = '" + user + "' and ContraseñaUsuario = '" + pass + "';";
            try
            {
                //Leemos la consulta y la asigmanos a la variable Lector...
                MySqlDataReader Lector = Consulta.ExecuteReader();
                if (Lector.Read())
                {
                    MessageBox.Show("Bienvenido " + Lector.GetValue(0));
                    Usuario.tipo = Lector.GetString(2);
                    this.Hide();
                    Principal Form = new Principal();
                    Form.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrertos...\n\nIntente de nuevo...");
                    TxtUser.Text = "";
                    TxtPass.Text = "";
                    TxtUser.Focus();
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error\n\n" + Ex);
            }
            finally
            {
                ConexionBD.Close();
            }
        }
    }
}
