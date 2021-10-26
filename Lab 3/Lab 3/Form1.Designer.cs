namespace Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spherePicTop = new System.Windows.Forms.PictureBox();
            this.radiusInLabel = new System.Windows.Forms.Label();
            this.radiusInBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.spherePicBottom = new System.Windows.Forms.PictureBox();
            this.diameterOutBox = new System.Windows.Forms.Label();
            this.volumeOutBox = new System.Windows.Forms.Label();
            this.areaOutBox = new System.Windows.Forms.Label();
            this.diameterOutLabel = new System.Windows.Forms.Label();
            this.areaOutLabel = new System.Windows.Forms.Label();
            this.volumeOutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spherePicTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePicBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // spherePicTop
            // 
            this.spherePicTop.Image = ((System.Drawing.Image)(resources.GetObject("spherePicTop.Image")));
            this.spherePicTop.Location = new System.Drawing.Point(12, 12);
            this.spherePicTop.Name = "spherePicTop";
            this.spherePicTop.Size = new System.Drawing.Size(150, 150);
            this.spherePicTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePicTop.TabIndex = 0;
            this.spherePicTop.TabStop = false;
            // 
            // radiusInLabel
            // 
            this.radiusInLabel.AutoSize = true;
            this.radiusInLabel.Location = new System.Drawing.Point(184, 65);
            this.radiusInLabel.Name = "radiusInLabel";
            this.radiusInLabel.Size = new System.Drawing.Size(120, 17);
            this.radiusInLabel.TabIndex = 1;
            this.radiusInLabel.Text = "Radius of sphere:";
            // 
            // radiusInBox
            // 
            this.radiusInBox.Location = new System.Drawing.Point(323, 59);
            this.radiusInBox.Name = "radiusInBox";
            this.radiusInBox.Size = new System.Drawing.Size(100, 22);
            this.radiusInBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(323, 112);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // spherePicBottom
            // 
            this.spherePicBottom.Image = ((System.Drawing.Image)(resources.GetObject("spherePicBottom.Image")));
            this.spherePicBottom.Location = new System.Drawing.Point(302, 214);
            this.spherePicBottom.Name = "spherePicBottom";
            this.spherePicBottom.Size = new System.Drawing.Size(150, 150);
            this.spherePicBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spherePicBottom.TabIndex = 4;
            this.spherePicBottom.TabStop = false;
            // 
            // diameterOutBox
            // 
            this.diameterOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutBox.Location = new System.Drawing.Point(143, 214);
            this.diameterOutBox.Name = "diameterOutBox";
            this.diameterOutBox.Size = new System.Drawing.Size(100, 23);
            this.diameterOutBox.TabIndex = 5;
            // 
            // volumeOutBox
            // 
            this.volumeOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeOutBox.Location = new System.Drawing.Point(143, 308);
            this.volumeOutBox.Name = "volumeOutBox";
            this.volumeOutBox.Size = new System.Drawing.Size(100, 23);
            this.volumeOutBox.TabIndex = 6;
            // 
            // areaOutBox
            // 
            this.areaOutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutBox.Location = new System.Drawing.Point(143, 259);
            this.areaOutBox.Name = "areaOutBox";
            this.areaOutBox.Size = new System.Drawing.Size(100, 23);
            this.areaOutBox.TabIndex = 7;
            // 
            // diameterOutLabel
            // 
            this.diameterOutLabel.AutoSize = true;
            this.diameterOutLabel.Location = new System.Drawing.Point(26, 219);
            this.diameterOutLabel.Name = "diameterOutLabel";
            this.diameterOutLabel.Size = new System.Drawing.Size(69, 17);
            this.diameterOutLabel.TabIndex = 8;
            this.diameterOutLabel.Text = "Diameter:";
            // 
            // areaOutLabel
            // 
            this.areaOutLabel.AutoSize = true;
            this.areaOutLabel.Location = new System.Drawing.Point(26, 265);
            this.areaOutLabel.Name = "areaOutLabel";
            this.areaOutLabel.Size = new System.Drawing.Size(95, 17);
            this.areaOutLabel.TabIndex = 9;
            this.areaOutLabel.Text = "Surface Area:";
            // 
            // volumeOutLabel
            // 
            this.volumeOutLabel.AutoSize = true;
            this.volumeOutLabel.Location = new System.Drawing.Point(26, 314);
            this.volumeOutLabel.Name = "volumeOutLabel";
            this.volumeOutLabel.Size = new System.Drawing.Size(59, 17);
            this.volumeOutLabel.TabIndex = 10;
            this.volumeOutLabel.Text = "Volume:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 391);
            this.Controls.Add(this.volumeOutLabel);
            this.Controls.Add(this.areaOutLabel);
            this.Controls.Add(this.diameterOutLabel);
            this.Controls.Add(this.areaOutBox);
            this.Controls.Add(this.volumeOutBox);
            this.Controls.Add(this.diameterOutBox);
            this.Controls.Add(this.spherePicBottom);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.radiusInBox);
            this.Controls.Add(this.radiusInLabel);
            this.Controls.Add(this.spherePicTop);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.spherePicTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spherePicBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spherePicTop;
        private System.Windows.Forms.Label radiusInLabel;
        private System.Windows.Forms.TextBox radiusInBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox spherePicBottom;
        private System.Windows.Forms.Label diameterOutBox;
        private System.Windows.Forms.Label volumeOutBox;
        private System.Windows.Forms.Label areaOutBox;
        private System.Windows.Forms.Label diameterOutLabel;
        private System.Windows.Forms.Label areaOutLabel;
        private System.Windows.Forms.Label volumeOutLabel;
    }
}

