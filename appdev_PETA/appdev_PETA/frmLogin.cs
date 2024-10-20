using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appdev_PETA
{
    public partial class frmLogin : Form
    {
        Database db;

        public frmLogin()
        {
            this.db = new Database();
            InitializeComponent();
        }
     
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            db.Login(txtLogin.Text, txtpword.Text);
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLogin.Text = string.Empty; txtpword.Text = string.Empty;
        }
    }
}
