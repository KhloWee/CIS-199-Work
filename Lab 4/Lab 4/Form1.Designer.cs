namespace Lab_4
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
            this.gradeLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.acceptCountLabel = new System.Windows.Forms.Label();
            this.rejectCountLabel = new System.Windows.Forms.Label();
            this.rejectNumOut = new System.Windows.Forms.Label();
            this.acceptNumOut = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.testScoreIn = new System.Windows.Forms.TextBox();
            this.gradeIn = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(122, 36);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(132, 17);
            this.gradeLabel.TabIndex = 0;
            this.gradeLabel.Text = "Enter Student GPA:";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(52, 67);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(194, 17);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "Enter Admissions Test Score:";
            // 
            // acceptCountLabel
            // 
            this.acceptCountLabel.AutoSize = true;
            this.acceptCountLabel.Location = new System.Drawing.Point(147, 223);
            this.acceptCountLabel.Name = "acceptCountLabel";
            this.acceptCountLabel.Size = new System.Drawing.Size(107, 17);
            this.acceptCountLabel.TabIndex = 2;
            this.acceptCountLabel.Text = "Total Accepted:";
            // 
            // rejectCountLabel
            // 
            this.rejectCountLabel.AutoSize = true;
            this.rejectCountLabel.Location = new System.Drawing.Point(150, 264);
            this.rejectCountLabel.Name = "rejectCountLabel";
            this.rejectCountLabel.Size = new System.Drawing.Size(104, 17);
            this.rejectCountLabel.TabIndex = 3;
            this.rejectCountLabel.Text = "Total Rejected:";
            // 
            // rejectNumOut
            // 
            this.rejectNumOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectNumOut.Location = new System.Drawing.Point(276, 258);
            this.rejectNumOut.Name = "rejectNumOut";
            this.rejectNumOut.Size = new System.Drawing.Size(100, 23);
            this.rejectNumOut.TabIndex = 4;
            // 
            // acceptNumOut
            // 
            this.acceptNumOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptNumOut.Location = new System.Drawing.Point(276, 217);
            this.acceptNumOut.Name = "acceptNumOut";
            this.acceptNumOut.Size = new System.Drawing.Size(100, 23);
            this.acceptNumOut.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(125, 112);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(251, 23);
            this.outputLabel.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(52, 118);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 17);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status:";
            // 
            // testScoreIn
            // 
            this.testScoreIn.Location = new System.Drawing.Point(276, 67);
            this.testScoreIn.Name = "testScoreIn";
            this.testScoreIn.Size = new System.Drawing.Size(100, 22);
            this.testScoreIn.TabIndex = 8;
            // 
            // gradeIn
            // 
            this.gradeIn.Location = new System.Drawing.Point(276, 31);
            this.gradeIn.Name = "gradeIn";
            this.gradeIn.Size = new System.Drawing.Size(100, 22);
            this.gradeIn.TabIndex = 9;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(182, 164);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(125, 26);
            this.applyButton.TabIndex = 10;
            this.applyButton.Text = "Apply Student";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.gradeIn);
            this.Controls.Add(this.testScoreIn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.acceptNumOut);
            this.Controls.Add(this.rejectNumOut);
            this.Controls.Add(this.rejectCountLabel);
            this.Controls.Add(this.acceptCountLabel);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.gradeLabel);
            this.Name = "Form1";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Label acceptCountLabel;
        private System.Windows.Forms.Label rejectCountLabel;
        private System.Windows.Forms.Label rejectNumOut;
        private System.Windows.Forms.Label acceptNumOut;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox testScoreIn;
        private System.Windows.Forms.TextBox gradeIn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button applyButton;
    }
}

