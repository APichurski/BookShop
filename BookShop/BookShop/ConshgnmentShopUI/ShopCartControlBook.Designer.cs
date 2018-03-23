namespace ConshgnmentShopUI
{
    partial class ShopCartControlBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameBookCart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCart = new System.Windows.Forms.Label();
            this.labelCartPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameBookCart
            // 
            this.labelNameBookCart.AutoSize = true;
            this.labelNameBookCart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameBookCart.Location = new System.Drawing.Point(92, 28);
            this.labelNameBookCart.Name = "labelNameBookCart";
            this.labelNameBookCart.Size = new System.Drawing.Size(116, 23);
            this.labelNameBookCart.TabIndex = 0;
            this.labelNameBookCart.Text = "Nazwa ksiazki";
            this.labelNameBookCart.Click += new System.EventHandler(this.labelNameBookCart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 43);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelCart
            // 
            this.labelCart.AutoSize = true;
            this.labelCart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCart.Location = new System.Drawing.Point(230, 28);
            this.labelCart.Name = "labelCart";
            this.labelCart.Size = new System.Drawing.Size(49, 23);
            this.labelCart.TabIndex = 2;
            this.labelCart.Text = "Cena:";
            // 
            // labelCartPrice
            // 
            this.labelCartPrice.AutoSize = true;
            this.labelCartPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCartPrice.Location = new System.Drawing.Point(285, 28);
            this.labelCartPrice.Name = "labelCartPrice";
            this.labelCartPrice.Size = new System.Drawing.Size(53, 23);
            this.labelCartPrice.TabIndex = 3;
            this.labelCartPrice.Text = "0,0 zl";
            // 
            // ShopCartControlBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCartPrice);
            this.Controls.Add(this.labelCart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNameBookCart);
            this.Name = "ShopCartControlBook";
            this.Size = new System.Drawing.Size(664, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameBookCart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCart;
        private System.Windows.Forms.Label labelCartPrice;
    }
}
