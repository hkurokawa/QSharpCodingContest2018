namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation Test (N : Int) : ()
    {
        body
        {
            using(qs = Qubit[N])
            {
                Solve(qs);
                Message($"qubits={qs}");
                ResetAll(qs);
            }
        }
    }

    operation Solve (qs : Qubit[]) : ()
    {
        body
        {
            // your code here
        }
    }
}