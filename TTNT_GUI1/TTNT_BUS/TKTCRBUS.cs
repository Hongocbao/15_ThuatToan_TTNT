using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNT_DAL;

namespace TTNT_BUS
{
    public class TKTCRBUS
    {
        private TKTCRDAL dal;

        public TKTCRBUS()
        {
            dal = new TKTCRDAL();
        }

        public List<string> GetVertices()
        {
            return dal.Graph.Keys.ToList();
        }

        public Dictionary<string, List<string>> GetGraph()
        {
            return dal.Graph;
        }

        public List<string> RunBFS(string start, string goal)
        {
            return dal.BFS(start, goal);
        }

        public List<List<string>> GetSteps(string start)
        {
            return dal.BFS_Steps(start);
        }


        public List<(int loop, string node, string open, string close)>
        GetSteps(string start, string goal)
        {
            var g = dal.Graph;

            var open = new Queue<string>();
            var close = new List<string>();
            var visited = new HashSet<string>();

            var log = new List<(int, string, string, string)>();

            int step = 1;

            open.Enqueue(start);
            visited.Add(start);

            while (open.Any())
            {
                string u = open.Dequeue();
                close.Add(u);

                log.Add(
                    (step++,
                     u,
                     string.Join(",", open),
                     string.Join(",", close))
                );

                if (u == goal)
                    break;

                foreach (var v in g[u])
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        open.Enqueue(v);
                    }
                }
            }

            return log;
        }
    }
}
