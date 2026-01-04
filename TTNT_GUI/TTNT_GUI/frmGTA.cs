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
    public partial class frmGTA : Form
    {
        GTABUS bus;

        List<string> finalPath = null;
        List<string> visited = new List<string>();

        List<(int loop, string x, string y, string close, string prev)> stepLog
            = new List<(int, string, string, string, string)>();

        Timer timer;
        int currentStep = 0;

        List<string> path;

        Dictionary<string, Point> pos = new Dictionary<string, Point>();
        public frmGTA()
        {
            InitializeComponent();
            bus = new GTABUS();

            timer = new Timer();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
        }

        private void frmGTA_Load(object sender, EventArgs e)
        {
            cboBD.DataSource = bus.GetVertices().ToList();
            cboKT.DataSource = bus.GetVertices().ToList();

            // vị trí node trên panel
            pos["A"] = new Point(100, 100);
            pos["B"] = new Point(200, 60);
            pos["C"] = new Point(200, 150);
            pos["D"] = new Point(300, 30);
            pos["E"] = new Point(300, 100);
            pos["F"] = new Point(300, 170);
            pos["G"] = new Point(420, 100);

            pnlDoThi.Paint += pnlDoThi_Paint;

            // setup listview
            lvSteps.View = View.Details;
            lvSteps.FullRowSelect = true;
            lvSteps.GridLines = true;

            lvSteps.Columns.Add("Lặp", 60);
            lvSteps.Columns.Add("X", 60);
            lvSteps.Columns.Add("Y", 60);
            lvSteps.Columns.Add("Close", 60);
            lvSteps.Columns.Add("Prev", 60);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ResetState();

            if (!ckbHTCT.Checked)
            {
                finalPath = bus.RunAStar(cboBD.Text, cboKT.Text);
                ShowPathList();
                pnlDoThi.Refresh();
            }
            else
            {
                stepLog = bus.GetSteps(cboBD.Text, cboKT.Text);
                currentStep = 0;
                timer.Start();
            }
        }


        private void btnR_Click(object sender, EventArgs e)
        {
            ResetState();
            pnlDoThi.Refresh();
        }

        void ResetState()
        {
            visited.Clear();
            finalPath = null;
            stepLog.Clear();
            currentStep = 0;
            timer.Stop();
            lstPath.Items.Clear();
            lvSteps.Items.Clear();
        }

        void ShowPathList()
        {
            lstPath.Items.Clear();
            if (finalPath == null) return;

            foreach (var p in finalPath)
                lstPath.Items.Add(p);
        }

        private void pnlDoThi_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var graph = bus.GetGraph();

            // vẽ cạnh
            foreach (var u in graph)
                foreach (var v in u.Value)
                    g.DrawLine(Pens.Black, pos[u.Key], pos[v.Item1]);

            // vẽ đỉnh
            foreach (var u in graph.Keys)
            {
                Brush br = Brushes.LightBlue;

                if (visited.Contains(u)) br = Brushes.Orange;
                if (finalPath != null && finalPath.Contains(u)) br = Brushes.Red;
                if (u == cboBD.Text) br = Brushes.Green;
                if (u == cboKT.Text) br = Brushes.Purple;

                Rectangle r = new Rectangle(pos[u].X - 15, pos[u].Y - 15, 30, 30);
                g.FillEllipse(br, r);
                g.DrawEllipse(Pens.Black, r);
                g.DrawString(u, new Font("Arial", 12), Brushes.Black,
                    pos[u].X - 7, pos[u].Y - 8);
            }
        }

        private void ckbHTCT_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHTCT.Checked)
                this.Text = "Giải thuật A* - Chế độ từng bước";
            else
                this.Text = "Giải thuật A* - Chạy bình thường";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (currentStep >= stepLog.Count)
            {
                timer.Stop();
                finalPath = bus.RunAStar(cboBD.Text, cboKT.Text);
                ShowPathList();
                pnlDoThi.Refresh();
                return;
            }

            var s = stepLog[currentStep];

            if (!visited.Contains(s.x))
                visited.Add(s.x);

            // add vào listview
            var item = new ListViewItem(s.loop.ToString());
            item.SubItems.Add(s.x);
            item.SubItems.Add(s.y);
            item.SubItems.Add(s.close);
            item.SubItems.Add(s.prev);

            lvSteps.Items.Add(item);

            currentStep++;
            pnlDoThi.Refresh();
        }
    }
}
