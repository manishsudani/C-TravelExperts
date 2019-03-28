using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TravelExpertsClasses;

namespace TravelExperts
{
    /*
     * Date: January 2019
     * Creator: Manish Sudani
     */
    public partial class AdminPannel : Form
    {
      
        List<TravelPackage> travelPackage = new List<TravelPackage>(); // empty list of travelPackage
        public AdminPannel()
        {
            InitializeComponent();
          
        }
        
        //On click open package form and hide current form
      
        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            Packages pForm = new Packages();
            pForm.Show();
            this.Hide();
            pForm.FormClosing += Packages_FormClosing;
        }

        // when Packages from is closed it will show this form again
      
        private void Packages_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        //On click open  Suppliers/Products and hide current form
     
        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers_Products spForm = new Suppliers_Products();
            spForm.Show();
            this.Hide();
            spForm.FormClosing += Supplies_Products_FormClosing;
        }

        //when supplies and products form is closed show this form again
       
        private void Supplies_Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        // Close Application
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // opens product form
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Packages_Products_Suppliers addProd = new Packages_Products_Suppliers();
            addProd.Show();
            this.Hide();
            addProd.FormClosing += Supplies_Products_FormClosing;
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
