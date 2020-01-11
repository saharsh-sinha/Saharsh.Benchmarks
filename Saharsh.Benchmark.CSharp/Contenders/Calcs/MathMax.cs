using Saharsh.Benchmarks.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp
{
    public class MathMax : BenchmarkBase, IContender
    {
        public long Run(BenchmarkParameters packet)
        {
            var timerId = StartATimer();
            int max;
            for (int i = 0; i < packet.n; i++)
            {
                max = Math.Max(i, packet.n - i);
            }

            return GetTimeElapsed(timerId); 
        }
    }
}
