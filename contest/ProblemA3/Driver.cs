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
                for (var i = 0; i < 1000; i++)
                {
                    var res = Test.Run(sim, new QArray<bool>(new bool[]{true, false, true, false, true}), new QArray<bool>(new bool[]{true, false, false, false, false})).Result;
                    System.Console.WriteLine(res);
                }
            }
        }
    }
}