using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Evaluators
{
    public abstract class ContenderCandidates
    {
        private readonly List<ContenderBase> candidates = new List<ContenderBase>();

        public abstract string Category { get; }

        public List<ContenderBase> Candidates => candidates;
    }
}
