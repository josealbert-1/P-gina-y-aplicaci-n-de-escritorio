using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MultiServi
{
    public partial class Login : Form
    {
        Consulta bd = new Consulta();
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader;
            string sql = ("SELECT * FROM msbd_users WHERE user_email='" + txtCorreo.Text + "'and user_nicename='" + txtContraseña.Text + "'");
            MySqlCommand comando = new MySqlCommand(sql, bd.GetConexion());
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Acceso concedido");
                this.Hide();
                Usuarios inicia =  new Usuarios();
                inicia.Show();
            }
            else
            {
                MessageBox.Show("Correo y/o contraseña incorrecto");
                txtCorreo.Clear();
                txtContraseña.Clear();
            }
;        }
    }
}
