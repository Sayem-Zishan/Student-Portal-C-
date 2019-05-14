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
    public partial class FacultyProfile : Form
    {
        public FacultyProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultyInterface fi = new FacultyInterface();
            fi.Show();
            this.Dispose();
        }

        private void FacultyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
