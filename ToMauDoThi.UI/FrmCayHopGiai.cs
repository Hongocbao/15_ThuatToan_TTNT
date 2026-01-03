using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToMauDoThi.DAL;
using ToMauDoThi.BLL;

namespace ToMauDoThi.UI
{
    public partial class FrmCayHopGiai : Form
    {

        GraphDAL graph;
        CayHopGiaiBLL cay;


        public FrmCayHopGiai()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoDoThi_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoDinh.Text);
            graph = new GraphDAL(n);

            dgvMaTran.ColumnCount = n;
            dgvMaTran.RowCount = n;
        }

        private void btnCayHopGiai_Click(object sender, EventArgs e)
        {
            int n = graph.SoDinh;
            int m = int.Parse(txtSoMau.Text);

            // Lấy dữ liệu từ DataGridView
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    graph.MaTranKe[i, j] =
                        Convert.ToInt32(dgvMaTran.Rows[i].Cells[j].Value);

            cay = new CayHopGiaiBLL(graph, m);
            cay.ToMau(0, cay.Root);

            treeCay.Nodes.Clear();
            TreeNode root = new TreeNode("Bắt đầu");
            treeCay.Nodes.Add(root);

            HienThiCay(cay.Root, root);
            treeCay.ExpandAll();
        }

        private void HienThiCay(DecisionNode node, TreeNode treeNode)
        {
            foreach (var child in node.Children)
            {
                TreeNode tn = new TreeNode(
                    $"Đỉnh {child.Dinh} → Màu {child.Mau}");
                treeNode.Nodes.Add(tn);
                HienThiCay(child, tn);
            }
        }
    }
    
}
