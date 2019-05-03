namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderLB = new System.Windows.Forms.ListBox();
            this.Instruction1 = new System.Windows.Forms.Label();
            this.AddModule = new System.Windows.Forms.Button();
            this.Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AssignInfo = new System.Windows.Forms.RichTextBox();
            this.LoInfo = new System.Windows.Forms.RichTextBox();
            this.SynposisInfo = new System.Windows.Forms.RichTextBox();
            this.TitleInfo = new System.Windows.Forms.TextBox();
            this.CodeInfo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RefreshB2 = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Hyperlink = new System.Windows.Forms.TextBox();
            this.AddNotes = new System.Windows.Forms.Button();
            this.FileLB = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ImageB = new System.Windows.Forms.Button();
            this.NotesBox = new System.Windows.Forms.RichTextBox();
            this.RefreshB1 = new System.Windows.Forms.Button();
            this.Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderLB
            // 
            this.FolderLB.FormattingEnabled = true;
            this.FolderLB.Location = new System.Drawing.Point(22, 41);
            this.FolderLB.Name = "FolderLB";
            this.FolderLB.Size = new System.Drawing.Size(144, 238);
            this.FolderLB.TabIndex = 1;
            this.FolderLB.SelectedIndexChanged += new System.EventHandler(this.folderselected);
            // 
            // Instruction1
            // 
            this.Instruction1.AutoSize = true;
            this.Instruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction1.Location = new System.Drawing.Point(19, 9);
            this.Instruction1.Name = "Instruction1";
            this.Instruction1.Size = new System.Drawing.Size(158, 17);
            this.Instruction1.TabIndex = 4;
            this.Instruction1.Text = "Please select a module.";
            // 
            // AddModule
            // 
            this.AddModule.Location = new System.Drawing.Point(22, 295);
            this.AddModule.Name = "AddModule";
            this.AddModule.Size = new System.Drawing.Size(144, 23);
            this.AddModule.TabIndex = 6;
            this.AddModule.Text = "Add New Module";
            this.AddModule.UseVisualStyleBackColor = true;
            this.AddModule.Click += new System.EventHandler(this.AddNewModule_Click);
            // 
            // Tab
            // 
            this.Tab.Controls.Add(this.tabPage1);
            this.Tab.Controls.Add(this.tabPage2);
            this.Tab.Location = new System.Drawing.Point(188, 12);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(649, 363);
            this.Tab.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.AssignInfo);
            this.tabPage1.Controls.Add(this.LoInfo);
            this.tabPage1.Controls.Add(this.SynposisInfo);
            this.tabPage1.Controls.Add(this.TitleInfo);
            this.tabPage1.Controls.Add(this.CodeInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Module Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Assignment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "LO ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Synposis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Code";
            // 
            // AssignInfo
            // 
            this.AssignInfo.Location = new System.Drawing.Point(123, 270);
            this.AssignInfo.Name = "AssignInfo";
            this.AssignInfo.ReadOnly = true;
            this.AssignInfo.Size = new System.Drawing.Size(314, 47);
            this.AssignInfo.TabIndex = 22;
            this.AssignInfo.Text = "";
            this.AssignInfo.TextChanged += new System.EventHandler(this.AssignInfo_TextChanged);
            // 
            // LoInfo
            // 
            this.LoInfo.Location = new System.Drawing.Point(122, 153);
            this.LoInfo.Name = "LoInfo";
            this.LoInfo.ReadOnly = true;
            this.LoInfo.Size = new System.Drawing.Size(315, 114);
            this.LoInfo.TabIndex = 21;
            this.LoInfo.Text = "";
            // 
            // SynposisInfo
            // 
            this.SynposisInfo.Location = new System.Drawing.Point(122, 69);
            this.SynposisInfo.Name = "SynposisInfo";
            this.SynposisInfo.ReadOnly = true;
            this.SynposisInfo.Size = new System.Drawing.Size(315, 81);
            this.SynposisInfo.TabIndex = 20;
            this.SynposisInfo.Text = "";
            this.SynposisInfo.TextChanged += new System.EventHandler(this.SynposisInfo_TextChanged);
            // 
            // TitleInfo
            // 
            this.TitleInfo.Location = new System.Drawing.Point(124, 43);
            this.TitleInfo.Name = "TitleInfo";
            this.TitleInfo.ReadOnly = true;
            this.TitleInfo.Size = new System.Drawing.Size(314, 20);
            this.TitleInfo.TabIndex = 19;
            // 
            // CodeInfo
            // 
            this.CodeInfo.Location = new System.Drawing.Point(123, 19);
            this.CodeInfo.Name = "CodeInfo";
            this.CodeInfo.ReadOnly = true;
            this.CodeInfo.Size = new System.Drawing.Size(315, 20);
            this.CodeInfo.TabIndex = 18;
            this.CodeInfo.TextChanged += new System.EventHandler(this.CodeInfo_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RefreshB2);
            this.tabPage2.Controls.Add(this.SaveB);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.PictureBox);
            this.tabPage2.Controls.Add(this.Hyperlink);
            this.tabPage2.Controls.Add(this.AddNotes);
            this.tabPage2.Controls.Add(this.FileLB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.ImageB);
            this.tabPage2.Controls.Add(this.NotesBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // RefreshB2
            // 
            this.RefreshB2.BackColor = System.Drawing.Color.White;
            this.RefreshB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RefreshB2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshB2.Image = ((System.Drawing.Image)(resources.GetObject("RefreshB2.Image")));
            this.RefreshB2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RefreshB2.Location = new System.Drawing.Point(14, 292);
            this.RefreshB2.Name = "RefreshB2";
            this.RefreshB2.Size = new System.Drawing.Size(119, 39);
            this.RefreshB2.TabIndex = 32;
            this.RefreshB2.Text = "Refresh Notes";
            this.RefreshB2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshB2.UseVisualStyleBackColor = false;
            this.RefreshB2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // SaveB
            // 
            this.SaveB.Location = new System.Drawing.Point(447, 286);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(119, 23);
            this.SaveB.TabIndex = 31;
            this.SaveB.Text = "Save Notes";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter your notes below:";
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBox.Location = new System.Drawing.Point(384, 71);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(243, 209);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 28;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Hyperlink
            // 
            this.Hyperlink.Location = new System.Drawing.Point(384, 15);
            this.Hyperlink.Name = "Hyperlink";
            this.Hyperlink.Size = new System.Drawing.Size(243, 20);
            this.Hyperlink.TabIndex = 27;
            this.Hyperlink.Text = "Enter image hyperlink here";
            this.Hyperlink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hyperlink.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNotes
            // 
            this.AddNotes.Location = new System.Drawing.Point(14, 261);
            this.AddNotes.Name = "AddNotes";
            this.AddNotes.Size = new System.Drawing.Size(119, 23);
            this.AddNotes.TabIndex = 26;
            this.AddNotes.Text = "Add Notes";
            this.AddNotes.UseVisualStyleBackColor = true;
            this.AddNotes.Click += new System.EventHandler(this.AddNotes_Click);
            // 
            // FileLB
            // 
            this.FileLB.FormattingEnabled = true;
            this.FileLB.Location = new System.Drawing.Point(14, 27);
            this.FileLB.Name = "FileLB";
            this.FileLB.Size = new System.Drawing.Size(119, 225);
            this.FileLB.Sorted = true;
            this.FileLB.TabIndex = 25;
            this.FileLB.SelectedIndexChanged += new System.EventHandler(this.FileSelected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Select your notes:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ImageB
            // 
            this.ImageB.BackColor = System.Drawing.Color.MidnightBlue;
            this.ImageB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ImageB.Location = new System.Drawing.Point(466, 41);
            this.ImageB.Name = "ImageB";
            this.ImageB.Size = new System.Drawing.Size(83, 24);
            this.ImageB.TabIndex = 22;
            this.ImageB.Text = "Show Image";
            this.ImageB.UseVisualStyleBackColor = false;
            this.ImageB.Click += new System.EventHandler(this.button4_Click);
            // 
            // NotesBox
            // 
            this.NotesBox.Location = new System.Drawing.Point(139, 27);
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.Size = new System.Drawing.Size(239, 286);
            this.NotesBox.TabIndex = 20;
            this.NotesBox.Text = "";
            this.NotesBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // RefreshB1
            // 
            this.RefreshB1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshB1.Image = ((System.Drawing.Image)(resources.GetObject("RefreshB1.Image")));
            this.RefreshB1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RefreshB1.Location = new System.Drawing.Point(22, 320);
            this.RefreshB1.Name = "RefreshB1";
            this.RefreshB1.Size = new System.Drawing.Size(144, 45);
            this.RefreshB1.TabIndex = 33;
            this.RefreshB1.Text = "Refresh Modules";
            this.RefreshB1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshB1.UseVisualStyleBackColor = false;
            this.RefreshB1.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 389);
            this.Controls.Add(this.RefreshB1);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.AddModule);
            this.Controls.Add(this.Instruction1);
            this.Controls.Add(this.FolderLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = " ModNote ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox FolderLB;
        private System.Windows.Forms.Label Instruction1;
        private System.Windows.Forms.Button AddModule;
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox AssignInfo;
        private System.Windows.Forms.RichTextBox LoInfo;
        private System.Windows.Forms.RichTextBox SynposisInfo;
        private System.Windows.Forms.TextBox TitleInfo;
        private System.Windows.Forms.TextBox CodeInfo;
        private System.Windows.Forms.RichTextBox NotesBox;
        private System.Windows.Forms.Button ImageB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox FileLB;
        private System.Windows.Forms.Button AddNotes;
        private System.Windows.Forms.TextBox Hyperlink;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button RefreshB2;
        private System.Windows.Forms.Button RefreshB1;
    }
}

