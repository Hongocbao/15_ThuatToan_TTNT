using System;
using System.Collections.Generic;
using System.Linq;
using TTNT_DAL;

namespace TTNT_BUS
{
    public class GTABUS
    {
        GTADAL dal;

        public GTABUS()
        {
            dal = new GTADAL();
        }

        public List<string> RunAStar(string start, string goal)
        {
            var graph = dal.GetGraph();
            var h = dal.GetHeuristic();

            var open = new SortedSet<(int, string)>(
                Comparer<(int, string)>.Create((a, b) =>
                {
                    int cmp = a.Item1.CompareTo(b.Item1);
                    if (cmp == 0) return a.Item2.CompareTo(b.Item2);
                    return cmp;
                })
            );

            var came = new Dictionary<string, string>();
            var g = graph.Keys.ToDictionary(x => x, x => int.MaxValue);

            g[start] = 0;
            open.Add((h[start], start));

            while (open.Any())
            {
                var first = open.First();
                var cur = first.Item2;
                open.Remove(first);

                if (cur == goal)
                    return Rebuild(came, cur);

                foreach (var e in graph[cur])
                {
                    var nb = e.Item1;
                    var cost = e.Item2;

                    int tg = g[cur] + cost;

                    if (tg < g[nb])
                    {
                        g[nb] = tg;
                        came[nb] = cur;

                        int f = tg + h[nb];
                        open.Add((f, nb));
                    }
                }
            }

            return new List<string>();
        }

        List<string> Rebuild(Dictionary<string, string> c, string cur)
        {
            var p = new List<string>();
            while (c.ContainsKey(cur))
            {
                p.Insert(0, cur);
                cur = c[cur];
            }
            p.Insert(0, cur);
            return p;
        }

        public List<(int loop, string X, string Y, string Close, string Prev)>
    GetSteps(string start, string goal)
        {
            var graph = dal.GetGraph();
            var h = dal.GetHeuristic();

            var open = new SortedSet<(int, string)>(
                Comparer<(int, string)>.Create((a, b) =>
                {
                    int cmp = a.Item1.CompareTo(b.Item1);
                    if (cmp == 0) return a.Item2.CompareTo(b.Item2);
                    return cmp;
                })
            );

            var came = new Dictionary<string, string>();
            var g = graph.Keys.ToDictionary(v => v, v => int.MaxValue);

            var log = new List<(int, string, string, string, string)>();

            g[start] = 0;
            open.Add((h[start], start));

            var closed = new List<string>();
            int step = 1;

            while (open.Any())
            {
                var first = open.First();
                var cur = first.Item2;
                open.Remove(first);

                closed.Add(cur);

                // ghi trạng thái lấy node cur ra xử lý
                log.Add((step++, cur, "-", string.Join(",", closed),
                    came.ContainsKey(cur) ? came[cur] : "-"));

                if (cur == goal)
                    break;

                foreach (var edge in graph[cur])
                {
                    var nb = edge.Item1;
                    var cost = edge.Item2;

                    int tg = g[cur] + cost;

                    // ghi bước xét nb
                    log.Add((step++, cur, nb, string.Join(",", closed), cur));

                    if (tg < g[nb])
                    {
                        came[nb] = cur;
                        g[nb] = tg;

                        int f = tg + h[nb];
                        open.Add((f, nb));
                    }
                }
            }

            return log;
        }


        public List<string> GetVertices()
            => dal.GetVertices();

        public Dictionary<string, List<(string, int)>> GetGraph()
            => dal.GetGraph();

        public Dictionary<string, int> GetHeuristic()
            => dal.GetHeuristic();
    }
}
