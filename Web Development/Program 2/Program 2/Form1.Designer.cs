namespace Program_2
{
    partial class program2
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
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.creditHoursTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.timeOutputLabel = new System.Windows.Forms.Label();
            this.outputButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(34, 60);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(528, 25);
            this.creditHoursLabel.TabIndex = 0;
            this.creditHoursLabel.Text = "Enter The Number Of Credit Hours You\'ve Completed:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 125);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(354, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Your Last Name (Lowercase):";
            // 
            // creditHoursTextBox
            // 
            this.creditHoursTextBox.Location = new System.Drawing.Point(580, 54);
            this.creditHoursTextBox.Name = "creditHoursTextBox";
            this.creditHoursTextBox.Size = new System.Drawing.Size(100, 31);
            this.creditHoursTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(580, 119);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 31);
            this.nameTextBox.TabIndex = 3;
            // 
            // timeOutputLabel
            // 
            this.timeOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeOutputLabel.Location = new System.Drawing.Point(162, 325);
            this.timeOutputLabel.Name = "timeOutputLabel";
            this.timeOutputLabel.Size = new System.Drawing.Size(152, 46);
            this.timeOutputLabel.TabIndex = 4;
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(121, 229);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(625, 49);
            this.outputButton.TabIndex = 5;
            this.outputButton.Text = "Click Me To See The Earliest You May Register For Classes";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(59, 346);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 25);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "Time:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(401, 346);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 25);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date:";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateOutputLabel.Location = new System.Drawing.Point(508, 325);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(360, 46);
            this.dateOutputLabel.TabIndex = 8;
            // 
            // program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 410);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.timeOutputLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.creditHoursTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.creditHoursLabel);
            this.Name = "program2";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox creditHoursTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label timeOutputLabel;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateOutputLabel;
    }
}

