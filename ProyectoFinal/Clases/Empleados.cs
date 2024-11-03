using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    class Empleados
    {
        //Creacion de variables o atributos...
        string Carnet, Nombre, Apellido, Tipo;
        int IdUsuario;

        //Constructor sin argumentos...
        public Empleados()
        {

        }

        //Constructor con argumentos..
        public Empleados(string carnet, string nombre, string apellido, int idUsuario, string tipo)
        {
            Carnet = carnet;
            Nombre = nombre;
            Apellido = apellido;
            IdUsuario = idUsuario;
            Tipo = tipo;
        }

        //Creacion de metodos Get y Set...
        public string carnet
        {
            get { return Carnet; }
            set { Carnet = value; }
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
        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
    }
}
