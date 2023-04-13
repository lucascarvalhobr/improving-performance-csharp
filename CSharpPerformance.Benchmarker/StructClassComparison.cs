using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class StructClassComparison
{
    [Benchmark]
    public void ThousandClasses()
    {
        var classes = Loops.names.Select(x => new PersonClass { Name = x });

        for (int i = 0; i < classes.Count(); i++)
        {
            var x = classes.ElementAt(i).Name;
        }
    }

    [Benchmark]
    public void ThousandStructs()
    {
        var structs = Loops.names.Select(x => new PersonStruct { Name = x });

        for (int i = 0; i < structs.Count(); i++)
        {
            var x = structs.ElementAt(i).Name;
        }
    }
}
