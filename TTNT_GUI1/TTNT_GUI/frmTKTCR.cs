using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNT_BUS;

namespace TTNT_GUI
{
    public partial class frmTKTCR : Form
    {
        List<(int loop, string node, string open, string close)> steps;

        List<List<string>> stepVisited;

        List<string> visitedSoFar = new List<string>();

        int currentStep = 0;

        List<string> finalPath;

        Timer timer;
        TKTCRBUS bus;

        Dictionary<string, Point> pos = new Dictionary<string, Point>();
        public frmTKTCR()
        {
            InitializeComponent();
            bus = new TKTCRBUS();

            timer = new Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
        }

        private void frmTKTCR_Load(object sender, EventArgs e)
        {
            cboBD.DataSource = bus.GetVertices().ToList();
            cboKT.DataSource = bus.GetVertices().ToList();

            pos["A"] = new Point(100, 100);
            pos["B"] = new Point(200, 60);
            pos["C"] = new Point(200, 140);
            pos["D"] = new Point(320, 40);
            pos["E"] = new Point(320, 100);
            pos["F"] = new Point(320, 160);

            pnlDoThi.Paint += pnlDoThi_Paint;

            lsvHT.Columns.Add("Lần lặp", 70);
            lsvHT.Columns.Add("Đỉnh", 70);
            lsvHT.Columns.Add("Open", 80);
            lsvHT.Columns.Add("Close", 80);

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lsvHT.Items.Clear();
            finalPath = null;

            if (!ckbHTCT.Checked)
            {
                finalPath = bus.RunBFS(cboBD.Text, cboKT.Text);
                pnlDoThi.Refresh();
            }
            else
            {
                steps = bus.GetSteps(cboBD.Text, cboKT.Text);   // log
                stepVisited = bus.GetSteps(cboBD.Text);         // visited animation

                foreach (var s in steps)
                {
                    var item = new ListViewItem(s.loop.ToString());
                    item.SubItems.Add(s.node);
                    item.SubItems.Add(s.open);
                    item.SubItems.Add(s.close);

                    lsvHT.Items.Add(item);
                }

                currentStep = 0;
                visitedSoFar.Clear();
                timer.Start();
            }
        }

        private void btnLKQ_Click(object sender, EventArgs e)
        {
            if (finalPath == null || finalPath.Count == 0)
            {
                MessageBox.Show("Chưa có kết quả để lưu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Text File|*.txt";
            s.Title = "Lưu kết quả BFS";

            if (s.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter w = new StreamWriter(s.FileName))
                {
                    w.WriteLine("KẾT QUẢ TÌM KIẾM THEO CHIỀU RỘNG (BFS)");
                    w.WriteLine("-------------------------------------");
                    w.WriteLine("Thời gian: " + DateTime.Now);
                    w.WriteLine("Đỉnh bắt đầu: " + cboBD.Text);
                    w.WriteLine("Đỉnh kết thúc: " + cboKT.Text);
                    w.WriteLine();
                    w.WriteLine("Đường đi ngắn nhất:");

                    foreach (var v in finalPath)
                        w.Write(v + " ");

                    w.WriteLine();
                }

                MessageBox.Show("Lưu thành công!", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnlDoThi_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var graph = bus.GetGraph();

            // Vẽ các cạnh
            foreach (var u in graph)
            {
                foreach (var v in u.Value)
                {
                    g.DrawLine(Pens.Black, pos[u.Key], pos[v]);
                }
            }

            // Vẽ các đỉnh
            foreach (var u in graph.Keys)
            {
                Brush br = Brushes.LightBlue;   // mặc định: chưa duyệt

                // Đỉnh đã duyệt trong quá trình BFS
                if (visitedSoFar.Contains(u))
                    br = Brushes.Orange;

                // Start node
                if (u == cboBD.Text)
                    br = Brushes.Green;

                // Goal node
                if (u == cboKT.Text)
                    br = Brushes.Purple;

                // Đỉnh thuộc đường đi ngắn nhất (ưu tiên cao nhất)
                if (finalPath != null && finalPath.Contains(u))
                    br = Brushes.Red;

                Rectangle r = new Rectangle(pos[u].X - 15, pos[u].Y - 15, 30, 30);

                g.FillEllipse(br, r);
                g.DrawEllipse(Pens.Black, r);
                g.DrawString(u, new Font("Arial", 12), Brushes.Black, pos[u].X - 7, pos[u].Y - 8);
            }
        }

        private void ckbHTCT_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHTCT.Checked)
                this.Text = "Tìm kiếm theo chiều rộng - Chế độ từng bước";
            else
                this.Text = "Tìm kiếm theo chiều rộng - Chạy bình thường";
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (stepVisited == null || stepVisited.Count == 0)
                return;

            if (currentStep >= stepVisited.Count)
            {
                timer.Stop();
                finalPath = bus.RunBFS(cboBD.Text, cboKT.Text);
                pnlDoThi.Refresh();
                return;
            }

            foreach (var v in stepVisited[currentStep])
            {
                if (!visitedSoFar.Contains(v))
                    visitedSoFar.Add(v);
            }

            currentStep++;

            pnlDoThi.Refresh();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            lsvHT.Items.Clear();
            finalPath = null;
            pnlDoThi.Refresh();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
