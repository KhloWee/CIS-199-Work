namespace Lab_2
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
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.salePriceBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.output15 = new System.Windows.Forms.Label();
            this.output18 = new System.Windows.Forms.Label();
            this.output20 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Location = new System.Drawing.Point(26, 59);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(131, 17);
            this.salePriceLabel.TabIndex = 0;
            this.salePriceLabel.Text = "Enter price of meal:";
            this.salePriceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // salePriceBox
            // 
            this.salePriceBox.Location = new System.Drawing.Point(175, 59);
            this.salePriceBox.Name = "salePriceBox";
            this.salePriceBox.Size = new System.Drawing.Size(100, 22);
            this.salePriceBox.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 17);
            this.label15.TabIndex = 2;
            this.label15.Text = "15%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(121, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "18%";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(121, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 17);
            this.label20.TabIndex = 4;
            this.label20.Text = "20%";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(108, 275);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 34);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Tip";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // output15
            // 
            this.output15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output15.Location = new System.Drawing.Point(175, 109);
            this.output15.Name = "output15";
            this.output15.Size = new System.Drawing.Size(100, 23);
            this.output15.TabIndex = 9;
            // 
            // output18
            // 
            this.output18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output18.Location = new System.Drawing.Point(175, 160);
            this.output18.Name = "output18";
            this.output18.Size = new System.Drawing.Size(100, 23);
            this.output18.TabIndex = 10;
            // 
            // output20
            // 
            this.output20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output20.Location = new System.Drawing.Point(175, 209);
            this.output20.Name = "output20";
            this.output20.Size = new System.Drawing.Size(100, 23);
            this.output20.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 321);
            this.Controls.Add(this.output20);
            this.Controls.Add(this.output18);
            this.Controls.Add(this.output15);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.salePriceBox);
            this.Controls.Add(this.salePriceLabel);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox salePriceBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label output15;
        private System.Windows.Forms.Label output18;
        private System.Windows.Forms.Label output20;
    }
}

