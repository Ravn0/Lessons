using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class BoxingTest
    {
        [Benchmark]
        public void NoBoxing()
        {
            int res = 0;
            int a = 1;
            res += a;
        }
        [Benchmark]
        public void Boxing()
        {
            int res = 0;
            object a = 1;
            res += (int)a;
        }
    }
}
