using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_BUS
{
    public class LogicNode
    {
        public string Expression { get; set; }
        public List<LogicNode> Children { get; set; } = new List<LogicNode>();
        public bool IsProved { get; set; } = false;
        public LogicNode(string exp) { Expression = exp; }
    }
}
