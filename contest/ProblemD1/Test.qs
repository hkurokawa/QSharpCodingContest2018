namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation Test (b : Int[]) : ()
    {
        body
        {
            let N = Length(b);
            using(qs = Qubit[N + 1])
            {
                let x = qs[0..N-1];
                let y = qs[N];
                X(qs[0]);
                X(qs[1]);
                Solve(x, y, b);
                DumpRegister("qs.txt", qs[N..N]);
                ResetAll(qs);
            }
        }
    }
}
