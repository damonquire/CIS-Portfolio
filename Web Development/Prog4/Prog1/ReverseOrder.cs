using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//this class creates a reverse sort order by copyright year
// Program 4
// CIS 200-01
// Due: 4/19/17
// By: D5249
namespace LibraryItems
{
    class ReverseOrder: Comparer<LibraryItem>
    {//precondition: none
        //postcodition: sorts list in acsending order by copy right year
        public override int Compare(LibraryItem l1, LibraryItem l2)
        { return (-1) * l1.CopyrightYear.CompareTo(l2.CopyrightYear);  }
        
    }
}
