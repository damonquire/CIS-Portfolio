using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library media item and provides a string representation
    public abstract class LibraryMediaItem : LibraryItem
    {
        private double _duration;//backing field
        public LibraryMediaItem(string theTitle, string thePublisher,
                        int theCopyrightYear, string theCallNumber, int theLoanPeriod, double theDuration)
                    : base(theTitle, thePublisher, theCopyrightYear, theCallNumber, theLoanPeriod)
            //precondition: none
            //postcondition: Media item is initialized
        {
            Duration = theDuration;
            
        }//precondition: value must be greater than or equal to 0
        //postcondition: value is assigned to duration
        public double Duration
        {
            get { return _duration; }
            set
            {
                if (value >= 0)
                    _duration = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Duration)}", value,
                        $"{nameof(Duration)} must be >= 0");
            }

        }
       public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }//enum to hold media types

        public abstract MediaType Medium //precondition: none
            //postcondition: allows other classes to access
        {

            get;set;
        }
        public override string ToString()
        {
            string NL = Environment.NewLine; // NewLine shortcut
            return $"{base.ToString()}{NL}Duration:{Duration}";
            //precondition: none
            //postcondition: string rep of properties is returned
        }





    }

    }


    
