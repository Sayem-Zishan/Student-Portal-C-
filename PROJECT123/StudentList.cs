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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DELL;Initial Catalog=Portal;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand("SELECT * FROM dbo.StudentReg;",conDataBase);
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dataset;
                dataGridView1.DataSource = dataset;
                sda.Update(dataset);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultyInterface fis = new FacultyInterface();
            fis.Show();
            this.Dispose();
        }

        private void StudentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student Name")
            {
                string constring = "Data Source=DELL;Initial Catalog=Portal;Integrated Security=True";
                SqlConnection conDataBase = new SqlConnection(constring);
                

                SqlDataAdapter sda = new SqlDataAdapter("select Name,Phone,Address,UserName,Password,CGPA FROM StudentReg where Name like '" +textBox1.Text+"%'",constring);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;
              
                sda.Update(dataset);
            }
            else if (comboBox1.Text == "Student Address")
            {
                string constring = "Data Source=DELL;Initial Catalog=Portal;Integrated Security=True";
                SqlConnection conDataBase = new SqlConnection(constring);


                SqlDataAdapter sda = new SqlDataAdapter("select Name,Phone,Address,UserName,Password,CGPA FROM StudentReg where Address like '" + textBox1.Text + "%'", constring);

                DataTable dataset = new DataTable();
                sda.Fill(dataset);
                dataGridView1.DataSource = dataset;

                sda.Update(dataset);
            }



        }
    }
}
