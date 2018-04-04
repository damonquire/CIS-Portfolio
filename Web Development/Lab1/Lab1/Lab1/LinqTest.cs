using System;//this is a simple test to use link to sort and select and then display results to console
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args) //precondition: none
            //postcondition: writes to console depending on sort and selected properties
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            // Display original array
            Console.WriteLine("Original Invoice Data\n");
            Console.WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------");

            foreach (Invoice inv in invoices)
                Console.WriteLine(inv);

            //SORT BY PART DESCRIPTION
            var sortedByPartDescription = from pD in invoices
                                              orderby pD.PartDescription //variable to sort by part description
                                              select pD;
            
                                          
            Console.WriteLine("\nInvoice sorted by Part Description:");
            
            Console.WriteLine("\nP.Num Part Description     Quant Price"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------");
            foreach (Invoice item in sortedByPartDescription)
                Console.WriteLine($" {item}"); //writes each sorted invoice onto console
            Console.WriteLine();

            //Sort by Price
            Console.WriteLine("\nInvoice sorted by price:");
            var sortedByPrice = from value in invoices //variable to sort by price
                                orderby value.Price descending
                                select value;
           
            Console.WriteLine("\nP.Num Part Description     Quant Price"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------");
            foreach (Invoice item in sortedByPrice) //writes each invoice sorted by price to console
                Console.WriteLine($" {item}");
            Console.WriteLine();

            //Select part description and quantity and sort by quantity
            Console.WriteLine("\nInvoice displaying only Part Description and Quantity and sorted by Quantity");
            Console.WriteLine("\n    Part Description               Quantity");
            var pDandQ = from i in invoices
                         select new { i.PartDescription, i.Quantity }; //variable to select only descritpion and quant
            var sortedByQ = from value in pDandQ
                            orderby value.Quantity descending
                            select value;
            foreach (var item in sortedByQ) //variable to sort the 2 properties by quantity 
                Console.WriteLine($" {item}");// writes them to the console
            Console.WriteLine();

            //Select part description and value of the each invoice (QxP)
            Console.WriteLine("\nInvoice displaying Part Description and Newly Calculated Total");
            Console.WriteLine("\n   Part Description                  Invoice Total");
            var selectpDandV = from i in invoices
                               let total = i.Price * i.Quantity //variable to create a new property of total
                               select new { i.PartDescription, total };
            var sortByValue = from value in selectpDandV //variable to sort by new Total
                              orderby value.total descending
                              select value;
            foreach (var item in sortByValue) //write to console
                Console.WriteLine($" {item}");
            Console.WriteLine();

            //select invoice totals in range of 200-500 inclusively

            var between200and500 = //variable to list only invoices with totals between 200 and 500
                from value in selectpDandV
                where (value.total >= 200) && (value.total <= 500)
                select value;
            Console.WriteLine("\nInvoices with totals in the range of " + $"{200:C}-{500:C} per month:");
            Console.WriteLine("\n   Part Description                  Invoice Total");
            foreach (var item in between200and500)
                Console.WriteLine($" {item}"); //write to console

           
        
        }
    }
}
