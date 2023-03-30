using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;


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