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
    public partial class Notices : Form
    {
        int id;
        public Notices(int id)
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

        private void showNoticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=DELL;Initial Catalog=Portal;Integrated Security=True";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand("SELECT * FROM dbo.Notice;", conDataBase);
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



        private void Notices_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }
    }
}
