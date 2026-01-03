using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToMauDoThi.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnThamLam_Click(object sender, EventArgs e)
        {

            new FrmThamLam().Show();
        }

        private void btnThamLamSapXep_Click(object sender, EventArgs e)
        {
            new FrmThamLamSapXep().Show();
        }

        private void btnGTS1_Click(object sender, EventArgs e)
        {
            new FrmGTS1().Show();
        }

        private void btnCayHopGiai_Click(object sender, EventArgs e)
        {
            new FrmCayHopGiai().Show();
        }

        private void btnCayQuyetDinh_Click(object sender, EventArgs e)
        {
            new FrmCayQuyetDinhV().Show();
        }
    }
}
