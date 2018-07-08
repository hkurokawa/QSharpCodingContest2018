namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
        body
        {
            ApplyToEach(H, qs);
            let m0 = M(qs[0]);
            let m1 = M(qs[1]);

            mutable index = 0;

            if m0 == One
            {
                set index = index + 2;
            }
            if m1 == One
            {
                set index = index + 1;
            }
            
            return index;
        }
    }
}
