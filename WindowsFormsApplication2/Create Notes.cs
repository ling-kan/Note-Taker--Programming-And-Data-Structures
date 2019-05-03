using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class CreateNotes : Form
    {
        public CreateNotes()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //create a string path to create new notes
            string path = @"Modules\" + MainForm.module+@"\" + FileTextBox.Text + ".txt";
            //If file exists already exists....
            if (!File.Exists(FileTextBox.Text))
            {
                // Create a new text file , incluing ' notes' and the text file name.
                File.AppendAllText(path, ("Notes:  " + FileTextBox.Text));
                //Then show messagebox reminding user to refresh the listbox 
                MessageBox.Show("Note File created, make sure you refresh the listbox.", "ModNote - Notes File Created ",
                    //Messagebox 
      MessageBoxButtons.OKCancel,
      MessageBoxIcon.Warning,
      MessageBoxDefaultButton.Button1,
      MessageBoxOptions.RightAlign,
      true);
                //close current form
                this.Close();
            }
            else
            {
                //Messagebox if file already exists
                MessageBox.Show("The file you have entered already exists. Please re-enter another name.", "Error - File already exists",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FileTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
