namespace Solution
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Test(N : Int) : ()
    {
        body
        {
            using(qubits = Qubit[N])
            {
                for (i in 0..N-1)
                {
                    Set(Zero, qubits[i]);
                }

                Solve(qubits);

                for (i in 0..N-1)
                {
                    Set(Zero, qubits[i]);
                }
            }
        }
    }

    operation Set (desired: Result, q1: Qubit) : ()
    {
        body
        {
            let current = M(q1);
            if (desired != current)
            {
                X(q1);
            }
        }
    }

    operation Solve (qs : Qubit[]) : ()
    {
        body
        {
            H(qs[0]);
            for (i in 0..Length(qs) - 2 )
            {
                CNOT(qs[i], qs[i + 1]);
            }
        }
    }
}
