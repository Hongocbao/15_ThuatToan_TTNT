using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_DAL
{
    public class TKTCRDAL
    {
        public Dictionary<string, List<string>> Graph { get; set; }

        public TKTCRDAL()
        {
            Graph = new Dictionary<string, List<string>>()
            {
                { "A", new List<string>{ "B","C" } },
                { "B", new List<string>{ "D","E" } },
                { "C", new List<string>{ "F" } },
                { "D", new List<string>() },
                { "E", new List<string>{ "F" } },
                { "F", new List<string>() }
            };
        }

        public List<string> BFS(string start, string goal)
        {
            Queue<string> q = new Queue<string>();
            Dictionary<string, string> parent = new Dictionary<string, string>();
            HashSet<string> visited = new HashSet<string>();

            q.Enqueue(start);
            visited.Add(start);

            while (q.Count > 0)
            {
                string u = q.Dequeue();

                if (u == goal)
                    break;

                foreach (var v in Graph[u])
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        parent[v] = u;
                        q.Enqueue(v);
                    }
                }
            }

            List<string> path = new List<string>();

            if (goal != start && !parent.ContainsKey(goal))
                return path;

            string cur = goal;
            path.Add(cur);

            while (cur != start)
            {
                cur = parent[cur];
                path.Add(cur);
            }

            path.Reverse();
            return path;
        }

        public List<List<string>> BFS_Steps(string start)
        {
            Queue<string> q = new Queue<string>();
            HashSet<string> visited = new HashSet<string>();

            List<List<string>> steps = new List<List<string>>();

            q.Enqueue(start);
            visited.Add(start);

            while (q.Count > 0)
            {
                string u = q.Dequeue();

                foreach (var v in Graph[u])
                {
                    if (!visited.Contains(v))
                    {
                        visited.Add(v);
                        q.Enqueue(v);
                    }
                }

                steps.Add(visited.ToList());
            }

            return steps;
        }
    }
}
