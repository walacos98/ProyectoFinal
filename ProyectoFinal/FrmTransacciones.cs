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
    public partial class FrmTransacciones : Form
    {
        //Agregando la clase Conexion...
        static private Clases.Conexion Con = new Clases.Conexion();

        //Asignando la cadena de conexion...
        static string Cadena = "Database = " + Con.bd + "; Data Source =" + Con.server + " ; User Id =" + Con.user + " ; Password = " + Con.pass;

        //Creando instancia para conecion de base de datos...
        static MySqlConnection ConexionBD = new MySqlConnection(Cadena);

        public FrmTransacciones()
        {
            InitializeComponent();
        }

        //Metodo para limpiar los textBox...
        private void LimpiarTexts()
        {
            TxtNumTransaccion.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtMonto.Clear();
            TxtFecha.Clear();
            ComboTipo.Text = "";
            TxtDescripcion.Clear();
            TxtNombre.Focus();
        }

        //Metodo para limpiar el grid...
        private void LimpiarGrid()
        {
            DgvTransacciones.Rows.Clear();
            DgvTransacciones.Refresh();
        }

        //Boton para lipmpiar los Texts...
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexts();
            LimpiarGrid();
        }

        //Boton para salir del Formulario...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Boton para agregar la transaccion...
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            ConexionBD.Open();
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Insert into transaccion (NombreCliente, ApellidoCliente, Monto, FechaTransacción, TipoTransaccion, DescripcionTransacción)" +
                "values ('" + TxtNombre.Text + "','" + TxtApellido.Text + "','" + double.Parse(TxtMonto.Text) + "', '" + TxtFecha.Text + "', '" + ComboTipo.Text + "','" + TxtDescripcion.Text + "');";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                Consulta.CommandText = "Select * From transaccion";
                AdaptadorMysql.Fill(Tabla);
                DgvTransacciones.DataSource = Tabla;
                LimpiarTexts();
                MessageBox.Show("Agregado exitosamente!...");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al ingresar la transaccion\n\n" + Ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ConexionBD.Close();
            }
        }

        //Boton para buscar las transacciones desde el Cliente...
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MySqlCommand Consulta = new MySqlCommand();
            //Abrimos conexion...
            ConexionBD.Open();

            string NombreCliente = TxtNombre.Text;
            string ApellidoCliente = TxtApellido.Text;
            Consulta.Connection = ConexionBD;
            Consulta.CommandText = "Select * From transaccion where NombreCliente = '" + NombreCliente + "' And ApellidoCliente = '" + ApellidoCliente + "'";
            try
            {
                //Inicializamos nueva instancia de la clase MySqlDataAdapter...
                MySqlDataAdapter AdaptadorMysql = new MySqlDataAdapter();
                AdaptadorMysql.SelectCommand = Consulta;
                DataTable Tabla = new DataTable();
                AdaptadorMysql.Fill(Tabla);
                DgvTransacciones.DataSource = Tabla;
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

        //Validaciones...
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }
    }
}
