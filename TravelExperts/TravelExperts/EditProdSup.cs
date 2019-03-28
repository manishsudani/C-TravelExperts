using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /*
     * Date: January 2019
     * Creators: Manish Sudani
     */

    public partial class EditProdSup : Form
    {
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

        public string SelectedProductName = null; // set prod to null
        public string SelectedSupplierName = null; // set supp to null
        List<Product> products = new List<Product>(); // list of products
        List<Supplier> suppliers = new List<Supplier>(); // list of supplies

        public EditProdSup()
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

        // on load check if supplier or product is being edited and display respective messages
        private void EditProdSup_Load(object sender, EventArgs e)
        {
            products = ProductDB.GetProducts();
            suppliers = SupplierDB.GetSuppliers();

            if (SelectedProductName != null)
            {
                btnUpdate.Text = "Update Product";
                lblProdSup.Text = "Selected Product Name:";
                txtProdSup.Text = SelectedProductName;
                txtProdSup.MaxLength = 50;
            }
            else
            {
                btnUpdate.Text = "Update Supplier";
                lblProdSup.Text = "Selected Supplier Name:";
                txtProdSup.Text = SelectedSupplierName;
                txtProdSup.MaxLength = 255;
            }
        }

        // call the proper function for insertion of the the supplier of the product and put to upper for the suppliers
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedProductName != null)
            {
                if (Validator.IsProvided(txtProdSup, "A Product Name"))
                {
                    string newName = txtProdSup.Text;
                    bool valid = false;

                    foreach (Product p in products)
                    {
                        if (p.ProdName == newName)
                        {
                            MessageBox.Show("Product already exists, choose a unique product name");
                            valid = false;
                            break;
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    if (valid == true)
                    {
                        try
                        {
                            ProductDB.UpdateProduct(SelectedProductName, newName);
                            MessageBox.Show(SelectedProductName + " was updated to " + newName);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Update was unsuccessful, try again");
                        }
                    }
                }
            }
            else if (Validator.IsProvided(txtProdSup, "A Supplier name"))
            {
                string newName = txtProdSup.Text.ToUpper();
                bool valid = false;

                foreach (Supplier s in suppliers)
                {
                    if (s.SupName == newName)
                    {
                        MessageBox.Show("Supplier already exists, choose a unique supplier name");
                        valid = false;
                        break;
                    }
                    else
                    {
                        valid = true;
                    }
                }
                if (valid == true)
                {
                    try
                    {
                        SupplierDB.UpdateSupplier(SelectedSupplierName, newName);
                        MessageBox.Show(SelectedSupplierName + " was updated to " + newName);
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Update was unsuccessful, try again");
                    }
                }
            }
        }
    }
}
