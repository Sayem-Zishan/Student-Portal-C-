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
    public partial class RemovStudent : Form
    {
       
        public RemovStudent()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
                sql.Open();
                
                SqlCommand cmd = new SqlCommand(@"Delete StudentReg Where Id='" + textBox1.Text + "' ", sql);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Student Removed Successfully");
                cmd.ExecuteNonQuery();
                sql.Close();





            }
            catch(Exception )
            {
                MessageBox.Show("Id does not match");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FacultyInterface fi = new FacultyInterface();
            fi.Show();
            this.Dispose();
        }

        private void RemovStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
}
}
