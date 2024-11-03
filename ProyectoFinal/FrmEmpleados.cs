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
    public partial class FrmEmpleados : Form
    {
        //Agregando la clase Conexion...
        static private Clases.Conexion Con = new Clases.Conexion();

        //Asignando la cadena de conexion...
        static string Cadena = "Database = " + Con.bd + "; Data Source =" + Con.server + " ; User Id =" + Con.user + " ; Password = " + Con.pass;

        //Creando instancia para conecion de base de datos...
        static MySqlConnection ConexionBD = new MySqlConnection(Cadena);

        public FrmEmpleados()
        {
            InitializeComponent();
            LeerBD();
        }

        //Metodo para Leer los datos de la Base de Datos...
        private void LeerBD()
        {
            //Inicializar nueva consulta con MySqlCommand...
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select * From empleados";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvEmpleados.DataSource = Tabla;
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

        //Metodo para limpiar los textBox...
        private void LimpiarTexts()
        {
            TxtCarnet.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            ComboTipo.Text = "";
            TxtCarnet.Focus();
        }

        //Metodo para limpiar el grid...
        private void LimpiarGrid()
        {
            DgvEmpleados.Rows.Clear();
            DgvEmpleados.Refresh();
        }

        //Boton para cerrar formulario...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton para limpiar...
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexts();
        }

        //Boton para agregar Empleados...
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Insert into empleados (Carnet, NombresEmpleado, ApellidosEmpleado, TipoEmpleado) values ('" + TxtCarnet.Text + "','" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + ComboTipo.Text + "')";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                Consulta.CommandText = "Select * Productos From empleados";
                AdaptadorMysql.Fill(Tabla);
                DgvEmpleados.DataSource = Tabla;
                LimpiarTexts();
                MessageBox.Show("Agregado exitosamente!...");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ingresar el empleado\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para eliminar a los empleados...
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string Carnet = Convert.ToString(DgvEmpleados.CurrentRow.Cells["Carnet"].Value);

            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Delete From empleados where Carnet = '" + Carnet + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                MessageBox.Show("Empleado eliminado con exito...");
                LimpiarTexts();
                //Se consulta nuevamente...
                Consulta.CommandText = "Select * Productos From empleados";
                AdaptadorMysql.Fill(Tabla);
                DgvEmpleados.DataSource = Tabla;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al eliminar el empleado\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para buscar empleado por medio del Carnet...
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            string Carnet = TxtCarnet.Text;
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select * Productos From empleados where Carnet = '" + Carnet + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvEmpleados.DataSource = Tabla;
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
