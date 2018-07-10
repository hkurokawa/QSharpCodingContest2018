namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : ()
    {
        body
        {
            let N = Length(qs);
            if N == 1
            {
                X(qs[0]);
            }
            else
            {
                let K = N / 2;
                Solve(qs[0..K-1]);
                using(temp = Qubit[1])
                {
                    let aux = temp[0];
                    H(aux);
                    for (i in 0..K-1)
                    {
                        (Controlled SWAP)([aux], (qs[i], qs[K + i]));
                        CNOT(qs[K + i], aux);
                    }
                    Reset(aux);
                }
            }
        }
    }
}