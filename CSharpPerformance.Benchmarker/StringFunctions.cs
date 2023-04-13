using BenchmarkDotNet.Attributes;
using CSharpPerformance.Code;

namespace CSharpPerformance.Benchmarker;
public class StringFunctions
{
    [Benchmark()]
    public void BuildStringBadly()
    {
        var result = new StringWorker().BuildStringBadly("test");
    }

    [Benchmark()]
    public void BuildStringBetter()
    {
        var result = new StringWorker().BuildStringBetter("test");
    }

    [Benchmark()]
    public void SplitNameUsingSubstring()
    {
        var result = new StringWorker().SplitNameUsingSubstring("Carvalho, Lucas");
    }

    [Benchmark()]
    public void SplitNameUsingSplitMethod()
    {
        var result = new StringWorker().SplitNameUsingSplitMethod("Carvalho, Lucas");
    }

    [Benchmark()]
    public void SplitNameUsingSpan()
    {
        var result = new StringWorker().SplitNameUsingSpan("Carvalho, Lucas");
    }
}
