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
    public partial class CarBrand : UserControl
    {
        public CarBrand()
        {
            InitializeComponent();
        }

        private void MINIBT_Click(object sender, EventArgs e)
        {
            MINI m = new MINI();
            m.Show();
        }

        private void BMWBT_Click(object sender, EventArgs e)
        {
            BMW b = new BMW();
            b.Show();
        }

        private void PEUGEOTBT_Click(object sender, EventArgs e)
        {
            Peugeot p = new Peugeot();
            p.Show();
        }
    }
}
