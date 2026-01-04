using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNT_DAL
{
    public class JobDAL
    {
            public class Job
            {
                public string Name { get; set; }
                public int Duration { get; set; }
            }

            public List<Job> Jobs { get; private set; } = new List<Job>();

            public void AddJob(string name, int duration)
            {
                Jobs.Add(new Job { Name = name, Duration = duration });
            }

            public void RemoveJob(int index)
            {
                if (index >= 0 && index < Jobs.Count)
                    Jobs.RemoveAt(index);
            }
        }
    }
