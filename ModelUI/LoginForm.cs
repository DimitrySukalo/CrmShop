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
    public partial class LoginForm : Form
    {
        CrmContext Crm;
        public Customer Customer { get; set; }

        public LoginForm(CrmContext crm)
        {
            InitializeComponent();
            Crm = crm;
            Customer = new Customer();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Customer = Customer ?? new Customer();
            Customer.Name = ClientNameTextBox.Text;
            Crm.Customers.Add(Customer);
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

        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            GetCorrectText(ClientNameTextBox);
        }
    }
}
