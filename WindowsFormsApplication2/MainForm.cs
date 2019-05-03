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
    public partial class MainForm : Form
    {
        public static string module;
        public MainForm()
        {
            InitializeComponent();
            
            // Directory folder
            string[] dirs = Directory.GetDirectories(@"Modules");

            foreach (string dir in dirs)
            {
                //Get folder names of the chosen directory then show each individual one in the listbox.
                FolderLB.Items.Add(Path.GetFileName(dir));
                Debug.WriteLine(dirs);
            }
            
        }
        
        private void folderselected(object sender, EventArgs e)
        {
            //Empty the listbox once the user has selcted an item in listbox1.
            FileLB.Items.Clear();

            //Creating a path
            string dir = @"Modules";
            string filepath = Path.Combine(dir, FolderLB.SelectedItem.ToString());//.SelectedItem.ToString());
            string[] files = Directory.GetFiles(filepath, "*.txt");
         
            foreach (string file in files)
            {   
                //Get all txt file names and show in listbox2.
              FileLB.Items.Add(Path.GetFileName(file));
            }
            //Open 'Module Information.txt' file.
            string filepath2 = Path.Combine(dir, FolderLB.SelectedItem.ToString(), "Module Information.txt");
            string files2 = File.ReadAllText(filepath2);

            //Extract information from txt file to form.
            //Collect information from Start to Finish point. (According to the titles)
            int Start = files2.IndexOf("CODE") + "CODE".Length;
            int Finish = files2.LastIndexOf("TITLE");
            string Code = (files2.Substring(Start, Finish - Start)).Trim();
            CodeInfo.Text = Code;

            Start = files2.IndexOf("TITLE") + "TITLE".Length;
            Finish = files2.LastIndexOf("SYNOPSIS");
            string Title = (files2.Substring(Start, Finish - Start)).Trim();
            TitleInfo.Text = Title;

            Start = files2.IndexOf("SYNOPSIS") + "SYNOPSIS".Length;
            Finish = files2.IndexOf("LO");
            string Synopsis = (files2.Substring(Start, Finish - Start)).Trim();
            SynposisInfo.Text = Synopsis;

            Start = files2.IndexOf("LO") + "LO".Length;
            Finish = files2.IndexOf("ASSIGNMENT");
            string Lo = (files2.Substring(Start, Finish - Start)).Trim();
            LoInfo.Text = Lo;
            //Collection information from starting point.
            Start = files2.LastIndexOf("ASSIGNMENT") + "ASSIGNMENT".Length;
            string Assign = (files2.Substring(Start)).Trim();
            AssignInfo.Text = Assign;
        }
        private void selectedfile(object sender, EventArgs e)
        {
         
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open the AddNewFolder form.
            AddNewFolder NewFolder = new AddNewFolder();
            NewFolder.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }
        private void CodeInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AssignInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void SynposisInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Open image hyperlink in picturebox
            PictureBox.ImageLocation = Hyperlink.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddNewModule_Click(object sender, EventArgs e)
        {
            //Open AddNewFolder form, once the button has been selected.
            AddNewFolder NewFolder = new AddNewFolder();
            NewFolder.ShowDialog();
        }

        private void AddNotes_Click(object sender, EventArgs e)
        {
            //Open CreateNewNotes form, once AddNotes button has been selcted.
            CreateNotes Notes = new CreateNotes();
            module = FolderLB.SelectedItem.ToString();
            Notes.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FileSelected(object sender, EventArgs e)
        {
            // Open selected module , and week in notebox
            NotesBox.Text = File.ReadAllText(@"Modules\" + FolderLB.SelectedItem.ToString() + @"\" + FileLB.SelectedItem.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Save note box text
            File.AppendAllText(@"Modules\" + FolderLB.SelectedItem.ToString() + @"\" + FileLB.SelectedItem.ToString(), NotesBox.Text);
            // Message box showing the file is saved
            MessageBox.Show("File Saved.", "File Saved.",
     MessageBoxButtons.OK,
     MessageBoxIcon.Warning,
     MessageBoxDefaultButton.Button1);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Clear file list box
            FileLB.Items.Clear();
            // 
            string dir = @"Modules";
            string filepath = Path.Combine(dir, FolderLB.SelectedItem.ToString());//.SelectedItem.ToString());
            string[] files = Directory.GetFiles(filepath, "*.txt");

            foreach (string file in files)
            {
                //Get all txt file names and show in listbox2.
                FileLB.Items.Add(Path.GetFileName(file));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear folder list box
            FolderLB.Items.Clear();
            string dir = @"Modules";
            string[] files = Directory.GetDirectories(dir);

            foreach (string file in files)
            {
                //Get all txt file names and show in listbox2.
                FolderLB.Items.Add(Path.GetFileName(file));
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Clear folder list box
            FolderLB.Items.Clear();
            string dir = @"Modules";
            string[] files = Directory.GetDirectories(dir);

            foreach (string file in files)
            {
                //Get all txt file names and show in listbox2.
                FolderLB.Items.Add(Path.GetFileName(file));
            }
        }
    }
}

