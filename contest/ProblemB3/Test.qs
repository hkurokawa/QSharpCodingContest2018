namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Test () : Int
    {
        body
        {
            mutable result = -1;
            using(qs = Qubit[2])
            {
                X(qs[0]);
                X(qs[1]);
                H(qs[0]);
                H(qs[1]);
                set result = Solve(qs);
                ResetAll(qs);
            }
            return result;
        }
    }
}