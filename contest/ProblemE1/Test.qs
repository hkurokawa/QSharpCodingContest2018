namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Diagnostics;

    operation Test (b : Int[]) : Int[]
    {
        body
        {
            let N = Length(b);
            let answer = Solve(N, ScalarProduct(_, _, b));
            return answer;
        }
    }

    operation ScalarProduct (x : Qubit[], y : Qubit, b : Int[]) : ()
    {
        body
        {
            for(i in 0..Length(b) - 1)
            {
                if b[i] == 1
                {
                    CNOT(x[i], y);
                }
            }
        }
    }    
}
