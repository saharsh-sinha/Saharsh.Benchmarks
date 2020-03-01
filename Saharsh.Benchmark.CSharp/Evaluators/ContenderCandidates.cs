using System.Collections.Generic;

namespace Saharsh.Benchmarks.CSharp.Evaluators
{
    public abstract class ContenderCandidates
    {
        private readonly List<ContenderBase> candidates = new List<ContenderBase>();

        public abstract string Category { get; }

        public List<ContenderBase> Candidates => candidates;
    }
}
