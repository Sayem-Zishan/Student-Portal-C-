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
    public partial class FacProfile : Form
    {
        int id;
        public FacProfile(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInterface3 st3 = new StudentInterface3(id);
            st3.Show();
            this.Dispose();
        }

        private void FacProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
