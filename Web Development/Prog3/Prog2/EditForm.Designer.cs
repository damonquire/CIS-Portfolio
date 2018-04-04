namespace LibraryItems
{
    partial class EditForm
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
            this.patronBtn = new System.Windows.Forms.Button();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.bookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronBtn
            // 
            this.patronBtn.Location = new System.Drawing.Point(41, 487);
            this.patronBtn.Name = "patronBtn";
            this.patronBtn.Size = new System.Drawing.Size(521, 65);
            this.patronBtn.TabIndex = 1;
            this.patronBtn.Text = "Click to edit Patron";
            this.patronBtn.UseVisualStyleBackColor = true;
            this.patronBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(24, 57);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(521, 33);
            this.patronComboBox.TabIndex = 2;
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(620, 57);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(520, 33);
            this.bookComboBox.TabIndex = 3;
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(620, 487);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(520, 65);
            this.bookBtn.TabIndex = 4;
            this.bookBtn.Text = "Click to edit Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 861);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(this.patronComboBox);
            this.Controls.Add(this.patronBtn);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button patronBtn;
        private System.Windows.Forms.ComboBox patronComboBox;
        private System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.Button bookBtn;
    }
}