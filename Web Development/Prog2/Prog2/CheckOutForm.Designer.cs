namespace LibraryItems
{
    partial class CheckOutForm
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
            this.components = new System.ComponentModel.Container();
            this.patronComboBox = new System.Windows.Forms.ComboBox();
            this.bookComboBox = new System.Windows.Forms.ComboBox();
            this.patronLbl = new System.Windows.Forms.Label();
            this.bookLbl = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.checkOutBtnCncl = new System.Windows.Forms.Button();
            this.libraryPatronBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryPatronBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryPatronBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryPatronBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patronComboBox
            // 
            this.patronComboBox.FormattingEnabled = true;
            this.patronComboBox.Location = new System.Drawing.Point(56, 105);
            this.patronComboBox.Name = "patronComboBox";
            this.patronComboBox.Size = new System.Drawing.Size(393, 33);
            this.patronComboBox.TabIndex = 0;
            this.patronComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.checkOutPatronInput_Validating);
            this.patronComboBox.Validated += new System.EventHandler(this.checkOutPatronInput_Validated);
            // 
            // bookComboBox
            // 
            this.bookComboBox.FormattingEnabled = true;
            this.bookComboBox.Location = new System.Drawing.Point(533, 105);
            this.bookComboBox.Name = "bookComboBox";
            this.bookComboBox.Size = new System.Drawing.Size(404, 33);
            this.bookComboBox.TabIndex = 1;
            this.bookComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.checkOutBookInput_Validating);
            this.bookComboBox.Validated += new System.EventHandler(this.checkOutBookInput_Validated);
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.Location = new System.Drawing.Point(56, 42);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(81, 25);
            this.patronLbl.TabIndex = 2;
            this.patronLbl.Text = "Patron:";
            // 
            // bookLbl
            // 
            this.bookLbl.AutoSize = true;
            this.bookLbl.Location = new System.Drawing.Point(528, 42);
            this.bookLbl.Name = "bookLbl";
            this.bookLbl.Size = new System.Drawing.Size(67, 25);
            this.bookLbl.TabIndex = 3;
            this.bookLbl.Text = "Book:";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(55, 533);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(789, 116);
            this.checkOutButton.TabIndex = 4;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click_1);
            // 
            // checkOutBtnCncl
            // 
            this.checkOutBtnCncl.Location = new System.Drawing.Point(56, 748);
            this.checkOutBtnCncl.Name = "checkOutBtnCncl";
            this.checkOutBtnCncl.Size = new System.Drawing.Size(790, 83);
            this.checkOutBtnCncl.TabIndex = 5;
            this.checkOutBtnCncl.Text = "Cancel";
            this.checkOutBtnCncl.UseVisualStyleBackColor = true;
            // 
            // libraryPatronBindingSource1
            // 
            this.libraryPatronBindingSource1.DataSource = typeof(LibraryPatron);
            // 
            // libraryPatronBindingSource
            // 
            this.libraryPatronBindingSource.DataSource = typeof(LibraryPatron);
            // 
            // CheckOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 1107);
            this.Controls.Add(this.checkOutBtnCncl);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.bookLbl);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.bookComboBox);
            this.Controls.Add(this.patronComboBox);
            this.Name = "CheckOutForm";
            this.Text = "CheckOutForm";
            this.Load += new System.EventHandler(this.CheckOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryPatronBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryPatronBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.Label bookLbl;
        private System.Windows.Forms.Button checkOutButton;
        internal System.Windows.Forms.ComboBox patronComboBox;
        internal System.Windows.Forms.ComboBox bookComboBox;
        private System.Windows.Forms.Button checkOutBtnCncl;
        private System.Windows.Forms.BindingSource libraryPatronBindingSource;
        private System.Windows.Forms.BindingSource libraryPatronBindingSource1;
    }
}