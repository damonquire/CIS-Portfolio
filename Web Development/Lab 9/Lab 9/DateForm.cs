using System;/*B8829
               lab 9
               November 29th
               CIS 199-75
               Program uses a seperate class to test values and assign them to variables to update the date text shown*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    
    public partial class DateForm : Form
    {
        
        private Date getDate = new Date();//to access getDate from Date class
        


        public DateForm()
        {
            InitializeComponent();
            



        }
        
        private void DateForm_Load(object sender, EventArgs e)//load event 
        {
            outputLabel.Text = getDate.ToString();//default date for when form loads
            
        }

        private void monthButton_Click(object sender, EventArgs e)
        //click event
        //precondition: has to be between 1-12
        //postcondition: displays new month number
        { int monthNumber;//int to store parsed textbox
            if (int.TryParse(monthTextBox.Text, out monthNumber))
            {
                getDate.month = monthNumber;//assign value from textbox to Date class 

                outputLabel.Text = getDate.month.ToString("d2") + "/" + getDate.day.ToString("d2") + "/" + getDate.year.ToString();
            }//display result
            else MessageBox.Show("Enter a correct month!");//error message
        }

        private void dayButton_Click(object sender, EventArgs e)//click event
        {//precondition: has to be between 1 and 31
            //postcondition: displays new number for day
            int dayNumber;//int to store parsed textbox
            if (int.TryParse(dayTextBox.Text, out dayNumber))

            {
                getDate.day = dayNumber;//assign value from textbox to Date class
                outputLabel.Text = getDate.month.ToString("d2") + "/" + getDate.day.ToString("d2") + "/" + getDate.year.ToString();
            }//display result
            else MessageBox.Show("Enter a correct Day!");//error message
        }

        private void yearButton_Click(object sender, EventArgs e)//click event
        {//precondition: can't be negative number
            //post condition: displays new year number
            int yearNumber;//int to store parsed textbox
            if (int.TryParse(yearTextBox.Text, out yearNumber))
            {
                getDate.year = yearNumber;//assign value from textbox to Date class
                outputLabel.Text = getDate.month.ToString("d2") + "/" + getDate.day.ToString("d2") + "/" + getDate.year.ToString();
            }//display results
            else MessageBox.Show("Enter a correct year!");//error message
        }



    }


}
