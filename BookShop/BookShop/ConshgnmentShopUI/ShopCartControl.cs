using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConshgnmentShopUI
{
    public partial class ShopCartControl : UserControl
    {
        public ShopCartControl()
        {
            InitializeComponent();
            Controls.Add(new ShopCartControlBook());
        }

        private void ShopCartControl_Load(object sender, EventArgs e)
        {

        }
    }
}
