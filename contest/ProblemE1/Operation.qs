namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Int[]
    {
        body
        {
            mutable b = new Int[N];
            using(qs = Qubit[N + 1])
            {
                let x = qs[0..N-1];
                let y = qs[N];
                X(y);
                ApplyToEach(H, qs);

                Uf(x, y);

                ApplyToEach(H, x);
                for (i in 0..N-1)
                {
                    let m = M(qs[i]);
                    if m == One
                    {
                        set b[i] = 1;
                    }
                }

                ResetAll(qs);
            }
            return b;
        }
    }
}
