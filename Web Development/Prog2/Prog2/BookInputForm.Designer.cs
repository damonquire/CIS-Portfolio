namespace LibraryItems
{
    partial class BookInputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.publisherLbl = new System.Windows.Forms.Label();
            this.copyRightLbl = new System.Windows.Forms.Label();
            this.loanLbl = new System.Windows.Forms.Label();
            this.callNumLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.publTxt = new System.Windows.Forms.TextBox();
            this.cPyTxt = new System.Windows.Forms.TextBox();
            this.loanTxt = new System.Windows.Forms.TextBox();
            this.callNumTxt = new System.Windows.Forms.TextBox();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.cancelBkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Book info:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(32, 125);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(59, 25);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Title:";
            // 
            // publisherLbl
            // 
            this.publisherLbl.AutoSize = true;
            this.publisherLbl.Location = new System.Drawing.Point(32, 182);
            this.publisherLbl.Name = "publisherLbl";
            this.publisherLbl.Size = new System.Drawing.Size(108, 25);
            this.publisherLbl.TabIndex = 2;
            this.publisherLbl.Text = "Publisher:";
            // 
            // copyRightLbl
            // 
            this.copyRightLbl.AutoSize = true;
            this.copyRightLbl.Location = new System.Drawing.Point(32, 248);
            this.copyRightLbl.Name = "copyRightLbl";
            this.copyRightLbl.Size = new System.Drawing.Size(162, 25);
            this.copyRightLbl.TabIndex = 3;
            this.copyRightLbl.Text = "Copyright Year:";
            // 
            // loanLbl
            // 
            this.loanLbl.AutoSize = true;
            this.loanLbl.Location = new System.Drawing.Point(32, 315);
            this.loanLbl.Name = "loanLbl";
            this.loanLbl.Size = new System.Drawing.Size(134, 25);
            this.loanLbl.TabIndex = 4;
            this.loanLbl.Text = "Loan Period:";
            // 
            // callNumLbl
            // 
            this.callNumLbl.AutoSize = true;
            this.callNumLbl.Location = new System.Drawing.Point(32, 393);
            this.callNumLbl.Name = "callNumLbl";
            this.callNumLbl.Size = new System.Drawing.Size(136, 25);
            this.callNumLbl.TabIndex = 5;
            this.callNumLbl.Text = "Call Number:";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(37, 467);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(81, 25);
            this.authorLbl.TabIndex = 6;
            this.authorLbl.Text = "Author:";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(281, 113);
            this.titleTxt.Multiline = true;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(561, 43);
            this.titleTxt.TabIndex = 7;
            this.titleTxt.Validating += new System.ComponentModel.CancelEventHandler(this.bookTitle_Validating);
            this.titleTxt.Validated += new System.EventHandler(this.bookTitle_Validated);
            // 
            // publTxt
            // 
            this.publTxt.Location = new System.Drawing.Point(281, 175);
            this.publTxt.Multiline = true;
            this.publTxt.Name = "publTxt";
            this.publTxt.Size = new System.Drawing.Size(561, 46);
            this.publTxt.TabIndex = 8;
            this.publTxt.Validating += new System.ComponentModel.CancelEventHandler(this.bookPunlisher_Validating);
            this.publTxt.Validated += new System.EventHandler(this.bookPublisher_Validated);
            // 
            // cPyTxt
            // 
            this.cPyTxt.Location = new System.Drawing.Point(281, 235);
            this.cPyTxt.Multiline = true;
            this.cPyTxt.Name = "cPyTxt";
            this.cPyTxt.Size = new System.Drawing.Size(561, 50);
            this.cPyTxt.TabIndex = 9;
            this.cPyTxt.Validating += new System.ComponentModel.CancelEventHandler(this.copyRight_Validating);
            this.cPyTxt.Validated += new System.EventHandler(this.copyRight_Validated);
            // 
            // loanTxt
            // 
            this.loanTxt.Location = new System.Drawing.Point(281, 308);
            this.loanTxt.Multiline = true;
            this.loanTxt.Name = "loanTxt";
            this.loanTxt.Size = new System.Drawing.Size(561, 44);
            this.loanTxt.TabIndex = 10;
            this.loanTxt.Validating += new System.ComponentModel.CancelEventHandler(this.loanPeriod_Validating);
            this.loanTxt.Validated += new System.EventHandler(this.loanPeriod_Validated);
            // 
            // callNumTxt
            // 
            this.callNumTxt.Location = new System.Drawing.Point(281, 372);
            this.callNumTxt.Multiline = true;
            this.callNumTxt.Name = "callNumTxt";
            this.callNumTxt.Size = new System.Drawing.Size(561, 46);
            this.callNumTxt.TabIndex = 11;
            this.callNumTxt.Validating += new System.ComponentModel.CancelEventHandler(this.callNumber_Validating);
            this.callNumTxt.Validated += new System.EventHandler(this.callNumber_Validated);
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(281, 460);
            this.authorTxt.Multiline = true;
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(561, 51);
            this.authorTxt.TabIndex = 12;
            this.authorTxt.Validating += new System.ComponentModel.CancelEventHandler(this.author_Validating);
            this.authorTxt.Validated += new System.EventHandler(this.author_Validated);
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(42, 562);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(319, 72);
            this.addBookBtn.TabIndex = 13;
            this.addBookBtn.Text = "Add Button";
            this.addBookBtn.UseVisualStyleBackColor = true;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // cancelBkBtn
            // 
            this.cancelBkBtn.Location = new System.Drawing.Point(567, 562);
            this.cancelBkBtn.Name = "cancelBkBtn";
            this.cancelBkBtn.Size = new System.Drawing.Size(348, 72);
            this.cancelBkBtn.TabIndex = 14;
            this.cancelBkBtn.Text = "Cancel";
            this.cancelBkBtn.UseVisualStyleBackColor = true;
            this.cancelBkBtn.Click += new System.EventHandler(this.cancelBkBtn_Click);
            // 
            // BookInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 668);
            this.Controls.Add(this.cancelBkBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.callNumTxt);
            this.Controls.Add(this.loanTxt);
            this.Controls.Add(this.cPyTxt);
            this.Controls.Add(this.publTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.callNumLbl);
            this.Controls.Add(this.loanLbl);
            this.Controls.Add(this.copyRightLbl);
            this.Controls.Add(this.publisherLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label1);
            this.Name = "BookInputForm";
            this.Text = "BookInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label publisherLbl;
        private System.Windows.Forms.Label copyRightLbl;
        private System.Windows.Forms.Label loanLbl;
        private System.Windows.Forms.Label callNumLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox publTxt;
        private System.Windows.Forms.TextBox cPyTxt;
        private System.Windows.Forms.TextBox loanTxt;
        private System.Windows.Forms.TextBox callNumTxt;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button cancelBkBtn;
    }
}