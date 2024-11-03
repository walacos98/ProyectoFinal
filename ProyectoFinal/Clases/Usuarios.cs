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

        private int IdUsuario;

        public Usuarios()
        {
            //Constructor sin argumentos...
        }

        public Usuarios(string user, string pass, int idUsuario)
        {
            //Constructor con argumentos...
            this.User = user;
            this.Pass = pass;
            this.IdUsuario = idUsuario;
        }

        //Metodos accesores...
        public string user
        {
            get { return User; }
            set { User = value; }
        }

        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }

        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
    }
}
