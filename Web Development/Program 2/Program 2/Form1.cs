using System;/*B8829
               Program 2
               CIS 199-75
               October 11th??
               This program displays the earliest date and time a student may register for classes*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }

        private void outputButton_Click(object sender, EventArgs e) //click event for button
        {

            double credithours;//declared variable
            if (double.TryParse(creditHoursTextBox.Text, out credithours)) ;
            //attempts to parse the text into a double and returns it to variable if successful
            else
                MessageBox.Show("Enter a correct number of credit hours");
            //shows message box if parse fails



            string name;//declared variable
            name = nameTextBox.Text;
            char nameletter = name[0];//declared variable

            if (credithours >= 60) //determines if user has 60 or more credit hours
            { if (nameletter <= 'd')//determines if user entered a letter within a-d
                    timeOutputLabel.Text = "2:00 PM";
                else if (nameletter <= 'i')//determines if user entered a letter within e-i
                    timeOutputLabel.Text = "4:00 PM";
                else if (nameletter <= 'o')//determines if user entered a letter within j-o
                    timeOutputLabel.Text = "8:30 AM";
                else if (nameletter <= 's')//determines if user entered a letter within p-s
                    timeOutputLabel.Text = "10:00 AM";
                else if (nameletter <= 'z')//determines if user entered a letter within t-z
                    timeOutputLabel.Text = "11:30 AM";
                //time label displays corresponding time based on credit hours and last name
            }
            else ///if statement for users that have less that 60 hours
            {
                if (nameletter <= 'b') //determines if user entered a letter within a-b
                    timeOutputLabel.Text = "10:00 AM";
                else if (nameletter <= 'd')//determines if user entered a letter within c-d
                    timeOutputLabel.Text = "11:30 AM";
                else if (nameletter <= 'f')//determines if user entered a letter within e-f
                    timeOutputLabel.Text = "2:00 PM";
                else if (nameletter <= 'i')//determines if user entered a letter within g-i
                    timeOutputLabel.Text = "4:00 PM";
                else if (nameletter <= 'l')//determines if user entered a letter within j-l
                    timeOutputLabel.Text = "8:30 AM";
                else if (nameletter <= 'o')//determines if user entered a letter within m-o
                    timeOutputLabel.Text = "10:00 AM";
                else if (nameletter <= 'q')//determines if user entered a letter within p-q
                    timeOutputLabel.Text = "11:30 AM";
                else if (nameletter <= 's')//determines if user entered a letter within r-s
                    timeOutputLabel.Text = "2:00 PM";
                else if (nameletter <= 'v')//determines if user entered a letter within t-v
                    timeOutputLabel.Text = "4:00 PM";
                else if (nameletter <= 'z')//determines if user entered a letter within w-z
                    timeOutputLabel.Text = "8:30 AM";
                    }//time label displays corresponding time based on credit hours and last name

            if (credithours >= 90)//if statement to allocate corresponding dates
                dateOutputLabel.Text = "Friday, November 4th";
            else if (credithours >= 60)
                dateOutputLabel.Text = "Monday, November 7th";
            else if (credithours >= 30 && nameletter <= 'i')
                dateOutputLabel.Text = "Thursday, November 10th";
            else if (credithours >= 30 && nameletter <= 'v')
                dateOutputLabel.Text = "Wednesday, November 9th";
            else if (credithours >= 30 && nameletter <= 'z')
                dateOutputLabel.Text = "Thursday, November 10th";
            else if (credithours < 30 && nameletter <= 'i')
                dateOutputLabel.Text = "Monday, November 14th";
            else if (credithours < 30 && nameletter <= 'v')
                dateOutputLabel.Text = "Friday, November 11th";
            else if (credithours < 30 && nameletter <= 'z')
                dateOutputLabel.Text = "Monday, November 14th";
            //date output label displays corresponding date based on number of credit hours and last name
                    
                    


            
                
               



        }
    }
}
