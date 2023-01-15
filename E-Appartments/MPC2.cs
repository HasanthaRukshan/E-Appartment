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
    public partial class MPC2 : Form
    {
        public MPC2()
        {
            InitializeComponent();
        }

        private void MPC2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet2.Colombo_2' table. You can move, or remove it, as needed.
            this.colombo_2TableAdapter.Fill(this._E_AppartmentsDataSet2.Colombo_2);

        }
    }
}
