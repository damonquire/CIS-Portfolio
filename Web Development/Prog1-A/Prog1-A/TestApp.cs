using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A
{//simple test app to display the different items and different ways of calculating late fee
    class TestApp
    {//precondition: none
        //postcondition: console displays string
        static void Main(string[] args)
        {

           
     LibraryBook book1 = new LibraryBook("Green Eggs and Ham", "Suess", "Dr Suess inc", 1999, "1234", 12);
     LibraryJournal journal1 = new LibraryJournal("NRA Journal", "NRA inc", 2010, "123456", 13, 2, 3, "guns", "editor1");
      LibraryMagazine mag1 = new LibraryMagazine("NRA Mag", "Guns inc", 2015, "12345", 12, 4, 1);
    LibraryMovie movie1 = new LibraryMovie("Forrest Gump", "Bubba",
        2005, "12567", 14, 2, "Ltn Dan", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13);
            LibraryMusic cD1 = new LibraryMusic("Kenny Chesney's top hits", "Kenny inc", 2010, "1234", 10, 2, "Kenny", LibraryMediaItem.MediaType.CD, 12);
            LibraryPatron patron1 = new LibraryPatron("Damon", "12345");//instances of objects from each class

            string NL = Environment.NewLine;//shortcut for new line

            Console.WriteLine("Library items to start:\n");
            Console.WriteLine($"{book1}\n");
            Console.WriteLine($"{journal1}\n");
            Console.WriteLine($"{mag1}\n");
            Console.WriteLine($"{movie1}\n");
            Console.WriteLine($"{cD1}\n");
            Console.WriteLine($"\n");//displays strings on console
            Console.WriteLine("Library items with fee:\n");
            Console.WriteLine($"{book1}{NL}Fee after 1 day late: {book1.CalcLateFee(1)}\n");
            Console.WriteLine($"{journal1}{NL}Fee after 1 day late: {journal1.CalcLateFee(1)}\n");
            Console.WriteLine($"{mag1}{NL}Fee after 1 day late: {mag1.CalcLateFee(1)}\n");
            Console.WriteLine($"{movie1}{NL}Fee after 1 day late: {movie1.CalcLateFee(1)}\n");
            Console.WriteLine($"{cD1}{NL}Fee after 1 day late: {cD1.CalcLateFee(1)}\n");
            //displays strings+the late fee for 1 day late
            



        }
    }
}
