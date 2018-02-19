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

namespace Library
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\ok\\Documents\\Visual Studio 2017\\Projects\\Library_Management\\Library_Management\\Database1.mdf\";Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select Artifact_Name, Author, Publication_Year, Genre, Issued From Artifacts WHERE Author LIKE '%"+textBox1.Text+"%'", con);
            DataSet dset = new DataSet();

            con.Open();
            adapter.SelectCommand = command;
            adapter.Fill(dset);
            con.Close();
            
            dataGridView1.DataSource = dset.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select Artifact_Name, Author, Publication_Year, Genre, Issued From Artifacts WHERE Artifact_Name LIKE '%" + textBox1.Text + "%'", con);
            DataSet dset = new DataSet();

            con.Open();
            adapter.SelectCommand = command;
            adapter.Fill(dset);
            con.Close();

            dataGridView1.DataSource = dset.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("Select Artifact_Name, Author, Publication_Year, Genre, Issued From Artifacts WHERE Genre LIKE '%" + textBox1.Text + "%'", con);
            DataSet dset = new DataSet();

            con.Open();
            adapter.SelectCommand = command;
            adapter.Fill(dset);
            con.Close();

            dataGridView1.DataSource = dset.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
