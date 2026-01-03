using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToMauDoThi.BLL;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;


namespace ToMauDoThi.UI
{
    public partial class FrmCayQuyetDinhV : Form
    {

        private DataTable DocBangTuWord(string filePath)
        {
            DataTable dt = new DataTable();

            using (WordprocessingDocument doc =
                   WordprocessingDocument.Open(filePath, false))
            {
                var table = doc.MainDocumentPart.Document.Body
                               .Elements<Table>().First();

                var rows = table.Elements<TableRow>().ToList();

                // Dòng tiêu đề
                foreach (var cell in rows[0].Elements<TableCell>())
                    dt.Columns.Add(cell.InnerText.Trim());

                // Dữ liệu
                for (int i = 1; i < rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    var cells = rows[i].Elements<TableCell>().ToList();

                    for (int j = 0; j < cells.Count; j++)
                        dr[j] = cells[j].InnerText.Trim();

                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        private void TinhDoDoV(DataTable dt)
        {
            DecisionTreeBLL bll = new DecisionTreeBLL();

            dgvKetQua.Rows.Clear();
            dgvKetQua.Columns.Clear();
            dgvKetQua.Columns.Add("ThuocTinh", "Thuộc tính");
            dgvKetQua.Columns.Add("DoDoV", "Độ đo V");

            string target = dt.Columns[dt.Columns.Count - 1].ColumnName;

            double maxV = -1;
            string root = "";

            for (int i = 0; i < dt.Columns.Count - 1; i++)
            {
                string attr = dt.Columns[i].ColumnName;
                double v = bll.Gain(dt, attr, target);

                dgvKetQua.Rows.Add(attr, v.ToString("0.###"));

                if (v > maxV)
                {
                    maxV = v;
                    root = attr;
                }
            }

            lblRoot.Text = $"Thuộc tính gốc: {root}";
            HienThiCay(root, dt);
        }
       

        public FrmCayQuyetDinhV()
        {
            InitializeComponent();
        }

        private void btnTinhV_Click(object sender, EventArgs e)
        {
            
        }


        private void treeQuyetDinh_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void HienThiCay(string root, DataTable dt)
        {
            treeQuyetDinh.Nodes.Clear();
            TreeNode r = new TreeNode(root);
            treeQuyetDinh.Nodes.Add(r);

            var values = dt.AsEnumerable()
                           .GroupBy(x => x[root].ToString());

            foreach (var v in values)
                r.Nodes.Add($"{root} = {v.Key}");

            treeQuyetDinh.ExpandAll();


        }

        private void FrmCayQuyetDinhV_Load(object sender, EventArgs e)
        {
           
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word files (*.docx)|*.docx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = DocBangTuWord(ofd.FileName);

                dgvData.DataSource = dt;

                TinhDoDoV(dt);
            }
        }
    }
}
