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
    public partial class Principal : Form
    {
        public Principal()
        {            
            InitializeComponent();
            ValidarUsuario();
        }

        //Funcion para validar los tipos de usuarios...
        public void ValidarUsuario()
        {
            Clases.Usuarios Usuario = new Clases.Usuarios();
            MessageBox.Show(Usuario.tipo);
        }
        //Boton para mostrar el formularios de clientes...
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Clientes = new FrmClientes();
            Clientes.MdiParent = this;
            Clientes.Show();
        }

        //Boton para salir de la aplicacion...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Boton para cerrar sesion...
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin Login = new FrmLogin();
            Login.Show();
        }

        //Boton para mostrar el formulario de los empleados...
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados Empleados = new FrmEmpleados();
            Empleados.MdiParent = this;
            Empleados.Show();
        }

        //Boton para mostar el formulario de Usuarios...
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios Usuarios = new FrmUsuarios();
            Usuarios.MdiParent = this;
            Usuarios.Show();
        }

        //Boton para mostrar el formulario de las Transacciones...
        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            FrmTransacciones Transacciones = new FrmTransacciones();
            Transacciones.MdiParent = this;
            Transacciones.Show();
        }
    }
}
