using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    class Clientes
    {
        //Creacion de variables de atributos...
        String Dui, Nombre, Apellido, Producto;

        //Constructor sin argumentos...
        public Clientes()
        {

        }

        //Constructor con argumentos...
        public Clientes(string dui, string nombre, string apellido, string producto)
        {
            Dui = dui;
            Nombre = nombre;
            Apellido = apellido;
            Producto = producto;
        }

        //Cracion de metodos Get y Set...
        public string dui
        {
            get { return Dui; }
            set { Dui = value; }
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public string producto
        {
            get { return Producto; }
            set { Producto = value; }
        }
    }
}
