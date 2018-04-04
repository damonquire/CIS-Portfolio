using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//this class adds patrons to the list
namespace LibraryItems
{
    
    public partial class PatronInputForm : Form
    {
        
        public PatronInputForm()
        {//precondition: none
            //postcondition: form constructed
            InitializeComponent();
        }
        ErrorProvider error1 = new ErrorProvider();//to use error
        internal string patronNameInput
        {//precondition: none
         //postcondition: value assigned
            get
            { return patronNameTxt.Text; }

            set

            { patronNameTxt.Text = value; }

        }
      

        internal string patronIdInput
        //precondition: none
        //postcondition: value assigned
        {
            get { return idTxt.Text; }
            set { idTxt.Text = value; }


        }
        private void PatronNameTxt_Validating(object sender, CancelEventArgs e)
        {//precondition: must be null
            //postcondition: event cancelled
            if (string.IsNullOrWhiteSpace(patronNameInput))
            {
                e.Cancel = true;

                error1.SetError(patronNameTxt, "Enter a name!");
                patronNameTxt.SelectAll();
            }
           
            
        }
        
        private void PatronNameTxt_Validated(object sender, EventArgs e)
        {//precondition: none
            //postcondition: error cleared
            error1.SetError(patronNameTxt, "");
           
        }
        private void PatronID_Validating(object sender, CancelEventArgs e)
        {//precondition: must be null
            //postcondition: event cancelled
            if (string.IsNullOrWhiteSpace(patronIdInput))
            {
                e.Cancel = true;

                error1.SetError(idTxt, "Enter an ID!");
                idTxt.SelectAll();
            }
        }
        private void PatronID_Validated(object sender, EventArgs e)
        {//precondition: none
            //postcondition: error cleared
            error1.SetError(idTxt, "");

        }








        private void patronBtn_Click(object sender, EventArgs e)
        {
            //precondition: must validate
            //postcondition: dialog box shown

            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
            
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: result cancelled
            
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
