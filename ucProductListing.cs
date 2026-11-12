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
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "Box", "Kilogram", "Liter", "cm", "ft",
                            "g", "lb", "in", "L", "m", "oz"};

        List<string> shopingList = new List<string>();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.AddRange(units);
            cmbUnit.SelectedIndex = 0;

            lbxItems.DataSource = shopingList;
        }

        private void updateGUI()
        {
            lbxItems.DataSource = null;
            lbxItems.DataSource = shopingList;
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtDescription.Text;
            double amount = double.Parse(txtAmount.Text);
            string unit = cmbUnit.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) && !string.IsNullOrEmpty(amount.ToString())) 
            {

                string row = $"{item}\t\t {amount} {unit}";
                shopingList.Add(row);
                updateGUI();

                MessageBox.Show("Item added");
                txtAmount.Clear();
                txtDescription.Clear();
                cmbUnit.Refresh();
                txtDescription.Focus();
            }
        
        }
    }
}
