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
    public partial class MINI : Form
    {
        public MINI()
        {
            InitializeComponent();
        }

        //private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.carBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.car_AgencyDataSet);

        //}

        private void MINI_Load(object sender, EventArgs e)
        {
            

        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn1 = new SqlConnection(@"Data Source = NARDIN\SQLEXPRESS; Initial Catalog = Car_Agency; Integrated Security = True");
            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT ID_Model, Price, Color, Transmission, Engine_Capacity, Horse_Power, Fuel_tanks, Manufacturing_Year, Maximum_Speed, Kilometers FROM  Car ", conn1);
            cmd1.Parameters.AddWithValue("ID_Model", iD_ModelTextBox.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                //iD_ModelTextBox.Text = reader2["ID_Model"].ToString();
                priceTextBox.Text = reader1["Price"].ToString();
                colorTextBox.Text = reader1["Color"].ToString();
                transmissionTextBox.Text = reader1["Transmission"].ToString();
                engine_CapacityTextBox.Text = reader1["engine_Capacity"].ToString();
                horse_PowerTextBox.Text = reader1["Horse_Power"].ToString();
                fuel_tanksTextBox.Text = reader1["Fuel_tanks"].ToString();
                manufacturing_YearDateTimePicker.Text = reader1["Manufacturing_Year"].ToString();
                maximum_SpeedTextBox.Text = reader1["Maximum_Speed"].ToString();
                kilometersTextBox.Text = reader1["Kilometers"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            conn1.Close();
        }

        private void MiniHatchBT_Click(object sender, EventArgs e)
        {

        }
    }
}
