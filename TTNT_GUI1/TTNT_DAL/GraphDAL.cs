using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_DAL
{
    public class GraphDAL
    {
        public int SoDinh { get; set; }
        public int[,] MaTranKe { get; set; }

        public GraphDAL(int soDinh)
        {
            SoDinh = soDinh;
            MaTranKe = new int[soDinh, soDinh];
        }

        public void ThemCanh(int u, int v)
        {
            MaTranKe[u, v] = 1;
            MaTranKe[v, u] = 1;
        }
    }
}
