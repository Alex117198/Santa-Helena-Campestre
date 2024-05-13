using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Helena_Campestre
{
    public partial class LogIn : Form
    {
        public User selectUser;
        public LogIn()
        {
            InitializeComponent();
            selectUser = new User();
            putUsers();
        }
        List<User> userList = new List<User>();
        private void putUsers()
        {
            string sqlCon = "Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True";
            string query = "SELECT idUsuario, tipoID, nombre, apellido, usuario, contrasenia, telefono FROM Usuario WHERE usuario = @userName AND contrasenia = @password";
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@userName", txtUser.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    userList.Add(new User {idUsuario = Convert.ToInt32(reader["idUsuario"]),
                    tipoID = reader["tipoID"].ToString(),
                    nombre = reader["nombre"].ToString(),
                    apellido = reader["apellido"].ToString(),
                    usuario = reader["usuario"].ToString(),
                    contrasenia = reader["contrasenia"].ToString(),
                    telefono = reader["telefono"].ToString()});
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainInterface main = new MainInterface();
            main.Show();
            this.Close();
        }
        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string connection = "Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True";
            string query = "SELECT idUsuario, nombre, apellido FROM Usuario WHERE usuario = @userName AND contrasenia = @password";

            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();

                    // Verificar credenciales del usuario
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@userName", txtUser.Text);
                    command.Parameters.AddWithValue("@password", txtPassword.Text);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string fullName = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                        int idUser = Convert.ToInt32(reader["idUsuario"]);
                        MessageBox.Show("¡Bienvenido/a " + reader["nombre"].ToString() + " " + reader["apellido"].ToString()+"!");
                        this.Hide();
                        UserPage userPage = new UserPage(fullName, idUser);
                        userPage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sus credenciales son incorrectas, por favor verifíquelas.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar iniciar sesión: " + ex.Message);
            }
        }
    }
}
