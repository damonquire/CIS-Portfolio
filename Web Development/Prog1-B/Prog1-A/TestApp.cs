using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog1_A//1_B using 1_A's namespace
{//simple test app to use LINQ in order to display and alter data 
    //D5249, 1-B, 2/23/17, 200-01
    class TestApp
    {
        public static void Pause()
        {//precondition:none
            //postcondition: console will pause until a key is pressed
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true); //pauses application
        }

        static void Main(string[] args)
        {//precondition: none
         //postcondition: console displays string


            LibraryPatron[] patrons = {
            new LibraryPatron("Damon Quire","12345"),
            new LibraryPatron("Andrew Wright", "23456"),
            new LibraryPatron("Peyton Manning","181818"),
            new LibraryPatron("Kobe Bryant", "242424"),
            new LibraryPatron("Samuel L Jackson", "234244")};//array to fill list
            List<LibraryPatron> patronList = new List<LibraryPatron>();//list of patron objects
            patronList.Add(patrons[0]);
            patronList.Add(patrons[1]);
            patronList.Add(patrons[2]);
            patronList.Add(patrons[3]);
            patronList.Add(patrons[4]);
            

            LibraryItem[] items = {
       new LibraryBook("Green Eggs and Ham", "Suess", "Dr Suess inc", 1999, "1234", 12),
       new LibraryBook("Lord of The Rings", "Tolkien", "LOTR", 1988, "12345",12),
       new LibraryJournal("NRA Journal", "NRA inc", 2010, "123456", 13, 2, 3, "guns", "editor1"),
       new LibraryJournal("UofL Journal", "UofL inc", 2009, "1468", 12, 1, 1, "University", "editor2"),
       new LibraryMagazine("NRA Mag", "Guns inc", 2015, "12345", 12, 4, 1),
       new LibraryMagazine("NRA Mag", "Guns inc", 2015, "123456", 12, 5, 2),
       new LibraryMovie("Forrest Gump", "Bubba",
       2005, "12567", 14, 2, "Ltn Dan", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.PG13),
       new LibraryMovie("Lion King", "Lion", 2000, "5678", 12, 2, "King", LibraryMovie.MediaType.BLURAY,
       LibraryMovie.MPAARatings.PG),
       new LibraryMusic("Kenny Chesney's top hits", "Kenny inc", 2010, "1234", 10, 2, "Kenny",
       LibraryMediaItem.MediaType.CD, 12),
       new LibraryMusic("Luke Bryan's top hits", "Luke inc", 2015, "6956", 12, 1, "Luke Bryan",
       LibraryMediaItem.MediaType.VINYL,12)};//array to fill list

            string NL = Environment.NewLine;//shortcut for new line

            List<LibraryItem> itemsList = new List<LibraryItem>();//list of libraryitem objects
            itemsList.Add(items[0]);
            itemsList.Add(items[1]);
            itemsList.Add(items[2]);
            itemsList.Add(items[3]);
            itemsList.Add(items[4]);
            itemsList.Add(items[5]);
            itemsList.Add(items[6]);
            itemsList.Add(items[7]);
            itemsList.Add(items[8]);
            itemsList.Add(items[9]);

            //bullet point #1
            foreach (LibraryItem libItem in itemsList)
                Console.WriteLine($"{libItem}{NL}");//display each item in list
            Pause();
            
            //bullet point #2
            itemsList[0].CheckOut(patronList[0]);
            itemsList[1].CheckOut(patronList[1]);
            itemsList[2].CheckOut(patronList[2]);//check out items and assign patrons
            itemsList[8].CheckOut(patronList[3]);
            itemsList[9].CheckOut(patronList[4]);
            Console.WriteLine($"{NL}\n\nLibrary Items After Some Have Been Checked Out:");
            foreach (LibraryItem libItem in itemsList)
                Console.WriteLine($"\n{libItem}{NL}");//display items that are checked out
            Pause();

            //bullet point #3
            Console.WriteLine($"\n\nItems that have been checked out:\n");
            var checkedOutItems =//variable to store query 
                from i in itemsList
                where i.IsCheckedOut()
                select i;
            foreach (LibraryItem item in checkedOutItems)
                Console.WriteLine($"\n{item}{NL}");//shows items that have been checked out
            Console.WriteLine($"Number of checked out Items:{checkedOutItems.Count()}");//shows # of items checked out
            Pause();

            //bullet point #4
            Console.WriteLine($"\n\nItems checked out that are Media items ONLY:\n");
            var mediaCheckedOut =//variable to store query
                from c in checkedOutItems
                where (c.GetType() ==typeof(LibraryMovie))||(c.GetType()==typeof(LibraryMusic))//make sure its a movie or music object
                select c;
            foreach(LibraryItem item in mediaCheckedOut)
                Console.WriteLine($"\n{item}{NL}");//display checked out media item objects
            Pause();

            //bullet point #5
            Console.WriteLine($"\n\nUnique Library Magazine Titles:\n");//header
            var magTitles =//variable to store query of only magazine titles
                from i in itemsList
                where i.GetType() == typeof(LibraryMagazine)
                select new { i.Title };

            var uniqueMagTitles =//varibale to store magazine titles that are unique
                from m in magTitles.Distinct()
                select m;
                foreach ( var item in uniqueMagTitles)
                Console.WriteLine($"\n{item}{NL}");//shows only unique magazine titles

            Pause();

            //bullet point #6
            Console.WriteLine($"\n\nItems with 14 days late fee added:\n");//header
            foreach (var item in itemsList)
                Console.WriteLine($"\nTitle: {item.Title}{NL}Call Number: {item.CallNumber}{NL}14 Days Late Fee: {item.CalcLateFee(14):C2}\n");
            //shows late fee, call number, and title of objects
            Pause();

            //bullet point #7
            Console.WriteLine($"\n\nItems returned and number of items checked out now counted again:\n");
            itemsList[0].ReturnToShelf();
            itemsList[1].ReturnToShelf();//return all checked out items
            itemsList[2].ReturnToShelf();
            itemsList[8].ReturnToShelf();
            itemsList[9].ReturnToShelf();
            Console.WriteLine($"Number of checked out Items:{checkedOutItems.Count()}\n");//shows all are checked in

            Pause();

            //bullet point #8
            Console.WriteLine($"\n\nCurrent Loan Periods for books: \n");//header

            foreach (var item in itemsList)
            {
                if (item.GetType() == typeof(LibraryBook))//makes sure type is correct to avoid casting issues
                {
                    Console.WriteLine(item.LoanPeriod);
                    
                }//writes current loan period for books (would've done this all in one loop 
                //instead of 2 but couldnt figure out how to put 2 different headings for original and 
                //current loan periods after adding 7 without it displaying for each item
                
            }
            Console.WriteLine("Add 7 to Loan Period:\n\n");//adds 7 to loan periods of books only and displays them
            foreach (var item in itemsList)
            {
                if (item.GetType()==typeof(LibraryBook))
                {
                    item.LoanPeriod += 7;
                    Console.WriteLine(item.LoanPeriod);
                }
            }
            Pause();


            //Bullet point #9
            Console.WriteLine("\nAll items displayed:\n");//display all objects one last time
            foreach (LibraryItem item in itemsList)
                Console.WriteLine($"{item}{NL}");

            
            
           








            




        }
    }
}
