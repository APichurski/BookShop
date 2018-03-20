namespace BookShop
{
    partial class BookShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListLabel = new System.Windows.Forms.Label();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.makePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerText.Location = new System.Drawing.Point(12, 32);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(310, 29);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop Demo";
            this.headerText.Click += new System.EventHandler(this.label1_Click);
            // 
            // itemsListbox
            // 
            this.itemsListbox.FormattingEnabled = true;
            this.itemsListbox.ItemHeight = 20;
            this.itemsListbox.Location = new System.Drawing.Point(17, 114);
            this.itemsListbox.Name = "itemsListbox";
            this.itemsListbox.Size = new System.Drawing.Size(233, 144);
            this.itemsListbox.TabIndex = 2;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(13, 91);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(103, 20);
            this.itemsListboxLabel.TabIndex = 3;
            this.itemsListboxLabel.Text = "Store Items";
            this.itemsListboxLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(256, 161);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(114, 31);
            this.addToCart.TabIndex = 4;
            this.addToCart.Text = "Add To Cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // shoppingCartListLabel
            // 
            this.shoppingCartListLabel.AutoSize = true;
            this.shoppingCartListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shoppingCartListLabel.Location = new System.Drawing.Point(372, 91);
            this.shoppingCartListLabel.Name = "shoppingCartListLabel";
            this.shoppingCartListLabel.Size = new System.Drawing.Size(124, 20);
            this.shoppingCartListLabel.TabIndex = 6;
            this.shoppingCartListLabel.Text = "Shopping Cart";
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 20;
            this.shoppingCartListbox.Location = new System.Drawing.Point(376, 114);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(233, 144);
            this.shoppingCartListbox.TabIndex = 5;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(495, 264);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(114, 31);
            this.makePurchase.TabIndex = 7;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.shoppingCartListLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemsListbox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.BookShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label shoppingCartListLabel;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Button makePurchase;
    }
}

