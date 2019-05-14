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
    public partial class AddStudent : Form
    {
       // String connectionString= @"Data Source=DELL;Initial Catalog = Portal; Integrated Security = True";
       

        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("addStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@Address", textBox4.Text);
            cmd.Parameters.AddWithValue("@UserName", textBox5.Text);
            cmd.Parameters.AddWithValue("@Password", textBox6.Text);
            cmd.Parameters.AddWithValue("@CGPA", textBox7.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Data Saved");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FacultyInterface faci = new FacultyInterface();
            faci.Show();
            this.Dispose();
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
