using System;/*B8829
               Lab 7
               Nov 6th
               199-75
               This program uses arrays and methods to correctly display the month 
               corresponding to the chosen langauge and month #*/
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class lab7 : Form
    {
        public lab7()
        {
            InitializeComponent();
        }
        int monthNumber;//declared int variable for all methods to access

        private void clickButton_Click(object sender, EventArgs e)//click event for button
        {

            if (englishRadioButton.Checked)
                GetEnglishMonth();//execute english method
            else if (spanishRadioButton.Checked)
                GetSpanishMonth();//execute spanish method
            else GetItalianMonth();//execute italian method
        }


        private void GetEnglishMonth()//method for english months
         //precondition: number in text box must be between 1 and 12 and english radio button selected
         //postconidion: output label displays month corresponding to langauge and month #
        {



            string[] englishArray;//declared array

            englishArray = new string[12];//stated array size

            englishArray[0] = "January";//stated what each position in array represents
            englishArray[1] = "Febraury";
            englishArray[2] = "March";
            englishArray[3] = "April";
            englishArray[4] = "May";
            englishArray[5] = "June";
            englishArray[6] = "July";
            englishArray[7] = "August";
            englishArray[8] = "September";
            englishArray[9] = "October";
            englishArray[10] = "November";
            englishArray[11] = "December";

            if (int.TryParse(monthTextBox.Text, out monthNumber))//parses text from text box
            {
                if (monthNumber > 0 && monthNumber <= 12)//makes sure # is between 1-12
                    outputLabel.Text = englishArray[monthNumber - 1];//displays correct month

                else

                    MessageBox.Show("Enter a correct month number!");//error message
            }
            else MessageBox.Show("Enter a correct month number!");//error message
        }
                
             
                
            
           private void GetSpanishMonth()//spanish months method
           //precondition: number in text box must be between 1 and 12 and spanish button selected
           //postconidion: output label displays month corresponding to langauge and month # 
        {


            string[] spanishArray;//declared array

            spanishArray = new string[12];//stated size for array

            spanishArray[0] = "Enero";//stated what each position in array represents
            spanishArray[1] = "Febrero";
            spanishArray[2] = "Marzo";
            spanishArray[3] = "Abril";
            spanishArray[4] = "Mayo";
            spanishArray[5] = "Junio";
            spanishArray[6] = "Julio";
            spanishArray[7] = "Agosto";
            spanishArray[8] = "Septiembre";
            spanishArray[9] = "Octubre";
            spanishArray[10] = "Noviembre";
            spanishArray[11] = "Diciembre";

            if (int.TryParse(monthTextBox.Text, out monthNumber))//parses text from textbox
            {
                if (monthNumber > 0 && monthNumber <= 12)//makes sure # is between 1-12
                    outputLabel.Text = spanishArray[monthNumber - 1];//displays correct month

                else

                    MessageBox.Show("Enter a correct month number!");//error message
            }
            else MessageBox.Show("Enter a correct month number!");//error message
        }

        private void GetItalianMonth()//italian month method
           //precondition: number in text box must be between 1 and 12 and italian button selected 
           //postconidion: output label displays month corresponding to langauge and month #
        {


            string[] italianArray;//declared array

            italianArray = new string[12];//stated size for array

            italianArray[0] = "Gennaio";//stated what each position in array represents
            italianArray[1] = "Febbraio";
            italianArray[2] = "Marzo";
            italianArray[3] = "Aprile";
            italianArray[4] = "Maggio";
            italianArray[5] = "Giugno";
            italianArray[6] = "Luglio";
            italianArray[7] = "Agosto";
            italianArray[8] = "Settembre";
            italianArray[9] = "Ottobre";
            italianArray[10] = "Novembre";
            italianArray[11] = "Dicimbre";

            if (int.TryParse(monthTextBox.Text, out monthNumber))//parses text from textbox
            {
                if (monthNumber > 0 && monthNumber <= 12)//makes sure # is between 1-12
                    outputLabel.Text = italianArray[monthNumber - 1];//displays correct month

                else

                    MessageBox.Show("Enter a correct month number!");//error message
            }
            else MessageBox.Show("Enter a correct month number!");//error message

            }
            
            



        }




        
        
        
    }

