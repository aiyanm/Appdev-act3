using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace appdev_PETA
{
    public partial class frmAdd : Form
    {
        Database db = new Database();
        public frmAdd()
        {
            InitializeComponent();
            
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         
            db.addData(txtAddName.Text, txtAddEmail.Text, txtAddSex.Text, txtAddress.Text);
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            txtAddName.Clear();
            txtAddEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtAddSex.Text = string.Empty;
           
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                   
                }
            }
            
            
        }

        private void txtAddName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
