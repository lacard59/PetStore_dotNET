namespace PetStore
{
    partial class HomeForm
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
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(938, 24);
            this.menuStripHome.TabIndex = 0;
            this.menuStripHome.Text = "menuStripHome";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerLoginToolStripMenuItem,
            this.catalogCategoriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // registerLoginToolStripMenuItem
            // 
            this.registerLoginToolStripMenuItem.Name = "registerLoginToolStripMenuItem";
            this.registerLoginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerLoginToolStripMenuItem.Text = "Register/Login";
            this.registerLoginToolStripMenuItem.Click += new System.EventHandler(this.registerLoginToolStripMenuItem_Click);
            // 
            // catalogCategoriesToolStripMenuItem
            // 
            this.catalogCategoriesToolStripMenuItem.Enabled = false;
            this.catalogCategoriesToolStripMenuItem.Name = "catalogCategoriesToolStripMenuItem";
            this.catalogCategoriesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.catalogCategoriesToolStripMenuItem.Text = "Catalog";
            this.catalogCategoriesToolStripMenuItem.Click += new System.EventHandler(this.catalogCategoriesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 562);
            this.Controls.Add(this.menuStripHome);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripHome;
            this.Name = "HomeForm";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}