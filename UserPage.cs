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
    public partial class UserPage : Form
    {
        private string fullName;
        private int idUser;
        public UserPage(string fullName, int idUser)
        {
            InitializeComponent();
            this.fullName = fullName;
            this.idUser = idUser;
            lblName.Text = fullName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MainInterface main = new MainInterface();
            this.Hide();
            main.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery(fullName, idUser);
            this.Hide();
            delivery.Show();
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory order = new OrderHistory(fullName, idUser);
            this.Hide();
            order.Show();
        }
    }
}
