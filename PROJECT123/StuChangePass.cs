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
    public partial class StuChangePass : Form
    {
        int id;
        
        public StuChangePass(int id)
        {
            this.id = id;
           
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentInterface3 st3 = new StudentInterface3(id);
            st3.Show();
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
            sql.Open();
            SqlCommand cmd = new SqlCommand(@"update StudentReg set Password='" + textBox1.Text + "' where Id='" + id + "'", sql);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password Changed");
            sql.Close();
        }

        private void StuChangePass_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
