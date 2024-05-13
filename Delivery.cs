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
    public partial class Delivery : Form
    {
        private string fullName;
        private int idUser;
        private int idDomicilioGenerado = 0;
        public Delivery(string fullName, int idUser)
        {
            InitializeComponent();
            putProducts();
            setPrice();
            SetDate();
            this.fullName = fullName;
            this.idUser = idUser;
        }

        List<Product> productList = new List<Product>();
        List<Item> itemList = new List<Item>();
        private void putProducts()
        {
            string sqlCon = "Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True";
            string query = "SELECT idProducto, nombre, precio FROM Producto";
            using (SqlConnection con = new SqlConnection(sqlCon))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = reader["nombre"].ToString();
                    cBoxProduct.Items.Add(productName);
                    productList.Add(new Product { Name = productName, IdProduct = Convert.ToInt32(reader["idProducto"]), Price = Convert.ToDouble(reader["precio"]) });
                }
            }
        }
        private void setPrice()
        {
            if (cBoxProduct.Text == "" && nudQuantity.Value == 0)
            {
                cBoxProduct.SelectedItem = "Picada";
                nudQuantity.Value = 1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserPage user = new UserPage(fullName, idUser);
            this.Hide();
            user.Show();
        }

        private void cBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Product p in productList)
            {
                if (p.Name.Equals(cBoxProduct.Text))
                {
                    lblPricePerUnit.Text = p.Price.ToString();
                    lblInv.Text = p.IdProduct.ToString();
                }  
            }
        }

        private void nUpDnQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblTotalProductPrice.Text = "$ "+ (Convert.ToInt32(nudQuantity.Value) * Convert.ToInt32(lblPricePerUnit.Text)).ToString();           
        }

        private void lblPricePerUnit_TextChanged(object sender, EventArgs e)
        {
            lblTotalProductPrice.Text = "$ " + (Convert.ToInt32(nudQuantity.Value) * Convert.ToInt32(lblPricePerUnit.Text)).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemList.Add(new Item { ID_Producto = Convert.ToInt32(lblInv.Text), 
                ID_Domicilio = Convert.ToInt32(lblTurnNumber.Text), 
                Cantidad = Convert.ToInt32(nudQuantity.Value), 
                Precio_Unitario = Convert.ToInt32(lblPricePerUnit.Text)});
            dgvSelectedItems.DataSource = null;
            dgvSelectedItems.DataSource = itemList;
            btnRegisterDelivery.Enabled = true;
        }

        private void Delivery_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterDelivery_Click(object sender, EventArgs e)
        {
            string con = "Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True";
            string query = "INSERT INTO Item (idProducto, idDomicilio, cantidad, valorItem) VALUES (@idProducto, @idDomicilio, @cantidad, @valorItem)";

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                foreach (Item item in itemList)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idProducto", item.ID_Producto);
                        command.Parameters.AddWithValue("@idDomicilio", item.ID_Domicilio);
                        command.Parameters.AddWithValue("@cantidad", item.Cantidad);
                        command.Parameters.AddWithValue("@valorItem", item.Precio_Unitario);
                        command.ExecuteNonQuery();
                    }
                }
            }
            MessageBox.Show("Tu pedido ha sido registrado, estará listo para entrega en 20 minutos.");
            UserPage user = new UserPage(fullName, idUser);
            this.Hide();
            user.Show();
        }

        private void CheckEmptyFields()
        {
            bool errorCity = true;
            bool errorAddress = true;
            bool errorPayMethod = true;

            //Validación campo ciudad
            if (cBoxCity.Text == "")
            {
                errorProviderCity.SetError(cBoxCity, "Por favor seleccione una ciudad destino.");
                errorCity = false;
            }
            else
                errorProviderCity.Clear();

            //Validación campo direccion
            if (txtAddress.Text == "")
            {
                errorProviderAddress.SetError(txtAddress, "Por favor ingresa una dirección para tu pedido.");
                errorPayMethod = false;
            }
            else
                errorProviderAddress.Clear();

            //Validación campo metodo de pago
            if (cBoxPaidMethod.Text == "")
            {
                errorProviderPayMethod.SetError(cBoxPaidMethod, "Por favor selecciona un metodo de pago.");
                errorPayMethod = false;
            }
            else
                errorProviderPayMethod.Clear();

            if ((errorCity && errorPayMethod && errorAddress) == true)
            {
                btnAddressConfirm.Enabled = true;
            }
            else
            {
                btnAddressConfirm.Enabled = false;
                gBoxPurchaseData.Enabled = false;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            CheckEmptyFields();
        }

        private void cBoxCity_TextChanged(object sender, EventArgs e)
        {
            CheckEmptyFields();
        }

        private void cBoxPaidMethod_TextChanged(object sender, EventArgs e)
        {
            CheckEmptyFields();
        }
        
        private void SetDate()
        {
            dtpDate.Value = Convert.ToDateTime(DateTime.Today.ToString("dd/MM/yyyy"));
        }
        private void btnAddressConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog='Santa Helena Campestre'; Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Domicilio (idUsuario, fecha, ciudad, direccion, medioPago) VALUES (@idUsuario, CONVERT(DATE, @fecha, 103), @ciudad, @direccion, @medioPago); SELECT SCOPE_IDENTITY();", con);
                cmd.CommandType = CommandType.Text;

                // Parámetros para la consulta de inserción
                cmd.Parameters.AddWithValue("@idUsuario", idUser);
                cmd.Parameters.AddWithValue("@fecha", dtpDate.Text);
                cmd.Parameters.AddWithValue("@ciudad", cBoxCity.Text);
                cmd.Parameters.AddWithValue("@direccion", txtAddress.Text);
                cmd.Parameters.AddWithValue("@medioPago", cBoxPaidMethod.Text);

                con.Open();

                // Ejecutar la consulta de inserción y obtener el idDomicilio generado
                idDomicilioGenerado = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("¡Datos de domicilio guardados con éxito!");
            }
            gBoxDelivery.Enabled = false;
            gBoxPurchaseData.Enabled = true;
            lblTurnNumber.Text = idDomicilioGenerado.ToString();
            btnBack.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (itemList.Count > 0)
            {
                itemList.RemoveAt(itemList.Count - 1);
            }
            else
            {
               MessageBox.Show("La lista está vacía. No hay elementos para eliminar.");
                btnRegisterDelivery.Enabled = false;
            }
            dgvSelectedItems.DataSource = null;
            dgvSelectedItems.DataSource = itemList;
        }
    }
}
