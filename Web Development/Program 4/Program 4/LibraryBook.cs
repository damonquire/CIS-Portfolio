using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    public class LibraryBook
    {
        private bool checkedout;//boolean to determine if checked out
        public string _author;
        public string _publisher;//variables to hold value
        public string _callNumber;
        public string _title;
        public int _copyRightYear;

        public string author

        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }
        public string publisher// get's the value and then sets it 
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }
        public string callNumber
        {
            get
            {
                return _callNumber;
            }
            set
            {
                _callNumber = value;
            }
        }
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public int copyRightYear
        {
            get //precondition:must be above 0
                //post condition: sets value
            {
                return _copyRightYear;
            }
            set
            {
                if (value >= 0) _copyRightYear = value;//makes sure it's above 0 and sets default
                else _copyRightYear = 2016;
            }
        }
        public LibraryBook(string t, string a, string p, string cN, int cPy)//constructor
        {
            title = t;
            author = a;
            publisher = p;
            callNumber = cN;//variables to be used in other class
            copyRightYear = cPy;
        }
        public override string ToString()//string method
        {
            string output;
            if (IsCheckedOut())//determines if it's checked out
            {
                output = "Title: " + _title + Environment.NewLine +
"Author: " + _author + Environment.NewLine +
"Publisher: " + _publisher + Environment.NewLine +
"Call Number: " + _callNumber + Environment.NewLine + "Copyright Year: " + _copyRightYear+Environment.NewLine+
"Status: Out";
            }
            else {
                output = "Title: " + _title + Environment.NewLine +
"Author: " + _author + Environment.NewLine +
"Publisher: " + _publisher + Environment.NewLine +
"Call Number: " + _callNumber + Environment.NewLine + "Copyright Year: " + _copyRightYear + Environment.NewLine +
"Status: Available";
            }
            return output;//returns string
        }
        
        public void CheckOut()
        {
            checkedout = true;//makes boolean true
            
        }
        public void ReturnToShelf()
        {  checkedout = false; }//makes boolean false

        public bool IsCheckedOut()
        {
            return checkedout;//returns boolean
   }

        }

    }

