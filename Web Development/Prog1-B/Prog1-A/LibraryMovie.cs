using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{
    class LibraryMovie : LibraryMediaItem
    {//this class shows how to calculate the late fee for a movie, defines a movie, and provieds a string
        private string _director;//backing fields
        private MediaType _medium;
        private MPAARatings _rating;
        public enum MPAARatings { G, PG, PG13, R, NC17, U }//holds ratings
        public LibraryMovie(string theTitle, string thePublisher,
                        int theCopyrightYear, string theCallNumber,
                        int theLoanPeriod, double theDuration, string theDirector,
                        MediaType theMedium, MPAARatings theRating) : base(theTitle, thePublisher, theCopyrightYear,
                            theCallNumber, theLoanPeriod, theDuration)
            //library movie is initialized
        {

            Director = theDirector;
            Medium = theMedium;
            Rating = theRating;
        }

        public string Director
        {//precondition: can't be null ot empty
            //postcondition: value is assigned to director
            get { return _director; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                    _director = value.Trim();          // Store trimmed value
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Director)}", value,
                        $"{nameof(Director)} must not be null or empty");
            }
        }

        public override MediaType Medium
        {//precondition: value must be DVD, BLURAY ot VHS
            //postcondition: valur assigned to medium
            get
            { return _medium; }
            set
            {
                if (value == MediaType.DVD || value == MediaType.BLURAY || value == MediaType.VHS)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                        $"{nameof(Medium)} must be a DVD, VHS, or BLURAY");
            }


        }//precondition: none
        //postcondition: enum is assigned to rating
        public MPAARatings Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }//precondition:fee can't exceed 25.00
        //postcondition: total fee is returned

        public override decimal CalcLateFee(int daysLate)
        { decimal maxCharge = 25m;
            decimal result;//holds fee
            decimal dvdOrVHSCharge=1.0m;//charge for late dvd/vhs
            decimal bluRayCharge = 1.5m;//charge for late bluray
            if (Medium == MediaType.DVD || Medium == MediaType.VHS)

                result = dvdOrVHSCharge * daysLate;//result
            else
                result = bluRayCharge * daysLate;
            if (result <= maxCharge)
                return result;
            else
                return maxCharge;//returned if result was over max charge
                
                
            
            
        }//precondition: none
        //postcondition: string rep of property values
        public override string ToString()
        {
            string NL = Environment.NewLine;
            return $"{base.ToString()}{NL}Director:{Director}{NL}Medium:{Medium}{NL}Rating:{Rating}";
        }
    }
}
    

