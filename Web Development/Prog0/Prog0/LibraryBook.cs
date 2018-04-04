// Program 0
// Starting Point

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2016; // Default copyright year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    private LibraryPatron _patron;
    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number, and a Library Patron object. The book is not checked out.
    public LibraryBook(string theTitle, string theAuthor, string thePublisher,
        int theCopyrightYear, string theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;
        

        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  the title must not be blank or whitespace
        // Postcondition: The title has been set to the specified value and trimmed or an exception is thrown
        set
        {
           
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(
                 nameof(value), value, $"{nameof(Title)} must not be blank");
            }
            else
                _title = value.Trim();
        }
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
            _author = value;
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
            _publisher = value;
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
        // Postcondition: The copyright year has been set to the specified value or an exception is thrown
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CopyrightYear)} must not be blank");
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

        // Precondition:  The value must not be null or whitespace
        // Postcondition: The call number has been set to the specified value and trimmed or an exception is thrown
        set
        {
            
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(
                 nameof(value), value, $"{nameof(CallNumber)} must not be blank");
            }
            else
            { _callNumber = value.Trim();}
                 
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out and a patron is assigned in this process
    public void CheckOut(LibraryPatron aPatron)
    {

        Patron=aPatron;
        _checkedOut = true;
        
    }

    // Precondition:  None
    // Postcondition: The book is not checked out and it's patron object is set to null
    public void ReturnToShelf()
    {
        Patron = null;
        _checkedOut = false;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;
        
    }


   //precondition: none
   //postcondition: a Patron object is assigned a value

    public LibraryPatron Patron
        //precondition: book must be checked out by a Patron or it is returned as null
        //Postcondition: _patron is returned
    {
        get
        {
            if (_checkedOut)
                return
                    _patron;
            else
                return null;
        }
        //precondition: none
        //postcondition: _patron is assigned a value
        private set { _patron = value; }

    }
    // Precondition:  A book must be checkd out or not to recieve a certain string representation
    // Postcondition: A string is returned presenting the libary book's data on
    //                separate lines
    public override string ToString()
    {
        if (!_checkedOut)// string for if the book is not checked out        
        { return "Title: " + Title + System.Environment.NewLine +
                "Author: " + Author + System.Environment.NewLine +
                "Publisher: " + Publisher + System.Environment.NewLine +
                "Copyright: " + CopyrightYear.ToString("D4") + System.Environment.NewLine +
                "Not Checked Out";
        }
        else // string for if the book is checked out
        {
            return "Title: " + Title + System.Environment.NewLine +
                  "Author: " + Author + System.Environment.NewLine +
                  "Publisher: " + Publisher + System.Environment.NewLine +
                  "Copyright: " + CopyrightYear.ToString("D4") + System.Environment.NewLine +
                  "Checked Out by: " + Patron; 


        }

    }
}
