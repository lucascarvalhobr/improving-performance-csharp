// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using CSharpPerformance.Benchmarker;

//var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
var summary = BenchmarkRunner.Run(typeof(DBCalls));

//var config = DefaultConfig.Instance;

// Disable optimizations validator
//config = config.WithOptions(ConfigOptions.DisableOptimizationsValidator);

//BenchmarkRunner.Run<StringFunctions>(config);