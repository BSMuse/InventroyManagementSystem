using InventroyManagementSystem;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (Inventory.AllParts.Count == 0)
            {
                Inventory.AllParts.Add(new Part(1, "Gear", 10.50m, 5, 1, 10, true, 101, ""));
                Inventory.AllParts.Add(new Part(2, "Bolt", 2.99m, 10, 5, 15, false, 0, "Alex Corp"));
            }
            if (Inventory.Products.Count == 0)
            {
                Product testProduct = new Product(1, "Bike", 99.99m, 2, 1, 5);
                testProduct.AssociatedParts.Add(Inventory.AllParts[0]);
                Inventory.Products.Add(testProduct);
            }

            partsGridView.DataSource = Inventory.AllParts;
            productGridView.DataSource = Inventory.Products;

            foreach (DataGridViewColumn column in partsGridView.Columns)
            {
                if (column.DataPropertyName == "PartID")
                    column.HeaderText = "Part ID";
            }

            foreach (DataGridViewColumn column in productGridView.Columns)
            {
                if (column.DataPropertyName == "ProductID")
                    column.HeaderText = "Product ID";
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPart_Click(object sender, EventArgs e)
        {
            new Add_Part().ShowDialog();
        }

        private void modifyPart_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            var part = (Part)partsGridView.SelectedRows[0].DataBoundItem;
            new Modify_Part(part).ShowDialog();
        }

        private void deletePart_Click(object sender, EventArgs e)
        {
            if (partsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a part to delete.");
                return;
            }
            Part selectedPart = (Part)partsGridView.SelectedRows[0].DataBoundItem;
            if (Inventory.Products.Any(p => p.AssociatedParts.Contains(selectedPart)))
                MessageBox.Show("Cannot delete part associated with a product.");
            else if (MessageBox.Show("Delete this part?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Inventory.removePart(selectedPart.PartID);
        }

        private void searchPartBtn_Click(object sender, EventArgs e)
        {
            string search = partSearchTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(search))
                partsGridView.DataSource = Inventory.AllParts;
            else
                partsGridView.DataSource = new BindingList<Part>(
                    Inventory.AllParts.Where(p => p.PartID.ToString().Contains(search) || p.Name.ToLower().Contains(search)).ToList());
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            new Add_Product().ShowDialog();
        }

        private void modifyProduct_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to modify.");
                return;
            }
            var product = (Product)productGridView.SelectedRows[0].DataBoundItem;
            new Modify_Product(product).ShowDialog();
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            Product selectedProduct = (Product)productGridView.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("Delete this product?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Inventory.removeProduct(selectedProduct.ProductID);
        }

        private void searchProductBtn_Click(object sender, EventArgs e)
        {
            string search = productSearchTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(search))
                productGridView.DataSource = Inventory.Products;
            else
                productGridView.DataSource = new BindingList<Product>(
                    Inventory.Products.Where(p => p.ProductID.ToString().Contains(search) || p.Name.ToLower().Contains(search)).ToList());
        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Not used currently
        }
    }
}