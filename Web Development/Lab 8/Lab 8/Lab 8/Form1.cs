using System;/*B8829
               Lab 8
               Nov 13th
               199-75
               program uses a while loop to step through array in order to find corresponding ticket cost*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class lab8 : Form
    {
        public lab8()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)//click event
        {//precondition:number must be >=0
         //postcondition: label displays cost of ticket   

            int milesTraveled;//variable to store int from textbox

            if (int.TryParse(inputTextbox.Text, out milesTraveled));//parse text to int variable
            else MessageBox.Show("Enter a correct number of Miles!");//error message for a failed parse

            int[] lowerLimitMilesTraveledArray = { 0, 100, 300, 500 };//array to store lower limits
            int[] ticketCostArray = { 25, 40, 55, 70 };//array to store ticket price
            bool found = false;//boolean variable to help loop stop
            int index = lowerLimitMilesTraveledArray.Length - 1;//start at last number in array 
            int ticketPrice = 0;//value for bad input

            while (index >= 0 && !found)//makes sure index is greater than 0 and not discovered yet
                if (milesTraveled >= lowerLimitMilesTraveledArray[index])//makes sure # of miles is greater tham the lower limit
                    found = true;//set to true if found
                else index--;//subtract 1 from index to move to next position
            if (found)//if number is found
                ticketPrice = ticketCostArray[index];//ticket price= value from array at same position as parrallel array
            outputLabel.Text = ticketPrice.ToString("c");//display cost of ticket in currency
                           
                    
                    
                    }

    }
}
