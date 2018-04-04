namespace Lab_4
{
    partial class lab4
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
            this.gpaTextbox = new System.Windows.Forms.TextBox();
            this.testScoreTextbox = new System.Windows.Forms.TextBox();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.testScoreLabel = new System.Windows.Forms.Label();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.acceptedOutputLabel = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.rejectedOutputLabel = new System.Windows.Forms.Label();
            this.passFailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpaTextbox
            // 
            this.gpaTextbox.Location = new System.Drawing.Point(512, 47);
            this.gpaTextbox.Name = "gpaTextbox";
            this.gpaTextbox.Size = new System.Drawing.Size(100, 31);
            this.gpaTextbox.TabIndex = 0;
            // 
            // testScoreTextbox
            // 
            this.testScoreTextbox.Location = new System.Drawing.Point(512, 125);
            this.testScoreTextbox.Name = "testScoreTextbox";
            this.testScoreTextbox.Size = new System.Drawing.Size(100, 31);
            this.testScoreTextbox.TabIndex = 1;
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(45, 47);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(257, 25);
            this.gpaLabel.TabIndex = 2;
            this.gpaLabel.Text = "Enter The Student\'s GPA:";
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.AutoSize = true;
            this.testScoreLabel.Location = new System.Drawing.Point(45, 131);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(379, 25);
            this.testScoreLabel.TabIndex = 3;
            this.testScoreLabel.Text = "Enter Student\'s Admission Test Score:";
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(22, 388);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(247, 25);
            this.acceptedLabel.TabIndex = 4;
            this.acceptedLabel.Text = "Total Amount Accepted: ";
            // 
            // acceptedOutputLabel
            // 
            this.acceptedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedOutputLabel.Location = new System.Drawing.Point(264, 378);
            this.acceptedOutputLabel.Name = "acceptedOutputLabel";
            this.acceptedOutputLabel.Size = new System.Drawing.Size(100, 35);
            this.acceptedOutputLabel.TabIndex = 5;
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(376, 388);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(236, 25);
            this.rejectedLabel.TabIndex = 6;
            this.rejectedLabel.Text = "Total Amount Rejected:";
            // 
            // rejectedOutputLabel
            // 
            this.rejectedOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedOutputLabel.Location = new System.Drawing.Point(619, 378);
            this.rejectedOutputLabel.Name = "rejectedOutputLabel";
            this.rejectedOutputLabel.Size = new System.Drawing.Size(100, 35);
            this.rejectedOutputLabel.TabIndex = 7;
            // 
            // passFailButton
            // 
            this.passFailButton.Location = new System.Drawing.Point(50, 257);
            this.passFailButton.Name = "passFailButton";
            this.passFailButton.Size = new System.Drawing.Size(423, 57);
            this.passFailButton.TabIndex = 8;
            this.passFailButton.Text = "Click Me To Determine Pass/Fail";
            this.passFailButton.UseVisualStyleBackColor = true;
            this.passFailButton.Click += new System.EventHandler(this.passFailButton_Click);
            // 
            // lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 461);
            this.Controls.Add(this.passFailButton);
            this.Controls.Add(this.rejectedOutputLabel);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedOutputLabel);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.testScoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.testScoreTextbox);
            this.Controls.Add(this.gpaTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "lab4";
            this.Text = "Lab 4";
            this.Load += new System.EventHandler(this.lab4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaTextbox;
        private System.Windows.Forms.TextBox testScoreTextbox;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label testScoreLabel;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.Label acceptedOutputLabel;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label rejectedOutputLabel;
        private System.Windows.Forms.Button passFailButton;
    }
}

