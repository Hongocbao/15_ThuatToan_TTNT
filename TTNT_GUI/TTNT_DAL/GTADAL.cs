using System.Collections.Generic;

namespace TTNT_DAL
{
    public class GTADAL
    {
        public Dictionary<string, List<(string, int)>> GetGraph()
        {
            return new Dictionary<string, List<(string, int)>>()
            {
                ["A"] = new List<(string, int)> { ("B", 2), ("C", 3) },
                ["B"] = new List<(string, int)> { ("D", 4), ("E", 1) },
                ["C"] = new List<(string, int)> { ("E", 2), ("F", 5) },
                ["D"] = new List<(string, int)> { ("G", 3) },
                ["E"] = new List<(string, int)> { ("G", 2) },
                ["F"] = new List<(string, int)> { ("G", 1) },
                ["G"] = new List<(string, int)>()
            };
        }

        public Dictionary<string, int> GetHeuristic()
        {
            return new Dictionary<string, int>()
            {
                ["A"] = 6,
                ["B"] = 4,
                ["C"] = 4,
                ["D"] = 2,
                ["E"] = 2,
                ["F"] = 1,
                ["G"] = 0
            };
        }

        public List<string> GetVertices()
            => new List<string> { "A", "B", "C", "D", "E", "F", "G" };
    }
}
