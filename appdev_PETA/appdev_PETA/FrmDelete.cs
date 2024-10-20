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
    public partial class FrmDelete : Form
    {
        
        public FrmDelete()
        {
            InitializeComponent();
        }

        private void BtnDelDelete_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            
            db.deleteData(txtDelName.Text,txtDelEmail.Text);
        }
    }
}
