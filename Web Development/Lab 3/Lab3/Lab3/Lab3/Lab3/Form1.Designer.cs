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
            this.percent15Label = new System.Windows.Forms.Label();
            this.percent18Label = new System.Windows.Forms.Label();
            this.percent20Label = new System.Windows.Forms.Label();
            this.percent15OutputLabel = new System.Windows.Forms.Label();
            this.percent18OutputLabel = new System.Windows.Forms.Label();
            this.percent20OutputLabel = new System.Windows.Forms.Label();
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
            // percent15Label
            // 
            this.percent15Label.AutoSize = true;
            this.percent15Label.Location = new System.Drawing.Point(65, 151);
            this.percent15Label.Name = "percent15Label";
            this.percent15Label.Size = new System.Drawing.Size(61, 25);
            this.percent15Label.TabIndex = 1;
            this.percent15Label.Text = "15%:";
            // 
            // percent18Label
            // 
            this.percent18Label.AutoSize = true;
            this.percent18Label.Location = new System.Drawing.Point(65, 233);
            this.percent18Label.Name = "percent18Label";
            this.percent18Label.Size = new System.Drawing.Size(61, 25);
            this.percent18Label.TabIndex = 2;
            this.percent18Label.Text = "18%:";
            // 
            // percent20Label
            // 
            this.percent20Label.AutoSize = true;
            this.percent20Label.Location = new System.Drawing.Point(65, 316);
            this.percent20Label.Name = "percent20Label";
            this.percent20Label.Size = new System.Drawing.Size(61, 25);
            this.percent20Label.TabIndex = 3;
            this.percent20Label.Text = "20%:";
            // 
            // percent15OutputLabel
            // 
            this.percent15OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent15OutputLabel.Location = new System.Drawing.Point(170, 150);
            this.percent15OutputLabel.Name = "percent15OutputLabel";
            this.percent15OutputLabel.Size = new System.Drawing.Size(100, 35);
            this.percent15OutputLabel.TabIndex = 4;
            // 
            // percent18OutputLabel
            // 
            this.percent18OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent18OutputLabel.Location = new System.Drawing.Point(170, 221);
            this.percent18OutputLabel.Name = "percent18OutputLabel";
            this.percent18OutputLabel.Size = new System.Drawing.Size(100, 37);
            this.percent18OutputLabel.TabIndex = 5;
            // 
            // percent20OutputLabel
            // 
            this.percent20OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.percent20OutputLabel.Location = new System.Drawing.Point(170, 303);
            this.percent20OutputLabel.Name = "percent20OutputLabel";
            this.percent20OutputLabel.Size = new System.Drawing.Size(100, 38);
            this.percent20OutputLabel.TabIndex = 6;
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
            this.Controls.Add(this.percent20OutputLabel);
            this.Controls.Add(this.percent18OutputLabel);
            this.Controls.Add(this.percent15OutputLabel);
            this.Controls.Add(this.percent20Label);
            this.Controls.Add(this.percent18Label);
            this.Controls.Add(this.percent15Label);
            this.Controls.Add(this.enterPriceLabel);
            this.Name = "lab3";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.lab3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.Label percent15Label;
        private System.Windows.Forms.Label percent18Label;
        private System.Windows.Forms.Label percent20Label;
        private System.Windows.Forms.Label percent15OutputLabel;
        private System.Windows.Forms.Label percent18OutputLabel;
        private System.Windows.Forms.Label percent20OutputLabel;
        private System.Windows.Forms.TextBox priceOfMealTextbox;
        private System.Windows.Forms.Button calculateButton;
    }
}

