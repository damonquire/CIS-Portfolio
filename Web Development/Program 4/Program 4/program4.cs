using System;/*B8829
               program 4
               Dec 6th
               cis199-75*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_4
{
    public partial class program4 : Form
    {
        public program4()
        {
            InitializeComponent();
        }
        private LibraryBook newBook = new LibraryBook("","","","",2016);//default instance
        List<LibraryBook> books = new List<LibraryBook>();//list to keep track of books

        private void addBookBtn_Click(object sender, EventArgs e)//click button
        {//Precondition: all text boxes must be filled
            //postcondition: adds item to list box
            int currentListboxIndex = titlesListBox.SelectedIndex;

            string t = titleTxt.Text;
            string a = authorTxt.Text;
            string p = publishTxt.Text;
            string cN = callNumTxt.Text;
            int cRy;//variables to hold values from text boxes
            if (int.TryParse(cpYTxt.Text, out cRy)) ;//parse
            else MessageBox.Show("Enter a year above 0!");//error msg
            newBook._title = t;//changing variables from other class to match text boxes
            newBook._author = a;
            newBook._publisher = p;
            newBook._callNumber = cN;
            newBook._copyRightYear = cRy;
            int bookcount = books.Count();


            if (bookcount >= 0)


            { LibraryBook newBook = new LibraryBook(t, a, p, cN, cRy);
                books.Add(newBook);
                titlesListBox.Items.Add("Title: " + newBook._title);
            }

            else { MessageBox.Show("0 books!"); }

                





            } 

        private void detailsBtn_Click(object sender, EventArgs e)//button click
        {
            int bookNumber = books.Count;
            
            //precondition: none
            //postcondition: message box shows details
            

            if (bookNumber >=0 )
            {

                int LbIndex = titlesListBox.SelectedIndex;//variable to show selected item
                
                if (LbIndex >=0)
                {
                    LibraryBook bookSelected = books[LbIndex];//variable to determine details behind listbox selection
                    MessageBox.Show(bookSelected.ToString());//shows details from book selected
                    
                }

                else
                {
                    MessageBox.Show("Select a book!");//error


                }

                
            }

            else
            {

                MessageBox.Show("0 books!");//error

            }
        
    }

        private void checkOutBtn_Click(object sender, EventArgs e)//button click... Preconditions: must have item selected
        {if (titlesListBox.SelectedIndex < 0)//makes sure something is selected... Postconditions: changes boolean
            { MessageBox.Show("Please select a book!"); }//error
            else
            {
                newBook.CheckOut();//changes boolean
                MessageBox.Show("This Book Has Been Checked Out!");//shows it's checked out
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)//click button
        {//precondition: must have item selected
            //postcondition: changes boolean

            if (titlesListBox.SelectedIndex < 0)//makes sure it's above 0
            { MessageBox.Show("Please select a book!"); }//error
            else
            {
                newBook.ReturnToShelf();
                MessageBox.Show("This Book Has Been Returned To The Shelf!");//shows its available
            }
        }

        private void clearButton_Click(object sender, EventArgs e)//click button
        {
            titleTxt.Text = String.Empty;
            authorTxt.Text = String.Empty;//clears text boxes
            publishTxt.Text = String.Empty;
            callNumTxt.Text = String.Empty;
            cpYTxt.Text = String.Empty;
            //precondition: none
            //postcondition: clears textboxes
        }
    }
}
