namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
        body
        {
            H(qs[1]);
            CNOT(qs[0], qs[1]);
            H(qs[0]);

            let m0 = M(qs[0]);
            let m1 = M(qs[1]);

            mutable idx = 0;
            if m1 == Zero
            {
                set idx = idx + 2;
            }
            if m0 == Zero
            {
                set idx = idx + 1;
            }
            return idx;
        }
    }
}
