using Saharsh.Benchmarks.CSharp.Evaluators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation
{
    public class PureStringBuilder : ContenderBase
    {
        public PureStringBuilder(BenchmarkParameters parameters) : base(parameters) { }

        public override string Name => "PureStringBuilder";

        protected override void Act()
        {
            StringBuilder sbMain = new StringBuilder();
            for (int i = 0; i < Parameters.n; i++)
            {
                sbMain.AppendLine();
                AddProperty(sbMain, "Property1", $"Value1_{i}");
                AddProperty(sbMain, "Property2", $"Value2_{i}");
                AddProperty(sbMain, "Property3", $"Value3_{i}");
                AddProperty(sbMain, "Property4", $"Value4_{i}");
                AddProperty(sbMain, "Property5", $"Value5_{i}");
                AddProperty(sbMain, "Property6", $"Value6_{i}");
                AddProperty(sbMain, "Property7", $"Value7_{i}");
                AddProperty(sbMain, "Property8", $"Value8_{i}");
                AddProperty(sbMain, "Property9", $"Value9_{i}");
                AddProperty(sbMain, "Property10", $"Value10_{i}");
                AddProperty(sbMain, "Property11", $"Value11_{i}");
                AddProperty(sbMain, "Property12", $"Value12_{i}");
                AddProperty(sbMain, "Property13", $"Value13_{i}");
                AddProperty(sbMain, "Property14", $"Value14_{i}");
                AddProperty(sbMain, "Property15", $"Value15_{i}");
                AddProperty(sbMain, "Property16", $"Value16_{i}");
                AddProperty(sbMain, "Property17", $"Value17_{i}");
                AddProperty(sbMain, "Property18", $"Value18_{i}");
                AddProperty(sbMain, "Property19", $"Value19_{i}");
                AddProperty(sbMain, "Property20", $"Value20_{i}");
                AddProperty(sbMain, "Property21", $"Value21_{i}");
                AddProperty(sbMain, "Property22", $"Value22_{i}");
                AddProperty(sbMain, "Property23", $"Value23_{i}");
                AddProperty(sbMain, "Property24", $"Value24_{i}");
                AddProperty(sbMain, "Property25", $"Value25_{i}");
                AddProperty(sbMain, "Property26", $"Value26_{i}");
                AddProperty(sbMain, "Property27", $"Value27_{i}");
                AddProperty(sbMain, "Property28", $"Value28_{i}");
                AddProperty(sbMain, "Property29", $"Value29_{i}");
                AddProperty(sbMain, "Property30", $"Value30_{i}");
                sbMain.AppendLine("// END OF PROP DECLARATION ");
            }
        }

        private void AddProperty(StringBuilder sb, string propertyName, string propertyValue)
        {
            sb.Append("public string ");
            sb.Append(propertyName);
            sb.Append(@" """);
            sb.Append(propertyValue);
            sb.AppendLine(@""";");
        }
    }
}
