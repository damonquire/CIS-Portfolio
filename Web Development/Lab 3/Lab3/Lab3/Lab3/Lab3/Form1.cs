using System;
/*B8829
 Lab 3
 Sep. 25th
 CIS 199-75
 Program displays 15, 18, and 20 percent of the total bill when button is clicked.
*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class lab3 : Form
    {
        const double startvalue = 0;//declared a value for labels to begin at
        const double smallpercenttip = .15;//declared a constant variable for 15% tip rate
        const double middlepercenttip = .18;//declared a constant variable for 18% tip rate
        const double largepercenttip = .20;//declared a constant variable for 20% tip rate
        public lab3()
        {
            InitializeComponent();
        }

        private void lab3_Load(object sender, EventArgs e)
        {
            percent15OutputLabel.Text = startvalue.ToString("c");
            percent18OutputLabel.Text = startvalue.ToString("c");//made output labels display 0$ to begin
            percent20OutputLabel.Text = startvalue.ToString("c");
             
            

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double smalltip = smallpercenttip * double.Parse(priceOfMealTextbox.Text);//declared variable small tip. Converted text to double
            percent15OutputLabel.Text = smalltip.ToString("c2");//made label display tip value converted to string

            double mediumtip = middlepercenttip * double.Parse(priceOfMealTextbox.Text);//declared variable medium tip. Converted text to double
            percent18OutputLabel.Text = mediumtip.ToString("c2");//made label display tip value converted to string

            double largetip = largepercenttip * double.Parse(priceOfMealTextbox.Text);//declared variable large tip. Converted text to double
            percent20OutputLabel.Text = largetip.ToString("c2");//made label display tip value converted to string

        }
    }
}
