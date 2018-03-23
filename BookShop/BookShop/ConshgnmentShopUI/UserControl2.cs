using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConshgnmentShopUI
{
    public partial class UserControl2 : UserControl
    {
        Store store = new Store();
        public UserControl2()
        {
            InitializeComponent();
            SetupData();
            int i = 0,suma=0,j=0;
            foreach (Item item in store.Items)
            {
                if (suma < 4)
                {
                    suma++;
                    Controls.Add(new BookControl(item.Title, i, j,item.Price));
                    i += 100;
                    
                    
                }
                if (suma == 4)
                {
                    suma = 0;
                    i = 0;
                    j += 150;
                    Controls.Add(new BookControl(item.Title, i, j, item.Price));
                }
                
                
            }
            
            

            
        }
        public void SetupData()
        {
            store.Vendors = new List<Vendor>();
            store.Vendors.Add(new Vendor { LastName = "Nowak", FirstName = "Jarosław", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Abacki", FirstName = "Adrian", Commission = .6 });
            store.Vendors.Add(new Vendor { LastName = "Parecki", FirstName = "Mateusz", Commission = .6 });

            store.Items = new List<Item>();
            store.Items.Add(new Item
            {
                Title = "Droga Królów",
                Price = 30,
                Sold = false,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Słowa Światłości",
                Price = 40,             
                Sold = false,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "The Eye of the World",
                Price = 25,
               
                Sold = false,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.Items.Add(new Item
            {
                Title = "The Great Hunt",
                Price = 29,
                Sold = false,
                Owner = store.Vendors[2]
            });

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
