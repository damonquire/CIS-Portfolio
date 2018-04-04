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
            
            double gpascore;//declared double variable
            double.TryParse(gpaTextbox.Text, out gpascore);//took text from textbox and converted to double
            double testscore;//declared double variable
            double.TryParse(testScoreTextbox.Text, out testscore);//took text from textbox and converted to double

            if ((gpascore >= 3.0 && testscore >= 60) || (gpascore < 3.0 && testscore >= 80))
            //if statement for criteria to be accpeted

            {
                MessageBox.Show("Accept!");//message box shows "Accept" when criteria is met
                accepttotal += ADD_ACCEPT;//added 1 to accept total
                acceptedOutputLabel.Text = accepttotal.ToString();//output label displays total in string

            }

            else//shows what happens if if statement criteria is not met

            { MessageBox.Show("Reject!");//message box displays "Reject" if criteria in if statement isnt met
                rejecttotal += ADD_REJECT;//added 1 to reject total
                rejectedOutputLabel.Text = rejecttotal.ToString();//output displays new total in string
            }
            

                
              

        }
    }
}
