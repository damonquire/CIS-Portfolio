using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library book and provides a string representation
    public class LibraryBook : LibraryItem
    {
        private string _author;//backing field for Author
        public LibraryBook(string theTitle, string theAuthor, string thePublisher,
            int theCopyrightYear, string theCallNumber, int theLoanPeriod)
            : base(theTitle, thePublisher, theCopyrightYear, theCallNumber, theLoanPeriod)
        {//Library Book is initialized
            Author=theAuthor;
        }
        public string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author;
            }

            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                // Since empty author is OK, just change null to empty string
                _author = (value == null ? string.Empty : value.Trim());
            }
        }

        public override decimal CalcLateFee(int daysLate) //precondition:none
            //postcondition:returns the fee amount
        {
            decimal charge = .25m;//fee per day late
            decimal result = daysLate * charge;// total fee
            return result;
        }
        public override string ToString() //precondition:none
            //postcondition:returns a string for all of the properties
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return $"{base.ToString()}{NL} Author:{Author}";
        }
    }
}
