namespace Program_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.underLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.firstRoomInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.underlayInput = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.yardLabel = new System.Windows.Forms.Label();
            this.hardwoodLabel = new System.Windows.Forms.Label();
            this.underCostLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.yardOutBox = new System.Windows.Forms.Label();
            this.hardwoodOutBox = new System.Windows.Forms.Label();
            this.underlayOutBox = new System.Windows.Forms.Label();
            this.laborOutBox = new System.Windows.Forms.Label();
            this.totalOutBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(73, 73);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(302, 32);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Max width of the room (ft):";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(73, 143);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(312, 32);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Max length of the room (ft):";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(100, 215);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(290, 32);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price of the wood (sq. yd):";
            // 
            // underLabel
            // 
            this.underLabel.AutoSize = true;
            this.underLabel.Location = new System.Drawing.Point(50, 290);
            this.underLabel.Name = "underLabel";
            this.underLabel.Size = new System.Drawing.Size(482, 32);
            this.underLabel.TabIndex = 3;
            this.underLabel.Text = "Is underlayment Needed? (1 = YES, 0 = NO)";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(100, 357);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(432, 32);
            this.roomLabel.TabIndex = 4;
            this.roomLabel.Text = "Is this the first room? (1 = YES, 0 = NO)";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(565, 73);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(200, 39);
            this.widthInput.TabIndex = 5;
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(565, 143);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(200, 39);
            this.lengthInput.TabIndex = 5;
            // 
            // firstRoomInput
            // 
            this.firstRoomInput.Location = new System.Drawing.Point(565, 353);
            this.firstRoomInput.Name = "firstRoomInput";
            this.firstRoomInput.Size = new System.Drawing.Size(200, 39);
            this.firstRoomInput.TabIndex = 5;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(565, 213);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(200, 39);
            this.priceInput.TabIndex = 5;
            // 
            // underlayInput
            // 
            this.underlayInput.Location = new System.Drawing.Point(565, 283);
            this.underlayInput.Name = "underlayInput";
            this.underlayInput.Size = new System.Drawing.Size(200, 39);
            this.underlayInput.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(175, 787);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(314, 46);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate Estimate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // yardLabel
            // 
            this.yardLabel.AutoSize = true;
            this.yardLabel.Location = new System.Drawing.Point(156, 428);
            this.yardLabel.Name = "yardLabel";
            this.yardLabel.Size = new System.Drawing.Size(108, 32);
            this.yardLabel.TabIndex = 7;
            this.yardLabel.Text = "Sq Yards:";
            // 
            // hardwoodLabel
            // 
            this.hardwoodLabel.AutoSize = true;
            this.hardwoodLabel.Location = new System.Drawing.Point(156, 499);
            this.hardwoodLabel.Name = "hardwoodLabel";
            this.hardwoodLabel.Size = new System.Drawing.Size(179, 32);
            this.hardwoodLabel.TabIndex = 7;
            this.hardwoodLabel.Text = "Hardwood cost:";
            // 
            // underCostLabel
            // 
            this.underCostLabel.AutoSize = true;
            this.underCostLabel.Location = new System.Drawing.Point(156, 570);
            this.underCostLabel.Name = "underCostLabel";
            this.underCostLabel.Size = new System.Drawing.Size(164, 32);
            this.underCostLabel.TabIndex = 7;
            this.underCostLabel.Text = "Underlay cost:";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(156, 641);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(128, 32);
            this.laborLabel.TabIndex = 7;
            this.laborLabel.Text = "Labor cost:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(156, 712);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 32);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total cost:";
            // 
            // yardOutBox
            // 
            this.yardOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yardOutBox.Location = new System.Drawing.Point(565, 423);
            this.yardOutBox.Name = "yardOutBox";
            this.yardOutBox.Size = new System.Drawing.Size(200, 39);
            this.yardOutBox.TabIndex = 7;
            // 
            // hardwoodOutBox
            // 
            this.hardwoodOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hardwoodOutBox.Location = new System.Drawing.Point(565, 493);
            this.hardwoodOutBox.Name = "hardwoodOutBox";
            this.hardwoodOutBox.Size = new System.Drawing.Size(200, 39);
            this.hardwoodOutBox.TabIndex = 7;
            // 
            // underlayOutBox
            // 
            this.underlayOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.underlayOutBox.Location = new System.Drawing.Point(565, 563);
            this.underlayOutBox.Name = "underlayOutBox";
            this.underlayOutBox.Size = new System.Drawing.Size(200, 39);
            this.underlayOutBox.TabIndex = 7;
            // 
            // laborOutBox
            // 
            this.laborOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborOutBox.Location = new System.Drawing.Point(565, 633);
            this.laborOutBox.Name = "laborOutBox";
            this.laborOutBox.Size = new System.Drawing.Size(200, 39);
            this.laborOutBox.TabIndex = 7;
            // 
            // totalOutBox
            // 
            this.totalOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutBox.Location = new System.Drawing.Point(565, 703);
            this.totalOutBox.Name = "totalOutBox";
            this.totalOutBox.Size = new System.Drawing.Size(200, 39);
            this.totalOutBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Super Quick EZ Hardware Cost Caulculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 858);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalOutBox);
            this.Controls.Add(this.laborOutBox);
            this.Controls.Add(this.underlayOutBox);
            this.Controls.Add(this.hardwoodOutBox);
            this.Controls.Add(this.yardOutBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.underCostLabel);
            this.Controls.Add(this.hardwoodLabel);
            this.Controls.Add(this.yardLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.underlayInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.firstRoomInput);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.underLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label underLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.TextBox firstRoomInput;
        private System.Windows.Forms.TextBox priceInput;
        private System.Windows.Forms.TextBox underlayInput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label yardLabel;
        private System.Windows.Forms.Label hardwoodLabel;
        private System.Windows.Forms.Label underCostLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label yardOutBox;
        private System.Windows.Forms.Label hardwareOutBox;
        private System.Windows.Forms.Label underlayOutBox;
        private System.Windows.Forms.Label laborOutBox;
        private System.Windows.Forms.Label totalOutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hardwoodOutBox;
    }
}

