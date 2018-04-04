namespace Lab_7
{
    partial class lab7
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
            this.monthLabel = new System.Windows.Forms.Label();
            this.langGroupBox = new System.Windows.Forms.GroupBox();
            this.italianRadioButton = new System.Windows.Forms.RadioButton();
            this.spanishRadioButton = new System.Windows.Forms.RadioButton();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.langGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(26, 48);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(189, 25);
            this.monthLabel.TabIndex = 0;
            this.monthLabel.Text = "Enter the Month #:";
            // 
            // langGroupBox
            // 
            this.langGroupBox.Controls.Add(this.italianRadioButton);
            this.langGroupBox.Controls.Add(this.spanishRadioButton);
            this.langGroupBox.Controls.Add(this.englishRadioButton);
            this.langGroupBox.Location = new System.Drawing.Point(31, 119);
            this.langGroupBox.Name = "langGroupBox";
            this.langGroupBox.Size = new System.Drawing.Size(256, 229);
            this.langGroupBox.TabIndex = 1;
            this.langGroupBox.TabStop = false;
            this.langGroupBox.Text = "Choose Language:";
            // 
            // italianRadioButton
            // 
            this.italianRadioButton.AutoSize = true;
            this.italianRadioButton.Location = new System.Drawing.Point(16, 157);
            this.italianRadioButton.Name = "italianRadioButton";
            this.italianRadioButton.Size = new System.Drawing.Size(100, 29);
            this.italianRadioButton.TabIndex = 2;
            this.italianRadioButton.Text = "Italian";
            this.italianRadioButton.UseVisualStyleBackColor = true;
            // 
            // spanishRadioButton
            // 
            this.spanishRadioButton.AutoSize = true;
            this.spanishRadioButton.Location = new System.Drawing.Point(16, 100);
            this.spanishRadioButton.Name = "spanishRadioButton";
            this.spanishRadioButton.Size = new System.Drawing.Size(121, 29);
            this.spanishRadioButton.TabIndex = 1;
            this.spanishRadioButton.Text = "Spanish";
            this.spanishRadioButton.UseVisualStyleBackColor = true;
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(16, 46);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(114, 29);
            this.englishRadioButton.TabIndex = 0;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(221, 48);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(227, 31);
            this.monthTextBox.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(31, 417);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(417, 65);
            this.outputLabel.TabIndex = 3;
            // 
            // clickButton
            // 
            this.clickButton.Location = new System.Drawing.Point(119, 518);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(219, 47);
            this.clickButton.TabIndex = 4;
            this.clickButton.Text = "Look Up";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // lab7
            // 
            this.AcceptButton = this.clickButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 577);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.langGroupBox);
            this.Controls.Add(this.monthLabel);
            this.Name = "lab7";
            this.Text = "Lab 7";
            this.langGroupBox.ResumeLayout(false);
            this.langGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.GroupBox langGroupBox;
        private System.Windows.Forms.RadioButton italianRadioButton;
        private System.Windows.Forms.RadioButton spanishRadioButton;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button clickButton;
    }
}

