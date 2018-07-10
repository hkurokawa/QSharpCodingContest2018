namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation Test (count : Int, flag : Int) : (Int, Int, Int)
    {
        body
        {
            mutable numZeros = 0;
            mutable numOnes = 0;
            mutable numNegatives = 0;
            using(qs = Qubit[1])
            {
                for (i in 1..count)
                {
                    if flag == 1
                    {
                        H(qs[0]);
                    }
                    let result = Solve(qs[0]);
                    if result == 0
                    {
                        set numZeros = numZeros + 1;
                    }
                    elif result == 1
                    {
                        set numOnes = numOnes + 1;
                    }
                    else
                    {
                        set numNegatives = numNegatives + 1;
                    }
                    ResetAll(qs);
                }
            }
            return (numZeros, numOnes, numNegatives);
        }
    }
}
