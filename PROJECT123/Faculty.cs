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
    public partial class Faculty : Form
    {
        int id;
        //public string textpassword = System.IO.File.ReadAllText(@"C:\Users\5000 Series\Documents\Visual Studio 2017\Projects\PROJECT123\password.txt");
        public Faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Console.WriteLine("Contents of WriteText.txt = {0}", textpassword);
                if (textBox1.Text == "SHIEFUZZAMAN" && textBox2.Text == System.IO.File.ReadAllText(@"C:\Users\5000 Series\Documents\Visual Studio 2017\Projects\PROJECT123\password.txt"))
                {
                    FacultyInterface facI = new FacultyInterface();
                    facI.Show();
                    this.Hide(); 
               


                }
                else
                {
                    SqlConnection sql = new SqlConnection(@"Data Source=DELL;Initial Catalog=Portal;Integrated Security=True");
                    sql.Open();
                    SqlCommand cmd = new SqlCommand(@"select count(*) from StudentReg where Id='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", sql);
                    int valid = (int)cmd.ExecuteScalar();
                    sql.Close();
                    id = Convert.ToInt32(textBox1.Text);
                    if (valid == 1)
                    {
                        StudentInterface3 st3 = new StudentInterface3(id);
                        st3.Show();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Id password does not match");
                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("not valid");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Dispose();
        }

        private void Faculty_Load(object sender, EventArgs e)
        {
         
        }

        private void Faculty_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
