using System;/*B8829
               lab 6
               Oct. 24th
               199-75
               program uses nested loops to display patterns of stars*/
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pattern A");//displays which pattern it is

            Console.WriteLine();//space between

            for (int rownumber = 1; rownumber <= 10; rownumber++)//outer loop for row numbers
            {
                for (int starnumber = 1; starnumber <= rownumber; starnumber++)//inner loop for # of start
                {
                    Console.Write("*");//display stars
                }
                Console.WriteLine();//go to next line

            }//ends the 1st pattern

            Console.Write("Pattern B");//displays which pattern

            Console.WriteLine();//space between patterns


            for (int rownumber = 10; rownumber >= 1; rownumber--)//outer loop for row number
            {
                for (int starnumber = 1; starnumber <= rownumber; starnumber++)//inner loop for # of stars
                {
                    Console.Write("*");//display stars
                }
                Console.WriteLine();//go to next line
            }//ends the second pattern

            Console.Write("Pattern C");//displays which pattern

            Console.WriteLine();//space between patterns


            for (int rownumber = 1; rownumber <= 10; rownumber++)//outer loop for row numbers
            {
                for (int spacenumber = 1; spacenumber < rownumber; spacenumber++)//inner loop for # of spaces
                {
                    Console.Write(" ");//display spaces
                }
                for (int starnumber = 10; starnumber >= rownumber; starnumber--)//inner loop for # of stars
                {
                    Console.Write("*");//display stars

                }
                Console.WriteLine();// move down a line


            }//ends 3rd pattern

            Console.Write("Pattern D");//displays which pattern

            Console.WriteLine();//space between patterns

            for (int rownumber = 1; rownumber <= 10; rownumber++)//outer loop for # of rows
            {
                for (int spacenumber = 10; spacenumber > rownumber; spacenumber--)//inner loop for # of spaces
                {
                    Console.Write(" ");//display spaces
                }
                for (int starnumber = 1; starnumber <= rownumber; starnumber++)//inner loop for # of stars
                {
                    Console.Write("*");//display stars
                }
                Console.WriteLine();//move to next line
            }
            
        }
    }
}






    






                    
               
                        






        
    
