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

namespace WindowsFormsApp4
{
    public partial class SignUPForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NARDIN\SQLEXPRESS;Initial Catalog=Car_Agency;Integrated Security=True");
        SqlCommand cmd;
        public SignUPForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                cmd = new SqlCommand("insert into Customer values( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            Home form = new Home();
            form.Show();
        }

        private void SignUPForm_Load(object sender, EventArgs e)
        {

        }
    }

}
