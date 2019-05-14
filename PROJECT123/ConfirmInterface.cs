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
    public partial class ConfirmInterface : Form
    {
        int id;
        public ConfirmInterface(int id)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("remove", sql);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Remove_stu_id", textBox1.Text);
                sql.Open();
                cmd.ExecuteNonQuery();
                sql.Close();
                sql.Open();
                SqlCommand cmd1 = new SqlCommand(@"Delete StudentReg Where Id='" + id + "' ", sql);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("The course have been droped successfully");
                sql.Close();
                Form1 fm1 = new Form1();
                fm1.Show();
                this.Dispose();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void ConfirmInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
