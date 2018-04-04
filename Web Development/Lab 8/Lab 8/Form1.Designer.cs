namespace Lab_8
{
    partial class lab8
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
            this.inputLabel = new System.Windows.Forms.Label();
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(12, 76);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(496, 25);
            this.inputLabel.TabIndex = 0;
            this.inputLabel.Text = "Enter the Distance Traveled in miles (in whole #\'s):";
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(514, 70);
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(100, 31);
            this.inputTextbox.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(243, 193);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(150, 25);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Cost of Ticket:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(57, 238);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(568, 50);
            this.outputLabel.TabIndex = 3;
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(216, 129);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(206, 37);
            this.clickButton.TabIndex = 4;
            this.clickButton.Text = "Calculate Cost";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // lab8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 334);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.inputTextbox);
            this.Controls.Add(this.inputLabel);
            this.Name = "lab8";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clickButton;
    }
}

