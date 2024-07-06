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
    public partial class Form6 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormHospital\DatabaseHospital.mdf;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
        }

        private void textBoxAdmiDate_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Room ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Room where [Room_num] = " + textBoxroomnum.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Room values( " + textBoxroomnum.Text + "," + textBoxstaffID.Text + "," + textBoxpaID.Text + ","+textBoxAdmiDate.Text+" )", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Room SET [Room_num] = " + textBoxroomnum.Text + ", [Patient_ID] = " + textBoxpaID.Text + ", [Staff_ID] = " + textBoxstaffID.Text + ",[Admission_Date] = " + textBoxAdmiDate.Text +"", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
