using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT123
{
    public partial class StudentInterface3 : Form
    {
         int id;
        public StudentInterface3(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MyProfile mp = new MyProfile(id);
            mp.Show();
            this.Dispose();
        }

        private void StudentInterface3_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            Faculty f = new Faculty();
            f.Show();
            this.Dispose();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StuChangePass scp = new StuChangePass(id);
            scp.Show();
            this.Dispose();
        }

        private void dropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmInterface cfi = new ConfirmInterface(id);
            cfi.Show();
            this.Dispose();
        }

        private void facultyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacProfile facp = new FacProfile(id);
            facp.Show();
            this.Dispose();

        }

        private void noticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notices n = new Notices(id);
            n.Show();
            this.Dispose();
        }

        private void StudentInterface3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
