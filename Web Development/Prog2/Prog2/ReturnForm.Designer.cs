namespace LibraryItems
{
    partial class ReturnForm
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
            this.returnBtn = new System.Windows.Forms.Button();
            this.bookcomboBox = new System.Windows.Forms.ComboBox();
            this.returnLbl = new System.Windows.Forms.Label();
            this.cnclBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(123, 217);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(567, 118);
            this.returnBtn.TabIndex = 0;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // bookcomboBox
            // 
            this.bookcomboBox.FormattingEnabled = true;
            this.bookcomboBox.Location = new System.Drawing.Point(284, 70);
            this.bookcomboBox.Name = "bookcomboBox";
            this.bookcomboBox.Size = new System.Drawing.Size(406, 33);
            this.bookcomboBox.TabIndex = 1;
            this.bookcomboBox.Validating += new System.ComponentModel.CancelEventHandler(this.returnBookInput_Validating);
            this.bookcomboBox.Validated += new System.EventHandler(this.returnBookInput_Validated);
            // 
            // returnLbl
            // 
            this.returnLbl.AutoSize = true;
            this.returnLbl.Location = new System.Drawing.Point(45, 78);
            this.returnLbl.Name = "returnLbl";
            this.returnLbl.Size = new System.Drawing.Size(72, 25);
            this.returnLbl.TabIndex = 2;
            this.returnLbl.Text = "Books";
            // 
            // cnclBtn
            // 
            this.cnclBtn.Location = new System.Drawing.Point(123, 382);
            this.cnclBtn.Name = "cnclBtn";
            this.cnclBtn.Size = new System.Drawing.Size(567, 81);
            this.cnclBtn.TabIndex = 3;
            this.cnclBtn.Text = "Cancel";
            this.cnclBtn.UseVisualStyleBackColor = true;
            this.cnclBtn.Click += new System.EventHandler(this.cnclBtn_Click);
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 528);
            this.Controls.Add(this.cnclBtn);
            this.Controls.Add(this.returnLbl);
            this.Controls.Add(this.bookcomboBox);
            this.Controls.Add(this.returnBtn);
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label returnLbl;
        private System.Windows.Forms.Button cnclBtn;
        internal System.Windows.Forms.ComboBox bookcomboBox;
    }
}