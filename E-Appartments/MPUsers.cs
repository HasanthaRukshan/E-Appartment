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
    public partial class MPUsers : Form
    {
        public MPUsers()
        {
            InitializeComponent();
        }

        private void MPUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet.User_Login' table. You can move, or remove it, as needed.
            this.user_LoginTableAdapter.Fill(this._E_AppartmentsDataSet.User_Login);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.user_LoginTableAdapter.FillBy(this._E_AppartmentsDataSet.User_Login);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
