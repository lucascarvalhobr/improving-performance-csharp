using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Mathematics;
using BenchmarkDotNet.Order;
using CSharpPerformance.Code;
using Microsoft.Extensions.Configuration;

namespace CSharpPerformance.Benchmarker;

[ShortRunJob]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn(NumeralSystem.Arabic)]
public class DBCalls
{
    private readonly IConfiguration _config;

    public string ConnectionString
    {
        get
        {
            return _config?.GetConnectionString("db");
        }
    }

    public DBCalls()
    {
        var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: false, reloadOnChange: true);

        _config = configBuilder.Build();
    }

    [Benchmark]
    public void GetPersonFromDatabase()
    {
        var database = new Database(ConnectionString);
        database.GetPersonByName("Bruno");
    }
}
