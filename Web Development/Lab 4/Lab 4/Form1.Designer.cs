namespace Lab_4
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
            this.gpatextBox = new System.Windows.Forms.TextBox();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.acceptedLbl = new System.Windows.Forms.Label();
            this.rejectedLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpatextBox
            // 
            this.gpatextBox.Location = new System.Drawing.Point(137, 39);
            this.gpatextBox.Name = "gpatextBox";
            this.gpatextBox.Size = new System.Drawing.Size(100, 26);
            this.gpatextBox.TabIndex = 0;
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.Location = new System.Drawing.Point(137, 110);
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(100, 26);
            this.testScoreTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(133, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Test Score:";
            // 
            // acceptedLbl
            // 
            this.acceptedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedLbl.Location = new System.Drawing.Point(556, 79);
            this.acceptedLbl.Name = "acceptedLbl";
            this.acceptedLbl.Size = new System.Drawing.Size(100, 23);
            this.acceptedLbl.TabIndex = 6;
            // 
            // rejectedLbl
            // 
            this.rejectedLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedLbl.Location = new System.Drawing.Point(556, 210);
            this.rejectedLbl.Name = "rejectedLbl";
            this.rejectedLbl.Size = new System.Drawing.Size(100, 23);
            this.rejectedLbl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Accepted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Rejected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rejectedLbl);
            this.Controls.Add(this.acceptedLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testScoreTextBox);
            this.Controls.Add(this.gpatextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpatextBox;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label acceptedLbl;
        private System.Windows.Forms.Label rejectedLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

