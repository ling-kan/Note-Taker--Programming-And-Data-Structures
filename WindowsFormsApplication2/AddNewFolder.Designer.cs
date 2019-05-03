namespace WindowsFormsApplication2
{
    partial class AddNewFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFolder));
            this.NewModuleName = new System.Windows.Forms.TextBox();
            this.SaveModule = new System.Windows.Forms.Button();
            this.NewTitle = new System.Windows.Forms.TextBox();
            this.AssignLabel = new System.Windows.Forms.Label();
            this.LoLabel = new System.Windows.Forms.Label();
            this.SynposisLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.NewAssign = new System.Windows.Forms.RichTextBox();
            this.NewLo = new System.Windows.Forms.RichTextBox();
            this.NewSynposis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewModuleName
            // 
            this.NewModuleName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NewModuleName.Location = new System.Drawing.Point(118, 55);
            this.NewModuleName.Name = "NewModuleName";
            this.NewModuleName.Size = new System.Drawing.Size(213, 20);
            this.NewModuleName.TabIndex = 0;
            this.NewModuleName.Text = "ENTER THE MODULE NAME";
            this.NewModuleName.TextChanged += new System.EventHandler(this.FolderName_TextChanged);
            // 
            // SaveModule
            // 
            this.SaveModule.Location = new System.Drawing.Point(121, 384);
            this.SaveModule.Name = "SaveModule";
            this.SaveModule.Size = new System.Drawing.Size(195, 23);
            this.SaveModule.TabIndex = 44;
            this.SaveModule.Text = "Save Module Info";
            this.SaveModule.UseVisualStyleBackColor = true;
            this.SaveModule.Click += new System.EventHandler(this.SaveModule_Click);
            // 
            // NewTitle
            // 
            this.NewTitle.Location = new System.Drawing.Point(117, 86);
            this.NewTitle.Name = "NewTitle";
            this.NewTitle.Size = new System.Drawing.Size(214, 20);
            this.NewTitle.TabIndex = 40;
            this.NewTitle.Text = "Enter Title";
            // 
            // AssignLabel
            // 
            this.AssignLabel.AutoSize = true;
            this.AssignLabel.Location = new System.Drawing.Point(51, 320);
            this.AssignLabel.Name = "AssignLabel";
            this.AssignLabel.Size = new System.Drawing.Size(61, 13);
            this.AssignLabel.TabIndex = 38;
            this.AssignLabel.Text = "Assignment";
            // 
            // LoLabel
            // 
            this.LoLabel.AutoSize = true;
            this.LoLabel.Location = new System.Drawing.Point(82, 112);
            this.LoLabel.Name = "LoLabel";
            this.LoLabel.Size = new System.Drawing.Size(24, 13);
            this.LoLabel.TabIndex = 37;
            this.LoLabel.Text = "LO ";
            // 
            // SynposisLabel
            // 
            this.SynposisLabel.AutoSize = true;
            this.SynposisLabel.Location = new System.Drawing.Point(63, 224);
            this.SynposisLabel.Name = "SynposisLabel";
            this.SynposisLabel.Size = new System.Drawing.Size(49, 13);
            this.SynposisLabel.TabIndex = 36;
            this.SynposisLabel.Text = "Synposis";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(79, 88);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 35;
            this.TitleLabel.Text = "Title";
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(79, 58);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(32, 13);
            this.CodeLabel.TabIndex = 34;
            this.CodeLabel.Text = "Code";
            // 
            // NewAssign
            // 
            this.NewAssign.Location = new System.Drawing.Point(117, 320);
            this.NewAssign.Name = "NewAssign";
            this.NewAssign.Size = new System.Drawing.Size(228, 49);
            this.NewAssign.TabIndex = 45;
            this.NewAssign.Text = "Enter the Assignment";
            this.NewAssign.TextChanged += new System.EventHandler(this.assign_TextChanged);
            // 
            // NewLo
            // 
            this.NewLo.Location = new System.Drawing.Point(117, 112);
            this.NewLo.Name = "NewLo";
            this.NewLo.Size = new System.Drawing.Size(229, 107);
            this.NewLo.TabIndex = 46;
            this.NewLo.Text = "Write the different learning objectives";
            this.NewLo.TextChanged += new System.EventHandler(this.NewLo_TextChanged);
            // 
            // NewSynposis
            // 
            this.NewSynposis.Location = new System.Drawing.Point(117, 221);
            this.NewSynposis.Name = "NewSynposis";
            this.NewSynposis.Size = new System.Drawing.Size(229, 96);
            this.NewSynposis.TabIndex = 47;
            this.NewSynposis.Text = "Write the Module synposis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Please fill in the following information:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddNewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewSynposis);
            this.Controls.Add(this.NewLo);
            this.Controls.Add(this.NewAssign);
            this.Controls.Add(this.SaveModule);
            this.Controls.Add(this.NewTitle);
            this.Controls.Add(this.AssignLabel);
            this.Controls.Add(this.LoLabel);
            this.Controls.Add(this.SynposisLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.NewModuleName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewFolder";
            this.Text = "ModNote - Create A New Module";
            this.Load += new System.EventHandler(this.AddNewFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewModuleName;
        private System.Windows.Forms.Button SaveModule;
        private System.Windows.Forms.TextBox NewTitle;
        private System.Windows.Forms.Label AssignLabel;
        private System.Windows.Forms.Label LoLabel;
        private System.Windows.Forms.Label SynposisLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.RichTextBox NewAssign;
        private System.Windows.Forms.RichTextBox NewLo;
        private System.Windows.Forms.RichTextBox NewSynposis;
        private System.Windows.Forms.Label label1;
    }
}