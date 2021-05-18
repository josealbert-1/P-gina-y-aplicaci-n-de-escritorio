using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace MultiServi
{
    class Consulta
    {
        public DataSet datos = new DataSet();
        public MySqlConnection GetConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;database=msbd;Uid=root;pwd=;");
            conexion.Open();
            return conexion;
        }
        public void muestraUsuariosTodos()
        {
            string consulta = "SELECT ID, user_login, user_nicename, user_email FROM msbd_users";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "msbd_users");
        }
        public void muestraUsuarioID(string idc)
        {
            string consulta = "SELECT ID, user_login, user_nicename, user_email FROM msbd_users WHERE ID='"+idc+"'";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, GetConexion());
            datos = new DataSet();
            adaptador.Fill(datos, "msbd_users");
        }
    }
}
