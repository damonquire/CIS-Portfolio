// Program 1B
// CIS 200-01
// Due: 2/22/2017
// By: Andrew L. Wright (Students use Grading ID)

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy using
// LINQ and demonstrates polymorphism.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
// Program 4
// CIS 200-01
// Due: 4/19/17
// By: D5249
//this class displays items to console and then sorts them using various methods
public class Program
{
    // Precondition:  None
    // Postcondition: items added to list and then displayed using different sort methods
    public static void Main(string[] args)
    {

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons



        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            "MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG));
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2000, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9B", 16, 8));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2016, 14,
            "MA53 9C", 16, 9));
        items.Add(new LibraryMagazine("VB Magazine", "UofL Mags", 2017, 14,
            "MA21 5V", 1, 1));

        Console.Out.WriteLine("Orginal list:");
        foreach (LibraryItem li in items)
            Console.WriteLine(li);
        Pause();


        items.Sort(); // sort using default order
        Console.Out.WriteLine("Sorted list (natural order by Title):");
        foreach (LibraryItem li in items)
            Console.WriteLine(li);
        Pause();

        items.Sort(new ReverseOrder()); // Sort - uses specified Comparer class

        Console.Out.WriteLine("Sorted list (descending natural order) by Copyright Year:");
        foreach (LibraryItem l in items)
            Console.WriteLine(l);
        Pause();
    }


         public static void Pause()
        //precondition: none
        //postcondition: program is paused until user clicks enter
    {
        Console.WriteLine("Press Enter to Continue..."); //let user know to click a button to move on
        Console.ReadLine();

        Console.Clear(); // Clear 
    }


}
