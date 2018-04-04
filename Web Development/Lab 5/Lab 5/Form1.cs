using System;/*B8829
               Lab 5
               Due Oct. 23rd
               199-75
               Application uses 3 different loop styles and displays numbers in list box after running
               the selected loop style*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class lab5 : Form
    {
        public lab5()
        {
            InitializeComponent();
        }

        private void loopButton_Click(object sender, EventArgs e)//click event for the button that runs the loop
        {
            string toBoxText;//declared string variable
            toBoxText = toTextBox.Text;//took text from text box
            int toNumber;//declared int variable
            string fromBoxText;//declared string variable
            fromBoxText = fromTextBox.Text;//took text from text box
            int fromNumber;//declared int variable

            if (int.TryParse(toBoxText, out toNumber))//if parse works, assign to int variable

            {
                if (int.TryParse(fromBoxText, out fromNumber))//if parse works, assign to int variable

                    if (whileRadioButton.Checked)//if while radio button is checked

                        while (fromNumber <= toNumber)//while the start value is less than or = to end value
                        {
                            outputListBox.Items.Add(fromNumber.ToString());//lsit box displays start variable
                            fromNumber++;//adds one to start variable

                        }

                    else if (forRadioButton.Checked)//if for radio button is checked

                        for (; fromNumber <= toNumber; fromNumber++)// add 1 to start value if its less than or = to end value
                            outputListBox.Items.Add(fromNumber.ToString());//list box displays start value

                    else if (doWhileRadioButton.Checked)//if do while button is checked

                        do
                        {
                            outputListBox.Items.Add(fromNumber.ToString());//display start value
                            fromNumber++;//add 1 to start value

                        }

                        while (fromNumber <= toNumber);//continue doing 2 steps above if start value<=end value

                    else
                        MessageBox.Show("Please select a loop style!");//error message no loop style is selected

                else { MessageBox.Show("Enter a correct number to start with!"); }//error message if parse fails
            }

            else
            { MessageBox.Show("Enter a correct number to end with!"); } //error message if parse fails

        }

        private void clearButton_Click(object sender, EventArgs e)//click event for clear button
        {
            outputListBox.Items.Clear();//clears contents of list box
        }
    }
}
