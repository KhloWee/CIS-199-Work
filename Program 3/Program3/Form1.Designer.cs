namespace Program3
{
    partial class Form1
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
            this.stateInLabel = new System.Windows.Forms.Label();
            this.productInLabel = new System.Windows.Forms.Label();
            this.quantityInLabel = new System.Windows.Forms.Label();
            this.initialCostOutLabel = new System.Windows.Forms.Label();
            this.discountOutLabel = new System.Windows.Forms.Label();
            this.taxOutLabel = new System.Windows.Forms.Label();
            this.totalOutLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.productNumInBox = new System.Windows.Forms.TextBox();
            this.quantityInBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.initialCostOutBox = new System.Windows.Forms.Label();
            this.discountOutBox = new System.Windows.Forms.Label();
            this.taxOutBox = new System.Windows.Forms.Label();
            this.totalOutBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stateInLabel
            // 
            this.stateInLabel.AutoSize = true;
            this.stateInLabel.Location = new System.Drawing.Point(19, 63);
            this.stateInLabel.Name = "stateInLabel";
            this.stateInLabel.Size = new System.Drawing.Size(45, 17);
            this.stateInLabel.TabIndex = 0;
            this.stateInLabel.Text = "State:";
            // 
            // productInLabel
            // 
            this.productInLabel.AutoSize = true;
            this.productInLabel.Location = new System.Drawing.Point(18, 117);
            this.productInLabel.Name = "productInLabel";
            this.productInLabel.Size = new System.Drawing.Size(61, 17);
            this.productInLabel.TabIndex = 1;
            this.productInLabel.Text = "Product:";
            // 
            // quantityInLabel
            // 
            this.quantityInLabel.AutoSize = true;
            this.quantityInLabel.Location = new System.Drawing.Point(19, 161);
            this.quantityInLabel.Name = "quantityInLabel";
            this.quantityInLabel.Size = new System.Drawing.Size(65, 17);
            this.quantityInLabel.TabIndex = 2;
            this.quantityInLabel.Text = "Quantity:";
            // 
            // initialCostOutLabel
            // 
            this.initialCostOutLabel.AutoSize = true;
            this.initialCostOutLabel.Location = new System.Drawing.Point(34, 291);
            this.initialCostOutLabel.Name = "initialCostOutLabel";
            this.initialCostOutLabel.Size = new System.Drawing.Size(76, 17);
            this.initialCostOutLabel.TabIndex = 3;
            this.initialCostOutLabel.Text = "Initial Cost:";
            // 
            // discountOutLabel
            // 
            this.discountOutLabel.AutoSize = true;
            this.discountOutLabel.Location = new System.Drawing.Point(34, 331);
            this.discountOutLabel.Name = "discountOutLabel";
            this.discountOutLabel.Size = new System.Drawing.Size(111, 17);
            this.discountOutLabel.TabIndex = 4;
            this.discountOutLabel.Text = "Discounted Cost";
            // 
            // taxOutLabel
            // 
            this.taxOutLabel.AutoSize = true;
            this.taxOutLabel.Location = new System.Drawing.Point(34, 370);
            this.taxOutLabel.Name = "taxOutLabel";
            this.taxOutLabel.Size = new System.Drawing.Size(35, 17);
            this.taxOutLabel.TabIndex = 5;
            this.taxOutLabel.Text = "Tax:";
            // 
            // totalOutLabel
            // 
            this.totalOutLabel.AutoSize = true;
            this.totalOutLabel.Location = new System.Drawing.Point(34, 417);
            this.totalOutLabel.Name = "totalOutLabel";
            this.totalOutLabel.Size = new System.Drawing.Size(80, 17);
            this.totalOutLabel.TabIndex = 6;
            this.totalOutLabel.Text = "Total Price:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "KY",
            "OH",
            "IN",
            "IL"});
            this.stateComboBox.Location = new System.Drawing.Point(187, 63);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 24);
            this.stateComboBox.TabIndex = 7;
            // 
            // productNumInBox
            // 
            this.productNumInBox.Location = new System.Drawing.Point(187, 112);
            this.productNumInBox.Name = "productNumInBox";
            this.productNumInBox.Size = new System.Drawing.Size(121, 22);
            this.productNumInBox.TabIndex = 8;
            // 
            // quantityInBox
            // 
            this.quantityInBox.Location = new System.Drawing.Point(187, 161);
            this.quantityInBox.Name = "quantityInBox";
            this.quantityInBox.Size = new System.Drawing.Size(121, 22);
            this.quantityInBox.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(198, 220);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 31);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // initialCostOutBox
            // 
            this.initialCostOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutBox.Location = new System.Drawing.Point(187, 285);
            this.initialCostOutBox.Name = "initialCostOutBox";
            this.initialCostOutBox.Size = new System.Drawing.Size(121, 23);
            this.initialCostOutBox.TabIndex = 11;
            // 
            // discountOutBox
            // 
            this.discountOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountOutBox.Location = new System.Drawing.Point(187, 325);
            this.discountOutBox.Name = "discountOutBox";
            this.discountOutBox.Size = new System.Drawing.Size(121, 23);
            this.discountOutBox.TabIndex = 12;
            // 
            // taxOutBox
            // 
            this.taxOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutBox.Location = new System.Drawing.Point(187, 364);
            this.taxOutBox.Name = "taxOutBox";
            this.taxOutBox.Size = new System.Drawing.Size(121, 23);
            this.taxOutBox.TabIndex = 13;
            // 
            // totalOutBox
            // 
            this.totalOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutBox.Location = new System.Drawing.Point(187, 411);
            this.totalOutBox.Name = "totalOutBox";
            this.totalOutBox.Size = new System.Drawing.Size(121, 23);
            this.totalOutBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 519);
            this.Controls.Add(this.totalOutBox);
            this.Controls.Add(this.taxOutBox);
            this.Controls.Add(this.discountOutBox);
            this.Controls.Add(this.initialCostOutBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.quantityInBox);
            this.Controls.Add(this.productNumInBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.totalOutLabel);
            this.Controls.Add(this.taxOutLabel);
            this.Controls.Add(this.discountOutLabel);
            this.Controls.Add(this.initialCostOutLabel);
            this.Controls.Add(this.quantityInLabel);
            this.Controls.Add(this.productInLabel);
            this.Controls.Add(this.stateInLabel);
            this.Name = "Form1";
            this.Text = "Program 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stateInLabel;
        private System.Windows.Forms.Label productInLabel;
        private System.Windows.Forms.Label quantityInLabel;
        private System.Windows.Forms.Label initialCostOutLabel;
        private System.Windows.Forms.Label discountOutLabel;
        private System.Windows.Forms.Label taxOutLabel;
        private System.Windows.Forms.Label totalOutLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox productNumInBox;
        private System.Windows.Forms.TextBox quantityInBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label initialCostOutBox;
        private System.Windows.Forms.Label discountOutBox;
        private System.Windows.Forms.Label taxOutBox;
        private System.Windows.Forms.Label totalOutBox;
    }
}

