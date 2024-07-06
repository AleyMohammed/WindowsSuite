using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHospital
{
    public partial class Form7 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormHospital\DatabaseHospital.mdf;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Hospital where [Hospital_ID] = " + textBoxHId.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Hospital  values( " + textBoxHId.Text + ",'" + textBoxHname.Text + "','" + textBoxHaddress.Text + "','" + textBox4Hphone.Text + "' )", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Hospital SET [Hospital_ID] = " + textBoxHId.Text + ", [Hospital_Name] = '" + textBoxHname.Text + "', [Hospital_Address] = " + textBoxHaddress.Text + ", [Hospital_PhoneNumber] = " + textBoxHaddress.Text + "", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Hospital ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
