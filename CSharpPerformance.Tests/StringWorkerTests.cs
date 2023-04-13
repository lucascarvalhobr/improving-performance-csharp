namespace CSharpPerformance.Tests;

using CSharpPerformance.Code;
using Xunit;

public class StringWorkerTests
{
    private readonly StringWorker _worker;

    public StringWorkerTests()
    {
        _worker = new StringWorker();
    }

    [Fact]
    public void BuildStringBadly_Tests()
    {
        var s = _worker.BuildStringBadly("test");

        Assert.Equal(StringConsts.TestString, s);
    }

    [Fact]
    public void BuildStringBetter_Tests()
    {
        var s = _worker.BuildStringBetter("test");

        Assert.Equal(StringConsts.TestString, s);
    }

    [Fact]
    public void FunctionsAreEquivalent_Tests()
    {
        var sbad = _worker.BuildStringBadly("test");
        var sbetter = _worker.BuildStringBetter("test");

        Assert.Equal(sbad, sbetter);
    }

    [Fact]
    public void SplitNameUsingSubstring_Tests()
    {
        var result = _worker.SplitNameUsingSubstring("Carvalho, Lucas");

        Assert.Equal("Lucas", result.firstName);
        Assert.Equal("Carvalho", result.lastName);
    }

    [Fact]
    public void SplitNameUsingSplitMethod_Tests()
    {
        var result = _worker.SplitNameUsingSplitMethod("Carvalho, Lucas");

        Assert.Equal("Lucas", result.firstName);
        Assert.Equal("Carvalho", result.lastName);
    }

    [Fact]
    public void SplitNameUsingSpan_Tests()
    {
        var result = _worker.SplitNameUsingSpan("Carvalho, Lucas");

        Assert.Equal("Lucas", result.firstName);
        Assert.Equal("Carvalho", result.lastName);
    }
}
