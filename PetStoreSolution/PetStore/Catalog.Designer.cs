namespace PetStore
{
    partial class Catalog
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
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.textBoxCategID = new System.Windows.Forms.TextBox();
            this.textBoxProdID = new System.Windows.Forms.TextBox();
            this.labelCategID = new System.Windows.Forms.Label();
            this.labelProdID = new System.Windows.Forms.Label();
            this.textBoxItemID = new System.Windows.Forms.TextBox();
            this.labelItemID = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.Location = new System.Drawing.Point(12, 178);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.ReadOnly = true;
            this.richTextBoxDisplay.Size = new System.Drawing.Size(797, 267);
            this.richTextBoxDisplay.TabIndex = 0;
            this.richTextBoxDisplay.Text = "";
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(102, 43);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(75, 23);
            this.buttonCategories.TabIndex = 0;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(272, 43);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonProducts.TabIndex = 0;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(452, 43);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(75, 23);
            this.buttonItems.TabIndex = 0;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // textBoxCategID
            // 
            this.textBoxCategID.Location = new System.Drawing.Point(176, 82);
            this.textBoxCategID.Name = "textBoxCategID";
            this.textBoxCategID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategID.TabIndex = 1;
            this.textBoxCategID.Text = "100";
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.Location = new System.Drawing.Point(388, 82);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.Size = new System.Drawing.Size(100, 20);
            this.textBoxProdID.TabIndex = 2;
            this.textBoxProdID.Text = "2001";
            // 
            // labelCategID
            // 
            this.labelCategID.AutoSize = true;
            this.labelCategID.Location = new System.Drawing.Point(107, 85);
            this.labelCategID.Name = "labelCategID";
            this.labelCategID.Size = new System.Drawing.Size(63, 13);
            this.labelCategID.TabIndex = 0;
            this.labelCategID.Text = "Category ID";
            // 
            // labelProdID
            // 
            this.labelProdID.AutoSize = true;
            this.labelProdID.Location = new System.Drawing.Point(324, 85);
            this.labelProdID.Name = "labelProdID";
            this.labelProdID.Size = new System.Drawing.Size(58, 13);
            this.labelProdID.TabIndex = 0;
            this.labelProdID.Text = "Product ID";
            // 
            // textBoxItemID
            // 
            this.textBoxItemID.Location = new System.Drawing.Point(586, 82);
            this.textBoxItemID.Name = "textBoxItemID";
            this.textBoxItemID.Size = new System.Drawing.Size(100, 20);
            this.textBoxItemID.TabIndex = 3;
            this.textBoxItemID.Text = "6000";
            // 
            // labelItemID
            // 
            this.labelItemID.AutoSize = true;
            this.labelItemID.Location = new System.Drawing.Point(539, 85);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(41, 13);
            this.labelItemID.TabIndex = 4;
            this.labelItemID.Text = "Item ID";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(629, 43);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCart.TabIndex = 5;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(397, 138);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckout.TabIndex = 6;
            this.buttonCheckout.Text = "Checkout!";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(642, 108);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(44, 20);
            this.textBoxQuantity.TabIndex = 4;
            this.textBoxQuantity.Text = "4";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(590, 111);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantity";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 457);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.labelItemID);
            this.Controls.Add(this.textBoxItemID);
            this.Controls.Add(this.labelProdID);
            this.Controls.Add(this.labelCategID);
            this.Controls.Add(this.textBoxProdID);
            this.Controls.Add(this.textBoxCategID);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.TextBox textBoxCategID;
        private System.Windows.Forms.TextBox textBoxProdID;
        private System.Windows.Forms.Label labelCategID;
        private System.Windows.Forms.Label labelProdID;
        private System.Windows.Forms.TextBox textBoxItemID;
        private System.Windows.Forms.Label labelItemID;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
    }
}