using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Evaluators
{
    public  abstract class ContenderBase
    {
        protected readonly BenchmarkParameters Parameters;

        public abstract string Name { get; }


        public ContenderBase(BenchmarkParameters parameters)
        {
            this.Parameters = parameters;
        }
        public long Run()
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            Act();
            s.Stop();
            return s.ElapsedMilliseconds;
        }

        protected abstract void Act();    
    }
}
