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
    public partial class FrmPrincipalCajero : Form
    {
        private int childFormNumber = 0;

        public FrmPrincipalCajero()
        {
            InitializeComponent();
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

        //Boton para mostrar el formulario de las Transacciones...
        private void BtnTransacciones_Click(object sender, EventArgs e)
        {
            FrmTransacciones Transacciones = new FrmTransacciones();
            Transacciones.MdiParent = this;
            Transacciones.Show();
        }
    }
}
