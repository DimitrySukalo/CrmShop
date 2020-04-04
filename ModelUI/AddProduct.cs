using CrmModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelUI
{
    public partial class AddProduct : Form
    {
        public Product Product { get; set; }

        public AddProduct()
        {
            InitializeComponent();
        }

        public AddProduct(Product product) : this()
        {
            Product = product ?? new Product();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product()
            {
                Name = ProductNameTextBox.Text,
                Price = ProductPriceNumberic.Value,
                Created = DateOfCreatingProduct.Value
            };
        }

        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(ProductNameTextBox.Text, "[^А-Я.а-я]"))
            {
                MessageBox.Show("Только русские буквы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ProductNameTextBox.Text.Length > 0)
                {
                    ProductNameTextBox.Text = ProductNameTextBox.Text.Remove(ProductNameTextBox.Text.Length - 1);
                    ProductNameTextBox.SelectionStart = ProductNameTextBox.Text.Length;
                }
            }
        }
    }
}
