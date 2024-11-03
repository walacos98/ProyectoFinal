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
    public partial class FrmClientes : Form
    {
        //Agregando la clase Conexion...
        static private Clases.Conexion Con = new Clases.Conexion();

        //Asignando la cadena de conexion...
        static string Cadena = "Database = " + Con.bd + "; Data Source =" + Con.server + " ; User Id =" + Con.user + " ; Password = " + Con.pass;

        //Creando instancia para conecion de base de datos...
        static MySqlConnection ConexionBD = new MySqlConnection(Cadena);

        public FrmClientes()
        {
            InitializeComponent();
            LeerBD();
        }
        
        //Metodo para limpiar los textBox...
        private void LimpiarTexts()
        {
            TxtDui.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            ComboProducto.Text = "";
            TxtDui.Focus();
        }

        //Metodo para Leer los datos de la Base de Datos...
        private void LeerBD()
        {
            //Inicializar nueva consulta con MySqlCommand...
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select DUICliente, NombresCliente, ApellidosCliente, Productos From clientes;";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvClientes.DataSource = Tabla;
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error al cargar la base\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Metodo para limpiar el grid...
        private void LimpiarGrid()
        {
            DgvClientes.Rows.Clear();
            DgvClientes.Refresh();
        }

        //Programacion del boton Salir...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton para limpiar...
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexts();
        }

        //Boton para agregar Clientes...
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Insert into clientes (DUICliente, NombresCliente, ApellidosCliente, Productos, IdTransaccion) values ('"+TxtDui.Text+ "','"+TxtNombre.Text+ "','"+TxtApellido.Text+ "','"+ComboProducto.Text+"',NULL)";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                Consulta.CommandText = "Select DUICliente, NombresCliente, ApellidosCliente, Productos From clientes";
                AdaptadorMysql.Fill(Tabla);
                DgvClientes.DataSource = Tabla;
                LimpiarTexts();
                MessageBox.Show("Agregado exitosamente!...");
            }
            catch(Exception Ex)
            {
                MessageBox.Show("Error al ingresar el cliente\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para eliminar los Clientes...
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string Id = Convert.ToString(DgvClientes.CurrentRow.Cells["DUICliente"].Value);

            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Delete From clientes where DUICliente = '" + Id + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                MessageBox.Show("Cliente eliminado con exito...");
                LimpiarTexts();
                //Se consulta nuevamente...
                Consulta.CommandText = "Select DUICliente, NombresCliente, ApellidosCliente, Productos From clientes";
                AdaptadorMysql.Fill(Tabla);
                DgvClientes.DataSource = Tabla;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar el cliente\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para buscar cliente con numero de DUI...
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            string Id = TxtDui.Text;
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select DUICliente, NombresCliente, ApellidosCliente, Productos From clientes where DUICliente = '" + Id + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvClientes.DataSource = Tabla;
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
