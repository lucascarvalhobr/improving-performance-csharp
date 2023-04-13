using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class Assignment
{
    [Benchmark]
    public void PropertyAssignment()
    {
        foreach (var name in Loops.names)
        {
            var person = new PersonClass();

            person.Name = name;
        }
    }

    [Benchmark]
    public void MemberAssignment()
    {
        foreach (var name in Loops.names)
        {
            var person = new PersonClass();

            person.name = name;
        }
    }
}
