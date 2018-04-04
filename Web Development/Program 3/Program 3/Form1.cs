using System;/*B8829
               Program 3
               Nov. 20th
               199-75*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_3
{
    public partial class program3 : Form
    {
        public program3()
        {
            InitializeComponent();
        }

        private void findRegTimeBtn_Click(object sender, EventArgs e)//Preconditions: Must have credits above or equal to 0
                                                                     //post condition: returns time you may register

        {
            bool found = false;//boolean variable to help with while statements
            char[] juniorSeniorNameLetter = { 'A', 'E', 'J', 'P', 'T' };//char array to hold letter minimums
            char[] freshmanSophomoreNameLetter = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T','W' };//char array to hold letter minimums
            
            const float SENIOR_HOURS = 90;    // Min hours for Senior
            const float JUNIOR_HOURS = 60;    // Min hours for Junior
            const float SOPHOMORE_HOURS = 30; // Min hours for Soph.
            string[] days = { "November 4", "November 7", "November 9", "November 10", "November 11", "November 14" };//string array to hold dates

            string[] juniorSeniorTimes = { "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM" };//string array to hold times
            string[] sophomoreFreshmanTimes = {"10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM",//string array to hold times
                                               "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM"};


            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            float creditHours;        // Entered credit hours

            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            if (creditHours >= SENIOR_HOURS)
                                dateStr = days[0];
                            else // Must be juniors
                                dateStr = days[1];
                            int index = juniorSeniorNameLetter.Length - 1;//variable to point to spot in array
                            while (index >= 0 && !found)//while statement to find correct range
                                if (lastNameLetterCh >= juniorSeniorNameLetter[index])
                                    found = true;
                                else index--;//move to previous spot in array
                            if (found)
                                timeStr = juniorSeniorTimes[index];//assign value to variable

                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE_HOURS)
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = days[2];
                                else // All other letters on next day
                                    dateStr = days[3];
                            }
                            else // must be freshman
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = days[4];
                                else // All other letters on next day
                                    dateStr = days[5];
                            }
                            int index = freshmanSophomoreNameLetter.Length - 1;
                            while (index >= 0 && !found)//while statement to find correct letter range
                                if (lastNameLetterCh >= freshmanSophomoreNameLetter[index])
                                    found = true;
                                else index--;
                            if (found)
                                timeStr = sophomoreFreshmanTimes[index];//assign value to variable
                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }
    }
}
