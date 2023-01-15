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
    public partial class C4C2 : Form
    {
        public C4C2()
        {
            InitializeComponent();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }
    }
}
