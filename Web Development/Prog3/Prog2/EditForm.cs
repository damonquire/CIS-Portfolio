using System;
using System.Collections.Generic;
//D5249
//this class allows you to edit the objects by 
//pulling up the forms that you enter objects in
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{//precondiiton: none
    //postcondition: lists declared and form initialized
    public partial class EditForm : Form
    {
        private List<LibraryItem> _items;     // List of library items
        private List<LibraryPatron> _patrons;//list of patrons
        public EditForm(List<LibraryItem> books, List<LibraryPatron> patrons)
        {
            
            InitializeComponent();
            _items = books; //to use later
            _patrons = patrons;


        }

        private void button1_Click(object sender, EventArgs e)
        {//precondition: button must be clicked
            //postcondition: pulls up patron form

            if (patronComboBox.SelectedIndex >= 0)//make sure one is selected
            {
                PatronForm patronForm = new PatronForm();// instance of form

                patronForm.PatronName = _patrons[patronComboBox.SelectedIndex].PatronName;//adds info to textboxes
                patronForm.PatronID = _patrons[patronComboBox.SelectedIndex].PatronID;
                DialogResult result = patronForm.ShowDialog();//shows form
            
                if (result == DialogResult.OK)//make sure user clicked OK
                {
                    _patrons[patronComboBox.SelectedIndex].PatronName = //edits object
                        patronForm.patronNameTxt.Text;
                    _patrons[patronComboBox.SelectedIndex].PatronID =
                        patronForm.patronIdTxt.Text;
                }

                



            }
        }
        //precondition: none
        //postcondition: form loaded and items added to combobox
        private void EditForm_Load(object sender, EventArgs e)
        {
            foreach (LibraryItem item in _items)
                bookComboBox.Items.Add(item.Title + ", " + item.CallNumber);
            foreach (LibraryPatron patron in _patrons)
                patronComboBox.Items.Add(patron.PatronName + ", " + patron.PatronID);
        }//fill comboboxes
        //precondition: none
        //postcondition: book form loaded and editing done through form
        private void bookBtn_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: brings up book form
            if(bookComboBox.SelectedIndex>=0)//make sure something is selected
            { BookForm bookForm = new BookForm();
                bookForm.ItemTitle = _items[bookComboBox.SelectedIndex].Title;
                bookForm.ItemPublisher = _items[bookComboBox.SelectedIndex].Publisher;
                bookForm.ItemLoanPeriod = _items[bookComboBox.SelectedIndex].LoanPeriod.ToString();
                bookForm.ItemCopyrightYear = _items[bookComboBox.SelectedIndex].CopyrightYear.ToString();
                bookForm.ItemCallNumber = _items[bookComboBox.SelectedIndex].CallNumber;
                //adds in text to boxes
                
                DialogResult result = bookForm.ShowDialog();// show form
                if(result==DialogResult.OK)// make sure ok is clicked
                { _items[bookComboBox.SelectedIndex].Title = bookForm.ItemTitle;
                    _items[bookComboBox.SelectedIndex].Publisher = bookForm.ItemPublisher;
               _items[bookComboBox.SelectedIndex].LoanPeriod = int.Parse(bookForm.ItemLoanPeriod);
                    _items[bookComboBox.SelectedIndex].CopyrightYear = int.Parse(bookForm.ItemCopyrightYear);
                    _items[bookComboBox.SelectedIndex].CallNumber = bookForm.ItemCallNumber;
                    
                   
                    //edits properties to match text boxes

                }



            }
            
            
        }
    }
}
