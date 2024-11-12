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
    public partial class FrmUsuarios : Form
    {
        //Agregando la clase Conexion...
        static private Clases.Conexion Con = new Clases.Conexion();

        //Asignando la cadena de conexion...
        static string Cadena = "Database = " + Con.bd + "; Data Source =" + Con.server + " ; User Id =" + Con.user + " ; Password = " + Con.pass;

        //Creando instancia para conecion de base de datos...
        static MySqlConnection ConexionBD = new MySqlConnection(Cadena);

        public FrmUsuarios()
        {
            InitializeComponent();
            LeerBD();
        }

        //Metodo para limpiar TextBox...
        public void LimpiarTexts()
        {
            TxtUsuario.Clear();
            TxtPass.Clear();
            TxtUsuario.Focus();
        }

        //Metodo para limpiar el grid...
        private void LimpiarGrid()
        {
            DgvUsuarios.Rows.Clear();
            DgvUsuarios.Refresh();
        }

        //Metodo para cargar leer Base
        public void LeerBD()
        {
            //Inicializar nueva consulta con MySqlCommand...
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select Usuario, ContraseñaUsuario, TipoEmpleado From usuarios";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvUsuarios.DataSource = Tabla;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar la base\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para salir del formulario...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton para limpiar los text...
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexts();
        }

        //Boton para agregar usuarios nuevos...
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Insert into usuarios (Usuario, ContraseñaUsuario, TipoEmpleado) values ('" + TxtUsuario.Text + "','" + TxtPass.Text + "', '" + ComboTipo.Text + "')";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                Consulta.CommandText = "Select Usuario, ContraseñaUsuario, TipoEmpleado From usuarios";
                AdaptadorMysql.Fill(Tabla);
                DgvUsuarios.DataSource = Tabla;
                LimpiarTexts();
                MessageBox.Show("Agregado exitosamente!...");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ingresar el usuario\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para eliminar usarios...
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string User = Convert.ToString(DgvUsuarios.CurrentRow.Cells["Usuario"].Value);

            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Delete From usuarios where Usuario = '" + User + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                MessageBox.Show("Usuario eliminado con exito...");
                LimpiarTexts();
                //Se consulta nuevamente...
                Consulta.CommandText = "Select Usuario, ContraseñaUsuario, TipoEmpleado From usuarios";
                AdaptadorMysql.Fill(Tabla);
                DgvUsuarios.DataSource = Tabla;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar el Usuario\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para buscar por medio del usuario...
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            string User = TxtUsuario.Text;
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select Usuario, ContraseñaUsuario, TipoEmpleado From usuarios where Usuario = '" + User + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvUsuarios.DataSource = Tabla;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al cargar la base\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }
    }
}
