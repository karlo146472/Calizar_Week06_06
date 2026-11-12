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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" &&
                txtPassword.Text == "1234")
            {
                MessageBox.Show("Login succesful!");
                var inventoryForm = new frmInventory();
                inventoryForm.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("Invalid username or password.");
                txtUsername.Clear();
                txtPassword.Clear();
            
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
