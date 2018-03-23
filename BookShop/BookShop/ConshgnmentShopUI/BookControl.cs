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

    public partial class BookControl : UserControl
    {

        Store store = new Store();
        public BookControl(string nazwa, int left, int top,decimal price)
        {
            InitializeComponent();
            
            this.BookNameLabel.Text = nazwa;
            this.Top = top;
            this.Left = left;
            this.PriceBookLabel.Text =price.ToString();
            this.pictureBook.Image = Properties.Resources.zw;



        }

        private void BookNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            

        }

        private void BookControl_Load(object sender, EventArgs e)
        {
            this.Width = 250;
            this.Height = 350;
        }

        private void ImageBookPanel_Paint(object sender, PaintEventArgs e)
        {
            

        }

        
    }
}
