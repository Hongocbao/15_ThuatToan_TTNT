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
using ToMauDoThi.DAL;


namespace ToMauDoThi.UI
{
    public partial class FrmThamLam : Form
    {
        DoThi dt;
        int[] mau;
        public FrmThamLam()
        {
            InitializeComponent();
        }

       
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoDinh.Text);

            // 2. Tạo đồ thị
            DoThi dt = new DoThi(n);

            // 3. Lấy ma trận kề
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dgvMaTranKe.Rows[i].Cells[j].Value == null)
                        dt.MaTranKe[i, j] = 0;
                    else
                        dt.MaTranKe[i, j] =
                            Convert.ToInt32(dgvMaTranKe.Rows[i].Cells[j].Value);
                }
            }

            // 4. GỌI HÀM CÓ NHẬT KÝ (BLL)
            ThamLamToMauBLL xl = new ThamLamToMauBLL();
            var ketQua = xl.ToMauCoNhatKy(dt);

            int[] mau = ketQua.Item1;
            List<string> log = ketQua.Item2;

            // 5. HIỂN THỊ BẢNG KẾT QUẢ
            dgvKetQua.Rows.Clear();
            dgvKetQua.Columns.Clear();
            dgvKetQua.Columns.Add("dinh", "Dinh");
            dgvKetQua.Columns.Add("mau", "Mau");

            for (int i = 0; i < mau.Length; i++)
                dgvKetQua.Rows.Add(i, mau[i]);

            // 6. HIỂN THỊ NHẬT KÝ
            rtbNhatKy.Clear();
            foreach (var dong in log)
                rtbNhatKy.AppendText(dong + "\n");

            // 7. VẼ ĐỒ THỊ
            pnlVeDoThi.Refresh();
            this.dt = dt;
            this.mau = mau;
            pnlVeDoThi.Invalidate();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoDinh.Text);

            dgvMaTranKe.Columns.Clear();
            dgvMaTranKe.Rows.Clear();

            for (int i = 0; i < n; i++)
                dgvMaTranKe.Columns.Add($"c{i}", i.ToString());

            dgvMaTranKe.Rows.Add(n);

            for (int i = 0; i < n; i++)
                dgvMaTranKe.Rows[i].HeaderCell.Value = i.ToString();
        }

        private void pnlVeDoThi_Paint(object sender, PaintEventArgs e)
        {
            if (dt == null || mau == null) return;

            Graphics g = e.Graphics;
            int n = dt.SoDinh;

            int R = 150;
            int cx = pnlVeDoThi.Width / 2;
            int cy = pnlVeDoThi.Height / 2;

            Point[] toaDo = new Point[n];

            for (int i = 0; i < n; i++)
            {
                double angle = 2 * Math.PI * i / n;
                toaDo[i] = new Point(
                    cx + (int)(R * Math.Cos(angle)),
                    cy + (int)(R * Math.Sin(angle))
                );
            }

            // Vẽ cạnh
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (dt.MaTranKe[i, j] == 1)
                        g.DrawLine(Pens.Black, toaDo[i], toaDo[j]);

            Color[] bangMau = {
        Color.Red, Color.Green, Color.Blue,
        Color.Yellow, Color.Orange, Color.Pink
    };

            // Vẽ đỉnh
            for (int i = 0; i < n; i++)
            {
                Brush b = new SolidBrush(bangMau[mau[i] % bangMau.Length]);
                g.FillEllipse(b, toaDo[i].X - 15, toaDo[i].Y - 15, 30, 30);
                g.DrawEllipse(Pens.Black, toaDo[i].X - 15, toaDo[i].Y - 15, 30, 30);
                g.DrawString(i.ToString(), Font, Brushes.Black,
                    toaDo[i].X - 5, toaDo[i].Y - 8);
            }
        }

        private void rtbNhatKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
