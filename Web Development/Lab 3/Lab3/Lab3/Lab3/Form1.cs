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
        const double STARTVALUE = 0;//declared a value for labels to begin at
        const double SMALLPERCENTTIP = .15;//declared a constant variable for 15% tip rate
        const double MIDDLEPERCENTTIP = .18;//declared a constant variable for 18% tip rate
        const double LARGEPERCENTTIP = .20;//declared a constant variable for 20% tip rate
        public lab3()
        {
            InitializeComponent();
        }

        private void lab3_Load(object sender, EventArgs e)
        {
            smallPercentOutputLabel.Text = STARTVALUE.ToString("c");
            middlePercentOutputLabel.Text = STARTVALUE.ToString("c");//made output labels display 0$ to begin
            largePercentOutputLabel.Text = STARTVALUE.ToString("c");
            smallPercentLabel.Text = SMALLPERCENTTIP.ToString("p0");//made label display small tip percent
            middlePercentLabel.Text = MIDDLEPERCENTTIP.ToString("P0");//made label display middle tip percent
            largePercentLabel.Text = LARGEPERCENTTIP.ToString("P0");//made label display large tip percent
            

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double smalltip = SMALLPERCENTTIP * double.Parse(priceOfMealTextbox.Text);//declared variable small tip. Converted text to double
            smallPercentOutputLabel.Text = smalltip.ToString("c2");//made label display tip value converted to string

            double mediumtip = MIDDLEPERCENTTIP * double.Parse(priceOfMealTextbox.Text);//declared variable medium tip. Converted text to double
            middlePercentOutputLabel.Text = mediumtip.ToString("c2");//made label display tip value converted to string

            double largetip = LARGEPERCENTTIP * double.Parse(priceOfMealTextbox.Text);//declared variable large tip. Converted text to double
            largePercentOutputLabel.Text = largetip.ToString("c2");//made label display tip value converted to string

        }
    }
}
