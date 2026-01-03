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
    public partial class FrmGTS1 : Form
    {
        DoThi dt;
        int[] mau;
        int[] bac;

        public FrmGTS1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSoDinh.Text);
            dt = new DoThi(n);

            // Lấy ma trận kề
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dt.MaTranKe[i, j] =
                        dgvMaTranKe.Rows[i].Cells[j].Value == null ? 0 :
                        Convert.ToInt32(dgvMaTranKe.Rows[i].Cells[j].Value);

            // Gọi GTS1
            GTS1BLL xl = new GTS1BLL();
            var kq = xl.ToMauGTS1(dt);

            mau = kq.Item1;
            bac = kq.Item2;
            List<string> log = kq.Item3;

            // Bảng kết quả
            dgvKetQua.Rows.Clear();
            dgvKetQua.Columns.Clear();
            dgvKetQua.Columns.Add("d", "Dinh");
            dgvKetQua.Columns.Add("b", "Bac");
            dgvKetQua.Columns.Add("m", "Mau");

            for (int i = 0; i < n; i++)
                dgvKetQua.Rows.Add(i, bac[i], mau[i]);

            // Nhật ký
            rtbNhatKy.Clear();
            foreach (var s in log)
                rtbNhatKy.AppendText(s + "\n");

            // Số sắc
            lblSoSac.Text = "So sac χ(G) = " + (mau.Max() + 1);

            pnlVeDoThi.Invalidate();
        }

        private void btnTaoMaTran_Click(object sender, EventArgs e)
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
    }
}
