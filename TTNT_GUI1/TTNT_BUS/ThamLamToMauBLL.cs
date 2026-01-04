using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNT_DAL;
namespace TTNT_BUS
{
    public class ThamLamToMauBLL
    {
                
            public int[] ToMau(DoThi dt)
            {
                int n = dt.SoDinh;
                int[] mau = new int[n];
                for (int i = 0; i < n; i++)
                    mau[i] = -1;

                mau[0] = 0;

                for (int u = 1; u < n; u++)
                {
                    bool[] daDung = new bool[n];

                    for (int v = 0; v < n; v++)
                    {
                        if (dt.MaTranKe[u, v] == 1 && mau[v] != -1)
                            daDung[mau[v]] = true;
                    }

                    int m;
                    for (m = 0; m < n; m++)
                    {
                        if (!daDung[m])
                            break;
                    }
                    mau[u] = m;
                }
                return mau;
            }

        public (int[], List<string>) ToMauCoNhatKy(DoThi dt)
        {
            int n = dt.SoDinh;
            int[] mau = new int[n];
            List<string> log = new List<string>();

            for (int i = 0; i < n; i++) mau[i] = -1; 

            for (int u = 0; u < n; u++)
            {
                
                bool[] cam = new bool[n];

                for (int v = 0; v < n; v++)
                {
                    if (dt.MaTranKe[u, v] > 0 && mau[v] != -1)
                    {
                        cam[mau[v]] = true;
                    }
                }

                int c;
                for (c = 0; c < n; c++)
                {
                    if (!cam[c]) break;
                }

                mau[u] = c;
                log.Add($"Xét đỉnh {u}: tô màu {c}");
            }

            return (mau, log);
        }

    }
}
