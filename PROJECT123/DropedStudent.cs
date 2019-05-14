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
    public partial class DropedStudent : Form
    {
        public DropedStudent()
        {
            InitializeComponent();
        }

        private void DropedStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void showDropedStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DELL;Initial Catalog=Portal;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand("SELECT * FROM dbo.RemovedStudent;", conDataBase);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FacultyInterface fi = new FacultyInterface();
            fi.Show();
            this.Dispose();
        }
    }
}
