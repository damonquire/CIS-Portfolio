using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library journal and creates a string representation
    public class LibraryJournal : LibraryPeriodical

    { private string _discipline;
        private string _editor; //backing fields

        public LibraryJournal(string theTitle, string thePublisher,
                int theCopyrightYear, string theCallNumber, int theLoanPeriod,
                int theVolume, int theNumber, string theDiscipline, string theEditor) : base(theTitle, thePublisher,
                    theCopyrightYear, theCallNumber, theLoanPeriod, theVolume, theNumber)
        {//library journal is initialized 
            Discipline = theDiscipline;
            Editor = theEditor;
        }
        //Precondition: discipline must not be null or empty
        //postcondition: value is assigned
        public string Discipline
        {
            get { return _discipline; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _discipline = value.Trim();        // Store trimmed value
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Discipline)}", value,
                        $"{nameof(Discipline)} must not be null or empty");
            }
        }//Precondition: editor must not be null or empty
        //postcondition: value is assigned
        public string Editor
        {
            get { return _editor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _editor = value.Trim();        // Store trimmed value
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Editor)}", value,
                        $"{nameof(Editor)} must not be null or empty");
            }
        }//precondition:none
        //postcondition: the fee charged is returned
        public override decimal CalcLateFee(int daysLate)
        {
            decimal charge = .75m;//charge per day late
            decimal result = daysLate * charge;//total fee
            return result;
        }
        //precondition:none
        //postcondition: tostring is returned to show values for properties
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return $"{base.ToString()}{NL}Discipline:{Discipline}{NL}Editor:{Editor}";
        }
    }
    }

