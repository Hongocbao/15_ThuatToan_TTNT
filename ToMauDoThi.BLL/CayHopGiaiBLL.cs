using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToMauDoThi.DAL;

namespace ToMauDoThi.BLL
{
    public class CayHopGiaiBLL
    {
        private GraphDAL graph;
        private int soMau;
        public int[] Mau;

        public DecisionNode Root;

        public CayHopGiaiBLL(GraphDAL g, int m)
        {
            graph = g;
            soMau = m;
            Mau = new int[g.SoDinh];
            Root = new DecisionNode(-1, -1);
        }

        public bool ToMau(int dinh, DecisionNode parent)
        {
            if (dinh == graph.SoDinh)
                return true;

            for (int mau = 1; mau <= soMau; mau++)
            {
                if (HopLe(dinh, mau))
                {
                    Mau[dinh] = mau;
                    DecisionNode node = new DecisionNode(dinh, mau);
                    parent.Children.Add(node);

                    if (ToMau(dinh + 1, node))
                        return true;

                    Mau[dinh] = 0; // backtrack
                }
            }
            return false;
        }

        private bool HopLe(int dinh, int mau)
        {
            for (int i = 0; i < graph.SoDinh; i++)
                if (graph.MaTranKe[dinh, i] == 1 && Mau[i] == mau)
                    return false;

            return true;
        }
    }
}
