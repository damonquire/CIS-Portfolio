using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library magazine and calculates late fee and provides a string
    class LibraryMagazine:LibraryPeriodical
    {public LibraryMagazine(string theTitle, string thePublisher,
                int theCopyrightYear, string theCallNumber, int theLoanPeriod,
                int theVolume, int theNumber) : base(theTitle, thePublisher,
                    theCopyrightYear, theCallNumber, theLoanPeriod, theVolume, theNumber)
        { }//library magazine is initialized
        public override decimal CalcLateFee(int daysLate)
        {//precondition:result must be less than or equal to 20
            //postcondition:value is returned for the fee
            decimal maxCharge = 20.00m;//max amount to be charged
            decimal charge = .25m;//charge per day late
            decimal result = daysLate * charge;//total fee if less than or equal to 20
            if (result <= maxCharge)
                return result;
            else
                return maxCharge;
        }

        public override string ToString()//precondition: none
            //postcondition: string rep. of property values
        {
            return $"{base.ToString()}";
        }
    }
}
