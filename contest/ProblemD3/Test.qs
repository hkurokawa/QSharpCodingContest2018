namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation Test () : ()
    {
        body
        {
            using(qs = Qubit[4])
            {
                let x = qs[0..2];
                let y = qs[3];
                //X(qs[0]);
                //X(qs[1]);
                X(qs[2]);
                Solve(x, y);
                DumpRegister("qs.txt", qs[3..3]);
                ResetAll(qs);
            }
        }
    }
}
