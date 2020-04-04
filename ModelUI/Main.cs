﻿using CrmModel.Model;
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

        public Main()
        {
            InitializeComponent();
            crm = new CrmContext();
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

    }
}
