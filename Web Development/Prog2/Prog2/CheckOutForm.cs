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
{
    //this class validates all inputs from selected combo box and creates a dialog box
    public partial class CheckOutForm : Form
    {

        
        public CheckOutForm(List<LibraryItem>books,List<LibraryPatron>patrons)//constructor
        {

            //precondition: none
            //postcondition: puts items in comboboxes


            InitializeComponent();

            
            foreach (LibraryPatron patron in patrons)


            {
                
                patronComboBox.Items.Add(patron);
                //add patrons to combobox
                
                 
               
            }
           
            foreach (LibraryBook book in books)
                bookComboBox.Items.Add(book); //add books to combo box
        }
        ErrorProvider error1 = new ErrorProvider();//to use error provider
        private void checkOutPatronInput_Validating(object sender, CancelEventArgs e)
        {//precondition: none must be selected
            //postcondition: even cancels andn error shows

            if (patronComboBox.SelectedIndex <= -1)
            {
                error1.SetError(patronComboBox, "Select a Patron!");
                e.Cancel = true;
            }

        }
        private void checkOutPatronInput_Validated(object sender, EventArgs e)
        {//precondition: none
            //postcondition: error erased
            error1.SetError(patronComboBox, "");

        }
        private void checkOutBookInput_Validating(object sender, CancelEventArgs e)
        //precondition: none must be selected
        //postcondition: even cancels andn error shows
        {
            if (bookComboBox.SelectedIndex <= -1)
            {
                error1.SetError(bookComboBox, "Select a Book!");
                e.Cancel = true;
            }


        }
        private void checkOutBookInput_Validated(object sender, EventArgs e)
        {//precondition: none
            //postcondition: error erased

            error1.SetError(bookComboBox, "");
        }



        private void checkOutButton_Click(object sender, EventArgs e)
        {//precondition: must validate
            //postconiditon: diolog box displayed
            if (this.ValidateChildren())
            this.DialogResult = DialogResult.OK;
            

        }

        private void checkOutBtnCncl_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: cancelled dialog result
            this.DialogResult = DialogResult.Cancel;
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            
        }

        private void checkOutButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
