namespace Solution
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Test(N: Int) : Bool
    {
        body
        {
            let result = Solve(N, CountOnes);
            return result;
        }
    }

    operation Constant (x : Qubit[], y : Qubit) : ()
    {
        body
        {
            let v = M(y);
            if v != One
            {
                X(y);
            }
        }
    }

    operation CountOnes (x : Qubit[], y : Qubit) : ()
    {
        body
        {
            for (i in 0..Length(x) - 1)
            {
                CNOT(x[i], y);
            }
        }
    }

    operation Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Bool
    {
        body
        {
            mutable result = true;
            using(qs = Qubit[N + 1])
            {
                let x = qs[0..N-1];
                let y = qs[N];

                X(y);
                ApplyToEach(H, qs);

                Uf(x, y);
                ApplyToEach(H, x);

                for(i in 0..N-1)
                {
                    if MResetZ(x[i]) == One
                    {
                        set result = false;
                    }
                }
                Reset(y);
            }
            return result;
        }
    }
}
