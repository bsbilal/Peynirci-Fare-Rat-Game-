using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatGamev0._2
{
    public partial class frmAreaSize : Form
    {
        public frmAreaSize()
        {
            InitializeComponent();
        }

        private void btnSendSize_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmNew = new frmMain(Convert.ToInt16(cmbAreaSize.SelectedItem));
            frmNew.ShowDialog();
            this.Close();
        }

        private void frmAreaSize_Load(object sender, EventArgs e)
        {

        }
    }
}
