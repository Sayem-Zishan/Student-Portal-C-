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
    public partial class MyProfile : Form
    {
        int id;
        public MyProfile(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
            sql.Open();
            SqlCommand cmd = new SqlCommand(@"update StudentReg set Phone='" + textBox7.Text + "' where Id='" + id + "'", sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            sql.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
            sql.Open();
            SqlCommand cmd = new SqlCommand(@"update StudentReg set Address='" + textBox8.Text + "' where Id='" + id + "'", sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            sql.Close();

        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            try
            {


                SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
                sql.Open();
                SqlCommand name = new SqlCommand(@"select Name from StudentReg where Id='" + id + "'", sql);
                SqlCommand phn = new SqlCommand(@"select Phone from StudentReg  where Id='" + id + "'", sql);
                SqlCommand address = new SqlCommand(@"select Address from StudentReg where Id='" + id + "'", sql);
                SqlCommand username = new SqlCommand(@"select UserName from StudentReg where Id='" + id + "'", sql);
                SqlCommand pass = new SqlCommand(@"select Password  from StudentReg where Id='" + id + "'", sql);
                SqlCommand cgpa = new SqlCommand(@"select CGPA  from StudentReg where Id='" + id + "'", sql);

                textBox1.Text = (string)name.ExecuteScalar();
                textBox2.Text = (string)phn.ExecuteScalar();
                textBox3.Text = (string)address.ExecuteScalar();
                textBox4.Text = (string)username.ExecuteScalar();
                textBox5.Text = (string)pass.ExecuteScalar();
                textBox6.Text = (string)cgpa.ExecuteScalar();

                sql.Close();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentInterface3 st3 = new StudentInterface3(id);
            st3.Show();
            this.Dispose();
        }

        private void MyProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
