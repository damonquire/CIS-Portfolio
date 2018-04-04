using System;//D5249, 1-A, 2/15/17, 200-01
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library item and issues a string representation
    public abstract class LibraryItem
    {
       

            public const int DEFAULT_YEAR = 2016; // Default copyright year

            private string _title;      // The book's title

            private string _publisher;  // The book's publisher
            private int _copyrightYear; // The book's year of copyright
            private string _callNumber; // The book's call number in the library
            private bool _checkedOut;
            private int _loanPeriod;// The book's checked out status

            // Precondition:  theCopyrightYear >= 0
            // Postcondition: The library book has been initialized with the specified
            //                values for title, author, publisher, copyright year, and
            //                call number. The book is not checked out.
            public LibraryItem(string theTitle, string thePublisher,
                int theCopyrightYear, string theCallNumber, int theLoanPeriod)
            {
                Title = theTitle;

                Publisher = thePublisher;
                CopyrightYear = theCopyrightYear;
                CallNumber = theCallNumber;
                LoanPeriod = theLoanPeriod;


                ReturnToShelf();



            }
            public string Title
            {
                // Precondition:  None
                // Postcondition: The title has been returned
                get
                {
                    return _title;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The title has been set to the specified value
                set
                {
                    if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        _title = value.Trim();
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(Title)}", value,
                            $"{nameof(Title)} must not be null or empty");
                }
            }


            public string Publisher
            {
                // Precondition:  None
                // Postcondition: The publisher has been returned
                get
                {
                    return _publisher;
                }

                // Precondition:  None
                // Postcondition: The publisher has been set to the specified value
                set
                {
                    // Since empty author is OK, just change null to empty string
                    _publisher = (value == null ? string.Empty : value.Trim());
                }
            }

            public int CopyrightYear
            {
                // Precondition:  None
                // Postcondition: The copyright year has been returned
                get
                {
                    return _copyrightYear;
                }

                // Precondition:  value >= 0
                // Postcondition: The copyright year has been set to the specified value
                set
                {
                    if (value >= 0)
                        _copyrightYear = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(CopyrightYear)}", value,
                            $"{nameof(CopyrightYear)} must be >= 0");
                }
            }

            public string CallNumber
            {
                // Precondition:  None
                // Postcondition: The call number has been returned
                get
                {
                    return _callNumber;
                }

                // Precondition:  value must not be null or empty
                // Postcondition: The call number has been set to the specified value
                set
                {
                    if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                        _callNumber = value.Trim();
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(CallNumber)}", value,
                            $"{nameof(CallNumber)} must not be null or empty");
                }
            }
            public int LoanPeriod//precondition: must be non negative
            //postcondition: value is assigned to loan period
            {
                get { return _loanPeriod; }
                set
                {
                    if (value >= 0)
                        _loanPeriod = value;
                    else
                        throw new ArgumentOutOfRangeException($"{nameof(LoanPeriod)}", value,
                            $"{nameof(LoanPeriod)} must be >= 0");
                }
            }

            // Create HAS-A
            public LibraryPatron Patron
            {
                // Precondition:  None
                // Postcondition: The book's patron has been returned
                get; // Auto-implement is fine

                // Helper
                // Precondition:  None
                // Postcondition: The book's patron has been set to the specified value
                private set; // Auto-implement is fine 
            }

            // Precondition:  thePatron != null
            // Postcondition: The book is checked out
            public void CheckOut(LibraryPatron thePatron)
            {
                _checkedOut = true;
                if (thePatron != null)
                    Patron = thePatron;
                else
                    throw new ArgumentNullException($"{nameof(thePatron)}", $"{nameof(thePatron)} must not be null");
            }

            // Precondition:  None
            // Postcondition: The book is not checked out
            public void ReturnToShelf()
            {
                _checkedOut = false;
                Patron = null; // Remove previously stored reference to patron
            }

            // Precondition:  None
            // Postcondition: true is returned if the book is checked out,
            //                otherwise false is returned
            public bool IsCheckedOut()
            {
                return _checkedOut;
            }

            

            public abstract decimal CalcLateFee(int daysLate);//abstract method to be defined by other classes


            public override string ToString()
        {// Precondition:  None
         // Postcondition: A string is returned presenting the libary book's data on
         //                separate lines
            string NL = Environment.NewLine; // NewLine shortcut
                string checkedOutBy; // Holds checked out message

                if (IsCheckedOut())
                    checkedOutBy = $"Checked Out By: {NL}{Patron}";//determines if checked out or not
                else
                    checkedOutBy = "Not Checked Out";

                return $"Title: {Title}{NL}Publisher: {Publisher}{NL}" +
                    $"Copyright: {CopyrightYear:D4}{NL}{checkedOutBy}{NL}Loan Period: {LoanPeriod}";



            }
        }
    }

