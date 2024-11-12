using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Clases
{
    class Usuarios
    {
        //Creacion de variables...
        //Variable que almacena el nombre de usuario...
        private string User;
        //Variable que almacena la contraseña del usuario...
        private string Pass;
        //Variable que almacena el tipo de usuario...
        private string Tipo;

        public Usuarios()
        {
            //Constructor sin argumentos...
        }

        public Usuarios(string user, string pass, string tipo)
        {
            //Constructor con argumentos...
            this.User = user;
            this.Pass = pass;
            this.Tipo = tipo;
        }

        //Metodos accesores...
        public string user { get => User; set => User = value; }
        public string pass { get => Pass; set => Pass = value; }
        public string tipo { get => Tipo; set => Tipo = value; }
    }
}
