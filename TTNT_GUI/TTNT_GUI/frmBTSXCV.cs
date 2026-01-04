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
using TTNT_DAL;

namespace TTNT_GUI
{
    public partial class frmBTSXCV : Form
    {
        private JobDAL jobDAL = new JobDAL();
        private JobBUS jobBUS;
        public frmBTSXCV()
        {
            InitializeComponent();
            jobBUS = new JobBUS(jobDAL);
        }

        private void frmBTSXCV_Load(object sender, EventArgs e)
        {
            SetupListViews();
            SetupComboBox();
        }

            private void SetupListViews()
        {
            // ListView Input
            lsvBD.View = View.Details;
            lsvBD.FullRowSelect = true;
            lsvBD.Columns.Add("Tên công việc", 100);
            lsvBD.Columns.Add("Thời gian", 80);

            // ListView Result
            lsvQL.View = View.Details;
            lsvQL.Columns.Add("Công việc", 100);
            lsvQL.Columns.Add("Thời gian", 80);
            lsvQL.Columns.Add("Máy", 50);
            lsvQL.Columns.Add("Bắt đầu", 80);
            lsvQL.Columns.Add("Kết thúc", 80);
        }
        private void SetupComboBox()
        {
            cboBT.Items.AddRange(new string[]
            {
        "M1=M2=M3",
        "M1=M2=2M3",
        "M1=2M2=2M3"
            });
            cboBT.SelectedIndex = 0; // mặc định chọn biểu thức đầu tiên
        }


        private void btnT_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTCV.Text) && int.TryParse(txtTGCV.Text, out int duration))
            {
                // Thêm công việc vào DAL
                jobDAL.AddJob(txtTCV.Text, duration);

                // Cập nhật ListView Input
                RefreshInputListView();

                // Xóa trắng TextBox và đặt focus vào txtTCV
                txtTCV.Clear();
                txtTGCV.Clear();
                txtTCV.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên công việc và thời gian hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (lsvBD.SelectedIndices.Count > 0)
            {
                int index = lsvBD.SelectedIndices[0];
                jobDAL.RemoveJob(index);
                RefreshInputListView();
            }
        }

        private void RefreshInputListView()
        {
            lsvBD.Items.Clear();
            foreach (var job in jobDAL.Jobs)
            {
                ListViewItem item = new ListViewItem(job.Name);
                item.SubItems.Add(job.Duration.ToString());
                lsvBD.Items.Add(item);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lsvQL.Items.Clear();
            var ratio = GetMachineRatio(); // lấy từ ComboBox
            var schedule = jobBUS.ScheduleJobs(ratio);

            foreach (var s in schedule)
            {
                ListViewItem item = new ListViewItem(s.job.Name);
                item.SubItems.Add(s.job.Duration.ToString());
                item.SubItems.Add($"M{s.machine}");
                item.SubItems.Add(Math.Round(s.start, 2).ToString());
                item.SubItems.Add(Math.Round(s.end, 2).ToString());
                lsvQL.Items.Add(item);
            }
        }

        private double[] GetMachineRatio()
        {
            switch (cboBT.SelectedItem.ToString())
            {
                case "M1=M2=M3":
                    return new double[] { 1, 1, 1 };
                case "M1=M2=2M3":
                    return new double[] { 1, 1, 0.5 };
                case "M1=2M2=2M3":
                    return new double[] { 2, 1, 1 };
                default:
                    return new double[] { 1, 1, 1 };
            }
        }


        private void btnXKQ_Click(object sender, EventArgs e)
        {
            lsvQL.Items.Clear();
        }
    }
}
