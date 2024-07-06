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
    public partial class Form3 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormHospital\DatabaseHospital.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Doctor where [Doctor_ID] = " + textBoxDOID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Doctor values( " + textBoxDOID.Text + ",'" + textBoxDOfname.Text + "','" + textBoxDolname.Text + "'," + textBoxDeID.Text + "," + textBoxDoNUm.Text + ",'" + comboBoxdoctor.Text + "' )", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Doctor ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Doctor SET [Doctor_ID] = " + textBoxDOID.Text + ", [Doctor_Fname] = '" + textBoxDOfname.Text + "', [Doctor_Lname] = '" + textBoxDolname.Text + "', [Department_ID] = " + comboBoxdoctor.Text + ", [Doctor_PhoneNumber] = " + textBoxDoNUm.Text + ", [Gender_doctor] = '" + comboBoxdoctor.Text + "'", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
