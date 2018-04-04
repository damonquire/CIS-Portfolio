using System;
/*B8829
 Program 1
 September 27th
 CIS 199-75
*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS199Program1FinalSubmission
{
    public partial class Program1 : Form
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double squarefoot;//declared variable squarefoot
            squarefoot = double.Parse(squareFootTextBox.Text);//took text from textbox, converted to double and assigned it to variable
            int coats;//declared variable coats
            coats = int.Parse(coatsTextBox.Text);//took text from textbox, converted to int and assigned it to variable
            double totalsquarefoot;//declared variable totalsquarefoot
            totalsquarefoot = squarefoot * coats;//multiply # of coats by square foot of walls
            totalSquareFootOutputLabel.Text = totalsquarefoot.ToString("n1");//bring the numeric value back as text rounded to 1 decimal


            int feetcoveredby1gallon;//declared variable feetcoveredby1gallon
            feetcoveredby1gallon = 275;//assigned the int 275 to variable
            double totalgallonsrequired;//declared variable totalgallonsrequired
            totalgallonsrequired = Math.Ceiling(totalsquarefoot / feetcoveredby1gallon);//total square foot/275
            totalGallonsOutputLabel.Text = totalgallonsrequired.ToString();//brought it to least whole # above decimal and converted it to string


            int hoursper275feet;//declared variable hoursper275feet
            hoursper275feet = 8;//assigned int 8 to variable
            double totalhoursrequired;//declared variable totalhoursrequire
            totalhoursrequired = (totalsquarefoot / feetcoveredby1gallon) * hoursper275feet;//(totalsquarefoot/275)*8
            totalLaborHoursOutputLabel.Text = totalhoursrequired.ToString("n1");//converted to string and output label displays it


            double costofpaint;//declared variable costofpaint
            costofpaint = double.Parse(paintCostTextBox.Text);//assigned text converted to double to variable
            double totalcostofpaint;//declared variable totalcostofpaint
            totalcostofpaint = costofpaint * totalgallonsrequired;//total cost of paint = cost of paint* number of gallons needed
            totalPaintCostOutputLabel.Text = totalcostofpaint.ToString("c2");//brought value back into a string in currency format


            double costofhourlabor;//declared variable costoflaborhour
            costofhourlabor = 12.5;//assigned 12.5 to variable
            double totalcostoflabor;//declared variable totalcostoflabor
            totalcostoflabor = costofhourlabor * totalhoursrequired;//totalcostoflabor equals 12.5*hours required
            totalLaborCostOutputLabel.Text = totalcostoflabor.ToString("c2");//made label display a numeric value in a string with currency format

            double totalcostofjob;//declared variable totalcostofjob
            totalcostofjob = totalcostoflabor + totalcostofpaint;//total cost of job= total cost of labor plus total cost of paint
            grandTotalOutputLabel.Text = totalcostofjob.ToString("C2");//assigned label a string currency version of number
        }
    }
}
