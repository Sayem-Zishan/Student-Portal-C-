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
    public partial class UploadNotice : Form
    {
        public UploadNotice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultyInterface fis = new FacultyInterface();
                fis.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Notices", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Notice", textBox1.Text);
           
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Notice Saved");
            }
        }

        private void UploadNotice_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
