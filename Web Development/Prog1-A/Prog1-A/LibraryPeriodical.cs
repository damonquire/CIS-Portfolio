using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a periodical, and provides a string
    public abstract class LibraryPeriodical:LibraryItem
    {
        private int _volume;
        private int _number;//backing fields
       public LibraryPeriodical(string theTitle, string thePublisher,
                int theCopyrightYear, string theCallNumber, int theLoanPeriod, 
                int theVolume, int theNumber):base(theTitle, thePublisher,theCopyrightYear
                    , theCallNumber, theLoanPeriod)//periodical initialized
        {
            Volume = theVolume;
            Number = theNumber;

        }//precondtion : must be >0
        //postcondition: value assigned to volume
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 1)
                    _volume = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Volume)}", value,
                       $"{nameof(Volume)} must be > 0");

            }

        }//precondition:value must be larger than 0
        //postcondition: value assigned to number

        public int Number
        {
get { return _number; }
            set
            {
                if (value >= 1)
                    _number = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Number)}", value,
                       $"{nameof(Number)} must be > 0");
            }

        }

        //precondition:none
        //postcondition: string rep of property values
        public override string ToString()
        {
            string NL = Environment.NewLine;
            return $"{base.ToString()}{NL}Volume:{Volume}{NL}Number:{Number}";
            
        }
    }
}
