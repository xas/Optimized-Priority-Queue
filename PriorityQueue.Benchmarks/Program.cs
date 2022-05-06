using BenchmarkDotNet.Running;

namespace PriorityQueue.Benchmarks
{
    class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
