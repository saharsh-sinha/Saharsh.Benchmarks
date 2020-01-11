using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp
{
    internal class Benchmark : System.Attribute
    {
        string BenchmarkType;
        string BenchmarkName;
        string BenchmarkDescription;
    }
}
