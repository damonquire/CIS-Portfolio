namespace Program_3
{
    partial class program3
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
            this.creditHrTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.findRegTimeBtn = new System.Windows.Forms.Button();
            this.dateTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditHrTxt
            // 
            this.creditHrTxt.Location = new System.Drawing.Point(293, 50);
            this.creditHrTxt.Name = "creditHrTxt";
            this.creditHrTxt.Size = new System.Drawing.Size(100, 31);
            this.creditHrTxt.TabIndex = 0;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(293, 125);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 31);
            this.lastNameTxt.TabIndex = 1;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(43, 50);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(204, 25);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "Hours Prior to 2016:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 131);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // findRegTimeBtn
            // 
            this.findRegTimeBtn.Location = new System.Drawing.Point(48, 232);
            this.findRegTimeBtn.Name = "findRegTimeBtn";
            this.findRegTimeBtn.Size = new System.Drawing.Size(365, 64);
            this.findRegTimeBtn.TabIndex = 4;
            this.findRegTimeBtn.Text = "Find Reg. Time";
            this.findRegTimeBtn.UseVisualStyleBackColor = true;
            this.findRegTimeBtn.Click += new System.EventHandler(this.findRegTimeBtn_Click);
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimeLbl.Location = new System.Drawing.Point(48, 349);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.Size = new System.Drawing.Size(365, 73);
            this.dateTimeLbl.TabIndex = 5;
            // 
            // program3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 525);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.findRegTimeBtn);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.creditHrTxt);
            this.Name = "program3";
            this.Text = "Program 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditHrTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button findRegTimeBtn;
        private System.Windows.Forms.Label dateTimeLbl;
    }
}

