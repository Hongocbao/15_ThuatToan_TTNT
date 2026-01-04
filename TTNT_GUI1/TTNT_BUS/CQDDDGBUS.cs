using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TTNT_BUS
{
    public class DecisionTreeBUS
    {
        // Tính Entropy (Độ hỗn loạn)
        public double CalculateEntropy(DataTable data, string targetColumn)
        {
            int total = data.Rows.Count;
            if (total == 0) return 0;

            var counts = data.AsEnumerable()
                             .GroupBy(r => r[targetColumn].ToString())
                             .Select(g => g.Count());

            double entropy = 0;
            foreach (var count in counts)
            {
                double p = (double)count / total;
                if (p > 0) entropy -= p * Math.Log(p, 2);
            }
            return entropy;
        }

        // Tìm thuộc tính tốt nhất dựa trên Gain
        public string GetBestAttribute(DataTable data, List<string> attributes, string targetColumn, out string stepLog)
        {
            string bestAttr = "";
            double maxGain = -1;
            StringBuilder sb = new StringBuilder();

            double systemEntropy = CalculateEntropy(data, targetColumn);
            sb.AppendLine($"- Entropy hiện tại: {Math.Round(systemEntropy, 4)}");

            foreach (string attr in attributes)
            {
                var groups = data.AsEnumerable().GroupBy(r => r[attr].ToString());
                double childEntropy = 0;

                foreach (var g in groups)
                {
                    DataTable temp = g.CopyToDataTable();
                    double weight = (double)temp.Rows.Count / data.Rows.Count;
                    childEntropy += weight * CalculateEntropy(temp, targetColumn);
                }

                double gain = systemEntropy - childEntropy;
                sb.AppendLine($"  + [{attr}]: Gain = {Math.Round(gain, 4)}");

                if (gain > maxGain)
                {
                    maxGain = gain;
                    bestAttr = attr;
                }
            }
            sb.AppendLine($"=> CHỌN: {bestAttr.ToUpper()}");
            sb.AppendLine("--------------------------------");

            stepLog = sb.ToString();
            return bestAttr;
        }
    }
}