using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;

namespace CSharpPerformance.Benchmarker;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class Loops
{
    public static string[] names = { "Lucas", "Maria", "Ana", "João", "Pedro", "Larissa", "Isabela", "Diego", "Daniela"}; 

    public void ForLoop()
    {
        for (int i = 0; i < names.Length; i++)
        {
            var x = names[i];
        }
    }

    public void ForEachLoop() 
    {
        foreach (var name in names)
        {
            var x = name;
        }
    }
}
