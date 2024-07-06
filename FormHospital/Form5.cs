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
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormHospital\DatabaseHospital.mdf;Integrated Security=True");

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Staff where [Patient_ID] = " + textBoxstaffID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Staff values( " + textBoxstaffID.Text + "," + textBoxDeID.Text + ",'" + textBoxstafname.Text + "','" + textBoxstaffLname.Text + "','" + textBoxsatffaddre.Text + "'," + textBoxstaffnum.Text + ")", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void textBoxsatfflname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Staff ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Patient SET [Staff_ID] = " + textBoxstaffID.Text + ", [Department_ID] = '" + textBoxDeID.Text + "', [Staff_Fname] = '" + textBoxstafname.Text + "', [Staff_Lname] = '" + textBoxstaffLname.Text + "', [Staff_Address] = '" + textBoxsatffaddre.Text + "',[Staff_PhoneNumberd] = " + textBoxstaffnum.Text + "", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
