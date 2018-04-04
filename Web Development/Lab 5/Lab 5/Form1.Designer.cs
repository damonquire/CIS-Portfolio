namespace Lab_5
{
    partial class lab5
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
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.whileRadioButton = new System.Windows.Forms.RadioButton();
            this.forRadioButton = new System.Windows.Forms.RadioButton();
            this.doWhileRadioButton = new System.Windows.Forms.RadioButton();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.loopLabel = new System.Windows.Forms.Label();
            this.loopButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(27, 100);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(43, 25);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(24, 9);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(67, 25);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "From:";
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(29, 145);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 31);
            this.toTextBox.TabIndex = 2;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(29, 51);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 31);
            this.fromTextBox.TabIndex = 3;
            // 
            // whileRadioButton
            // 
            this.whileRadioButton.AutoSize = true;
            this.whileRadioButton.Location = new System.Drawing.Point(32, 259);
            this.whileRadioButton.Name = "whileRadioButton";
            this.whileRadioButton.Size = new System.Drawing.Size(97, 29);
            this.whileRadioButton.TabIndex = 4;
            this.whileRadioButton.TabStop = true;
            this.whileRadioButton.Text = "While";
            this.whileRadioButton.UseVisualStyleBackColor = true;
            // 
            // forRadioButton
            // 
            this.forRadioButton.AutoSize = true;
            this.forRadioButton.Location = new System.Drawing.Point(32, 311);
            this.forRadioButton.Name = "forRadioButton";
            this.forRadioButton.Size = new System.Drawing.Size(75, 29);
            this.forRadioButton.TabIndex = 5;
            this.forRadioButton.TabStop = true;
            this.forRadioButton.Text = "For";
            this.forRadioButton.UseVisualStyleBackColor = true;
            // 
            // doWhileRadioButton
            // 
            this.doWhileRadioButton.AutoSize = true;
            this.doWhileRadioButton.Location = new System.Drawing.Point(32, 365);
            this.doWhileRadioButton.Name = "doWhileRadioButton";
            this.doWhileRadioButton.Size = new System.Drawing.Size(131, 29);
            this.doWhileRadioButton.TabIndex = 6;
            this.doWhileRadioButton.TabStop = true;
            this.doWhileRadioButton.Text = "Do-While";
            this.doWhileRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 25;
            this.outputListBox.Location = new System.Drawing.Point(255, 42);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(223, 429);
            this.outputListBox.TabIndex = 7;
            // 
            // loopLabel
            // 
            this.loopLabel.AutoSize = true;
            this.loopLabel.Location = new System.Drawing.Point(27, 201);
            this.loopLabel.Name = "loopLabel";
            this.loopLabel.Size = new System.Drawing.Size(127, 25);
            this.loopLabel.TabIndex = 8;
            this.loopLabel.Text = "Loop Using:";
            // 
            // loopButton
            // 
            this.loopButton.Location = new System.Drawing.Point(32, 419);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(139, 44);
            this.loopButton.TabIndex = 9;
            this.loopButton.Text = "Run Loop";
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(32, 491);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(139, 45);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // lab5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 571);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.loopLabel);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.doWhileRadioButton);
            this.Controls.Add(this.forRadioButton);
            this.Controls.Add(this.whileRadioButton);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toLabel);
            this.Name = "lab5";
            this.Text = "Lab 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.RadioButton whileRadioButton;
        private System.Windows.Forms.RadioButton forRadioButton;
        private System.Windows.Forms.RadioButton doWhileRadioButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label loopLabel;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.Button clearButton;
    }
}

