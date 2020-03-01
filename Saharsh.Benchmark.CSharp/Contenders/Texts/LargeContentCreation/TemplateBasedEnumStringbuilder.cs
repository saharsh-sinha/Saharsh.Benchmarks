using Saharsh.Benchmarks.CSharp.Evaluators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation
{
    public enum Fields
    {
        Property0,
        Property1,
        Property2,
        Property3,
        Property4,
        Property5,
        Property6,
        Property7,
        Property8,
        Property9,
        Property10,
        Property11,
        Property12,
        Property13,
        Property14,
        Property15,
        Property16,
        Property17,
        Property18,
        Property19,
        Property20,
        Property21,
        Property22,
        Property23,
        Property24,
        Property25,
        Property26,
        Property27,
        Property28,
        Property29,
        Property30
    }

    public class TemplateBasedEnumStringbuilder : ContenderBase
    {
        private string _template = @"
public string Property1 ""`string_Property1`"";
public string Property2 ""`string_Property2`"";
public string Property3 ""`string_Property3`"";
public string Property4 ""`string_Property4`"";
public string Property5 ""`string_Property5`"";
public string Property6 ""`string_Property6`"";
public string Property7 ""`string_Property7`"";
public string Property8 ""`string_Property8`"";
public string Property9 ""`string_Property9`"";
public string Property10 ""`string_Property10`"";
public string Property11 ""`string_Property11`"";
public string Property12 ""`string_Property12`"";
public string Property13 ""`string_Property13`"";
public string Property14 ""`string_Property14`"";
public string Property15 ""`string_Property15`"";
public string Property16 ""`string_Property16`"";
public string Property17 ""`string_Property17`"";
public string Property18 ""`string_Property18`"";
public string Property19 ""`string_Property19`"";
public string Property20 ""`string_Property20`"";
public string Property21 ""`string_Property21`"";
public string Property22 ""`string_Property22`"";
public string Property23 ""`string_Property23`"";
public string Property24 ""`string_Property24`"";
public string Property25 ""`string_Property25`"";
public string Property26 ""`string_Property26`"";
public string Property27 ""`string_Property27`"";
public string Property28 ""`string_Property28`"";
public string Property29 ""`string_Property29`"";
public string Property30 ""`string_Property30`"";
// END OF PROP DECLARATION 
";

        public override string Name => "TemplateBasedEnumStringbuilder";
        public TemplateBasedEnumStringbuilder()
        {

        }
        public TemplateBasedEnumStringbuilder(BenchmarkParameters parameters) : base(parameters)
        {
        }

        protected override void Act()
        {
            StringBuilder sbMain = new StringBuilder();
            var templateParts = TemplateParts();
            Dictionary < Fields, string> valueLookups = new Dictionary<Fields, string>();
            for (int i = 0; i < N; i++)
            {
                valueLookups[Fields.Property1] = $"Value1_{i}";
                valueLookups[Fields.Property2] = $"Value2_{i}";
                valueLookups[Fields.Property3] = $"Value3_{i}";
                valueLookups[Fields.Property4] = $"Value4_{i}";
                valueLookups[Fields.Property5] = $"Value5_{i}";
                valueLookups[Fields.Property6] = $"Value6_{i}";
                valueLookups[Fields.Property7] = $"Value7_{i}";
                valueLookups[Fields.Property8] = $"Value8_{i}";
                valueLookups[Fields.Property9] = $"Value9_{i}";
                valueLookups[Fields.Property10] = $"Value10_{i}";
                valueLookups[Fields.Property11] = $"Value11_{i}";
                valueLookups[Fields.Property12] = $"Value12_{i}";
                valueLookups[Fields.Property13] = $"Value13_{i}";
                valueLookups[Fields.Property14] = $"Value14_{i}";
                valueLookups[Fields.Property15] = $"Value15_{i}";
                valueLookups[Fields.Property16] = $"Value16_{i}";
                valueLookups[Fields.Property17] = $"Value17_{i}";
                valueLookups[Fields.Property18] = $"Value18_{i}";
                valueLookups[Fields.Property19] = $"Value19_{i}";
                valueLookups[Fields.Property20] = $"Value20_{i}";
                valueLookups[Fields.Property21] = $"Value21_{i}";
                valueLookups[Fields.Property22] = $"Value22_{i}";
                valueLookups[Fields.Property23] = $"Value23_{i}";
                valueLookups[Fields.Property24] = $"Value24_{i}";
                valueLookups[Fields.Property25] = $"Value25_{i}";
                valueLookups[Fields.Property26] = $"Value26_{i}";
                valueLookups[Fields.Property27] = $"Value27_{i}";
                valueLookups[Fields.Property28] = $"Value28_{i}";
                valueLookups[Fields.Property29] = $"Value29_{i}";
                valueLookups[Fields.Property30] = $"Value30_{i}";
                Integrate(sbMain, templateParts, valueLookups);
            }
        }

        private string[] TemplateParts()
        {
            return _template.Split('`');
        }

        private void Integrate(StringBuilder sb, string[] templateParts, Dictionary<string, string> lookupValues)
        {
            int index = 1;
            int len = templateParts.Length;
            for (int i = 0; i < len - 1; i += 2)
            {
                sb.Append(templateParts[i]);
                sb.Append(lookupValues[index]);
                index++;
            }
            sb.Append(templateParts[len - 1]);
        }
    }
}
