using InventoryManagementSystem;

namespace InventroyManagementSystem
{
    public partial class Modify_Part : Form
    {
        private Part originalPart;
        public Modify_Part(Part part)
        {
            InitializeComponent();
            originalPart = part;
            idTextBox.Text = part.PartID.ToString();
            nameTextBox.Text = part.Name;
            inventoryTextBox.Text = part.InStock.ToString();
            priceTextBox.Text = part.Price.ToString();
            maxTextBox.Text = part.Max.ToString();
            minTextBox.Text = part.Min.ToString();
            inHouseRadio.Checked = part.IsInHouse;
            outsourcedRadio.Checked = !part.IsInHouse;
            conditionalLabel.Text = part.IsInHouse ? "Machine ID" : "Company Name";
            conditionalTextBox.Text = part.IsInHouse ? part.MachineID.ToString() : part.CompanyName;
            idTextBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(inventoryTextBox.Text, out int inventory) || !int.TryParse(maxTextBox.Text, out int max) ||
        !int.TryParse(minTextBox.Text, out int min) || !decimal.TryParse(priceTextBox.Text, out decimal price) ||
        (inHouseRadio.Checked && !int.TryParse(conditionalTextBox.Text, out int machineID)))
            {
                MessageBox.Show("Enter valid numeric values.");
                return;
            }
            if (min > max || inventory < min || inventory > max)
            {
                MessageBox.Show("Min must be <= Inventory <= Max.");
                return;
            }

            Part updatedPart = new Part(
                int.Parse(idTextBox.Text), nameTextBox.Text, price, inventory, min, max,
                inHouseRadio.Checked, inHouseRadio.Checked ? int.Parse(conditionalTextBox.Text) : 0,
                outsourcedRadio.Checked ? conditionalTextBox.Text : ""
            );
            Inventory.updatePart(int.Parse(idTextBox.Text), updatedPart);
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Machine ID";
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            conditionalLabel.Text = "Company Name";
        }
    }
}
