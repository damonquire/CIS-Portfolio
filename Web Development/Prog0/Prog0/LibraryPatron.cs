// Program 0
// Starting Point

// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  the value cannot be null or white soace
        // Postcondition: The patron's name has been set to the specified value then trimmed or an exception is thrown
        set
        {

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(
                nameof(value), value, $"{nameof(PatronName)} must be not be blank");
            }
            else
            {
                _patronName = value.Trim();
                
            }
        }
    }

    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  the value must not be null or whitespace
        // Postcondition: The patron's ID has been set to the specified value and trimmed or an exception is thrown
        set
        {

            if (string.IsNullOrWhiteSpace(value))
            { throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PatronID)} must not be blank"); }
            else
            {
                _patronID = value.Trim();
                
            }
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}



