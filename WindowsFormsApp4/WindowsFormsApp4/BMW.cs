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
    public partial class BMW : Form
    {
        public BMW()
        {
            InitializeComponent();
        }

        //private void carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.carBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.car_AgencyDataSet1);

        //}

        private void BMW_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_AgencyDataSet.Car' table. You can move, or remove it, as needed.
           // this.carTableAdapter1.Fill(this.car_AgencyDataSet.Car);
            // TODO: This line of code loads data into the 'car_AgencyDataSet1.Car_Brand' table. You can move, or remove it, as needed.
            //this.car_BrandTableAdapter.Fill(this.car_AgencyDataSet1.Car_Brand);
            // TODO: This line of code loads data into the 'car_AgencyDataSet1.Car' table. You can move, or remove it, as needed.
            //this.carTableAdapter.Fill(this.car_AgencyDataSet1.Car);

        }

        private void BMWX7BT_Click(object sender, EventArgs e)
        {
            //UserControl8 userControl8 = new UserControl8();
            //userControl8.Show();
        }

        private void BMWX6BT_Click(object sender, EventArgs e)
        {
            //UserControl9 userControl9 = new UserControl9();
            //userControl9.Show();
        }

        private void BMWM3BT_Click(object sender, EventArgs e)
        {
            //UserControl10 userControl10 = new UserControl10(); 
            //userControl10.Show();
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            SqlConnection conn3 = new SqlConnection(@"Data Source = NARDIN\SQLEXPRESS; Initial Catalog = Car_Agency; Integrated Security = True");
            conn3.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT ID_Model, Price, Color, Transmission, Engine_Capacity, Horse_Power, Fuel_tanks, Manufacturing_Year, Maximum_Speed, Kilometers FROM  Car ", conn3);
            cmd3.Parameters.AddWithValue("ID_Model", iD_ModelTextBox.Text);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            if (reader3.Read())
            {
                //iD_ModelTextBox.Text = reader2["ID_Model"].ToString();
                priceTextBox.Text = reader3["Price"].ToString();
                colorTextBox.Text = reader3["Color"].ToString();
                transmissionTextBox.Text = reader3["Transmission"].ToString();
                engine_CapacityTextBox.Text = reader3["engine_Capacity"].ToString();
                horse_PowerTextBox.Text = reader3["Horse_Power"].ToString();
                fuel_tanksTextBox.Text = reader3["Fuel_tanks"].ToString();
                manufacturing_YearDateTimePicker.Text = reader3["Manufacturing_Year"].ToString();
                maximum_SpeedTextBox.Text = reader3["Maximum_Speed"].ToString();
                kilometersTextBox.Text = reader3["Kilometers"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            conn3.Close();
        }
    }
}
