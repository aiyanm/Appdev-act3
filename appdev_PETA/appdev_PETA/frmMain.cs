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
using System.Xml.Linq;

namespace appdev_PETA
{
    public partial class frmMain : Form
    {
        string username;
        Database db;

        public frmMain(string username)
        {
            InitializeComponent();
            this.username = username;
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.db = new Database();
            this.Text = "Welcome " + this.username;
            cboGender.SelectedIndex = -1;
            
            
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            db.Search(txtName.Text, cboGender.Text, grdView);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd frmAdd = new frmAdd();
            frmAdd.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            frmEdit frmEdit = new frmEdit();
            frmEdit.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            FrmDelete frmDelete = new FrmDelete();  
            frmDelete.ShowDialog();
        }

        private void grdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
          
            db.TextchangeSeacrch(txtName.Text,cboGender.Text,grdView);
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGender.SelectedIndex == 0)
            {
                db.SearchALL(grdView);
            }

            else
            {
                db.SearchSex(cboGender.Text, grdView);
            }
          
        }
    }
}
