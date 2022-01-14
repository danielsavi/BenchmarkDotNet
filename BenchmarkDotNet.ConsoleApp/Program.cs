using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;

namespace BenchmarkDotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Demo>();
        }
    }

    [MemoryDiagnoser]
    public class Demo
    {
        [Benchmark]
        public string GetStringInefficiently()
        {
            string result = String.Empty;
            for (int i = 0; i < 100; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
