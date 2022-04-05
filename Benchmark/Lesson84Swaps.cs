using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Lessons;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class SwapsBenchmark
    {
        [Benchmark]
        public void GenericSwapBenchmark()
        {
            double a = 1;
            double b = 5.3;
            SwapTestClass.GenericSwap(ref a, ref b);
        }
        [Benchmark]
        public void SwapBenchmark()
        {
            object a = 2;
            object b = 4;
            SwapTestClass.Swap(ref a, ref b);
        }
    }
}
