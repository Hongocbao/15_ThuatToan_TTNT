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
    public partial class frmVH : Form
    {
        private LogicNode currentTree = null;
        public frmVH()
        {
            InitializeComponent();
            pnlDT.AutoScroll = true; // Thêm scroll
            this.DoubleBuffered = true;
            pnlDT.Paint += pnlDT_Paint;
        }

        private void frmVH_Load(object sender, EventArgs e)
        {

        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            string input = txtBT.Text;
            if (string.IsNullOrWhiteSpace(input)) return;

            // Xây dựng cây phân rã chi tiết
            currentTree = ExpandNode(new LogicNode(input));

            // Kiểm tra tổng thể để hiện thông báo
            bool allProved = CheckAllLeaves(currentTree);
            lblTB.Text = allProved ? "Tất cả các trường hợp đều được CM. Vậy phát biểu trên là ĐÚNG"
                                   : "Phát biểu KHÔNG được chứng minh hoàn toàn.";
            lblTB.ForeColor = allProved ? Color.DarkGreen : Color.Red;

            pnlDT.Invalidate();
        }

        private LogicNode ExpandNode(LogicNode node)
        {
            // 1. Kiểm tra mâu thuẫn để dừng (IsProved)
            if (IsProved(node.Expression))
            {
                node.IsProved = true;
                return node;
            }

            // Tách danh sách thành các phần tử
            var formulas = node.Expression.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(x => x.Trim()).ToList();

            // 2. Tìm mục tiêu phân rã (Ưu tiên Tuyển ∨ để giống hình)
            string targetV = formulas.FirstOrDefault(f => f.Contains("∨"));
            if (targetV != null)
            {
                // Loại bỏ chính nó để node con không bị lặp lại vô tận
                var others = formulas.Where(f => f != targetV).ToList();
                string[] parts = targetV.Split('∨');

                // Nhánh trái: A + các phần tử còn lại
                string leftExpr = string.Join(", ", others) + (others.Any() ? ", " : "") + parts[0].Trim();
                node.Children.Add(ExpandNode(new LogicNode(leftExpr)));

                // Nhánh phải: B + các phần tử còn lại
                string rightExpr = string.Join(", ", others) + (others.Any() ? ", " : "") + parts[1].Trim();
                node.Children.Add(ExpandNode(new LogicNode(rightExpr)));

                return node;
            }

            // 3. Xét đến Kéo theo → (Nếu không còn ∨)
            string targetArrow = formulas.FirstOrDefault(f => f.Contains("→"));
            if (targetArrow != null)
            {
                var others = formulas.Where(f => f != targetArrow).ToList();
                string[] parts = targetArrow.Split('→');

                // Theo hình: p → t  => giữ nguyên biểu thức đó và "đưa" p ra ngoài để xét mâu thuẫn
                // Ở đây để tránh đệ quy vô tận, ta coi như đã xử lý xong dấu → của cụm này
                string newExpr = string.Join(", ", others) + (others.Any() ? ", " : "") + parts[0].Trim() + ", " + parts[1].Trim();

                node.Children.Add(ExpandNode(new LogicNode(newExpr)));
                return node;
            }

            return node;
        }

        private bool IsProved(string expr)
        {
            if (string.IsNullOrEmpty(expr)) return false;

            var atoms = expr.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.Trim())
                            .Where(x => !string.IsNullOrEmpty(x)) // Loại bỏ rỗng
                            .ToList();

            foreach (var a in atoms)
            {
                // Nếu a là "p", tìm "¬p"
                if (!a.StartsWith("¬"))
                {
                    if (atoms.Contains("¬" + a)) return true;
                }
                // Nếu a là "¬p", tìm "p"
                else
                {
                    string positive = a.Substring(1).Trim();
                    if (atoms.Contains(positive)) return true;
                }
            }
            return false;
        }

        private bool CheckAllLeaves(LogicNode node)
        {
            if (node == null) return false;
            if (node.Children.Count == 0) return node.IsProved;
            return node.Children.All(c => CheckAllLeaves(c));
        }


        private void btnXC_Click(object sender, EventArgs e)
        {
            txtBT.Clear();
            currentTree = null;
            pnlDT.Invalidate();
        }

        private void txtBT_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtBT.SelectionStart;
            string originalText = txtBT.Text;

            // Quy tắc thay đổi: thêm dấu ^ thành ∧
            string newText = originalText
                .Replace("!", "¬")   // Gõ ! -> ¬
                .Replace("|", "∨")   // Gõ | -> ∨
                .Replace("^", "∧")   // Gõ ^ -> ∧ (Mới thêm)
                .Replace("->", "→"); // Gõ -> -> →

            if (newText != originalText)
            {
                txtBT.Text = newText;
                // Giữ vị trí con trỏ không bị nhảy
                txtBT.SelectionStart = Math.Max(0, cursorPosition);
            }
        }

        private void pnlDT_Paint(object sender, PaintEventArgs e)
        {
            if (currentTree == null) return;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.TranslateTransform(pnlDT.AutoScrollPosition.X, pnlDT.AutoScrollPosition.Y);

            // Dùng hàm DrawTree thống nhất
            DrawTree(e.Graphics, currentTree, pnlDT.Width / 2, 20, pnlDT.Width / 4);
        }


        private string GetAllExpressions(LogicNode node)
        {
            string result = node.Expression;
            foreach (var child in node.Children)
            {
                result += Environment.NewLine + GetAllExpressions(child);
            }
            return result;
        }

        private void DrawTree(Graphics g, LogicNode node, float x, float y, float xOffset)
        {
            float w = 180, h = 35;
            RectangleF rect = new RectangleF(x - w / 2, y, w, h);

            // Vẽ Box (Màu sắc theo trạng thái)
            Brush bg = node.IsProved ? Brushes.LightYellow : Brushes.LightBlue;
            g.FillRectangle(bg, rect);
            g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);

            // Vẽ chữ
            StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(node.Expression, this.Font, Brushes.Black, rect, sf);

            if (node.IsProved && node.Children.Count == 0)
                g.DrawString("Được CM", new Font(this.Font, FontStyle.Bold), Brushes.Red, x - 35, y + h + 5);

            // Vẽ nhánh đệ quy
            for (int i = 0; i < node.Children.Count; i++)
            {
                float childX = (node.Children.Count == 1) ? x : (i == 0 ? x - xOffset : x + xOffset);
                float childY = y + 80;
                g.DrawLine(Pens.Gray, x, y + h, childX, childY);
                DrawTree(g, node.Children[i], childX, childY, xOffset / 1.8f);
            }
        }

        private void lblHD_Click(object sender, EventArgs e)
        {

        }
    }
}

