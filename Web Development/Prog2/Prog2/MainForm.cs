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
    public partial class MainForm : Form
    {//assuming that the "about" section of the main form is adequate but just in case:
        //D5249, Cis200-01, due 3/9/17,Prog 2

        //this class serves as a front end to the library class
        //just an fyi, everything works perfectly on my end, but it seemed like 1/5 times
        //when I would only check out 1 book, then make the form show me checked out items
        //then return it, it would still remain checked out. however, this only happened
        //for me during that exact scenario, and not everytime. other times it ran
        //flawlessly under that exact scenario, and when I would check out more
        //than one item and then return them all it never left one item still checked out,
        //wierd, but I couldn't figure out if maybe my computer was slow and maybe not
        //running the checkout process fluently or what. It also Checked out and returned
        //the item flawlessly every time if I didn't make the form display the checked out
        //item before returning it. I find it strange that only in a specific scenario
        //it would mess up and most of all strange, it didnt mess up every time even under
        //the same scenario/condition, maybe you can figure out why it was doing that,
        //or if it was just a problem with my computer at run time? 
        public MainForm()
        {
            InitializeComponent();
        }

        Library item = new Library();//library instance
     
        
        


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: messagebox displayed
            MessageBox.Show("Program 2, D5249, Due 3/9/17, This application provides a front end for the library class, CIS200-01");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: exits app
            this.Close();
        }

        private void addPatronToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: result must be ok
            //postcondition: adds patron
            PatronInputForm patronInputBox = new PatronInputForm();//form instance
            
            DialogResult result;
            result = patronInputBox.ShowDialog();

            if (result == DialogResult.OK)
             item.AddPatron(patronInputBox.patronNameInput, patronInputBox.patronIdInput);
            //adds patron

            
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition:result must be OK
            //postcondition: book is added
            
            BookInputForm bookInputBox = new BookInputForm();//form instance
            DialogResult result;
            result = bookInputBox.ShowDialog();
            if (result == DialogResult.OK)
            {
                item.AddLibraryBook(bookInputBox.bookTitle, bookInputBox.bookPublisher,
                      int.Parse(bookInputBox.bookCopyRightYear),
                      int.Parse(bookInputBox.bookLoanPeriod),
                      bookInputBox.bookCallNumber, bookInputBox.bookAuthor);
                //add book
                
            }
            
        }

        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: printed to message box
            StringBuilder start = new StringBuilder();//string builder to hold string
            start.Append("count:" + item.GetPatronCount().ToString()+Environment.NewLine);
            mainTxt.Clear();//clear textbox prior
            foreach (LibraryPatron patron in item._patrons)
            {
                start.Append(patron.ToString() + Environment.NewLine);
                mainTxt.Text=start.ToString();
            }
                //show all patrons


        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: printed to message box
            StringBuilder start = new StringBuilder();//to hold string output
             start.Append( "count:" + item.GetItemCount().ToString() + Environment.NewLine);
            mainTxt.Clear();//clear textbox prior
            foreach (LibraryBook book in item._items)
            {
                start.Append(book.ToString() + Environment.NewLine);
                mainTxt.Text = start.ToString();
            }//show all books

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //precondition: none
            //postcondition: item is checked out by patron

            CheckOutForm checkoutBox = new CheckOutForm(item._items,item._patrons);
            DialogResult result;
            result = checkoutBox.ShowDialog();
            

            
                
                if(checkoutBox.bookComboBox.SelectedIndex>=0&&checkoutBox.patronComboBox.SelectedIndex>=0)
                item._items[checkoutBox.bookComboBox.SelectedIndex].
                  CheckOut(item._patrons[checkoutBox.patronComboBox.SelectedIndex]);
            //check out

            
                
                
                
        }

        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: prints checked out items
            StringBuilder start = new StringBuilder();//to use stringbuilder
            start.Append("count:" + item.GetCheckedOutCount().ToString() + Environment.NewLine);
            mainTxt.Clear();//clear textbox prior
            foreach (LibraryBook book in item._items)
            {
                if (book.IsCheckedOut())
                { start.Append(book.ToString() + Environment.NewLine);
                mainTxt.Text=start.ToString();}
            }//show all checked out books
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            item.AddPatron("Damon", "12345");//test objects
            item.AddPatron("Andrew", "2345");
            item.AddLibraryBook("Lord of the Rings", "LOTR Inc", 2010, 3, "234", "JRR Tolkien");
            item.AddLibraryBook("Cat in the hat", "Suess inc", 2009, 2, "344", "Dr Suess");

            //precondition: none
            //postcondition: adds items to lists 







        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition:returns book
            ReturnForm returnBox = new ReturnForm(item._items,item._patrons//instance of return form
                );
            //instance of checkout form
            
            DialogResult result;
            result = returnBox.ShowDialog();
            if (returnBox.bookcomboBox.SelectedIndex >= 0)
            {
                item._items[returnBox.bookcomboBox.SelectedIndex].
                     ReturnToShelf();
                mainTxt.Clear();
            }
        }
            //return selected book
        }
    }

