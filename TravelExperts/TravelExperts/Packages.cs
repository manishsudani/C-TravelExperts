﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /* 
     * Date: January 2019
     * Creator: Manish Sudani
     */
    public partial class Packages : Form
    {
        List<TravelPackage> packages; // list of packages
        private TravelPackage selectedPackage; // selected package for edit/delete

        public Packages()
        {
            InitializeComponent();
        }

        // validate text boxes and put fields into an object to be added into database
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtPkgName, "Package Name") &&
            Validator.IsProvided(txtPkgDesc, "Package Description") &&
            Validator.IsProvided(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgAgncCommish, "Agency Commision"))
                {
                if (dtpStartDate.Value < dtpEndDate.Value)
                {
                    // get input fields
                    string pkgName = txtPkgName.Text;
                    DateTime pkgStartDate = dtpStartDate.Value;
                    DateTime pkgEndDate = dtpEndDate.Value;
                    string pkgDesc = txtPkgDesc.Text;
                    decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    decimal pkgAgncCommish = 0;
                    if (txtPkgAgncCommish.Text == "")
                    {
                        txtPkgAgncCommish.Text = null;
                    }
                    else
                    {
                        pkgAgncCommish = Convert.ToDecimal(txtPkgAgncCommish.Text);
                    }

                    //create package class
                    TravelPackage package = new TravelPackage();
                    package.PkgName = pkgName;
                    package.PkgStartDate = pkgStartDate;
                    package.PkgEndDate = pkgEndDate;
                    package.PkgDesc = pkgDesc;
                    package.PkgBasePrice = pkgBasePrice;
                    package.PkgAgencyCommission = pkgAgncCommish;

                    // call insert command
                    TravelPackageDB.AddPackage(package);

                    // clear fields
                    txtPkgName.Text = "";
                    dtpStartDate.Value = DateTime.Today;
                    txtPkgDesc.Text = "";
                    txtPkgBasePrice.Text = "";
                    txtPkgAgncCommish.Text = "";

                    displayPackages();
                }
                else
                {
                    MessageBox.Show("The Start Date must be before the End Date");
                }
            }
        }

        //Display all packages from list
        private void displayPackages()
        {
            // lists items in list view in specified sub list items
            lstPackages.Items.Clear();
            packages = TravelPackageDB.GetTavelPackage();
            int i = 0;
            foreach (TravelPackage package in packages)
            {
                ListViewItem lvi = new ListViewItem(package.PkgID.ToString(), i); // new list view item starting with package name
                lvi.SubItems.Add(package.PkgName);
                lvi.SubItems.Add((package.PkgStartDate).ToShortDateString());
                lvi.SubItems.Add((package.PkgEndDate).ToShortDateString());
                lvi.SubItems.Add(package.PkgDesc);
                lvi.SubItems.Add(package.PkgBasePrice.ToString("c"));
                lvi.SubItems.Add(package.PkgAgencyCommission.ToString("c"));
                
                lstPackages.Items.Add(lvi);
                i++;
            }
        }

        // Close Application
        // By Nathan Armstrong
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //close this form
        //By Nathan Armstrong
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Open new Packages_Products_Suppliers form and hide this one
        // By Nathan Armstrong
        private void btnLinkProSup_Click(object sender, EventArgs e)
        {
            Packages_Products_Suppliers ppsForm = new Packages_Products_Suppliers();
            ppsForm.Show();
            this.Hide();
            ppsForm.FormClosing += PPS_FormClosing;
        }

        // on Packages_Products_Suppliers closing re show this form it is is hidden
        // By Nathan Armstrong
        private void PPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            displayPackages();
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        // When form loads get all data from DB and display it
        private void Packages_Load(object sender, EventArgs e)
        {
            displayPackages();
            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // set the mindate for the date time picker
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // load selected package items from list table into object to pass into delete or 
        private void lstPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditPackage.Enabled = true;
            btnDelete.Enabled = true;
            selectedPackage = new TravelPackage();
            selectedPackage.PkgID = Convert.ToInt32(lstPackages.FocusedItem.SubItems[0].Text);
            selectedPackage.PkgName = lstPackages.FocusedItem.SubItems[1].Text;
            selectedPackage.PkgStartDate = Convert.ToDateTime(lstPackages.FocusedItem.SubItems[2].Text);
            selectedPackage.PkgEndDate = Convert.ToDateTime(lstPackages.FocusedItem.SubItems[3].Text);
            selectedPackage.PkgDesc = Convert.ToString(lstPackages.FocusedItem.SubItems[4].Text);
            selectedPackage.PkgBasePrice = Convert.ToDecimal(lstPackages.FocusedItem.SubItems[5].Text.Substring(1));
            selectedPackage.PkgAgencyCommission = Convert.ToDecimal(lstPackages.FocusedItem.SubItems[6].Text.Substring(1));
        }

        // regex for base price, legacy not used
        private void txtPkgBasePrice_TextChanged(object sender, EventArgs e)
        {
            string previousInput = "";
            Regex r = new Regex(@"[0-9]+(\\.[0-9][0-9]?)?"); // This is the main part, can be altered to match any desired form or limitations
            Match m = r.Match(txtPkgBasePrice.Text);
            if (m.Success)
            {
                previousInput = txtPkgBasePrice.Text;
            }
            else
            {
                txtPkgBasePrice.Text = previousInput;
            }
        }

        // confirm deleteion and call delete package function, inserting in the selected package
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstPackages.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a package from the list");
            }
            else
            {
                int selectedPkg = Convert.ToInt32(lstPackages.SelectedItems[0].Text);
                string selectedPkgName = lstPackages.FocusedItem.SubItems[1].Text;

                var confirmDelete = MessageBox.Show("Are you sure you want to delete " + selectedPkgName + "?", "Confirm?", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    try
                    {
                        TravelPackageDB.DeletePackage(selectedPkg);
                        MessageBox.Show("Package deleted successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Package could not be deleted, contact the administrator");
                    }
                    displayPackages();
                }
            }
        }

        // calls the edit package form and puts in the selected package into an object into that form 
        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            if (lstPackages.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a package from the list");
            }
            else
            {
                EditPackage ppsForm = new EditPackage();
                ppsForm.package = selectedPackage;
                ppsForm.Show();
                this.Hide();
                ppsForm.FormClosing += PPS_FormClosing;
            }
        }

        // clears the fields on click
        private void button1_Click(object sender, EventArgs e)
        {
            txtPkgName.Text = "";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgncCommish.Text = "";
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

    // all the following functions give leave and and enter events to disable 

        private void txtPkgName_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgDesc_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgBasePrice_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgAgncCommish_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgName_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgDesc_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgBasePrice_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void txtPkgAgncCommish_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void dtpStartDate_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void dtpEndDate_Leave(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void dtpStartDate_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        private void dtpEndDate_Enter(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnEditPackage.Enabled = false;
        }

        // This adds the event handler for the control
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
    }
}
