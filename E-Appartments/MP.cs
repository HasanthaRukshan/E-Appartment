using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Appartments
{
    public partial class MP : Form
    {
        public MP()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void users_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPUsers mpu = new MPUsers();
            mpu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC1 mpc1 = new MPC1();
            mpc1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC2 mpc2 = new MPC2();
            mpc2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC3 mpc3 = new MPC3();
            mpc3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC4 mpc4 = new MPC4();
            mpc4.Show();
        }
    }
}
