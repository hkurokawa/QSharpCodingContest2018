namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (q : Qubit) : Int
    {
        body
        {
            let r = RandomInt(2);
            if r == 0
            {
                let m = M(q);
                if m == One
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                H(q);
                let m = M(q);
                if m == One
                {
                    return 0;
                }
                return -1;
            }
        }
    }
}
