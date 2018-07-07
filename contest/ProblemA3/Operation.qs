namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Test(bits0 : Bool[], bits1 : Bool[]) : Bool[]
    {
        body
        {
            let N = Length(bits0);
            mutable result = new Bool[N];
            using(qs = Qubit[N])
            {
                Solve(qs, bits0, bits1);
                for (i in 0..N-1)
                {
                    let m = M(qs[i]);
                    if m == One
                    {
                        set result[i] = true;
                    }
                }
                ResetAll(qs);
            }
            return result;
        }
    }

    operation Solve (qs : Qubit[], bits0 : Bool[], bits1 : Bool[]) : ()
    {
        body
        {
            mutable idx = -1;
            mutable b0 = bits0;
            mutable b1 = bits1;
            for(j in 0..Length(bits0)-1)
            {
                if idx < 0 && bits0[j] != bits1[j]
                {
                    set idx = j;
                    if bits1[j] == false
                    {
                        set b0 = bits1;
                        set b1 = bits0;
                    }
                }
            }

            H(qs[idx]);
            for(j in 0..Length(b0)-1)
            {
                if b0[j]
                {
                    X(qs[j]);
                }
                if j != idx && b0[j] != b1[j]
                {
                    CNOT(qs[idx], qs[j]);
                }
            }
        }
    }
}
