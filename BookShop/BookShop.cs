using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class BookShop : Form
    {
        
        private Store store = new Store();
        BindingSource itemsBinding = new BindingSource();



        public BookShop()
        {
            InitializeComponent();
            SetupData();
            itemsBinding.DataSource = store.Items;
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";
        }

        private void SetupData()
        {

            store.Vendors.Add(new Vendor { FirstName="Andrzej",LastName="Sapkowski"});
            store.Vendors.Add(new Vendor { FirstName = "Richard", LastName = "Dawkins" });

            store.Items.Add(new Item { Title = "Koniec", Description = "O koncu...",Price=30,Owner=store.Vendors[0] });
            store.Items.Add(new Item { Title = "Poczatek", Description = "O poczatku...", Price = 25, Owner = store.Vendors[1] });
            store.Items.Add(new Item { Title = "Dalej", Description = "O koncu...", Price = 20, Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Kranic", Description = "O poczatku...", Price = 15, Owner = store.Vendors[1] });

            store.Name = "Cheap books";
        }
        private void BookShop_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
