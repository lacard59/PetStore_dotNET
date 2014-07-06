namespace PetStore
{
    partial class CatalogDatabase
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
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonItems = new System.Windows.Forms.Button();
            this.textBoxCategID = new System.Windows.Forms.TextBox();
            this.textBoxProdID = new System.Windows.Forms.TextBox();
            this.labelCategID = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.Size = new System.Drawing.Size(636, 321);
            this.dataGridViewCatalog.TabIndex = 0;
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(44, 42);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(75, 23);
            this.buttonCategories.TabIndex = 1;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.buttonCategories_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(266, 42);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(75, 23);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Products";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(529, 42);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(75, 23);
            this.buttonItems.TabIndex = 3;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.buttonItems_Click);
            // 
            // textBoxCategID
            // 
            this.textBoxCategID.Location = new System.Drawing.Point(266, 83);
            this.textBoxCategID.Name = "textBoxCategID";
            this.textBoxCategID.Size = new System.Drawing.Size(75, 20);
            this.textBoxCategID.TabIndex = 4;
            // 
            // textBoxProdID
            // 
            this.textBoxProdID.Location = new System.Drawing.Point(529, 83);
            this.textBoxProdID.Name = "textBoxProdID";
            this.textBoxProdID.Size = new System.Drawing.Size(75, 20);
            this.textBoxProdID.TabIndex = 5;
            // 
            // labelCategID
            // 
            this.labelCategID.AutoSize = true;
            this.labelCategID.Location = new System.Drawing.Point(197, 86);
            this.labelCategID.Name = "labelCategID";
            this.labelCategID.Size = new System.Drawing.Size(63, 13);
            this.labelCategID.TabIndex = 6;
            this.labelCategID.Text = "Category ID";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(465, 86);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(58, 13);
            this.labelProductID.TabIndex = 7;
            this.labelProductID.Text = "Product ID";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 459);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelCategID);
            this.Controls.Add(this.textBoxProdID);
            this.Controls.Add(this.textBoxCategID);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.dataGridViewCatalog);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonItems;
        private System.Windows.Forms.TextBox textBoxCategID;
        private System.Windows.Forms.TextBox textBoxProdID;
        private System.Windows.Forms.Label labelCategID;
        private System.Windows.Forms.Label labelProductID;
    }
}