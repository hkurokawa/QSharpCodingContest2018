namespace Solution
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Test(count : Int, index : Int) : (Int[])
    {
        body
        {
            mutable numCounts = new Int[4];
            using(qubits = Qubit[2])
            {
                for (test in 1..count)
                {
                    Set(Zero, qubits[0]);
                    Set(Zero, qubits[1]);

                    Solve(qubits, index);

                    let res0 = M(qubits[0]);
                    let res1 = M(qubits[1]);

                    if (res0 == Zero && res1 == Zero)
                    {
                        set numCounts[0] = numCounts[0] + 1;
                    }
                    elif (res0 == Zero && res1 == One)
                    {
                        set numCounts[1] = numCounts[1] + 1;
                    }
                    elif (res0 == One && res1 == Zero)
                    {
                        set numCounts[2] = numCounts[2] + 1;
                    }
                    else
                    {
                        set numCounts[3] = numCounts[3] + 1;
                    }
                }
                Set(Zero, qubits[0]);
                Set(Zero, qubits[1]);
            }
            return (numCounts);
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

    operation Solve (qs : Qubit[], index : Int) : ()
    {
        body
        {
            if (index == 0)
            {
                H(qs[0]);
                CNOT(qs[0], qs[1]);
            }
            elif (index == 1)
            {
                X(qs[0]);
                H(qs[0]);
                Z(qs[1]);
                CNOT(qs[0], qs[1]);
            }
            elif (index == 2)
            {
                H(qs[0]);
                X(qs[1]);
                CNOT(qs[0], qs[1]);
            }
            else
            {
                X(qs[0]);
                X(qs[1]);
                H(qs[0]);
                Z(qs[1]);
                CNOT(qs[0], qs[1]);
            }
        }
    }
}
