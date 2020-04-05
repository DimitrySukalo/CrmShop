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
    public partial class AddSeller : Form
    {
        public Seller Seller { get; set; }

        public AddSeller()
        {
            InitializeComponent();
        }

        public AddSeller(Seller seller) : this()
        {
            Seller = seller ?? new Seller();
            SellerNameTextBox.Text = seller.Name;
            SellerSurname.Text = seller.Surname;
            SellerLastname.Text = seller.Lastname;
            SellerAgeNumeric.Value = seller.Age;
        }

        private void AddSellerButton_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = SellerNameTextBox.Text;
            Seller.Surname = SellerSurname.Text;
            Seller.Lastname = SellerLastname.Text;
            Seller.Age = Convert.ToInt32(SellerAgeNumeric.Value);
        }

        private void GetCorrectText(TextBox textBox)
        {
            if (Regex.IsMatch(textBox.Text, "[^А-Я.а-я]"))
            {
                MessageBox.Show("Только русские буквы", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void SellerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(SellerNameTextBox);
        }

        private void SellerSurname_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(SellerSurname);
        }

        private void SellerLastname_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(SellerLastname);
        }
    }
}
