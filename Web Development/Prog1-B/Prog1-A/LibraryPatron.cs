﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library patron and provides a string representation
    public class LibraryPatron
    {
        private string _patronName; // Name of the patron
        private string _patronID;   // ID of the patron

        // Precondition:  name and id must not be null or empty
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

            // Precondition:  value must not be null or empty
            // Postcondition: The patron's name has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _patronName = value.Trim();        // Store trimmed value
                else
                    throw new ArgumentOutOfRangeException($"{nameof(PatronName)}", value,
                        $"{nameof(PatronName)} must not be null or empty");
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

            // Precondition:  value must not be null or empty
            // Postcondition: The patron's ID has been set to the specified value
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _patronID = value.Trim();          // Store trimmed value
                else
                    throw new ArgumentOutOfRangeException($"{nameof(PatronID)}", value,
                        $"{nameof(PatronID)} must not be null or empty");
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
}
