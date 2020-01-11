using Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Saharsh.Benchmarks.CSharp.Tests.Contenders.Texts.LargeContentCreation
{
    public class TemplateBasedStringBuilderTests
    {
        [Fact]
        public void LargeStringGetsCreated()
        {
            TemplateBasedStringBuilder pureStringBuilder = new TemplateBasedStringBuilder(new BenchmarkParameters { n = 10 });
            long elapsed = pureStringBuilder.Run();
            Assert.True(elapsed > 0);
        }
    }
}
