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
                DumpMachine("qs.txt");
                ResetAll(qs);
            }
        }
    }
}
