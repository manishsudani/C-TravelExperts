namespace TravelExperts
{
    partial class Packages_Products_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packages_Products_Suppliers));
            this.btnLink = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.cbProSup = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lsbPackageProducts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLink
            // 
            this.btnLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLink.Enabled = false;
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.Location = new System.Drawing.Point(180, 155);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(344, 37);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "&Link Package to Product Suppliers";
            this.btnLink.UseVisualStyleBackColor = false;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = global::TravelExperts.Properties.Resources.icons8_shutdown_48;
            this.btnExit.Location = new System.Drawing.Point(632, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 5;
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
            this.btnBackPage.Location = new System.Drawing.Point(0, 374);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 4;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // cbPackage
            // 
            this.cbPackage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Location = new System.Drawing.Point(29, 117);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(309, 25);
            this.cbPackage.TabIndex = 0;
            this.cbPackage.SelectedIndexChanged += new System.EventHandler(this.cbPackage_SelectedIndexChanged);
            this.cbPackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPackage_KeyDown);
            this.cbPackage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPackage_KeyPress);
            // 
            // cbProSup
            // 
            this.cbProSup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProSup.FormattingEnabled = true;
            this.cbProSup.Location = new System.Drawing.Point(388, 117);
            this.cbProSup.Name = "cbProSup";
            this.cbProSup.Size = new System.Drawing.Size(306, 25);
            this.cbProSup.TabIndex = 1;
            this.cbProSup.SelectedIndexChanged += new System.EventHandler(this.cbProSup_SelectedIndexChanged);
            this.cbProSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbProSup_KeyDown);
            this.cbProSup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbProSup_KeyPress);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(316, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lsbPackageProducts
            // 
            this.lsbPackageProducts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbPackageProducts.FormattingEnabled = true;
            this.lsbPackageProducts.ItemHeight = 17;
            this.lsbPackageProducts.Location = new System.Drawing.Point(267, 229);
            this.lsbPackageProducts.Name = "lsbPackageProducts";
            this.lsbPackageProducts.Size = new System.Drawing.Size(180, 140);
            this.lsbPackageProducts.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current Package Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select a Package:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Select a product to add:";
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
            this.label1.Size = new System.Drawing.Size(722, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // Packages_Products_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbPackageProducts);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cbProSup);
            this.Controls.Add(this.cbPackage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnLink);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Packages_Products_Suppliers";
            this.Load += new System.EventHandler(this.Packages_Products_Suppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.ComboBox cbProSup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lsbPackageProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}