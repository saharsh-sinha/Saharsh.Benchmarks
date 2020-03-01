using Saharsh.Benchmarks.CSharp.Evaluators;
using System.Text;

namespace Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation
{
    public class TemplateBasedArrayStringBuilder : ContenderBase
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

        public override string Name => "TemplateBasedArrayStringBuilder";
        public TemplateBasedArrayStringBuilder()
        {

        }
        public TemplateBasedArrayStringBuilder(BenchmarkParameters parameters) : base(parameters)
        {
        }

        protected override void Act()
        {
            StringBuilder sbMain = new StringBuilder();
            var templateParts = TemplateParts();
            string[] valueLookups = new string[31];
            for (int i = 0; i < N; i++)
            {
                valueLookups[1] = $"Value1_{i}";
                valueLookups[2] = $"Value2_{i}";
                valueLookups[3] = $"Value3_{i}";
                valueLookups[4] = $"Value4_{i}";
                valueLookups[5] = $"Value5_{i}";
                valueLookups[6] = $"Value6_{i}";
                valueLookups[7] = $"Value7_{i}";
                valueLookups[8] = $"Value8_{i}";
                valueLookups[9] = $"Value9_{i}";
                valueLookups[10] = $"Value10_{i}";
                valueLookups[11] = $"Value11_{i}";
                valueLookups[12] = $"Value12_{i}";
                valueLookups[13] = $"Value13_{i}";
                valueLookups[14] = $"Value14_{i}";
                valueLookups[15] = $"Value15_{i}";
                valueLookups[16] = $"Value16_{i}";
                valueLookups[17] = $"Value17_{i}";
                valueLookups[18] = $"Value18_{i}";
                valueLookups[19] = $"Value19_{i}";
                valueLookups[20] = $"Value20_{i}";
                valueLookups[21] = $"Value21_{i}";
                valueLookups[22] = $"Value22_{i}";
                valueLookups[23] = $"Value23_{i}";
                valueLookups[24] = $"Value24_{i}";
                valueLookups[25] = $"Value25_{i}";
                valueLookups[26] = $"Value26_{i}";
                valueLookups[27] = $"Value27_{i}";
                valueLookups[28] = $"Value28_{i}";
                valueLookups[29] = $"Value29_{i}";
                valueLookups[30] = $"Value30_{i}";
                Integrate(sbMain, templateParts, valueLookups);
            }
        }

        private string[] TemplateParts()
        {
            return _template.Split('`');
        }

        private void Integrate(StringBuilder sb, string[] templateParts, string[] lookupValues)
        {
            int index = 1;
            int len = templateParts.Length;
            for (int i = 0; i < len - 1; i+=2)
            {
                sb.Append(templateParts[i]);
                sb.Append(lookupValues[index]);
                index++;
            }
            sb.Append(templateParts[len - 1]);
        }
    } 


}
