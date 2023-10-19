using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ass7_Sep06
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan elapsedTime = endTime - startTime;
            return elapsedTime.TotalMilliseconds;
        }
    }
}
