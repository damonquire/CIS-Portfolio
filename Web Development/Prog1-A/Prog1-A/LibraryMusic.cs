using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//this class defines a library music, calculates late fee, and provides a string
    public class LibraryMusic : LibraryMediaItem

    {
        private MediaType _medium;//backing fields
        private int _numberOfTracks;
        private string _artist;
       public LibraryMusic(string theTitle, string thePublisher,
                        int theCopyrightYear,
                        string theCallNumber, int theLoanPeriod, double theDuration,
                        string theArtist, MediaType theMedium, int theNumberofTracks)
            : base(theTitle, thePublisher, theCopyrightYear,
                            theCallNumber, theLoanPeriod, theDuration)
        {//library music initialized
            Artist = theArtist;
            Medium = theMedium;
            NumberOfTracks = theNumberofTracks;
        }//precondition:none
        //postcondition: artist is assigned a value
        public string Artist
        {
            get { return _artist; }
            set { _artist=value; }
        }//precondition:must be CD, SACD, or Vinyl 
        //postcondition: medium is assigned a value
        public override MediaType Medium
        {
            get { return _medium; }

            set
            {
                if (value == MediaType.CD || value == MediaType.SACD || value == MediaType.VINYL)
                    _medium = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Medium)}", value,
                        $"{nameof(Medium)} must not be be a DVD, VHS, or BLURAY");
            }
        }
        //precondition: must be above 0
        //postcondition: value is assigned to number of tracks
        public int NumberOfTracks
        { get { return _numberOfTracks; }
        set { if (value >= 1)
                     _numberOfTracks=value;
        else
                    
          throw new ArgumentOutOfRangeException($"{nameof(NumberOfTracks)}", value,
                        $"{nameof(NumberOfTracks)} must be > 0");
            }
        }//precondition:result must be 20$ or less
        //postcondition: returns fee amount
        public override decimal CalcLateFee(int daysLate)
        {
            decimal maxCharge = 20.00m;//max charge amount
            decimal charge = .5m;//charge per day late
            decimal result=charge*daysLate;//total
            if (result <= 20)
                return result;
            else
                return maxCharge;

        }//precondition:none
        //postcondition: string rep of property values
        public override string ToString()
        {
            string NL = Environment.NewLine;
       return $"{base.ToString()}{NL}Artist:{Artist}{NL}Medium:{Medium}{NL}Number of tracks:{NumberOfTracks}";

        }





    }
    }

