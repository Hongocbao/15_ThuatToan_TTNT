// TTNT_BUS/JobBUS.cs
using System.Collections.Generic;
using System.Linq;
using TTNT_DAL;

namespace TTNT_BUS
{
    public class JobBUS
    {
        private JobDAL jobDAL;

        public JobBUS(JobDAL dal)
        {
            jobDAL = dal;
        }

        // Thuật toán LPT cho 3 máy
        public List<(JobDAL.Job job, int machine, double start, double end)> ScheduleJobs(double[] machineRatio = null)
        {
            var jobs = jobDAL.Jobs.OrderByDescending(j => j.Duration).ToList();
            int machineCount = machineRatio != null ? machineRatio.Length : 3;
            if (machineRatio == null)
            {
                machineRatio = Enumerable.Repeat(1.0, machineCount).ToArray();
            }

            double[] machineTime = new double[machineCount]; // thời gian tích lũy
            var result = new List<(JobDAL.Job job, int machine, double start, double end)>();

            foreach (var job in jobs)
            {
                int mIndex = 0;
                double minTime = machineTime[0] / machineRatio[0]; // hiệu quả
                for (int i = 1; i < machineCount; i++)
                {
                    double effTime = machineTime[i] / machineRatio[i];
                    if (effTime < minTime)
                    {
                        minTime = effTime;
                        mIndex = i;
                    }
                }

                double startTime = machineTime[mIndex];
                double endTime = startTime + job.Duration / machineRatio[mIndex];
                machineTime[mIndex] = endTime;

                result.Add((job, mIndex + 1, startTime, endTime));
            }

            return result;
        }

    }
}

