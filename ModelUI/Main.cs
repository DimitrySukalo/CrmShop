using CrmModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelUI
{
    public partial class Main : Form
    {
        CrmContext crm;
        public Cart Cart { get; set; }
        public Customer Customer { get; set; }

        public Main()
        {
            InitializeComponent();
            crm = new CrmContext();
            Customer = new Customer();
            Cart = new Cart();
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Customer>(crm.Customers, crm);
            catalogForm.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Seller>(crm.Sellers, crm);
            catalogForm.Show();
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Product>(crm.Products, crm);
            catalogForm.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Check>(crm.Checks, crm);
            catalogForm.Show();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addingClientForm = new AddClient();
            if(addingClientForm.ShowDialog() == DialogResult.OK)
            {
                crm.Customers.Add(addingClientForm.Customer);
                crm.SaveChanges();
                GetMessageInfo("Клиент");
            }
        }

        private static void GetMessageInfo(string item)
        {
            MessageBox.Show($"{item} был добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var addingSeller = new AddSeller();
            if(addingSeller.ShowDialog() == DialogResult.OK)
            {
                crm.Sellers.Add(addingSeller.Seller);
                crm.SaveChanges();
                GetMessageInfo("Продавец");
            }
        }

        private void AddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var addingProduct = new AddProduct();
            if(addingProduct.ShowDialog() == DialogResult.OK)
            {
                crm.Products.Add(addingProduct.Product);
                crm.SaveChanges();
                GetMessageInfo("Продукт");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                ProductListForChoose.Invoke((Action)delegate { ProductListForChoose.Items.AddRange(crm.Products.ToArray()); });
            });
        }

        private void ProductListForChoose_DoubleClick(object sender, EventArgs e)
        {
            if (Customer.Name == null)
            {
                MessageBox.Show("Авторизуйтесь пожалуйста!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (ProductListForChoose.SelectedItem is Product product)
                {
                    Cart.Add(product);
                    ProductListForSale.Items.Add(product);
                    UpdateLists();
                }
            }
        }

        private void UpdateLists()
        {
            ProductListForSale.Invoke((Action)delegate
            {
                ProductListForSale.Items.Clear();
                ProductListForSale.Items.AddRange(Cart.Products.ToArray());
                SumPayLabel.Text = Cart.Price.ToString();
            });
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (Customer.Name == null)
            {
                MessageBox.Show("Авторизуйтесь пожалуйста!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CashDesk cashDesk = new CashDesk(10, crm.Sellers.First(), crm);
                cashDesk.Enqueue(Cart);
                cashDesk.ServeCustomer();
                MessageBox.Show("Покупка проведена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoginLinkLabel_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm(crm);
            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                crm.SaveChanges();
                GetMessageInfo("Покупатель");
                LoginLinkLabel.Text = $"Добро пожаловать, {loginForm.Customer}";
                Customer = loginForm.Customer;
                Cart = new Cart(Customer);
            }
        }

        private void ProductListForSale_DoubleClick(object sender, EventArgs e)
        {
            if(ProductListForSale.SelectedItem is Product product)
            {
                Cart.Products.Remove(product);
                Cart.Price -= product.Price; 
                ProductListForSale.Items.Remove(product);
                UpdateLists();
            }
        }
    }
}
