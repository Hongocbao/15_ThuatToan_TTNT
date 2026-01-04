using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_DAL
{
    public class DoThi
    {
        public int SoDinh { get; set; }
        public int[,] MaTranKe { get; set; }

        public DoThi(int soDinh)
        {
            SoDinh = soDinh;
            MaTranKe = new int[soDinh, soDinh];
        }
    }
}

