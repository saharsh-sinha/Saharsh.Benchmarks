using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Saharsh.Benchmarks.CSharp
{
    public class BenchmarkBase
    {
        private Dictionary<Guid, Stopwatch> _timers;
        protected Guid StartATimer()
        {
            Guid timerId = new Guid();
            Stopwatch s = new Stopwatch();
            _timers.Add(timerId, s);
            return timerId;
        }

        protected long GetTimeElapsed(Guid timerId)
        {
            _timers[timerId].Stop();
            long milliseconds = _timers[timerId].ElapsedMilliseconds;
            _timers.Remove(timerId);
            return milliseconds;
        }

        protected long GetTimeElapsedSeconds(Guid timerId)
        {
            return GetTimeElapsed(timerId)/1000;
        }


    }
}
