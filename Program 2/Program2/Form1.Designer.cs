namespace Program2
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
            this.calcButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.companyBLabel = new System.Windows.Forms.Label();
            this.companyALabel = new System.Windows.Forms.Label();
            this.companyCLabel = new System.Windows.Forms.Label();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.companyAOutLabel = new System.Windows.Forms.Label();
            this.companyCOutLabel = new System.Windows.Forms.Label();
            this.companyBOutLabel = new System.Windows.Forms.Label();
            this.bigOutLabel = new System.Windows.Forms.Label();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.daysInBox = new System.Windows.Forms.TextBox();
            this.milesInBox = new System.Windows.Forms.TextBox();
            this.weightInBox = new System.Windows.Forms.TextBox();
            this.resultGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(44, 161);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(121, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate Cost";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 18);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(111, 17);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "Package Weight";
            // 
            // companyBLabel
            // 
            this.companyBLabel.AutoSize = true;
            this.companyBLabel.Location = new System.Drawing.Point(6, 62);
            this.companyBLabel.Name = "companyBLabel";
            this.companyBLabel.Size = new System.Drawing.Size(116, 17);
            this.companyBLabel.TabIndex = 2;
            this.companyBLabel.Text = "Company B Cost:";
            // 
            // companyALabel
            // 
            this.companyALabel.AutoSize = true;
            this.companyALabel.Location = new System.Drawing.Point(6, 24);
            this.companyALabel.Name = "companyALabel";
            this.companyALabel.Size = new System.Drawing.Size(116, 17);
            this.companyALabel.TabIndex = 3;
            this.companyALabel.Text = "Company A Cost:";
            // 
            // companyCLabel
            // 
            this.companyCLabel.AutoSize = true;
            this.companyCLabel.Location = new System.Drawing.Point(6, 101);
            this.companyCLabel.Name = "companyCLabel";
            this.companyCLabel.Size = new System.Drawing.Size(116, 17);
            this.companyCLabel.TabIndex = 4;
            this.companyCLabel.Text = "Company C Cost:";
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(6, 105);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(95, 17);
            this.deliveryLabel.TabIndex = 5;
            this.deliveryLabel.Text = "Delivery Days";
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(6, 62);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(109, 17);
            this.distanceLabel.TabIndex = 6;
            this.distanceLabel.Text = "Distance (Miles)";
            // 
            // companyAOutLabel
            // 
            this.companyAOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyAOutLabel.Location = new System.Drawing.Point(158, 18);
            this.companyAOutLabel.Name = "companyAOutLabel";
            this.companyAOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyAOutLabel.TabIndex = 7;
            // 
            // companyCOutLabel
            // 
            this.companyCOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyCOutLabel.Location = new System.Drawing.Point(158, 100);
            this.companyCOutLabel.Name = "companyCOutLabel";
            this.companyCOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyCOutLabel.TabIndex = 8;
            // 
            // companyBOutLabel
            // 
            this.companyBOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyBOutLabel.Location = new System.Drawing.Point(158, 56);
            this.companyBOutLabel.Name = "companyBOutLabel";
            this.companyBOutLabel.Size = new System.Drawing.Size(100, 23);
            this.companyBOutLabel.TabIndex = 9;
            // 
            // bigOutLabel
            // 
            this.bigOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bigOutLabel.Location = new System.Drawing.Point(9, 161);
            this.bigOutLabel.Name = "bigOutLabel";
            this.bigOutLabel.Size = new System.Drawing.Size(255, 23);
            this.bigOutLabel.TabIndex = 10;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.companyALabel);
            this.resultGroupBox.Controls.Add(this.bigOutLabel);
            this.resultGroupBox.Controls.Add(this.companyBLabel);
            this.resultGroupBox.Controls.Add(this.companyCOutLabel);
            this.resultGroupBox.Controls.Add(this.companyBOutLabel);
            this.resultGroupBox.Controls.Add(this.companyCLabel);
            this.resultGroupBox.Controls.Add(this.companyAOutLabel);
            this.resultGroupBox.Location = new System.Drawing.Point(325, 43);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(296, 203);
            this.resultGroupBox.TabIndex = 11;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Results";
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.weightInBox);
            this.inputGroupBox.Controls.Add(this.milesInBox);
            this.inputGroupBox.Controls.Add(this.daysInBox);
            this.inputGroupBox.Controls.Add(this.weightLabel);
            this.inputGroupBox.Controls.Add(this.distanceLabel);
            this.inputGroupBox.Controls.Add(this.calcButton);
            this.inputGroupBox.Controls.Add(this.deliveryLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(21, 43);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(255, 203);
            this.inputGroupBox.TabIndex = 12;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // daysInBox
            // 
            this.daysInBox.Location = new System.Drawing.Point(137, 100);
            this.daysInBox.Name = "daysInBox";
            this.daysInBox.Size = new System.Drawing.Size(100, 22);
            this.daysInBox.TabIndex = 7;
            // 
            // milesInBox
            // 
            this.milesInBox.Location = new System.Drawing.Point(137, 56);
            this.milesInBox.Name = "milesInBox";
            this.milesInBox.Size = new System.Drawing.Size(100, 22);
            this.milesInBox.TabIndex = 8;
            // 
            // weightInBox
            // 
            this.weightInBox.Location = new System.Drawing.Point(137, 19);
            this.weightInBox.Name = "weightInBox";
            this.weightInBox.Size = new System.Drawing.Size(100, 22);
            this.weightInBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 276);
            this.Controls.Add(this.inputGroupBox);
            this.Controls.Add(this.resultGroupBox);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label companyBLabel;
        private System.Windows.Forms.Label companyALabel;
        private System.Windows.Forms.Label companyCLabel;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label companyAOutLabel;
        private System.Windows.Forms.Label companyCOutLabel;
        private System.Windows.Forms.Label companyBOutLabel;
        private System.Windows.Forms.Label bigOutLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox weightInBox;
        private System.Windows.Forms.TextBox milesInBox;
        private System.Windows.Forms.TextBox daysInBox;
    }
}

