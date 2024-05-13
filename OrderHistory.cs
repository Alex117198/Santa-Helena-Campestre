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
    public partial class OrderHistory : Form
    {
        private string fullName;
        private int idUser;
        public OrderHistory(string fullName, int idUser)
        {
            InitializeComponent();
            FillDGV(idUser);
            this.fullName = fullName;
            this.idUser = idUser;
        }
        private void FillDGV(int idUser)
        {
            string con = "Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True";
            string query = @"SELECT u.nombre AS 'Nombre Usuario', d.fecha AS 'Fecha', d.ciudad AS 'Ciudad', 
                        d.direccion AS 'Dirección', d.medioPago AS 'Medio de Pago', 
                        i.cantidad AS 'Cantidad', i.valorItem AS 'Valor Item', 
                        p.nombre AS 'Nombre Producto', p.descripcion AS 'Descripción Producto', 
                        (i.cantidad * i.valorItem) AS 'Total'
                 FROM Usuario u, Domicilio d, Item i, Producto p
                 WHERE u.idUsuario = @idUsuario 
                     AND d.idDomicilio = i.idDomicilio 
                     AND i.idProducto = p.idProducto";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@idUsuario", idUser);
                    connection.Open();
                    adapter.Fill(dataTable);
                }
            }
            dgvOrderHistory.DataSource = dataTable;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserPage user = new UserPage(fullName, idUser);
            this.Hide();
            user.Show();
        }
    }
}
