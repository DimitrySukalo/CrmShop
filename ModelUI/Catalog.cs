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
    public partial class Catalog<T> : Form
        where T: class
    {
        DbSet<T> db;
        CrmContext crm;

        public Catalog(DbSet<T> db, CrmContext crm)
        {
            InitializeComponent();

            this.db = db;
            this.crm = crm;
            db.Load();

            CatalogDataGrig.DataSource = db.Local.ToBindingList();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if(typeof(T) == typeof(Product))
            {
                var addingProductForm = new AddProduct();
                if(addingProductForm.ShowDialog() == DialogResult.OK)
                {
                    crm.Products.Add(addingProductForm.Product);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }

            if(typeof(T) == typeof(Customer))
            {
                var addingCustomerForm = new AddClient();
                if(addingCustomerForm.ShowDialog() == DialogResult.OK)
                {
                    crm.Customers.Add(addingCustomerForm.Customer);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }

            if(typeof(T) == typeof(Seller))
            {
                var addingSellerForm = new AddSeller();
                if(addingSellerForm.ShowDialog() == DialogResult.OK)
                {
                    crm.Sellers.Add(addingSellerForm.Seller);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }
        }

        private void ChangeItemButton_Click(object sender, EventArgs e)
        {
            var id = CatalogDataGrig.SelectedRows[0].Cells[0].Value;

            if(typeof(T) == typeof(Product))
            {
                var product = db.Find(id) as Product;
                if(product != null)
                {
                    var addProductForm = new AddProduct(product);
                    if(addProductForm.ShowDialog() == DialogResult.OK)
                    {
                        product = addProductForm.Product;
                        crm.SaveChanges();
                        CatalogDataGrig.Update();
                    }
                }
            }

            if(typeof(T) == typeof(Customer))
            {
                var customer = db.Find(id) as Customer;
                if(customer != null)
                {
                    var addCustomerForm = new AddClient(customer);
                    if(addCustomerForm.ShowDialog() == DialogResult.OK)
                    {
                        customer = addCustomerForm.Customer;
                        crm.SaveChanges();
                        CatalogDataGrig.Update();
                    }
                }
            }

            if(typeof(T) == typeof(Seller))
            {
                var seller = db.Find(id) as Seller;
                if(seller != null)
                {
                    var addSellerForm = new AddSeller(seller);
                    if(addSellerForm.ShowDialog() == DialogResult.OK)
                    {
                        seller = addSellerForm.Seller;
                        crm.SaveChanges();
                        CatalogDataGrig.Update();
                    }
                }
            }
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            var id = CatalogDataGrig.SelectedRows[0].Cells[0].Value;

            if(typeof(T) == typeof(Product))
            {
                var product = db.Find(id) as Product;
                if(product != null)
                {
                    crm.Products.Remove(product);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }

            if(typeof(T) == typeof(Customer))
            {
                var customer = db.Find(id) as Customer;
                if(customer != null)
                {
                    crm.Customers.Remove(customer);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }

            if(typeof(T) == typeof(Seller))
            {
                var seller = db.Find(id) as Seller;
                if(seller != null)
                {
                    crm.Sellers.Remove(seller);
                    crm.SaveChanges();
                    CatalogDataGrig.Update();
                }
            }
        }
    }
}
