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
    public partial class MPC4 : Form
    {
        public MPC4()
        {
            InitializeComponent();
        }

        private void MPC4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet4.Colombo_4' table. You can move, or remove it, as needed.
            this.colombo_4TableAdapter.Fill(this._E_AppartmentsDataSet4.Colombo_4);

        }
    }
}
