using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Benchmark(10000);
            Benchmark(100000);
            Benchmark(1000000);
            Benchmark(10000000);
            Benchmark(100000000);
            Benchmark(1000000000);
            Benchmark(100000000000000);
            Benchmark(1000000000000000000);
            Console.ReadLine();
        }

        static void Benchmark(long benchmarkBoundary)
        {

            Console.WriteLine("Benchmarking for {0} items...", benchmarkBoundary);
            int[] strArray = new int[benchmarkBoundary];
            for (int i = 0; i < strArray.Length; i++)
            {
                strArray[i] = i;
            }
            long totSum = 0;
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < strArray.Length; i++)
            {
                totSum += i;
            }

            sw.Stop();
            Console.WriteLine("for loop time = " + sw.ElapsedMilliseconds.ToString() + "ms.");
            totSum = 0;
            sw = Stopwatch.StartNew();
            foreach (var strItem in strArray)
            {
                totSum += strItem;
            }

            sw.Stop();
            Console.WriteLine("foreach loop time = " + sw.ElapsedMilliseconds.ToString() + "ms.");

        }
    }
}
