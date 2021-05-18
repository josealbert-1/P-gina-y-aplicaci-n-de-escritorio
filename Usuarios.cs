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
    public partial class Usuarios : Form
    {
        Consulta consul = new Consulta();
        int pocicion;
        public Usuarios()
        {
            InitializeComponent();
        }
        public void limpia()
        {
            txtID.Clear();
            txtContraseña.Clear();
            txtCorreo.Clear();
            txtUsuario.Clear();
        }

        private void btnMuestraTodo_Click(object sender, EventArgs e)
        {
            consul.muestraUsuariosTodos();
            dataUsers.DataSource = consul.datos;
            dataUsers.DataMember = "msbd_users";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consul.muestraUsuarioID(txtID.Text);
            dataUsers.DataSource = consul.datos;
            dataUsers.DataMember = "msbd_users";
            limpia();
        }

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pocicion = dataUsers.CurrentRow.Index;
            txtIdControl.Text = dataUsers[0, pocicion].Value.ToString();
            txtUsuario.Text = dataUsers[1, pocicion].Value.ToString();
            txtContraseña.Text = dataUsers[2, pocicion].Value.ToString();
            txtCorreo.Text = dataUsers[3, pocicion].Value.ToString();
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MySqlCommand sql = new MySqlCommand("UPDATE msbd_users SET user_login=@user, user_nicename=@contra, user_email = @correo WHERE ID=@Id", consul.GetConexion());
            sql.Parameters.AddWithValue("@user", txtUsuario.Text);
            sql.Parameters.AddWithValue("@contra", txtContraseña.Text);
            sql.Parameters.AddWithValue("@correo", txtCorreo.Text);
            sql.Parameters.AddWithValue("@Id", txtIdControl.Text);
            sql.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados correctamente");
            limpia();
            consul.muestraUsuariosTodos();
            dataUsers.DataSource = consul.datos;
            dataUsers.DataMember = "msbd_users";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MySqlCommand sql = new MySqlCommand("DELETE FROM msbd_users WHERE Id=@Id", consul.GetConexion());
            sql.Parameters.AddWithValue("@Id", txtIdControl.Text);
            sql.ExecuteNonQuery();
            MessageBox.Show("Datos eliminados correctamente");
            limpia();
            consul.muestraUsuariosTodos();
            dataUsers.DataSource = consul.datos;
            dataUsers.DataMember = "msbd_users";
        }
    }
}
