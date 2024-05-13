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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        //Validación de datos al momento de registrar usuario
        private void registerBtn_Click(object sender, EventArgs e)
        {
            //Booleanos para errores por casilla
            bool errorUser = true;
            bool errorPw1 = true;
            bool errorPw2 = true;
            bool errorID = true;
            bool errorIDType = true;
            bool errorName = true;
            bool errorLastName = true;
            bool errorPhoneNumber = true;

            //Validación del campo usuario
            if (txtUser.Text == "")
            {
                errorUser = false;
                errorProviderUser.SetError(txtUser, "Por favor escriba un nombre de usuario.");
            }
            else
                errorProviderUser.Clear();

            //Validación del campo contraseña
            if (txtPassword1.Text == "")
            {
                errorPw1 = false;
                errorProviderPw.SetError(txtPassword1, "Por favor establezca una contraseña.");
            }
            else
                errorProviderPw.Clear();

            //Validación del campo confirma contraseña
            if (txtPassword2.Text == "" || txtPassword1.Text != txtPassword2.Text)
            {
                errorPw2 = false;
                errorProviderPw.SetError(txtPassword2, "Su contraseña no coincide, por favor verifiquela.");
            }
            else
                errorProviderPw.Clear();            

            //Validación del campo tipo de identificación
            if (cBoxIDType.Text == "")
            {
                errorIDType = false;
                errorProviderIDType.SetError(cBoxIDType, "Por favor seleccione un tipo de documento de identificación.");
            }
            else
                errorProviderIDType.Clear();

            //Validación del campo número de identificación
            foreach (char aux in txtID.Text)
            {
                if (char.IsLetter(aux) || char.IsPunctuation(aux) || char.IsSymbol(aux))
                {
                    errorID = false;
                    errorProviderID.SetError(txtID, "Por favor ingrese su numero de identificación.");
                    break;
                }
            }
            if (txtID.Text == "")
            {
                errorID = false;
                errorProviderID.SetError(txtID, "Este campo no puede estar vacio.");
            }
            else
                errorProviderID.Clear();
            
            //Validación del campo nombre
            foreach (char aux in txtName.Text)
            {
                if(char.IsNumber(aux) || char.IsPunctuation(aux) || char.IsSymbol(aux))
                {
                    errorName = false;
                    errorProviderName.SetError(txtName, "Este campo es obligatorio, por favor ingrese su nombre.");
                    break;
                }
            }
            if(txtName.Text == "")
            {
                errorName = false;
                errorProviderName.SetError(txtName, "Este campo no puede estar vacio.");
            }
            else
                errorProviderName.Clear();

            //Validación del campo apellido
            foreach (char aux in txtLastName.Text)
            {
                if (char.IsNumber(aux) || char.IsPunctuation(aux) || char.IsSymbol(aux))
                {
                    errorLastName = false;
                    errorProviderLastName.SetError(txtLastName, "Este campo es obligatorio, por favor ingrese su apellido.");
                    break;
                }
            }
            if (txtLastName.Text == "")
            {
                errorLastName = false;
                errorProviderLastName.SetError(txtLastName, "Este campo no puede estar vacio.");
            }
            else
                errorProviderLastName.Clear();
          

            //Validación del campo numero telefonico
            foreach (char aux in txtPhoneNumber.Text)
            {
                if (char.IsLetter(aux) || char.IsPunctuation(aux) || char.IsSymbol(aux))
                {
                    errorPhoneNumber = false;
                    errorProviderPhoneNumber.SetError(txtPhoneNumber, "Por favor ingrese su numero de telefono.");
                    break;
                }
            }
            if (txtPhoneNumber.Text == "")
            {
                errorPhoneNumber = false;
                errorProviderPhoneNumber.SetError(txtPhoneNumber, "Este campo no puede estar vacio.");
            }
            else
                errorProviderPhoneNumber.Clear();
                
            
            if((errorUser && errorPw1 && errorPw2 && errorID && errorIDType && errorName && errorLastName && errorPhoneNumber) == true)
            {
                MainInterface mainInterface = new MainInterface();
                using(SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (idUsuario, tipoID, nombre, apellido, usuario, contrasenia, telefono) VALUES (" + txtID.Text + ",'" + cBoxIDType.Text + "','" + txtName.Text + "','" + txtLastName.Text + "','" + txtUser.Text + "','" + txtPassword2.Text + "','" + txtPhoneNumber.Text + "')", con);
                    cmd.CommandType = CommandType.Text;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("¡Usuario "+txtUser.Text+" registrado con exito!");
                mainInterface.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Uno o más campos son incorrectos, por favor verifique la información.");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
        }

        private void lblPassword1_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword2_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProviderUser.Clear();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esto funciona pero le falta que al momento de registrar NO lo permita.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProviderID.SetError(txtID, "Este campo solo soporta caracteres numericos.");
            }
            else
                errorProviderID.Clear();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                errorProviderPhoneNumber.SetError(txtPhoneNumber, "Este campo solo soporta caracteres numericos.");
            }
            else
                errorProviderPhoneNumber.Clear();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 255))
            {
                errorProviderName.SetError(txtName, "Por favor, escriba su nombre.");
            }
            else
                errorProviderName.Clear();
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 159) || (e.KeyChar >= 166 && e.KeyChar <= 255))
            {
                errorProviderLastName.SetError(txtLastName, "Por favor, escriba su apellido.");
            }
            else
                errorProviderLastName.Clear();
        }

        private void cBoxIDType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword1_TextChanged(object sender, EventArgs e)
        {
            errorProviderPw.Clear();
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            errorProviderPw.Clear();
        }
    }
}
