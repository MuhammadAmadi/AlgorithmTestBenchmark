using BenchmarkDotNet.Running;


namespace RaceOfSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>();
        }
    }
}