using Saharsh.Benchmarks.CSharp;
using Saharsh.Benchmarks.CSharp.Contenders.Texts.LargeContentCreation;
using Saharsh.Benchmarks.CSharp.Evaluators;
using Saharsh.Benchmarks.CSharp.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saharsh.Benchmark.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1000;
            if (args.Length == 1)
                input = int.Parse(args[0]);
            //MergeSort m = new MergeSort();
            //var sorted = m.Sort(new[] { 99,8,7,63,5,4,32,22,113,323,333, 4,354655,66,8778,23238, 923 });
            //for (int i = 1; i < sorted.Length; i++)
            //{
            //    if (sorted[i - 1] > sorted[i])
            //        Console.WriteLine("Failed");
            //    else
            //        Console.WriteLine("Looks good");

            //}
            LargeContentCreationContenders largeContentCreationContenders = new LargeContentCreationContenders(new BenchmarkParameters
            {
                n = input
            });
            Runner runner = new Runner();
            runner.Run(largeContentCreationContenders);
            Console.ReadLine();
        }
    }
}
