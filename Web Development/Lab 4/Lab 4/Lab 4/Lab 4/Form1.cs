using System;/*B8829
              lab 4
              Oct. 2nd
              199-75
              program determines if student pass or failed while keeping a total of how many
              passed and how many failed*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class lab4 : Form
    {
        private int accepttotal = 0;//declared private start value variable for accepted running total 
        private int rejecttotal = 0;//declared private start value variable for rejected running total
        const int ADD_ACCEPT = 1;//declared a variable 1 to add to total
        const int ADD_REJECT = 1;//declared a variable 1 to add to total

        public lab4()
        {
            InitializeComponent();
        }

        private void lab4_Load(object sender, EventArgs e)//load event
        {
            acceptedOutputLabel.Text = accepttotal.ToString();//made label show and begin at 0
            rejectedOutputLabel.Text = rejecttotal.ToString();//made label show and begin at 0
        }

        private void passFailButton_Click(object sender, EventArgs e)//click event for button
        {
            double testscore;//declared double variable
            double gpascore;//declared double variable

            if (double.TryParse(gpaTextbox.Text, out gpascore))  //took text from textbox and converted to double
            {
                if (double.TryParse(testScoreTextbox.Text, out testscore))  //took text from textbox and converted to double
                {
                    if ((gpascore >= 3.0 && testscore >= 60) || (gpascore < 3.0 && testscore >= 80))
                    {
                        acceptedOutputLabel.Text = (accepttotal += ADD_ACCEPT).ToString();//adds 1 to output label
                        MessageBox.Show("Accepted!");//if all criteria is met displays "accept"
                    }
                    else
                    {
                        rejectedOutputLabel.Text = (rejecttotal += ADD_REJECT).ToString();//adds 1 to reject output
                        MessageBox.Show("Rejected!");//displays "rejected"

                    }
                }
                else
                {
                    MessageBox.Show("Enter a correct test score!");//if parse for test score fails message box tells you to enter correct number
                }
            }
            else
            { MessageBox.Show("Enter a correct GPA!"); } }//if parse fails for gpa, message box tells you to fix it
        }
    }


              
                   

                        


              
