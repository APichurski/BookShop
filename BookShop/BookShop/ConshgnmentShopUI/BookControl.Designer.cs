namespace ConshgnmentShopUI
{
    partial class BookControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookControl));
            this.BookNameLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceBookLabel = new System.Windows.Forms.Label();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            this.SuspendLayout();
            // 
            // BookNameLabel
            // 
            resources.ApplyResources(this.BookNameLabel, "BookNameLabel");
            this.BookNameLabel.Name = "BookNameLabel";
            this.BookNameLabel.Click += new System.EventHandler(this.BookNameLabel_Click);
            // 
            // AddToCartButton
            // 
            resources.ApplyResources(this.AddToCartButton, "AddToCartButton");
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PriceBookLabel
            // 
            resources.ApplyResources(this.PriceBookLabel, "PriceBookLabel");
            this.PriceBookLabel.Name = "PriceBookLabel";
            // 
            // pictureBook
            // 
            resources.ApplyResources(this.pictureBook, "pictureBook");
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.TabStop = false;
            // 
            // BookControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBook);
            this.Controls.Add(this.PriceBookLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.BookNameLabel);
            this.Name = "BookControl";
            this.Load += new System.EventHandler(this.BookControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookNameLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceBookLabel;
        private System.Windows.Forms.PictureBox pictureBook;
    }
}
