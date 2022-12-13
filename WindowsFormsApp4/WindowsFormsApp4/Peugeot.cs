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
    public partial class Peugeot : Form
    {
        public Peugeot()
        {
            InitializeComponent();
        }

        private void Peugeot_Load(object sender, EventArgs e)
        {

        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection(@"Data Source = NARDIN\SQLEXPRESS; Initial Catalog = Car_Agency; Integrated Security = True");
            conn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT ID_Model, Price, Color, Transmission, Engine_Capacity, Horse_Power, Fuel_tanks, Manufacturing_Year, Maximum_Speed, Kilometers FROM  Car ", conn2);
            cmd2.Parameters.AddWithValue("ID_Model", iD_ModelTextBox.Text);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                //iD_ModelTextBox.Text = reader2["ID_Model"].ToString();
                priceTextBox.Text = reader2["Price"].ToString();
                colorTextBox.Text = reader2["Color"].ToString();
                transmissionTextBox.Text = reader2["Transmission"].ToString();
                engine_CapacityTextBox.Text = reader2["engine_Capacity"].ToString();
                horse_PowerTextBox.Text = reader2["Horse_Power"].ToString();
                fuel_tanksTextBox.Text = reader2["Fuel_tanks"].ToString();
                manufacturing_YearDateTimePicker.Text = reader2["Manufacturing_Year"].ToString();
                maximum_SpeedTextBox.Text = reader2["Maximum_Speed"].ToString();
                kilometersTextBox.Text = reader2["Kilometers"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            conn2.Close();
        }
    }
}
