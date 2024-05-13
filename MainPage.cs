using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santa_Helena_Campestre
{
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LogIn newLog = new LogIn();
            newLog.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm newRegister = new RegisterForm();
            newRegister.Show();
            this.Hide();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Santa Helena Campestre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
