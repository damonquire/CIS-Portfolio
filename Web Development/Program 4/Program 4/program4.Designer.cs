namespace Program_4
{
    partial class program4
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.publishTxt = new System.Windows.Forms.TextBox();
            this.cpYTxt = new System.Windows.Forms.TextBox();
            this.callNumTxt = new System.Windows.Forms.TextBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.publishLbl = new System.Windows.Forms.Label();
            this.cPYLbl = new System.Windows.Forms.Label();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.titlesListBox = new System.Windows.Forms.ListBox();
            this.libraryBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBookBtn = new System.Windows.Forms.Button();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(207, 71);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(100, 31);
            this.titleTxt.TabIndex = 0;
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(207, 144);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(100, 31);
            this.authorTxt.TabIndex = 1;
            // 
            // publishTxt
            // 
            this.publishTxt.Location = new System.Drawing.Point(207, 222);
            this.publishTxt.Name = "publishTxt";
            this.publishTxt.Size = new System.Drawing.Size(100, 31);
            this.publishTxt.TabIndex = 2;
            // 
            // cpYTxt
            // 
            this.cpYTxt.Location = new System.Drawing.Point(207, 298);
            this.cpYTxt.Name = "cpYTxt";
            this.cpYTxt.Size = new System.Drawing.Size(100, 31);
            this.cpYTxt.TabIndex = 3;
            // 
            // callNumTxt
            // 
            this.callNumTxt.Location = new System.Drawing.Point(207, 370);
            this.callNumTxt.Name = "callNumTxt";
            this.callNumTxt.Size = new System.Drawing.Size(100, 31);
            this.callNumTxt.TabIndex = 4;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(23, 74);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(59, 25);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Title:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(23, 150);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(81, 25);
            this.authorLbl.TabIndex = 6;
            this.authorLbl.Text = "Author:";
            // 
            // publishLbl
            // 
            this.publishLbl.AutoSize = true;
            this.publishLbl.Location = new System.Drawing.Point(23, 225);
            this.publishLbl.Name = "publishLbl";
            this.publishLbl.Size = new System.Drawing.Size(108, 25);
            this.publishLbl.TabIndex = 7;
            this.publishLbl.Text = "Publisher:";
            // 
            // cPYLbl
            // 
            this.cPYLbl.AutoSize = true;
            this.cPYLbl.Location = new System.Drawing.Point(23, 304);
            this.cPYLbl.Name = "cPYLbl";
            this.cPYLbl.Size = new System.Drawing.Size(162, 25);
            this.cPYLbl.TabIndex = 8;
            this.cPYLbl.Text = "Copyright Year:";
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(23, 376);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(136, 25);
            this.callNumLbl.TabIndex = 9;
            this.callNumLbl.Text = "Call Number:";
            // 
            // titlesListBox
            // 
            this.titlesListBox.FormattingEnabled = true;
            this.titlesListBox.ItemHeight = 25;
            this.titlesListBox.Location = new System.Drawing.Point(419, 68);
            this.titlesListBox.Name = "titlesListBox";
            this.titlesListBox.Size = new System.Drawing.Size(267, 329);
            this.titlesListBox.TabIndex = 10;
            // 
            // libraryBookBindingSource
            // 
            this.libraryBookBindingSource.DataSource = typeof(Program_4.LibraryBook);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(28, 484);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(232, 105);
            this.addBookBtn.TabIndex = 11;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Location = new System.Drawing.Point(752, 68);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(138, 52);
            this.detailsBtn.TabIndex = 12;
            this.detailsBtn.Text = "Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.detailsBtn_Click);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.Location = new System.Drawing.Point(752, 169);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(138, 54);
            this.checkOutBtn.TabIndex = 13;
            this.checkOutBtn.Text = "Check Out";
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(752, 272);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(138, 57);
            this.returnBtn.TabIndex = 14;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(28, 416);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(279, 47);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear Boxes";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 611);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.detailsBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.titlesListBox);
            this.Controls.Add(this.callNumLbl);
            this.Controls.Add(this.cPYLbl);
            this.Controls.Add(this.publishLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.callNumTxt);
            this.Controls.Add(this.cpYTxt);
            this.Controls.Add(this.publishTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.titleTxt);
            this.Name = "program4";
            this.Text = "Program 4";
            ((System.ComponentModel.ISupportInitialize)(this.libraryBookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox publishTxt;
        private System.Windows.Forms.TextBox cpYTxt;
        private System.Windows.Forms.TextBox callNumTxt;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label publishLbl;
        private System.Windows.Forms.Label cPYLbl;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.ListBox titlesListBox;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button detailsBtn;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource libraryBookBindingSource;
    }
}

