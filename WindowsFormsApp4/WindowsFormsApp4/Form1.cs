using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CarBrandsBT_Click(object sender, EventArgs e)
        {
            carBrand1.Show();
            signIn1.Hide();
            //signUp1.Hide();
        }

        private void SignInBT_Click(object sender, EventArgs e)
        {
            carBrand1.Hide();
            signIn1.Show();
            //signUp1.Hide();
        }

        private void SignUpBT_Click(object sender, EventArgs e)
        {
            //carBrand1.Hide();
            //signIn1.Hide();
            //signUp1.Show();
            SignUPForm s = new SignUPForm();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void carBrand1_Load(object sender, EventArgs e)
        {

        }
    }
}
