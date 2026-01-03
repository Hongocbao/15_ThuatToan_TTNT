using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToMauDoThi.DAL;


namespace ToMauDoThi.BLL
{
    public class GTS1BLL
    {
        public (int[], int[], List<string>) ToMauGTS1(DoThi dt)
        {
            int n = dt.SoDinh;
            int[] mau = new int[n];
            int[] bac = new int[n];
            bool[] daTo = new bool[n];
            List<string> log = new List<string>();

            // Khởi tạo
            for (int i = 0; i < n; i++)
            {
                mau[i] = -1;
                for (int j = 0; j < n; j++)
                    bac[i] += dt.MaTranKe[i, j];
            }

            for (int step = 0; step < n; step++)
            {
                // 1. Chọn đỉnh chưa tô có bậc lớn nhất
                int u = -1;
                int maxBac = -1;

                for (int i = 0; i < n; i++)
                    if (!daTo[i] && bac[i] > maxBac)
                    {
                        maxBac = bac[i];
                        u = i;
                    }

                // 2. Tìm màu nhỏ nhất hợp lệ
                bool[] cam = new bool[n];
                for (int v = 0; v < n; v++)
                    if (dt.MaTranKe[u, v] == 1 && mau[v] != -1)
                        cam[mau[v]] = true;

                int c;
                for (c = 0; c < n; c++)
                    if (!cam[c]) break;

                mau[u] = c;
                daTo[u] = true;

                log.Add($"Buoc {step + 1}: chon dinh {u} (bac {maxBac}) → to mau {c}");

                // 3. Giảm bậc các đỉnh kề chưa tô
                for (int v = 0; v < n; v++)
                    if (dt.MaTranKe[u, v] == 1 && !daTo[v])
                        bac[v]--;
            }

            return (mau, bac, log);
        }
    }
}
