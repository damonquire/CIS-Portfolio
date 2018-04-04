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
{//this class returns books
    public partial class ReturnForm : Form
    {
        
        public ReturnForm(List<LibraryItem> books, List<LibraryPatron> patrons)
        {//precondition: none
            //postcondition: all checked ou items are in combo box
          
            InitializeComponent();

            foreach (LibraryBook book in books)
            {
                if (book.IsCheckedOut())
                    bookcomboBox.Items.Add(book);
            }
        }

        ErrorProvider error1 = new ErrorProvider();
        private void returnBookInput_Validating(object sender, CancelEventArgs e)
        {//precondition: must not have one selected
            //postcondition: event cancelled

            if (bookcomboBox.SelectedIndex <= -1)
            {
                error1.SetError(bookcomboBox, "Select a Book!");
                e.Cancel = true;
            }

        }
        private void returnBookInput_Validated(object sender, EventArgs e)
        {//precondtion: one must be selected
            //postcondition: error cleared
            error1.SetError(bookcomboBox, "");

        }



        private void ReturnForm_Load(object sender, EventArgs e)
        {

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {//precondition: must validate
            //postcondition: dialog box formed
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }

        private void cnclBtn_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: result cancelled
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
