﻿namespace WindowsFormsApplication2
{
    partial class CreateNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNotes));
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.CreateNote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FileTextBox
            // 
            this.FileTextBox.Location = new System.Drawing.Point(46, 41);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(204, 20);
            this.FileTextBox.TabIndex = 0;
            this.FileTextBox.TextChanged += new System.EventHandler(this.FileTextBox_TextChanged);
            // 
            // CreateNote
            // 
            this.CreateNote.Location = new System.Drawing.Point(93, 67);
            this.CreateNote.Name = "CreateNote";
            this.CreateNote.Size = new System.Drawing.Size(75, 23);
            this.CreateNote.TabIndex = 1;
            this.CreateNote.Text = "Add Note";
            this.CreateNote.UseVisualStyleBackColor = true;
            this.CreateNote.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the note title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CreateNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateNote);
            this.Controls.Add(this.FileTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ModNote - Create Note File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button CreateNote;
        private System.Windows.Forms.Label label1;
    }
}