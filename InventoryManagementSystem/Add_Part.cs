using InventoryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventroyManagementSystem
{
    public partial class Add_Part : Form
    {
        public Add_Part()
        {
            InitializeComponent();
            idTextBox.Text = (Inventory.AllParts.Any() ? Inventory.AllParts.Max(p => p.PartID) + 1 : 1).ToString();
            idTextBox.Enabled = false;
            inHouseRadio.Checked = true;
            conditionalLabel.Text = "Machine ID";
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Machine ID";
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Company Name";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(inventoryTextBox.Text, out int inventory) || !int.TryParse(maxTextBox.Text, out int max) ||
        !int.TryParse(minTextBox.Text, out int min) || !decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                MessageBox.Show("Enter valid numeric values.");
                return;
            }
            if (min > max || inventory < min || inventory > max)
            {
                MessageBox.Show("Min must be <= Inventory <= Max.");
                return;
            }
            if (inHouseRadio.Checked && !int.TryParse(conditionalTextBox.Text, out int machineID))
            {
                MessageBox.Show("Machine ID must be a number.");
                return;
            }

            Part newPart = new Part(
                int.Parse(idTextBox.Text), nameTextBox.Text, price, inventory, min, max,
                inHouseRadio.Checked, inHouseRadio.Checked ? int.Parse(conditionalTextBox.Text) : 0,
                outsourcedRadio.Checked ? conditionalTextBox.Text : ""
            );
            Inventory.addPart(newPart);
            Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
