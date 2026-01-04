using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNT_DAL;

namespace TTNT_BUS
{
    public class DecisionTreeBLL
    {
        public double Entropy(List<string> labels)
        {
            double entropy = 0;
            int total = labels.Count;

            var groups = labels.GroupBy(x => x);
            foreach (var g in groups)
            {
                double p = (double)g.Count() / total;
                entropy -= p * Math.Log(p, 2);
            }
            return entropy;
        }

        public double Gain(DataTable data, string attribute, string target)
        {
            double entropyS = Entropy(
                data.AsEnumerable().Select(r => r[target].ToString()).ToList());

            double sum = 0;
            int total = data.Rows.Count;

            var values = data.AsEnumerable()
                             .GroupBy(r => r[attribute].ToString());

            foreach (var v in values)
            {
                List<string> labels = v.Select(r => r[target].ToString()).ToList();
                sum += (double)labels.Count / total * Entropy(labels);
            }

            return entropyS - sum;
        }
    }
}
