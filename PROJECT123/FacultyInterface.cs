using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROJECT123
{
    public partial class FacultyInterface : Form
    {
        
        public FacultyInterface()
        {
            InitializeComponent();
        }

        private void courseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UploadNotice un = new UploadNotice();
            un.Show();
            this.Dispose();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultyProfile fp = new FacultyProfile();
            fp.Show();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StudentList sl = new StudentList();
            sl.Show();
            this.Dispose();
        }
        public Faculty fa;
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.IO.File.WriteAllText(@"C:\Users\5000 Series\Documents\Visual Studio 2017\Projects\PROJECT123\password.txt", fa.textpassword);
            ChangePassword cp = new ChangePassword();
            cp.Show();
            this.Dispose(); 
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ad = new AddStudent();
            ad.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
           

        }

        private void FacultyInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faculty f = new Faculty();
            f.Show();
            this.Dispose();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Faculty fs = new Faculty();
            fs.Show();
            this.Dispose();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovStudent RS = new RemovStudent();
            RS.Show();
            this.Dispose();

        }

        private void FacultyInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dropedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DropedStudent d = new DropedStudent();
            d.Show();
            this.Dispose();
        }
    }
}
