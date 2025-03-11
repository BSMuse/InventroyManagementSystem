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
    public partial class Modify_Product : Form
    {
        private BindingList<Part> associatedParts;
        private Product originalProduct;
        public Modify_Product(Product product)
        {
            InitializeComponent();
            associatedParts = new BindingList<Part>(product.AssociatedParts.ToList());
            originalProduct = product;
            idTextBox.Text = originalProduct.ProductID.ToString();
            nameTextBox.Text = originalProduct.Name;
            inventoryTextBox.Text = originalProduct.InStock.ToString();
            priceTextBox.Text = originalProduct.Price.ToString();
            maxTextBox.Text = originalProduct.Max.ToString();
            minTextBox.Text = originalProduct.Min.ToString();
            idTextBox.Enabled = false;
            allPartGrid.DataSource = Inventory.AllParts;
            associatedPartsGrid.DataSource = associatedParts;

            foreach (DataGridViewColumn column in allPartGrid.Columns)
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
            if (allPartGrid.SelectedRows.Count > 0)
            {
                Part selectedPart = (Part)allPartGrid.SelectedRows[0].DataBoundItem;
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

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a product name.");
                return;
            }

            Product updatedProduct = new Product(
                originalProduct.ProductID, 
                nameTextBox.Text,
                price,
                inventory,
                min,
                max
            );
            updatedProduct.AssociatedParts = originalProduct.AssociatedParts; 

            Inventory.updateProduct(originalProduct.ProductID, updatedProduct);
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
                allPartGrid.DataSource = Inventory.AllParts;
            }
            else
            {
                var filteredParts = Inventory.AllParts
                    .Where(p => p.PartID.ToString().Contains(search) || p.Name.ToLower().Contains(search))
                    .ToList();
                allPartGrid.DataSource = new BindingList<Part>(filteredParts);
            }
        }
    }
}
