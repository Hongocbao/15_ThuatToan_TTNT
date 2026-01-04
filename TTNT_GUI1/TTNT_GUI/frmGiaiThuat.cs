using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTNT_GUI
{
    public partial class frmGiaiThuat : Form
    {
        public frmGiaiThuat()
        {
            InitializeComponent();
        }

        private void btnTKTCR_Click(object sender, EventArgs e)
        {
            frmTKTCR f = new frmTKTCR();
            f.ShowDialog();

        }

        private void btnGTA_Click(object sender, EventArgs e)
        {
            frmGTA f = new frmGTA();
            f.ShowDialog();
        }

        private void btnBTSXCV_Click(object sender, EventArgs e)
        {
            frmBTSXCV f = new frmBTSXCV();
            f.ShowDialog();
        }

        private void btnVH_Click(object sender, EventArgs e)
        {
            frmVH f = new frmVH();
            f.ShowDialog();
        }

        private void btnCQDDDG_Click(object sender, EventArgs e)
        {
            frmCQDDDG f = new frmCQDDDG();
            f.ShowDialog();
        }

        private void btnTMTL_Click(object sender, EventArgs e)
        {
            new FrmThamLam().Show();
        }

        private void btnTMTLCSXTTTB_Click(object sender, EventArgs e)
        {
            new FrmThamLamSapXep().Show();
        }

        private void btnGTGTS1_Click(object sender, EventArgs e)
        {
            new FrmGTS1().Show();
        }

        private void btnCHG_Click(object sender, EventArgs e)
        {
            new FrmCayHopGiai().Show();
        }

        private void btnCQDDDV_Click(object sender, EventArgs e)
        {
            new FrmCayQuyetDinhV().Show();
        }

        private void btnTMTU_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void btnTKTCS_Click(object sender, EventArgs e)
        {
            new FormDFS() .Show();
        }

        private void btnQTINDO_Click(object sender, EventArgs e)
        {
            new frm_INDO().Show();
        }

        private void btnHGTT_Click(object sender, EventArgs e)
        {
            new frm_HopGiai() .Show();
        }

        private void btnGTGTS2_Click(object sender, EventArgs e)
        {
            new FormGTS2().Show();
        }
    }
}
