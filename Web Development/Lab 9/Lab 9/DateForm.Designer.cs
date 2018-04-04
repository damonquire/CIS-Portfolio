namespace Lab_9
{
    partial class DateForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.monthButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(108, 64);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(63, 25);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(29, 151);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(78, 25);
            this.monthLabel.TabIndex = 1;
            this.monthLabel.Text = "Month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(29, 249);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(56, 25);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "Day:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(29, 362);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 25);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(252, 47);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(267, 57);
            this.outputLabel.TabIndex = 4;
            // 
            // monthTextBox
            // 
            this.monthTextBox.Location = new System.Drawing.Point(169, 144);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 31);
            this.monthTextBox.TabIndex = 5;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(169, 249);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(100, 31);
            this.dayTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(169, 356);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 31);
            this.yearTextBox.TabIndex = 7;
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(359, 134);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(201, 59);
            this.monthButton.TabIndex = 8;
            this.monthButton.Text = "Update Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // dayButton
            // 
            this.dayButton.Location = new System.Drawing.Point(359, 233);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(201, 56);
            this.dayButton.TabIndex = 9;
            this.dayButton.Text = "Update Day";
            this.dayButton.UseVisualStyleBackColor = true;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(359, 336);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(201, 59);
            this.yearButton.TabIndex = 10;
            this.yearButton.Text = "Update Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 510);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.monthButton);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateLabel);
            this.Name = "DateForm";
            this.Text = "Lab 9";
            this.Load += new System.EventHandler(this.DateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Button yearButton;
        public System.Windows.Forms.TextBox monthTextBox;
        public System.Windows.Forms.TextBox dayTextBox;
        public System.Windows.Forms.TextBox yearTextBox;
    }
}

