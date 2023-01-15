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
    public partial class MPC3 : Form
    {
        public MPC3()
        {
            InitializeComponent();
        }

        private void MPC3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet3.Colombo_3' table. You can move, or remove it, as needed.
            this.colombo_3TableAdapter.Fill(this._E_AppartmentsDataSet3.Colombo_3);

        }
    }
}
