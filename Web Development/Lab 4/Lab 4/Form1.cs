// B5310
// CIS199-75
// October 2, 2016
// Lab 4
// Determines whether a user meets the GPA and Test Score criteria for acceptance
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Store variables 
            double gpaScore;
            int testScore;
            const double total = 0;
            const double increase = 1;
            const double runningTotal = total + increase;

            if (double.TryParse(gpatextBox.Text, out gpaScore))
            {
                if (int.TryParse(testScoreTextBox.Text, out testScore))

                {     // determine if user input meets acceptance criteria 

                    if (gpaScore < 3.0 & testScore >= 80)

                        label1.Text = ("Accepted");

                    if (gpaScore >= 3.0 & testScore >= 60)

                        label1.Text = ("Accepted");

                    else
                    {          // display results for rejection 
                        if (gpaScore < 3.0 & testScore < 80)

                            label1.Text = ("Rejected");

                        if (gpaScore > 3.0 || testScore < 60)

                            label1.Text = ("Rejected");
                    }

                    {
                        if (label1.Text == ("Accepted")) // If label 1 returns "accepted", then display runningTotal in acceptedLbl

                            acceptedLbl.Text = runningTotal.ToString(""); //running total of accepted applicants
                    }

                    {
                        if (label1.Text == ("Rejected")) // If label 1 returns "rejected" then display rejected in rejectedLbl

                            rejectedLbl.Text = runningTotal.ToString(""); // running total of rejected applicants
                    }
                }
            }
        }
    }
}




