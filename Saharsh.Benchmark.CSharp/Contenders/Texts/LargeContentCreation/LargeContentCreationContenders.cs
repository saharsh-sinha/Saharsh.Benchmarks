using Saharsh.Benchmarks.CSharp.Evaluators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation
{
    public class LargeContentCreationContenders : ContenderCandidates
    {
        public override string Category => "Large Content Creation";
        public LargeContentCreationContenders(BenchmarkParameters parameters)
        {
            Candidates.Add(new PureStringBuilder(parameters));
            Candidates.Add(new TemplateBasedStringBuilder(parameters));
        }
    }
}
