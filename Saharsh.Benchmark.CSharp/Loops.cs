using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp
{
    internal class Loop : IBenchmarkable
    {
        public float Run(int limit)
        {
            //Timer t = new Timer()
            for (int i = 0; i < limit; i++)
            {
                for (int j = 0; j < limit; j++)
                {
                    //do nothing
                }
            }
            return 0;
        }
    }
}
