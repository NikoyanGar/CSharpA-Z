using BenchmarkDotNet.Running;

namespace _011_Working_With_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringBenchmarker>();
        }
    }
}