using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{//this class validates all inputs from textboxes and creates a dialog box
    public partial class BookInputForm : Form
    {
        public BookInputForm()
        {
            InitializeComponent();
        }
        ErrorProvider error1 = new ErrorProvider();//to use error

        internal string bookTitle
        { get { return titleTxt.Text; }
        set { titleTxt.Text = value; }
        }//precondition: none
        //postcondition: value is set

internal string bookPublisher
        { get { return publTxt.Text; }
        set { publTxt.Text = value; }
        }//precondition: none
         //postcondition: value is set
        internal string bookCopyRightYear
        {
            get { return cPyTxt.Text; }
            set { cPyTxt.Text = value; }
        }//precondition: none
         //postcondition: value is set
        internal string bookLoanPeriod
        {
            get { return loanTxt.Text; }
            set { cPyTxt.Text = value; }
        }//precondition: none
         //postcondition: value is set
        internal string bookCallNumber
        { get { return callNumTxt.Text; }
        set { callNumTxt.Text = value; }

        }//precondition: none
        //postcondition: value is set
        internal string bookAuthor
        { get { return authorTxt.Text; }
        set { authorTxt.Text = value; }
        }//precondition: none
        //postcondition: value is set

        private void bookTitle_Validating(object sender, CancelEventArgs e)
        {//precondition: string must be null
            //postcondition: event is cancelled and error produced
            if (string.IsNullOrEmpty(titleTxt.Text))
                
            {
                error1.SetError(titleTxt, "Enter a Title!");
                e.Cancel = true;
                titleTxt.SelectAll();
            }

            
        }
        private void bookTitle_Validated(object sender, EventArgs e)
        {//precondition: everything must validate
            //postcondition: error cleared
            error1.SetError(titleTxt, "");
            
            
           
            
            // Clears error message
        }

        private void bookPunlisher_Validating(object sender, CancelEventArgs e)
        {//precondition: string must be null
            //postcondition: event is cancelled and error produced
            if (string.IsNullOrEmpty(publTxt.Text))
                
            {
                error1.SetError(publTxt, "Enter a Publisher!");
                e.Cancel = true;
                publTxt.SelectAll();
            }
        }

        private void bookPublisher_Validated(object sender, EventArgs e)
        { error1.SetError(publTxt, ""); }
        //precondition: everything must validate
        //postcondition: error cleared

        private void copyRight_Validating(object sender, CancelEventArgs e)
        { int copyRightInt;//to try to parse into
            //precondition: value must be a non-int type or be below 0
            //postcondition:event cancelled and error set
            if (!int.TryParse(cPyTxt.Text, out copyRightInt))
            {
                error1.SetError(cPyTxt, "Enter an Integer!");
                e.Cancel = true;
                cPyTxt.SelectAll();
            }
            else if (copyRightInt < 0)
            {
                error1.SetError(cPyTxt, "Enter an integer above 0!");
                e.Cancel = true;
                cPyTxt.SelectAll();
            }
        }

        private void copyRight_Validated(object sender, EventArgs e)

        { error1.SetError(cPyTxt, ""); }
        //precondition: everything must validate
        //postcondition: error cleared

        private void callNumber_Validating(object sender, CancelEventArgs e)
        {//precondition: string must be null
            //postcondition: event is cancelled and error produced
            if (string.IsNullOrEmpty(callNumTxt.Text))
            {
                error1.SetError(callNumTxt, "Enter a Call Number!");
                e.Cancel = true;
                callNumTxt.SelectAll();
            }
        }

        private void callNumber_Validated(object sender, EventArgs e)
        { error1.SetError(callNumTxt, ""); }//precondition: everything must validate
                                            //postcondition: error cleared

        private void loanPeriod_Validating(object sender, CancelEventArgs e)
        {//precondition: value must be a non-int type or be below 0
            //postcondition:event cancelled and error set
            int loanPeriodInt;//to try and parse into
            if (!int.TryParse(loanTxt.Text, out loanPeriodInt))
            {
                error1.SetError(loanTxt, "Enter an Integer!");
                e.Cancel = true;
                loanTxt.SelectAll();
            }
            else if (loanPeriodInt < 0)
            {
                error1.SetError(loanTxt, "Enter an integer above 0!");
                e.Cancel = true;
                loanTxt.SelectAll();
            }
        }
        private void loanPeriod_Validated(object sender, EventArgs e)
        { error1.SetError(loanTxt, ""); }//precondition: everything must validate
                                         //postcondition: error cleared

        private void author_Validating(object sender, CancelEventArgs e)
        {//precondition: string must be null
            //postcondition: event is cancelled and error produced
            if (string.IsNullOrEmpty(authorTxt.Text))
            {
                error1.SetError(authorTxt, "Enter an author!");
                e.Cancel = true;
                authorTxt.SelectAll();
            }
        }
        private void author_Validated(object sender, EventArgs e)
        { error1.SetError(authorTxt, ""); }//precondition: everything must validate
                                           //postcondition: error cleared

        private void addBookBtn_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: dialog box shown
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void cancelBkBtn_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: result cancelled
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
