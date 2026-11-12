using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calizar_Week06_05
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void showPage(UserControl page)
        {
            pnlCont.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlCont.Controls.Add(page);
        }


        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage(new ucHomePage());
        }

        private void productListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage(new ucProductListing());
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you sure you want to exit?, ",
                                             "Exit Confirmation", MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

  
    }
}
