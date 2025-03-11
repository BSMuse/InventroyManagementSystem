using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Add_Product : Form
    {
        private BindingList<Part> associatedParts = new BindingList<Part>();
        public Add_Product()
        {
            InitializeComponent();
            idTextBox.Text = (Inventory.Products.Any() ? Inventory.Products.Max(p => p.ProductID) + 1 : 1).ToString();
            idTextBox.Enabled = false;
            allPartsGrid.DataSource = Inventory.AllParts;
            associatedPartsGrid.DataSource = associatedParts;

            foreach (DataGridViewColumn column in allPartsGrid.Columns)
            {
                if (column.DataPropertyName == "PartID")
                    column.HeaderText = "Part ID";
            }

            foreach (DataGridViewColumn column in associatedPartsGrid.Columns)
            {
                if (column.DataPropertyName == "PartID")
                    column.HeaderText = "Part ID";
            }
        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (allPartsGrid.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)allPartsGrid.SelectedRows[0].DataBoundItem;
                associatedParts.Add(selectedPart);
                associatedPartsGrid.DataSource = null;
                associatedPartsGrid.DataSource = associatedParts;
            }
        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            if (associatedPartsGrid.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)associatedPartsGrid.SelectedRows[0].DataBoundItem;
                associatedParts.Remove(selectedPart);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
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

            Product newProduct = new Product(int.Parse(idTextBox.Text), nameTextBox.Text, price, inventory, min, max);
            foreach (Part part in associatedParts)
                newProduct.AssociatedParts.Add(part);
            Inventory.addProduct(newProduct);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchTextBox.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(search))
            {
                allPartsGrid.DataSource = Inventory.AllParts;
            }
            else
            {
                var filteredParts = Inventory.AllParts
                    .Where(p => p.PartID.ToString().Contains(search) || p.Name.ToLower().Contains(search))
                    .ToList();
                allPartsGrid.DataSource = new BindingList<Part>(filteredParts);
            }
        }
    }
}
