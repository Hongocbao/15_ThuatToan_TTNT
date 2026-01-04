using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNT_DAL;

namespace TTNT_BUS 
{
    public class ThamLamSapXepBLL
    {
        public (int[], int[], List<string>) ToMauTheoBac(DoThi dt)
        {
            int n = dt.SoDinh;
            int[] mau = new int[n];
            int[] bac = new int[n];
            List<string> log = new List<string>();

            // 1. Tính bậc của từng đỉnh
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (dt.MaTranKe[i, j] > 0) count++;
                }
                bac[i] = count;
                mau[i] = -1; // Khởi tạo chưa tô màu
            }

            // 2. Tạo danh sách đỉnh và sắp xếp giảm dần theo bậc
            var danhSachDinh = Enumerable.Range(0, n)
                .OrderByDescending(i => bac[i])
                .ToList();

            log.Add("Danh sách đỉnh sắp xếp theo bậc giảm dần:");
            foreach (var v in danhSachDinh) log.Add($"Đỉnh {v} (bậc {bac[v]})");
            log.Add("---------------------------");

            // 3. Tiến hành tô màu tham lam dựa trên danh sách đã sắp xếp
            foreach (int u in danhSachDinh)
            {
                bool[] cam = new bool[n];
                for (int v = 0; v < n; v++)
                {
                    if (dt.MaTranKe[u, v] > 0 && mau[v] != -1)
                        cam[mau[v]] = true;
                }

                int c;
                for (c = 0; c < n; c++)
                {
                    if (!cam[c]) break;
                }

                mau[u] = c;
                log.Add($"Xét đỉnh {u} (bậc {bac[u]}): tô màu {c}");
            }

            return (mau, bac, log);
        }
    }
}

