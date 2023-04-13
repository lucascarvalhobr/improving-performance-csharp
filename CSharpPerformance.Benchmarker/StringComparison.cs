using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class StringComparison
{
    string testString = "TEST";

    [Benchmark()]
    public void EqualityComparison()
    {
        var compare = testString == "TEST";
    }

    [Benchmark()]
    public void EqualsComparison()
    {
        var compare = testString.Equals("TEST");
    }

    [Benchmark()]
    public void StringCompareComparison()
    {
        var compare = string.Compare(testString, "TEST");
    }
}
