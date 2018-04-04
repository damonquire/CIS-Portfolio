namespace CIS199Program1FinalSubmission
{
    partial class Program1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.squareFootTextBox = new System.Windows.Forms.TextBox();
            this.coatsTextBox = new System.Windows.Forms.TextBox();
            this.paintCostTextBox = new System.Windows.Forms.TextBox();
            this.squareFootLabel = new System.Windows.Forms.Label();
            this.numberOfDesiredCoatsLabel = new System.Windows.Forms.Label();
            this.paintPriceLabel = new System.Windows.Forms.Label();
            this.totalSquareFootLabel = new System.Windows.Forms.Label();
            this.totalSquareFootOutputLabel = new System.Windows.Forms.Label();
            this.totalGallonsLabel = new System.Windows.Forms.Label();
            this.totalGallonsOutputLabel = new System.Windows.Forms.Label();
            this.totalLaborHoursLabel = new System.Windows.Forms.Label();
            this.totalLaborHoursOutputLabel = new System.Windows.Forms.Label();
            this.totalPaintCostLabel = new System.Windows.Forms.Label();
            this.totalPaintCostOutputLabel = new System.Windows.Forms.Label();
            this.totalLaborCostLabel = new System.Windows.Forms.Label();
            this.totalLaborCostOutputLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.grandTotalOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(868, 66);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(285, 222);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // squareFootTextBox
            // 
            this.squareFootTextBox.Location = new System.Drawing.Point(557, 71);
            this.squareFootTextBox.Name = "squareFootTextBox";
            this.squareFootTextBox.Size = new System.Drawing.Size(137, 31);
            this.squareFootTextBox.TabIndex = 1;
            // 
            // coatsTextBox
            // 
            this.coatsTextBox.Location = new System.Drawing.Point(557, 158);
            this.coatsTextBox.Name = "coatsTextBox";
            this.coatsTextBox.Size = new System.Drawing.Size(137, 31);
            this.coatsTextBox.TabIndex = 2;
            // 
            // paintCostTextBox
            // 
            this.paintCostTextBox.Location = new System.Drawing.Point(557, 241);
            this.paintCostTextBox.Name = "paintCostTextBox";
            this.paintCostTextBox.Size = new System.Drawing.Size(137, 31);
            this.paintCostTextBox.TabIndex = 3;
            // 
            // squareFootLabel
            // 
            this.squareFootLabel.Location = new System.Drawing.Point(12, 71);
            this.squareFootLabel.Name = "squareFootLabel";
            this.squareFootLabel.Size = new System.Drawing.Size(488, 40);
            this.squareFootLabel.TabIndex = 4;
            this.squareFootLabel.Text = "Enter The Square Foot Of Walls To Be Painted:";
            // 
            // numberOfDesiredCoatsLabel
            // 
            this.numberOfDesiredCoatsLabel.Location = new System.Drawing.Point(12, 158);
            this.numberOfDesiredCoatsLabel.Name = "numberOfDesiredCoatsLabel";
            this.numberOfDesiredCoatsLabel.Size = new System.Drawing.Size(488, 38);
            this.numberOfDesiredCoatsLabel.TabIndex = 5;
            this.numberOfDesiredCoatsLabel.Text = "Enter Your Desired Number Of Paint Coats:";
            // 
            // paintPriceLabel
            // 
            this.paintPriceLabel.Location = new System.Drawing.Point(13, 241);
            this.paintPriceLabel.Name = "paintPriceLabel";
            this.paintPriceLabel.Size = new System.Drawing.Size(470, 23);
            this.paintPriceLabel.TabIndex = 6;
            this.paintPriceLabel.Text = "Enter The Price Per Gallon Of Desired Paint:";
            // 
            // totalSquareFootLabel
            // 
            this.totalSquareFootLabel.Location = new System.Drawing.Point(12, 372);
            this.totalSquareFootLabel.Name = "totalSquareFootLabel";
            this.totalSquareFootLabel.Size = new System.Drawing.Size(360, 23);
            this.totalSquareFootLabel.TabIndex = 7;
            this.totalSquareFootLabel.Text = "Total Square Foot To Be Painted:";
            // 
            // totalSquareFootOutputLabel
            // 
            this.totalSquareFootOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalSquareFootOutputLabel.Location = new System.Drawing.Point(446, 351);
            this.totalSquareFootOutputLabel.Name = "totalSquareFootOutputLabel";
            this.totalSquareFootOutputLabel.Size = new System.Drawing.Size(199, 66);
            this.totalSquareFootOutputLabel.TabIndex = 8;
            // 
            // totalGallonsLabel
            // 
            this.totalGallonsLabel.Location = new System.Drawing.Point(13, 491);
            this.totalGallonsLabel.Name = "totalGallonsLabel";
            this.totalGallonsLabel.Size = new System.Drawing.Size(398, 23);
            this.totalGallonsLabel.TabIndex = 9;
            this.totalGallonsLabel.Text = "Total Gallons Of Paint Needed For Job:";
            // 
            // totalGallonsOutputLabel
            // 
            this.totalGallonsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalGallonsOutputLabel.Location = new System.Drawing.Point(446, 466);
            this.totalGallonsOutputLabel.Name = "totalGallonsOutputLabel";
            this.totalGallonsOutputLabel.Size = new System.Drawing.Size(199, 70);
            this.totalGallonsOutputLabel.TabIndex = 10;
            // 
            // totalLaborHoursLabel
            // 
            this.totalLaborHoursLabel.AutoSize = true;
            this.totalLaborHoursLabel.Location = new System.Drawing.Point(18, 601);
            this.totalLaborHoursLabel.Name = "totalLaborHoursLabel";
            this.totalLaborHoursLabel.Size = new System.Drawing.Size(283, 25);
            this.totalLaborHoursLabel.TabIndex = 11;
            this.totalLaborHoursLabel.Text = "Total Labor Hours Required:";
            // 
            // totalLaborHoursOutputLabel
            // 
            this.totalLaborHoursOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborHoursOutputLabel.Location = new System.Drawing.Point(446, 577);
            this.totalLaborHoursOutputLabel.Name = "totalLaborHoursOutputLabel";
            this.totalLaborHoursOutputLabel.Size = new System.Drawing.Size(199, 66);
            this.totalLaborHoursOutputLabel.TabIndex = 12;
            // 
            // totalPaintCostLabel
            // 
            this.totalPaintCostLabel.AutoSize = true;
            this.totalPaintCostLabel.Location = new System.Drawing.Point(718, 372);
            this.totalPaintCostLabel.Name = "totalPaintCostLabel";
            this.totalPaintCostLabel.Size = new System.Drawing.Size(280, 25);
            this.totalPaintCostLabel.TabIndex = 13;
            this.totalPaintCostLabel.Text = "Total Cost Of Paint Needed:";
            // 
            // totalPaintCostOutputLabel
            // 
            this.totalPaintCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPaintCostOutputLabel.Location = new System.Drawing.Point(1157, 351);
            this.totalPaintCostOutputLabel.Name = "totalPaintCostOutputLabel";
            this.totalPaintCostOutputLabel.Size = new System.Drawing.Size(186, 66);
            this.totalPaintCostOutputLabel.TabIndex = 14;
            // 
            // totalLaborCostLabel
            // 
            this.totalLaborCostLabel.AutoSize = true;
            this.totalLaborCostLabel.Location = new System.Drawing.Point(718, 489);
            this.totalLaborCostLabel.Name = "totalLaborCostLabel";
            this.totalLaborCostLabel.Size = new System.Drawing.Size(205, 25);
            this.totalLaborCostLabel.TabIndex = 15;
            this.totalLaborCostLabel.Text = "Total Cost Of Labor:";
            // 
            // totalLaborCostOutputLabel
            // 
            this.totalLaborCostOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLaborCostOutputLabel.Location = new System.Drawing.Point(1157, 466);
            this.totalLaborCostOutputLabel.Name = "totalLaborCostOutputLabel";
            this.totalLaborCostOutputLabel.Size = new System.Drawing.Size(186, 70);
            this.totalLaborCostOutputLabel.TabIndex = 16;
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLabel.Location = new System.Drawing.Point(723, 601);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(400, 37);
            this.grandTotalLabel.TabIndex = 17;
            this.grandTotalLabel.Text = "Grand Total Cost Of Job:";
            // 
            // grandTotalOutputLabel
            // 
            this.grandTotalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grandTotalOutputLabel.Location = new System.Drawing.Point(1157, 577);
            this.grandTotalOutputLabel.Name = "grandTotalOutputLabel";
            this.grandTotalOutputLabel.Size = new System.Drawing.Size(192, 75);
            this.grandTotalOutputLabel.TabIndex = 18;
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 724);
            this.Controls.Add(this.grandTotalOutputLabel);
            this.Controls.Add(this.grandTotalLabel);
            this.Controls.Add(this.totalLaborCostOutputLabel);
            this.Controls.Add(this.totalLaborCostLabel);
            this.Controls.Add(this.totalPaintCostOutputLabel);
            this.Controls.Add(this.totalPaintCostLabel);
            this.Controls.Add(this.totalLaborHoursOutputLabel);
            this.Controls.Add(this.totalLaborHoursLabel);
            this.Controls.Add(this.totalGallonsOutputLabel);
            this.Controls.Add(this.totalGallonsLabel);
            this.Controls.Add(this.totalSquareFootOutputLabel);
            this.Controls.Add(this.totalSquareFootLabel);
            this.Controls.Add(this.paintPriceLabel);
            this.Controls.Add(this.numberOfDesiredCoatsLabel);
            this.Controls.Add(this.squareFootLabel);
            this.Controls.Add(this.paintCostTextBox);
            this.Controls.Add(this.coatsTextBox);
            this.Controls.Add(this.squareFootTextBox);
            this.Controls.Add(this.calculateButton);
            this.Name = "Program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox squareFootTextBox;
        private System.Windows.Forms.TextBox coatsTextBox;
        private System.Windows.Forms.TextBox paintCostTextBox;
        private System.Windows.Forms.Label squareFootLabel;
        private System.Windows.Forms.Label numberOfDesiredCoatsLabel;
        private System.Windows.Forms.Label paintPriceLabel;
        private System.Windows.Forms.Label totalSquareFootLabel;
        private System.Windows.Forms.Label totalSquareFootOutputLabel;
        private System.Windows.Forms.Label totalGallonsLabel;
        private System.Windows.Forms.Label totalGallonsOutputLabel;
        private System.Windows.Forms.Label totalLaborHoursLabel;
        private System.Windows.Forms.Label totalLaborHoursOutputLabel;
        private System.Windows.Forms.Label totalPaintCostLabel;
        private System.Windows.Forms.Label totalPaintCostOutputLabel;
        private System.Windows.Forms.Label totalLaborCostLabel;
        private System.Windows.Forms.Label totalLaborCostOutputLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.Label grandTotalOutputLabel;
    }
}

