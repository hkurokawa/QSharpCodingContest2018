namespace Solution
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Solve (qs : Qubit[]) : (Int)
    {
        body
        {
            CNOT(qs[0], qs[1]);
            H(qs[0]);
            let r0 = M(qs[0]);
            let r1 = M(qs[1]);
            if (r0 == Zero)
            {
                if (r1 == Zero)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (r1 == Zero)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
