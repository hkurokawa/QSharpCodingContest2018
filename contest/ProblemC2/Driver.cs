using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Solution
{
    class Driver
    {
        static void Main(string[] args)
        {
            using(var sim = new QuantumSimulator())
            {
                var count = 10000;
                var (numZeros, numOnes, numNegatives) = Test.Run(sim, count, 0).Result;
                System.Console.WriteLine($"0: {numZeros * 1.0 / count}, 1: {numOnes * 1.0 / count}, -1: {numNegatives * 1.0 / count}");
                (numZeros, numOnes, numNegatives) = Test.Run(sim, count, 1).Result;
                System.Console.WriteLine($"0: {numZeros * 1.0 / count}, 1: {numOnes * 1.0 / count}, -1: {numNegatives * 1.0 / count}");
            }
        }
    }
}