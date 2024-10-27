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
        }

        //Boton para mostrar el formularios de clientes...
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes Fr = new FrmClientes();
            Fr.MdiParent = this;
            Fr.Show();
        }

        //Boton para salir de la aplicacion...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton para cerrar sesion...
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }

        //Boton para mostrar el formulario de los empleados...
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados Fr = new FrmEmpleados();
            Fr.MdiParent = this;
            Fr.Show();
        }
    }
}
