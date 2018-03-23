namespace ConshgnmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelFront = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonVendors = new System.Windows.Forms.Button();
            this.buttonShoppingCart = new System.Windows.Forms.Button();
            this.buttonOffering = new System.Windows.Forms.Button();
            this.shopCartControl1 = new ConshgnmentShopUI.ShopCartControl();
            this.userControl22 = new ConshgnmentShopUI.UserControl2();
            this.userControl21 = new ConshgnmentShopUI.UserControl2();
            this.userControl11 = new ConshgnmentShopUI.UserControl1();
            this.control2 = new ConshgnmentShopUI.UserControl2();
            this.PanelFront.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelFront
            // 
            this.PanelFront.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelFront.Controls.Add(this.buttonSettings);
            this.PanelFront.Controls.Add(this.buttonAccount);
            this.PanelFront.Controls.Add(this.buttonVendors);
            this.PanelFront.Controls.Add(this.buttonShoppingCart);
            this.PanelFront.Controls.Add(this.buttonOffering);
            this.PanelFront.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelFront.Location = new System.Drawing.Point(0, 0);
            this.PanelFront.Name = "PanelFront";
            this.PanelFront.Size = new System.Drawing.Size(200, 921);
            this.PanelFront.TabIndex = 15;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSettings.Location = new System.Drawing.Point(3, 296);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(197, 49);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAccount.Location = new System.Drawing.Point(3, 241);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(197, 49);
            this.buttonAccount.TabIndex = 3;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.UseVisualStyleBackColor = false;
            // 
            // buttonVendors
            // 
            this.buttonVendors.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonVendors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendors.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVendors.Location = new System.Drawing.Point(3, 186);
            this.buttonVendors.Name = "buttonVendors";
            this.buttonVendors.Size = new System.Drawing.Size(197, 49);
            this.buttonVendors.TabIndex = 2;
            this.buttonVendors.Text = "Vendors";
            this.buttonVendors.UseVisualStyleBackColor = false;
            this.buttonVendors.Click += new System.EventHandler(this.buttonVendors_Click);
            // 
            // buttonShoppingCart
            // 
            this.buttonShoppingCart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShoppingCart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShoppingCart.Location = new System.Drawing.Point(3, 131);
            this.buttonShoppingCart.Name = "buttonShoppingCart";
            this.buttonShoppingCart.Size = new System.Drawing.Size(197, 49);
            this.buttonShoppingCart.TabIndex = 1;
            this.buttonShoppingCart.Text = "Shopping Cart";
            this.buttonShoppingCart.UseVisualStyleBackColor = false;
            this.buttonShoppingCart.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // buttonOffering
            // 
            this.buttonOffering.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonOffering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOffering.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOffering.Location = new System.Drawing.Point(3, 75);
            this.buttonOffering.Name = "buttonOffering";
            this.buttonOffering.Size = new System.Drawing.Size(197, 49);
            this.buttonOffering.TabIndex = 0;
            this.buttonOffering.Text = "Books";
            this.buttonOffering.UseVisualStyleBackColor = false;
            this.buttonOffering.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // shopCartControl1
            // 
            this.shopCartControl1.Location = new System.Drawing.Point(204, 0);
            this.shopCartControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shopCartControl1.Name = "shopCartControl1";
            this.shopCartControl1.Size = new System.Drawing.Size(1130, 884);
            this.shopCartControl1.TabIndex = 19;
            // 
            // userControl22
            // 
            this.userControl22.AutoScroll = true;
            this.userControl22.Location = new System.Drawing.Point(204, 0);
            this.userControl22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl22.Name = "userControl22";
            this.userControl22.Size = new System.Drawing.Size(1202, 828);
            this.userControl22.TabIndex = 18;
            // 
            // userControl21
            // 
            this.userControl21.AutoScroll = true;
            this.userControl21.Location = new System.Drawing.Point(204, 0);
            this.userControl21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1213, 853);
            this.userControl21.TabIndex = 17;
            this.userControl21.Load += new System.EventHandler(this.userControl21_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(207, 0);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1147, 734);
            this.userControl11.TabIndex = 16;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // control2
            // 
            this.control2.AutoScroll = true;
            this.control2.Location = new System.Drawing.Point(199, 0);
            this.control2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.control2.Name = "control2";
            this.control2.Size = new System.Drawing.Size(200, 250);
            this.control2.TabIndex = 17;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 921);
            this.Controls.Add(this.shopCartControl1);
            this.Controls.Add(this.userControl22);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.PanelFront);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.PanelFront.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelFront;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonVendors;
        private System.Windows.Forms.Button buttonShoppingCart;
        private System.Windows.Forms.Button buttonOffering;
        private UserControl1 userControl11;
        private UserControl2 control2;
        private UserControl2 userControl21;
        private UserControl2 userControl22;
        private ShopCartControl shopCartControl1;
    }
}

