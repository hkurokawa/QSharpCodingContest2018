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
                var b = new QArray<long>(new long[]{1, 0});
                var result = Test.Run(sim, b).Result;
            }
        }
    }
}