using CrmModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModelUI
{
    public partial class AddClient : Form
    {
        public Customer Customer { get; set; }

        public AddClient()
        {
            InitializeComponent();
        }

        public AddClient(Customer customer) : this()
        {
            Customer = customer ?? new Customer();
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            Customer = Customer ?? new Customer()
            {
                Name = ClientNameTextBox.Text,
                Surname = SurnameClientTextBox.Text,
                Age = Convert.ToInt32(AgeClientNumeric.Value)
            };
        }

        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(ClientNameTextBox);
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

        private void SurnameClientTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(SurnameClientTextBox);
        }
    }
}
