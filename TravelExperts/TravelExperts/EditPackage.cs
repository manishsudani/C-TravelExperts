using System;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /* 
     * Date: January 2019
     * Creator: Manish Sudani
     */

    public partial class EditPackage : Form
    {
        public TravelPackage package;

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

        public EditPackage()
        {
            InitializeComponent();
        }

        // back to previous form
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // exit app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Loads travel package and sets text boxes to contain package info
        // sets date time picker min dates
        private void EditPackage_Load(object sender, EventArgs e)
        {
            txtPkgID.Text = package.PkgID.ToString();
            txtPkgName.Text = package.PkgName.ToString();
            txtPkgDesc.Text = package.PkgDesc.ToString();
            txtPkgBasePrice.Text = package.PkgBasePrice.ToString();
            txtPkgAgncComm.Text = package.PkgAgencyCommission.ToString();
            dtpStartDate.Value = package.PkgStartDate;
            dtpEndDate.Value = package.PkgEndDate;

            dtpStartDate.MinDate = package.PkgStartDate;
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // sets datetime picker min date
        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value.AddDays(1);
        }

        // on click validate text fields and create new package for insertion
        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            if (Validator.IsProvided(txtPkgName, "Package Name") &&
            Validator.IsProvided(txtPkgDesc, "Package Description") &&
            Validator.IsProvided(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgBasePrice, "Package Base Price") &&
            Validator.IsNonNegativeMoney(txtPkgAgncComm, "Agency Commision"))
            {
                if (dtpStartDate.Value < dtpEndDate.Value)
                {
                    // get input fields
                    string pkgName = txtPkgName.Text;
                    DateTime pkgStartDate = dtpStartDate.Value.Date;
                    DateTime pkgEndDate = dtpEndDate.Value.Date;
                    string pkgDesc = txtPkgDesc.Text;
                    decimal pkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    decimal pkgAgncCommish = 0;
                    if (txtPkgAgncComm.Text == "")
                    {
                        txtPkgAgncComm.Text = null;
                    }
                    else
                    {
                        pkgAgncCommish = Convert.ToDecimal(txtPkgAgncComm.Text);
                    }

                    //create new newpackage class
                    TravelPackage newpackage = new TravelPackage();
                    newpackage.PkgName = pkgName;
                    newpackage.PkgStartDate = pkgStartDate;
                    newpackage.PkgEndDate = pkgEndDate;
                    newpackage.PkgDesc = pkgDesc;
                    newpackage.PkgBasePrice = pkgBasePrice;
                    newpackage.PkgAgencyCommission = pkgAgncCommish;

                    // call insert function and insert new package with old package
                    if (TravelPackageDB.UpdatePackage(package, newpackage))
                    {
                        MessageBox.Show("Package was updated successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error while updating, try again");
                    }
                }
            }
        }
    }
}
