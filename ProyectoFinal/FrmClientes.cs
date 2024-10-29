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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
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

        //Programacion del boton Salir...
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
