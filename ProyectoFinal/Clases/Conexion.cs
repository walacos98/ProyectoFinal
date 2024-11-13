namespace ProyectoFinal.Clases
{
    class Conexion
    {
        //Creacion de variables...
        string Server = "localhost";
        string BD = "acoemprendedores";
        string User = "root";
        string Pass = "root";

        //Constructor sin argumentos...
        public Conexion()
        {

        }

        //Constructor con argumentos...
        public Conexion(string server, string bd, string user, string pass)
        {
            Server = server;
            BD = bd;
            User = user;
            Pass = pass;
        }

        //Metodos Get y Set...
        public string server
        {
            get { return Server; }
            set { Server = value; }
        }
        public string bd
        {
            get { return BD; }
            set { bd = value; }
        }
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
    }
}
