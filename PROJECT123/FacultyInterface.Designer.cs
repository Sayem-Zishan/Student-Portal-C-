namespace PROJECT123
{
    partial class FacultyInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropedStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.courseDetailsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.addStudentToolStripMenuItem,
            this.removeStudentToolStripMenuItem,
            this.dropedStudentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // courseDetailsToolStripMenuItem
            // 
            this.courseDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.courseDetailsToolStripMenuItem.Name = "courseDetailsToolStripMenuItem";
            this.courseDetailsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.courseDetailsToolStripMenuItem.Text = "Upload Notice";
            this.courseDetailsToolStripMenuItem.Click += new System.EventHandler(this.courseDetailsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // removeStudentToolStripMenuItem
            // 
            this.removeStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.removeStudentToolStripMenuItem.Name = "removeStudentToolStripMenuItem";
            this.removeStudentToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.removeStudentToolStripMenuItem.Text = "RemoveStudent";
            this.removeStudentToolStripMenuItem.Click += new System.EventHandler(this.removeStudentToolStripMenuItem_Click);
            // 
            // dropedStudentToolStripMenuItem
            // 
            this.dropedStudentToolStripMenuItem.ForeColor = System.Drawing.Color.Teal;
            this.dropedStudentToolStripMenuItem.Name = "dropedStudentToolStripMenuItem";
            this.dropedStudentToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dropedStudentToolStripMenuItem.Text = "DropedStudent";
            this.dropedStudentToolStripMenuItem.Click += new System.EventHandler(this.dropedStudentToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASSIGN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(389, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lec-Com-Sci-Lan-Stu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(32, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "00185-OBJECT ORIENTED PROGRAMMING 2 [A]";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(389, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "3 - 1 - 0 - 0 - 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(29, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "(Theory) Time: Sun 10:0 - Sun 12:0 PM Room: 5114";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(32, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "(Lab) Time: Tue 8:0 - Tue 11:0 Room: CL8";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(428, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FacultyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FacultyInterface";
            this.Text = "Faculty Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FacultyInterface_FormClosing);
            this.Load += new System.EventHandler(this.FacultyInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem removeStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropedStudentToolStripMenuItem;
    }
}