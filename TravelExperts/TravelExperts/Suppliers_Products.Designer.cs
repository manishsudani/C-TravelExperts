namespace TravelExperts
{
    partial class Suppliers_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers_Products));
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbSuppliers = new System.Windows.Forms.ListBox();
            this.txtProducts = new System.Windows.Forms.TextBox();
            this.txtSuppliers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.btnLinkPS = new System.Windows.Forms.Button();
            this.btnLinkToPackage = new System.Windows.Forms.Button();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(128, 151);
            this.lbProducts.MultiColumn = true;
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(184, 228);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbSuppliers
            // 
            this.lbSuppliers.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuppliers.FormattingEnabled = true;
            this.lbSuppliers.ItemHeight = 16;
            this.lbSuppliers.Location = new System.Drawing.Point(349, 151);
            this.lbSuppliers.Name = "lbSuppliers";
            this.lbSuppliers.Size = new System.Drawing.Size(184, 228);
            this.lbSuppliers.TabIndex = 1;
            this.lbSuppliers.SelectedIndexChanged += new System.EventHandler(this.lbSuppliers_SelectedIndexChanged);
            // 
            // txtProducts
            // 
            this.txtProducts.Location = new System.Drawing.Point(128, 415);
            this.txtProducts.MaxLength = 50;
            this.txtProducts.Name = "txtProducts";
            this.txtProducts.Size = new System.Drawing.Size(184, 20);
            this.txtProducts.TabIndex = 2;
            // 
            // txtSuppliers
            // 
            this.txtSuppliers.Location = new System.Drawing.Point(349, 415);
            this.txtSuppliers.MaxLength = 255;
            this.txtSuppliers.Name = "txtSuppliers";
            this.txtSuppliers.Size = new System.Drawing.Size(184, 20);
            this.txtSuppliers.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product to add:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier to add:";
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.Green;
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducts.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Location = new System.Drawing.Point(128, 445);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(184, 25);
            this.btnAddProducts.TabIndex = 3;
            this.btnAddProducts.Text = "Add &Products";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.BackColor = System.Drawing.Color.Green;
            this.btnAddSuppliers.FlatAppearance.BorderSize = 0;
            this.btnAddSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSuppliers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSuppliers.Location = new System.Drawing.Point(349, 441);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(184, 25);
            this.btnAddSuppliers.TabIndex = 7;
            this.btnAddSuppliers.Text = "Add &Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = false;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // btnLinkPS
            // 
            this.btnLinkPS.BackColor = System.Drawing.Color.Green;
            this.btnLinkPS.Enabled = false;
            this.btnLinkPS.FlatAppearance.BorderSize = 0;
            this.btnLinkPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkPS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkPS.Location = new System.Drawing.Point(578, 279);
            this.btnLinkPS.Name = "btnLinkPS";
            this.btnLinkPS.Size = new System.Drawing.Size(213, 28);
            this.btnLinkPS.TabIndex = 12;
            this.btnLinkPS.Text = "Link Product to Supplier";
            this.btnLinkPS.UseVisualStyleBackColor = false;
            this.btnLinkPS.Click += new System.EventHandler(this.btnLinkPS_Click);
            // 
            // btnLinkToPackage
            // 
            this.btnLinkToPackage.BackColor = System.Drawing.Color.Green;
            this.btnLinkToPackage.FlatAppearance.BorderSize = 0;
            this.btnLinkToPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkToPackage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkToPackage.Location = new System.Drawing.Point(579, 391);
            this.btnLinkToPackage.Name = "btnLinkToPackage";
            this.btnLinkToPackage.Size = new System.Drawing.Size(212, 60);
            this.btnLinkToPackage.TabIndex = 14;
            this.btnLinkToPackage.Text = "&Link to add Products to Packages";
            this.btnLinkToPackage.UseVisualStyleBackColor = false;
            this.btnLinkToPackage.Click += new System.EventHandler(this.btnLinkToPackage_Click);
            // 
            // cbProducts
            // 
            this.cbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(578, 189);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(213, 21);
            this.cbProducts.TabIndex = 10;
            this.cbProducts.SelectedIndexChanged += new System.EventHandler(this.cbProducts_SelectedIndexChanged);
            this.cbProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbProducts_KeyDown);
            this.cbProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProducts_KeyPress);
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(579, 242);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(212, 21);
            this.cbSuppliers.TabIndex = 11;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            this.cbSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSuppliers_KeyDown);
            this.cbSuppliers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSuppliers_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Products:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Suppliers:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(647, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 26);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(221, 476);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(91, 30);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "&Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteSupplier.Enabled = false;
            this.btnDeleteSupplier.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.Location = new System.Drawing.Point(445, 476);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteSupplier.TabIndex = 9;
            this.btnDeleteSupplier.Text = "&Delete Supplier";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditProduct.Enabled = false;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditProduct.Location = new System.Drawing.Point(128, 476);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(87, 30);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "&Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditSupplier.Enabled = false;
            this.btnEditSupplier.FlatAppearance.BorderSize = 0;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditSupplier.Location = new System.Drawing.Point(349, 476);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(80, 30);
            this.btnEditSupplier.TabIndex = 8;
            this.btnEditSupplier.Text = "&Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "List of Products:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "List of Suppliers:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(124, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(409, 48);
            this.label8.TabIndex = 22;
            this.label8.Text = "List of Products and Suppliers to add, delete and edit";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 76);
            this.label9.TabIndex = 23;
            this.label9.Text = "Select a product and a supplier to link a product to a supplier";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Image = global::TravelExperts.Properties.Resources.icons8_beach_48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = global::TravelExperts.Properties.Resources.icons8_shutdown_48;
            this.btnExit.Location = new System.Drawing.Point(804, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBackPage.FlatAppearance.BorderSize = 0;
            this.btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackPage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackPage.Image = global::TravelExperts.Properties.Resources.icons8_return_48;
            this.btnBackPage.Location = new System.Drawing.Point(0, 476);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 15;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // Suppliers_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(894, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.cbProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnLinkToPackage);
            this.Controls.Add(this.btnLinkPS);
            this.Controls.Add(this.btnAddSuppliers);
            this.Controls.Add(this.btnAddProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuppliers);
            this.Controls.Add(this.txtProducts);
            this.Controls.Add(this.lbSuppliers);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.label9);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Suppliers_Products";
            this.Text = "Suppliers_Products";
            this.Load += new System.EventHandler(this.Suppliers_Products_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.ListBox lbSuppliers;
        private System.Windows.Forms.TextBox txtProducts;
        private System.Windows.Forms.TextBox txtSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.Button btnLinkPS;
        private System.Windows.Forms.Button btnLinkToPackage;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}