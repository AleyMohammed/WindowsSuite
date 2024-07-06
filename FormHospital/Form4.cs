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
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Downloads\AppVS\FormHospital\DatabaseHospital.mdf;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void textBoxPaNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxpaID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxdoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Patient where [Patient_ID] = " + textBoxpaID.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Patient values( " + textBoxpaID.Text + ",'" + textBoxaPaname.Text + "','" + textBoxPalname.Text + "','" + textBoxPaddress.Text + "'," + textBoxPaNum.Text + ",'" + comboBoxpatient.Text + "' )", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Patient ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Patient SET [Patient_ID] = " + textBoxpaID.Text + ", [Patient_Fname] = '" + textBoxaPaname.Text + "', [textBoxPalname] = " + textBoxPalname.Text + ", [Patient_Address] = '" + textBoxPaddress.Text + "', [Patient_PhoneNumber] = " + textBoxPaNum.Text + ",[Gender_Patient] = "+comboBoxpatient.Text+"", conn);
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
