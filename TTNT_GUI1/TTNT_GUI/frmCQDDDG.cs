using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNT_BUS;

namespace TTNT_GUI
{
    public partial class frmCQDDDG : Form
    {
        DataBUS bus = new DataBUS();
        DataTable dtGoc;
        public frmCQDDDG()
        {
            InitializeComponent();
        }

        private void frmCQDDDG_Load(object sender, EventArgs e)
        {

        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls;*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gọi BUS để lấy dữ liệu
                    dtGoc = bus.LayDuLieu(ofd.FileName);

                    // Hiển thị lên DataGridView để người dùng xem
                    dgvData.DataSource = dtGoc;

                    // Tự động nạp tên các cột vào ComboBox để người dùng chọn cột Target (nhãn)
                    cboTarget.Items.Clear();
                    foreach (DataColumn col in dtGoc.Columns)
                    {
                        cboTarget.Items.Add(col.ColumnName);
                    }

                    MessageBox.Show("Nạp dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnBuildTree_Click(object sender, EventArgs e)
        {
            if (dtGoc == null || dtGoc.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng nạp dữ liệu trước!");
                return;
            }

            if (cboTarget.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn cột nhãn (Target)!");
                return;
            }

            string targetColumn = cboTarget.SelectedItem.ToString();

            // Lấy danh sách các cột thuộc tính (loại bỏ cột nhãn)
            List<string> attributes = new List<string>();
            foreach (DataColumn col in dtGoc.Columns)
            {
                if (col.ColumnName != targetColumn)
                    attributes.Add(col.ColumnName);
            }

            tvDecisionTree.Nodes.Clear();

            // Gọi hàm đệ quy để xây dựng cây
            BuildTreeView(dtGoc, attributes, targetColumn, null);

            tvDecisionTree.ExpandAll();
            MessageBox.Show("Xây dựng cây thành công!");
        }

        private void BuildTreeView(DataTable data, List<string> attributes, string target, TreeNode parentNode)
        {
            // Kiểm tra nếu tất cả cùng 1 nhãn
            var labels = data.AsEnumerable().Select(r => r[target].ToString()).Distinct().ToList();
            if (labels.Count == 1)
            {
                parentNode?.Nodes.Add("KẾT QUẢ: " + labels[0]);
                return;
            }

            if (attributes.Count == 0) return;

            string log;
            string best = bus.GetBestAttribute(data, attributes, target, out log);
            txtLog.AppendText(log); // Ghi log vào RichTextBox

            TreeNode currentNode = (parentNode == null) ? tvDecisionTree.Nodes.Add(best) : parentNode.Nodes.Add(best);

            var values = data.AsEnumerable().Select(r => r[best].ToString()).Distinct().ToList();
            foreach (var val in values)
            {
                TreeNode valNode = currentNode.Nodes.Add(val);
                DataTable childData = data.AsEnumerable().Where(r => r[best].ToString() == val).CopyToDataTable();
                BuildTreeView(childData, attributes.Where(a => a != best).ToList(), target, valNode);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtGoc = null;
            dgvData.DataSource = null;
            tvDecisionTree.Nodes.Clear();
            cboTarget.Items.Clear();
            cboTarget.Text = "";
            MessageBox.Show("Đã làm mới dữ liệu!");
        }
    }
}
