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
                for (int N = 1; N <= 8; N++)
                {
                    Test.Run(sim, N);
                }
            }
        }
    }
}