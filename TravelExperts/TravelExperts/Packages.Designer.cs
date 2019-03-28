namespace TravelExperts
{
    partial class Packages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packages));
            this.txtPkgName = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPkgAgncCommish = new System.Windows.Forms.TextBox();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBackPage = new System.Windows.Forms.Button();
            this.btnLinkProSup = new System.Windows.Forms.Button();
            this.lstPackages = new System.Windows.Forms.ListView();
            this.colPkgID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAgComm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditPackage = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPkgName
            // 
            this.txtPkgName.Location = new System.Drawing.Point(300, 394);
            this.txtPkgName.MaxLength = 50;
            this.txtPkgName.Name = "txtPkgName";
            this.txtPkgName.Size = new System.Drawing.Size(286, 21);
            this.txtPkgName.TabIndex = 4;
            this.txtPkgName.Enter += new System.EventHandler(this.txtPkgName_Enter);
            this.txtPkgName.Leave += new System.EventHandler(this.txtPkgName_Leave);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(523, 468);
            this.dtpStartDate.MaxDate = new System.DateTime(2998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(87, 21);
            this.dtpStartDate.TabIndex = 8;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            this.dtpStartDate.Enter += new System.EventHandler(this.dtpStartDate_Enter);
            this.dtpStartDate.Leave += new System.EventHandler(this.dtpStartDate_Leave);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(523, 494);
            this.dtpEndDate.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(87, 21);
            this.dtpEndDate.TabIndex = 9;
            this.dtpEndDate.Enter += new System.EventHandler(this.dtpEndDate_Enter);
            this.dtpEndDate.Leave += new System.EventHandler(this.dtpEndDate_Leave);
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(300, 420);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(286, 41);
            this.txtPkgDesc.TabIndex = 5;
            this.txtPkgDesc.Enter += new System.EventHandler(this.txtPkgDesc_Enter);
            this.txtPkgDesc.Leave += new System.EventHandler(this.txtPkgDesc_Leave);
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(300, 468);
            this.txtPkgBasePrice.MaxLength = 12;
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(83, 21);
            this.txtPkgBasePrice.TabIndex = 6;
            this.txtPkgBasePrice.TextChanged += new System.EventHandler(this.txtPkgBasePrice_TextChanged);
            this.txtPkgBasePrice.Enter += new System.EventHandler(this.txtPkgBasePrice_Enter);
            this.txtPkgBasePrice.Leave += new System.EventHandler(this.txtPkgBasePrice_Leave);
            // 
            // txtPkgAgncCommish
            // 
            this.txtPkgAgncCommish.Location = new System.Drawing.Point(300, 494);
            this.txtPkgAgncCommish.MaxLength = 12;
            this.txtPkgAgncCommish.Name = "txtPkgAgncCommish";
            this.txtPkgAgncCommish.Size = new System.Drawing.Size(83, 21);
            this.txtPkgAgncCommish.TabIndex = 7;
            this.txtPkgAgncCommish.Enter += new System.EventHandler(this.txtPkgAgncCommish_Enter);
            this.txtPkgAgncCommish.Leave += new System.EventHandler(this.txtPkgAgncCommish_Leave);
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.BackColor = System.Drawing.Color.Green;
            this.btnAddPackage.FlatAppearance.BorderSize = 0;
            this.btnAddPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPackage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPackage.ForeColor = System.Drawing.Color.White;
            this.btnAddPackage.Location = new System.Drawing.Point(300, 520);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(119, 35);
            this.btnAddPackage.TabIndex = 10;
            this.btnAddPackage.Text = "&Add Package";
            this.btnAddPackage.UseVisualStyleBackColor = false;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Image = global::TravelExperts.Properties.Resources.icons8_shutdown_48;
            this.btnExit.Location = new System.Drawing.Point(756, 530);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 75);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackPage
            // 
            this.btnBackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBackPage.FlatAppearance.BorderSize = 0;
            this.btnBackPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackPage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackPage.Image = global::TravelExperts.Properties.Resources.icons8_return_48;
            this.btnBackPage.Location = new System.Drawing.Point(0, 530);
            this.btnBackPage.Name = "btnBackPage";
            this.btnBackPage.Size = new System.Drawing.Size(90, 75);
            this.btnBackPage.TabIndex = 12;
            this.btnBackPage.Text = "Back";
            this.btnBackPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBackPage.UseVisualStyleBackColor = false;
            this.btnBackPage.Click += new System.EventHandler(this.btnBackPage_Click);
            // 
            // btnLinkProSup
            // 
            this.btnLinkProSup.BackColor = System.Drawing.Color.Green;
            this.btnLinkProSup.FlatAppearance.BorderSize = 0;
            this.btnLinkProSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkProSup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinkProSup.ForeColor = System.Drawing.Color.White;
            this.btnLinkProSup.Location = new System.Drawing.Point(488, 275);
            this.btnLinkProSup.Name = "btnLinkProSup";
            this.btnLinkProSup.Size = new System.Drawing.Size(98, 54);
            this.btnLinkProSup.TabIndex = 3;
            this.btnLinkProSup.Text = "&Link to add Products to Packages";
            this.btnLinkProSup.UseVisualStyleBackColor = false;
            this.btnLinkProSup.Click += new System.EventHandler(this.btnLinkProSup_Click);
            // 
            // lstPackages
            // 
            this.lstPackages.BackColor = System.Drawing.Color.DimGray;
            this.lstPackages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPkgID,
            this.colName,
            this.colStartDate,
            this.colEndDate,
            this.colDesc,
            this.colBasePrice,
            this.colAgComm});
            this.lstPackages.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPackages.ForeColor = System.Drawing.Color.White;
            this.lstPackages.FullRowSelect = true;
            this.lstPackages.GridLines = true;
            this.lstPackages.Location = new System.Drawing.Point(28, 116);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(745, 153);
            this.lstPackages.TabIndex = 0;
            this.lstPackages.UseCompatibleStateImageBehavior = false;
            this.lstPackages.View = System.Windows.Forms.View.Details;
            this.lstPackages.SelectedIndexChanged += new System.EventHandler(this.lstPackages_SelectedIndexChanged);
            // 
            // colPkgID
            // 
            this.colPkgID.Text = "Package ID";
            this.colPkgID.Width = 0;
            // 
            // colName
            // 
            this.colName.Text = "Package Name";
            this.colName.Width = 111;
            // 
            // colStartDate
            // 
            this.colStartDate.Text = "Start Date";
            this.colStartDate.Width = 97;
            // 
            // colEndDate
            // 
            this.colEndDate.Text = "End Date";
            this.colEndDate.Width = 80;
            // 
            // colDesc
            // 
            this.colDesc.Text = "Description";
            this.colDesc.Width = 175;
            // 
            // colBasePrice
            // 
            this.colBasePrice.Text = "Base Price";
            this.colBasePrice.Width = 76;
            // 
            // colAgComm
            // 
            this.colAgComm.Text = "Agency Commision";
            this.colAgComm.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Package Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Package End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Package Start Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Package Description:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Package Agency Commision:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Package Base Price:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(364, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 54);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete Selected Package";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditPackage
            // 
            this.btnEditPackage.BackColor = System.Drawing.Color.Green;
            this.btnEditPackage.Enabled = false;
            this.btnEditPackage.FlatAppearance.BorderSize = 0;
            this.btnEditPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPackage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPackage.ForeColor = System.Drawing.Color.White;
            this.btnEditPackage.Location = new System.Drawing.Point(236, 275);
            this.btnEditPackage.Name = "btnEditPackage";
            this.btnEditPackage.Size = new System.Drawing.Size(101, 54);
            this.btnEditPackage.TabIndex = 1;
            this.btnEditPackage.Text = "&Edit Selected Package";
            this.btnEditPackage.UseVisualStyleBackColor = false;
            this.btnEditPackage.Click += new System.EventHandler(this.btnEditPackage_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(504, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "List of Current Packages.  Select a package to edit or delete";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(298, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Fill out form to add a new Package";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(444, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "&Clear form";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.label1.Size = new System.Drawing.Size(846, 40);
            this.label1.TabIndex = 26;
            this.label1.Text = "Travel Experts Admin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // Packages
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEditPackage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPackages);
            this.Controls.Add(this.btnLinkProSup);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackPage);
            this.Controls.Add(this.btnAddPackage);
            this.Controls.Add(this.txtPkgAgncCommish);
            this.Controls.Add(this.txtPkgBasePrice);
            this.Controls.Add(this.txtPkgDesc);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtPkgName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Packages";
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.Packages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPkgName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgAgncCommish;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBackPage;
        private System.Windows.Forms.Button btnLinkProSup;
        private System.Windows.Forms.ListView lstPackages;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colStartDate;
        private System.Windows.Forms.ColumnHeader colEndDate;
        private System.Windows.Forms.ColumnHeader colDesc;
        private System.Windows.Forms.ColumnHeader colBasePrice;
        private System.Windows.Forms.ColumnHeader colAgComm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ColumnHeader colPkgID;
        private System.Windows.Forms.Button btnEditPackage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}