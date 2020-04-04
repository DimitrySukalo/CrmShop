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

    }
}
