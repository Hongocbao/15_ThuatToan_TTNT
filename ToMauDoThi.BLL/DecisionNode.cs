using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToMauDoThi.DAL;

namespace ToMauDoThi.BLL
{
    public class DecisionNode
    {
        public int Dinh { get; set; }
        public int Mau { get; set; }
        public List<DecisionNode> Children { get; set; }

        public DecisionNode(int dinh, int mau)
        {
            Dinh = dinh;
            Mau = mau;
            Children = new List<DecisionNode>();
        }
    }
}
