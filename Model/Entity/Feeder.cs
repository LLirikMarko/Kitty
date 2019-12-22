using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Feeder : BaseEntity
    {
        public string Name { get; set; }
        public double Amount_of_food { get; set; }
        public TimeTable TimeTable { get; set; } = new TimeTable();
    }

    public class TimeTable
    {
        public int StartTime = 0;

        public double this[int hour]
        {
            get
            {
                return TimeValue.Where(kv => kv.Item1 == hour).Select(kv => kv.Item2).FirstOrDefault();
            }
        }

        public List<(int, double)> TimeValue { get; set; } = new List<(int, double)>();
    }
}
