using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;


[MemoryDiagnoser]
public class FactorialBenchmarks
{
    [Params(20)]
    public ulong n;



    private ulong expectedFactorial;

    [Benchmark]
    public ulong RecursiveFactorialBenchmark()
    {
        return Program.RecursiveFactorial(n);
    }

    [Benchmark]
    public ulong IterativeFactorialBenchmark()
    {
        return Program.IterativeFactorial(n);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        ulong n = 20;

        var summury = BenchmarkDotNet.Running.BenchmarkRunner.Run<FactorialBenchmarks>();
    }


    public static ulong RecursiveFactorial(ulong n)
    {
        if (n == 0)
            return 1;
        return n * RecursiveFactorial(n - 1);
    }

    public static ulong IterativeFactorial(ulong n)
    {
        ulong result = 1;
        for (ulong i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}

