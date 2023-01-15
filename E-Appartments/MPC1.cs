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
    public partial class MPC1 : Form
    {
        public MPC1()
        {
            InitializeComponent();
        }

        private void MPC1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet1.Colombo_1' table. You can move, or remove it, as needed.
            this.colombo_1TableAdapter.Fill(this._E_AppartmentsDataSet1.Colombo_1);

        }
    }
}
