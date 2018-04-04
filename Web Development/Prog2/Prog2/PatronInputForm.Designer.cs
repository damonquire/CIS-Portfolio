namespace LibraryItems
{
    partial class PatronInputForm
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
            this.patronLabel = new System.Windows.Forms.Label();
            this.patronNameTxt = new System.Windows.Forms.TextBox();
            this.patronBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.iDLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronLabel
            // 
            this.patronLabel.AutoSize = true;
            this.patronLabel.Location = new System.Drawing.Point(28, 68);
            this.patronLabel.Name = "patronLabel";
            this.patronLabel.Size = new System.Drawing.Size(122, 25);
            this.patronLabel.TabIndex = 0;
            this.patronLabel.Text = "Patron info:";
            // 
            // patronNameTxt
            // 
            this.patronNameTxt.Location = new System.Drawing.Point(159, 114);
            this.patronNameTxt.Multiline = true;
            this.patronNameTxt.Name = "patronNameTxt";
            this.patronNameTxt.Size = new System.Drawing.Size(198, 33);
            this.patronNameTxt.TabIndex = 1;
            this.patronNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PatronNameTxt_Validating);
            this.patronNameTxt.Validated += new System.EventHandler(this.PatronNameTxt_Validated);
            // 
            // patronBtn
            // 
            this.patronBtn.Location = new System.Drawing.Point(33, 255);
            this.patronBtn.Name = "patronBtn";
            this.patronBtn.Size = new System.Drawing.Size(688, 76);
            this.patronBtn.TabIndex = 2;
            this.patronBtn.Text = "Add Patron";
            this.patronBtn.UseVisualStyleBackColor = true;
            this.patronBtn.Click += new System.EventHandler(this.patronBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(33, 117);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 25);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name:";
            // 
            // iDLbl
            // 
            this.iDLbl.AutoSize = true;
            this.iDLbl.Location = new System.Drawing.Point(38, 172);
            this.iDLbl.Name = "iDLbl";
            this.iDLbl.Size = new System.Drawing.Size(56, 25);
            this.iDLbl.TabIndex = 4;
            this.iDLbl.Text = "ID #:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(159, 172);
            this.idTxt.Multiline = true;
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(198, 31);
            this.idTxt.TabIndex = 5;
            this.idTxt.Validating += new System.ComponentModel.CancelEventHandler(this.PatronID_Validating);
            this.idTxt.Validated += new System.EventHandler(this.PatronID_Validated);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(33, 360);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(688, 70);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // PatronInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 473);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.iDLbl);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.patronBtn);
            this.Controls.Add(this.patronNameTxt);
            this.Controls.Add(this.patronLabel);
            this.Name = "PatronInputForm";
            this.Text = "InputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patronLabel;
        private System.Windows.Forms.TextBox patronNameTxt;
        private System.Windows.Forms.Button patronBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label iDLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button cancelBtn;
    }
}