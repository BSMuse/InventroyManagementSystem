namespace InventroyManagementSystem
{
    partial class Add_Part
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
            inHouseRadio = new RadioButton();
            outsourcedRadio = new RadioButton();
            label2 = new Label();
            idTextBox = new TextBox();
            inventoryTextBox = new TextBox();
            label3 = new Label();
            priceTextBox = new TextBox();
            label4 = new Label();
            maxTextBox = new TextBox();
            label5 = new Label();
            conditionalTextBox = new TextBox();
            conditionalLabel = new Label();
            nameTextBox = new TextBox();
            label7 = new Label();
            minTextBox = new TextBox();
            label8 = new Label();
            saveBtn = new Button();
            exitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 12);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.Checked = true;
            inHouseRadio.Location = new Point(136, 13);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(127, 34);
            inHouseRadio.TabIndex = 1;
            inHouseRadio.TabStop = true;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            inHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.Location = new Point(358, 15);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(151, 34);
            outsourcedRadio.TabIndex = 2;
            outsourcedRadio.TabStop = true;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            outsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 82);
            label2.Name = "label2";
            label2.Size = new Size(34, 30);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(310, 82);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(261, 37);
            idTextBox.TabIndex = 4;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(310, 188);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.Size = new Size(261, 37);
            inventoryTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 195);
            label3.Name = "label3";
            label3.Size = new Size(105, 30);
            label3.TabIndex = 5;
            label3.Text = "Inventory";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(310, 242);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(261, 37);
            priceTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 245);
            label4.Name = "label4";
            label4.Size = new Size(124, 30);
            label4.TabIndex = 7;
            label4.Text = "Price / Cost";
            // 
            // maxTextBox
            // 
            maxTextBox.Location = new Point(311, 296);
            maxTextBox.Name = "maxTextBox";
            maxTextBox.Size = new Size(86, 37);
            maxTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 303);
            label5.Name = "label5";
            label5.Size = new Size(54, 30);
            label5.TabIndex = 9;
            label5.Text = "Max";
            // 
            // conditionalTextBox
            // 
            conditionalTextBox.Location = new Point(310, 349);
            conditionalTextBox.Name = "conditionalTextBox";
            conditionalTextBox.Size = new Size(261, 37);
            conditionalTextBox.TabIndex = 12;
            // 
            // conditionalLabel
            // 
            conditionalLabel.AutoSize = true;
            conditionalLabel.Location = new Point(93, 349);
            conditionalLabel.Name = "conditionalLabel";
            conditionalLabel.Size = new Size(170, 30);
            conditionalLabel.TabIndex = 11;
            conditionalLabel.Text = "Company Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(310, 135);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(261, 37);
            nameTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 135);
            label7.Name = "label7";
            label7.Size = new Size(71, 30);
            label7.TabIndex = 13;
            label7.Text = "Name";
            // 
            // minTextBox
            // 
            minTextBox.Location = new Point(517, 296);
            minTextBox.Name = "minTextBox";
            minTextBox.Size = new Size(86, 37);
            minTextBox.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(431, 299);
            label8.Name = "label8";
            label8.Size = new Size(50, 30);
            label8.TabIndex = 15;
            label8.Text = "Min";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(517, 404);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(112, 34);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(660, 404);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(112, 34);
            exitBtn.TabIndex = 19;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Add_Part_Inhouse
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitBtn);
            Controls.Add(saveBtn);
            Controls.Add(minTextBox);
            Controls.Add(label8);
            Controls.Add(nameTextBox);
            Controls.Add(label7);
            Controls.Add(conditionalTextBox);
            Controls.Add(conditionalLabel);
            Controls.Add(maxTextBox);
            Controls.Add(label5);
            Controls.Add(priceTextBox);
            Controls.Add(label4);
            Controls.Add(inventoryTextBox);
            Controls.Add(label3);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(outsourcedRadio);
            Controls.Add(inHouseRadio);
            Controls.Add(label1);
            Name = "Add_Part_Inhouse";
            Text = "Add_Part";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton inHouseRadio;
        private RadioButton outsourcedRadio;
        private Label label2;
        private TextBox idTextBox;
        private TextBox inventoryTextBox;
        private Label label3;
        private TextBox priceTextBox;
        private Label label4;
        private TextBox maxTextBox;
        private Label label5;
        private TextBox conditionalTextBox;
        private Label conditionalLabel;
        private TextBox nameTextBox;
        private Label label7;
        private TextBox minTextBox;
        private Label label8;
        private Button saveBtn;
        private Button exitBtn;
    }
}