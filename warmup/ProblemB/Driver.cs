using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Solution
{
    class Driver
    {
        static void Main(string[] args)
        {
using (var sim = new QuantumSimulator())
            {
                for (int idx = 0; idx < 4; idx++)
                {
                    var res = Test.Run(sim, 1000, idx).Result;
                    var numCounts = res;
                    System.Console.WriteLine(
                        $"Idx:{idx,-4} {numCounts}");
                }
            }
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}