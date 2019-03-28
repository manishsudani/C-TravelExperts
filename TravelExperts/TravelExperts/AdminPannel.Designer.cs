namespace TravelExperts
{
    partial class AdminPannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPannel));
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnAddSupPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.Teal;
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAddPackage.ForeColor = System.Drawing.Color.White;
            this.btnAddPackage.Image = global::TravelExperts.Properties.Resources.icons8_airport_48;
            this.btnAddPackage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPackage.Location = new System.Drawing.Point(12, 58);
            this.btnAddPackage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(161, 100);
            this.btnAddPackage.TabIndex = 0;
            this.btnAddPackage.Text = "Add, Edit or Delete &Package";
            this.btnAddPackage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddPackage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnAddSupPro
            // 
            this.btnAddSupPro.BackColor = System.Drawing.Color.Teal;
            this.btnAddSupPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupPro.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAddSupPro.ForeColor = System.Drawing.Color.White;
            this.btnAddSupPro.Image = global::TravelExperts.Properties.Resources.icons8_manager_48;
            this.btnAddSupPro.Location = new System.Drawing.Point(12, 181);
            this.btnAddSupPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddSupPro.Name = "btnAddSupPro";
            this.btnAddSupPro.Size = new System.Drawing.Size(161, 100);
            this.btnAddSupPro.TabIndex = 1;
            this.btnAddSupPro.Text = "Add, Edit or Delete &Suppliers/Products";
            this.btnAddSupPro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddSupPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddSupPro.UseVisualStyleBackColor = false;
            this.btnAddSupPro.Click += new System.EventHandler(this.button2_Click);
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
            this.label1.Size = new System.Drawing.Size(649, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = global::TravelExperts.Properties.Resources.icons8_shutdown_48;
            this.btnExit.Location = new System.Drawing.Point(12, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 90);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Teal;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::TravelExperts.Properties.Resources.icons8_sell_stock_48;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 303);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(161, 100);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "&Add Products to Existing Packages";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // AdminPannel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::TravelExperts.Properties.Resources.TravelSuit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(649, 527);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddSupPro);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPannel";
            this.Text = "Travel Experts Admin Pannel";
          
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddSupPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddPackage;
    }
}

