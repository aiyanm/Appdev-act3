using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdev_PETA
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            Database db = new Database();
          
            db.editData(Convert.ToInt32(txtEditID.Text), txtAddName.Text, txtEditEmail.Text, txtEditAddress.Text);
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            txtEditEmail.Text = string.Empty;
            txtEditAddress.Text = string.Empty;
        }
    }
}
