namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[], bits0 : Bool[], bits1 : Bool[]) : Int
    {
        body
        {
            mutable flag = true;

            for (i in 0..Length(qs)-1)
            {
                let q = M(qs[i]);
                if q == Zero
                {
                    set flag = flag && !bits0[i];
                }
                else
                {
                    set flag = flag && bits0[i];
                }
            }

            if flag
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}