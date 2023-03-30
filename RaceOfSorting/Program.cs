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
        private class CustomConfig : ManualConfig
        {
            public CustomConfig()
            {
                AddJob(new Job());
                AddValidator(JitOptimizationsValidator.DontFailOnError);
                AddLogger(ConsoleLogger.Default);
                AddColumnProvider(DefaultColumnProviders.Instance);
            }
        }
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ListOfSortingBenchmark>(new CustomConfig());
            Console.ReadLine();
        }
    }
}