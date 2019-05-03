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
using System.Diagnostics;

namespace WindowsFormsApplication2
{
    public partial class AddNewFolder : Form
    {
        public AddNewFolder()
        {
            InitializeComponent();
        }

        private void AddNewFolder_Load(object sender, EventArgs e)
        {

        }

        private void NewFolder_Click(object sender, EventArgs e)
        { }

        private void FolderName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SaveModule_Click(object sender, EventArgs e)
        {
            
                string path = @"Modules" + "\\" + NewModuleName.Text;
                string path2 = Path.Combine(path, "Module Information.txt");
                //if directory exists then create a new file and folder
                if (!Directory.Exists(path))
                {
                    //Create a new folder
                    Directory.CreateDirectory(path);
                    //Create a text file with all the information the user has just entered.
                    File.AppendAllText(path2, ("CODE\n"+NewModuleName.Text+ "\nTITLE\n" + NewTitle.Text+ "\nSYNOPSIS\n" + NewSynposis.Text+ "\n.LO\n" + NewLo.Text+ "\nASSIGNMENT\n" + NewAssign.Text));
                // Close form 
                this.Close();
                }
                // If directory does not exist, make a error message appear 
                else
                {
                    MessageBox.Show("The module you have entered already exists. Please re-enter another name.", "Error - Module already exists",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void assign_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewLo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

