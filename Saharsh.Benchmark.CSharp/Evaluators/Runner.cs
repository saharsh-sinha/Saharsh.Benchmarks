using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Evaluators
{
    public class Runner
    {
        public Runner()
        {

        }

        public void Run(ContenderCandidates candidates)
        {
            candidates.Candidates.ForEach(c =>
            {
                var result = c.Run();
                Console.WriteLine($"{c.Name} - {result}");
            });
        }
    }
}
