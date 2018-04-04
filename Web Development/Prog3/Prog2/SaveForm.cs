using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
//this for allows you to save the library in it's current state
namespace LibraryItems
{
    public partial class SaveForm : Form
    { private BinaryFormatter formatter = new BinaryFormatter();//to serialize
        private FileStream output;// file to be written
        //precondition: none
        //postcondition: form is initialized
        public SaveForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {//precondition: none
            //postcondition: content saved
            DialogResult result;// sees if clicked OK or not
            string fileName;// string var
            using (SaveFileDialog fileChooser = new SaveFileDialog())//choose file
            {
                fileChooser.CheckFileExists = false;//file doesnt exist
                result = fileChooser.ShowDialog();//makes sure its ok
                fileName = fileChooser.FileName;

            }
            if (result == DialogResult.OK)//males sure ok is clicked
            {
                if (string.IsNullOrEmpty(fileName))//makes sure not empty
                {
                    MessageBox.Show("Invalid File Name", "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);//error
                }
else {
        try
         { output = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        saveButton.Enabled = false;// new file
                    }
                    catch (IOException)
                    { MessageBox.Show("Error opening File", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);//error
                    }
                        
                        }
            }
        }
    }


}
