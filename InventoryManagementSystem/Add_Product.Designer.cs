namespace InventoryManagementSystem
{
    partial class Add_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            idTextBox = new TextBox();
            minTextBox = new TextBox();
            priceTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            nameTextBox = new TextBox();
            maxTextBox = new TextBox();
            allPartsGrid = new DataGridView();
            associatedPartsGrid = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            searchButton = new Button();
            searchTextBox = new TextBox();
            addPartButton = new Button();
            deletePartButton = new Button();
            cancelButton = new Button();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)allPartsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 73);
            label1.Name = "label1";
            label1.Size = new Size(34, 30);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 125);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 178);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 2;
            label3.Text = "Inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 228);
            label4.Name = "label4";
            label4.Size = new Size(60, 30);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 278);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 4;
            label5.Text = "Max";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 278);
            label6.Name = "label6";
            label6.Size = new Size(50, 30);
            label6.TabIndex = 5;
            label6.Text = "Min";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(217, 72);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(150, 37);
            idTextBox.TabIndex = 6;
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(308, 278);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(76, 37);
            minTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(217, 223);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(150, 37);
            priceTextBox.TabIndex = 10;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(217, 171);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(150, 37);
            inventoryTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(217, 124);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 37);
            nameTextBox.TabIndex = 12;
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(117, 278);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(76, 37);
            maxTextBox.TabIndex = 13;
            // 
            // allPartsGrid
            // 
            allPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allPartsGrid.Location = new Point(466, 125);
            allPartsGrid.Name = "allPartsGrid";
            allPartsGrid.RowHeadersWidth = 62;
            allPartsGrid.Size = new Size(961, 217);
            allPartsGrid.TabIndex = 14;
            // 
            // associatedPartsGrid
            // 
            associatedPartsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            associatedPartsGrid.Location = new Point(466, 437);
            associatedPartsGrid.Name = "associatedPartsGrid";
            associatedPartsGrid.RowHeadersWidth = 62;
            associatedPartsGrid.Size = new Size(961, 201);
            associatedPartsGrid.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 9);
            label7.Name = "label7";
            label7.Size = new Size(134, 30);
            label7.TabIndex = 16;
            label7.Text = "Add Product";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 92);
            label8.Name = "label8";
            label8.Size = new Size(176, 30);
            label8.TabIndex = 17;
            label8.Text = "All candiate Parts";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(466, 404);
            label9.Name = "label9";
            label9.Size = new Size(334, 30);
            label9.TabIndex = 18;
            label9.Text = "Parts Associated with this Product";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(997, 46);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1139, 48);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(288, 37);
            searchTextBox.TabIndex = 20;
            // 
            // addPartButton
            // 
            addPartButton.Location = new Point(1315, 363);
            addPartButton.Name = "addPartButton";
            addPartButton.Size = new Size(112, 34);
            addPartButton.TabIndex = 21;
            addPartButton.Text = "Add";
            addPartButton.UseVisualStyleBackColor = true;
            addPartButton.Click += addPartButton_Click;
            // 
            // deletePartButton
            // 
            deletePartButton.Location = new Point(1315, 661);
            deletePartButton.Name = "deletePartButton";
            deletePartButton.Size = new Size(112, 34);
            deletePartButton.TabIndex = 22;
            deletePartButton.Text = "Delete";
            deletePartButton.UseVisualStyleBackColor = true;
            deletePartButton.Click += deletePartButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(1315, 725);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1197, 725);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(112, 34);
            saveButton.TabIndex = 24;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 995);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(deletePartButton);
            Controls.Add(addPartButton);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(associatedPartsGrid);
            Controls.Add(allPartsGrid);
            Controls.Add(maxTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(inventoryTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(minTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Add_Product";
            Text = "Add_Product";
            ((System.ComponentModel.ISupportInitialize)allPartsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idTextBox;
        private TextBox minTextBox;
        private TextBox priceTextBox;
        private TextBox inventoryTextBox;
        private TextBox nameTextBox;
        private TextBox maxTextBox;
        private DataGridView allPartsGrid;
        private DataGridView associatedPartsGrid;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button searchButton;
        private TextBox searchTextBox;
        private Button addPartButton;
        private Button deletePartButton;
        private Button cancelButton;
        private Button saveButton;
    }
}