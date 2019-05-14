using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT123
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public Faculty facu;
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\Users\5000 Series\Documents\Visual Studio 2017\Projects\PROJECT123\password.txt", textBox1.Text);
            MessageBox.Show("Password Change successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyInterface facIu = new FacultyInterface();
            facIu.Show();
            this.Dispose();
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
