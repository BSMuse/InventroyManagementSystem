namespace InventoryManagementSystem
{
    partial class Main
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
            partsGridView = new DataGridView();
            productGridView = new DataGridView();
            label1 = new Label();
            searchProductBtn = new Button();
            productSearchTextBox = new TextBox();
            partSearchTextBox = new TextBox();
            searchPartBtn = new Button();
            modifyProduct = new Button();
            addProduct = new Button();
            deleteProduct = new Button();
            deletePart = new Button();
            addPart = new Button();
            modifyPart = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)partsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).BeginInit();
            SuspendLayout();
            // 
            // partsGridView
            // 
            partsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            partsGridView.Location = new Point(12, 197);
            partsGridView.Name = "partsGridView";
            partsGridView.RowHeadersWidth = 62;
            partsGridView.Size = new Size(965, 225);
            partsGridView.TabIndex = 0;
            // 
            // productGridView
            // 
            productGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productGridView.Location = new Point(1001, 197);
            productGridView.Name = "productGridView";
            productGridView.RowHeadersWidth = 62;
            productGridView.Size = new Size(965, 225);
            productGridView.TabIndex = 1;
            productGridView.CellContentClick += productGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(315, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            // 
            // searchProductBtn
            // 
            searchProductBtn.Location = new Point(1531, 154);
            searchProductBtn.Name = "searchProductBtn";
            searchProductBtn.Size = new Size(112, 34);
            searchProductBtn.TabIndex = 3;
            searchProductBtn.Text = "Search";
            searchProductBtn.UseVisualStyleBackColor = true;
            searchProductBtn.Click += searchProductBtn_Click;
            // 
            // productSearchTextBox
            // 
            productSearchTextBox.Location = new Point(1661, 154);
            productSearchTextBox.Name = "productSearchTextBox";
            productSearchTextBox.Size = new Size(305, 37);
            productSearchTextBox.TabIndex = 5;
            // 
            // partSearchTextBox
            // 
            partSearchTextBox.Location = new Point(672, 154);
            partSearchTextBox.Name = "partSearchTextBox";
            partSearchTextBox.Size = new Size(305, 37);
            partSearchTextBox.TabIndex = 7;
            // 
            // searchPartBtn
            // 
            searchPartBtn.Location = new Point(542, 154);
            searchPartBtn.Name = "searchPartBtn";
            searchPartBtn.Size = new Size(112, 34);
            searchPartBtn.TabIndex = 6;
            searchPartBtn.Text = "Search";
            searchPartBtn.UseVisualStyleBackColor = true;
            searchPartBtn.Click += searchPartBtn_Click;
            // 
            // modifyProduct
            // 
            modifyProduct.Location = new Point(1736, 442);
            modifyProduct.Name = "modifyProduct";
            modifyProduct.Size = new Size(112, 34);
            modifyProduct.TabIndex = 8;
            modifyProduct.Text = "Modify";
            modifyProduct.UseVisualStyleBackColor = true;
            modifyProduct.Click += modifyProduct_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(1618, 442);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(112, 34);
            addProduct.TabIndex = 10;
            addProduct.Text = "Add";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.Location = new Point(1854, 442);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(112, 34);
            deleteProduct.TabIndex = 11;
            deleteProduct.Text = "Delete";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // deletePart
            // 
            deletePart.Location = new Point(869, 442);
            deletePart.Name = "deletePart";
            deletePart.Size = new Size(112, 34);
            deletePart.TabIndex = 14;
            deletePart.Text = "Delete";
            deletePart.UseVisualStyleBackColor = true;
            deletePart.Click += deletePart_Click;
            // 
            // addPart
            // 
            addPart.Location = new Point(633, 442);
            addPart.Name = "addPart";
            addPart.Size = new Size(112, 34);
            addPart.TabIndex = 13;
            addPart.Text = "Add";
            addPart.UseVisualStyleBackColor = true;
            addPart.Click += addPart_Click;
            // 
            // modifyPart
            // 
            modifyPart.Location = new Point(751, 442);
            modifyPart.Name = "modifyPart";
            modifyPart.Size = new Size(112, 34);
            modifyPart.TabIndex = 12;
            modifyPart.Text = "Modify";
            modifyPart.UseVisualStyleBackColor = true;
            modifyPart.Click += modifyPart_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(2049, 515);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2196, 570);
            Controls.Add(exitBtn);
            Controls.Add(deletePart);
            Controls.Add(addPart);
            Controls.Add(modifyPart);
            Controls.Add(deleteProduct);
            Controls.Add(addProduct);
            Controls.Add(modifyProduct);
            Controls.Add(partSearchTextBox);
            Controls.Add(searchPartBtn);
            Controls.Add(productSearchTextBox);
            Controls.Add(searchProductBtn);
            Controls.Add(label1);
            Controls.Add(productGridView);
            Controls.Add(partsGridView);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)partsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView partsGridView;
        private DataGridView productGridView;
        private Label label1;
        private Button searchProductBtn;
        private TextBox productSearchTextBox;
        private TextBox partSearchTextBox;
        private Button searchPartBtn;
        private Button modifyProduct;
        private Button addProduct;
        private Button deleteProduct;
        private Button deletePart;
        private Button addPart;
        private Button modifyPart;
        private Button exitBtn;
    }
}