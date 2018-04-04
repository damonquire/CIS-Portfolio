namespace Lab3
{
    partial class lab3
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
            this.enterPriceLabel = new System.Windows.Forms.Label();
            this.smallPercentLabel = new System.Windows.Forms.Label();
            this.middlePercentLabel = new System.Windows.Forms.Label();
            this.largePercentLabel = new System.Windows.Forms.Label();
            this.smallPercentOutputLabel = new System.Windows.Forms.Label();
            this.middlePercentOutputLabel = new System.Windows.Forms.Label();
            this.largePercentOutputLabel = new System.Windows.Forms.Label();
            this.priceOfMealTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterPriceLabel
            // 
            this.enterPriceLabel.AutoSize = true;
            this.enterPriceLabel.Location = new System.Drawing.Point(60, 66);
            this.enterPriceLabel.Name = "enterPriceLabel";
            this.enterPriceLabel.Size = new System.Drawing.Size(248, 25);
            this.enterPriceLabel.TabIndex = 0;
            this.enterPriceLabel.Text = "Enter The Price Of Meal:";
            // 
            // smallPercentLabel
            // 
            this.smallPercentLabel.AutoSize = true;
            this.smallPercentLabel.Location = new System.Drawing.Point(65, 151);
            this.smallPercentLabel.Name = "smallPercentLabel";
            this.smallPercentLabel.Size = new System.Drawing.Size(0, 25);
            this.smallPercentLabel.TabIndex = 1;
            // 
            // middlePercentLabel
            // 
            this.middlePercentLabel.AutoSize = true;
            this.middlePercentLabel.Location = new System.Drawing.Point(65, 233);
            this.middlePercentLabel.Name = "middlePercentLabel";
            this.middlePercentLabel.Size = new System.Drawing.Size(0, 25);
            this.middlePercentLabel.TabIndex = 2;
            // 
            // largePercentLabel
            // 
            this.largePercentLabel.AutoSize = true;
            this.largePercentLabel.Location = new System.Drawing.Point(65, 316);
            this.largePercentLabel.Name = "largePercentLabel";
            this.largePercentLabel.Size = new System.Drawing.Size(0, 25);
            this.largePercentLabel.TabIndex = 3;
            // 
            // smallPercentOutputLabel
            // 
            this.smallPercentOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.smallPercentOutputLabel.Location = new System.Drawing.Point(170, 150);
            this.smallPercentOutputLabel.Name = "smallPercentOutputLabel";
            this.smallPercentOutputLabel.Size = new System.Drawing.Size(100, 35);
            this.smallPercentOutputLabel.TabIndex = 4;
            // 
            // middlePercentOutputLabel
            // 
            this.middlePercentOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlePercentOutputLabel.Location = new System.Drawing.Point(170, 221);
            this.middlePercentOutputLabel.Name = "middlePercentOutputLabel";
            this.middlePercentOutputLabel.Size = new System.Drawing.Size(100, 37);
            this.middlePercentOutputLabel.TabIndex = 5;
            // 
            // largePercentOutputLabel
            // 
            this.largePercentOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.largePercentOutputLabel.Location = new System.Drawing.Point(170, 303);
            this.largePercentOutputLabel.Name = "largePercentOutputLabel";
            this.largePercentOutputLabel.Size = new System.Drawing.Size(100, 38);
            this.largePercentOutputLabel.TabIndex = 6;
            // 
            // priceOfMealTextbox
            // 
            this.priceOfMealTextbox.Location = new System.Drawing.Point(361, 59);
            this.priceOfMealTextbox.Name = "priceOfMealTextbox";
            this.priceOfMealTextbox.Size = new System.Drawing.Size(100, 31);
            this.priceOfMealTextbox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(194, 454);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(209, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Tip";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 607);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.priceOfMealTextbox);
            this.Controls.Add(this.largePercentOutputLabel);
            this.Controls.Add(this.middlePercentOutputLabel);
            this.Controls.Add(this.smallPercentOutputLabel);
            this.Controls.Add(this.largePercentLabel);
            this.Controls.Add(this.middlePercentLabel);
            this.Controls.Add(this.smallPercentLabel);
            this.Controls.Add(this.enterPriceLabel);
            this.Name = "lab3";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.lab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.Label smallPercentLabel;
        private System.Windows.Forms.Label middlePercentLabel;
        private System.Windows.Forms.Label largePercentLabel;
        private System.Windows.Forms.Label smallPercentOutputLabel;
        private System.Windows.Forms.Label middlePercentOutputLabel;
        private System.Windows.Forms.Label largePercentOutputLabel;
        private System.Windows.Forms.TextBox priceOfMealTextbox;
        private System.Windows.Forms.Button calculateButton;
    }
}

