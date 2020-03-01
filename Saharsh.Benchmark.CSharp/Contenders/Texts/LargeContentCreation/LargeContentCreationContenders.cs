using Saharsh.Benchmarks.CSharp.Evaluators;

namespace Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation
{
    public class LargeContentCreationContenders : ContenderCandidates
    {
        public override string Category => "Large Content Creation";
        public LargeContentCreationContenders(BenchmarkParameters parameters)
        {
            Candidates.Add(new PureStringBuilder(parameters));
            Candidates.Add(new TemplateBasedStringBuilder(parameters));
            Candidates.Add(new TemplateBasedArrayStringBuilder(parameters));
        }
    }
}
