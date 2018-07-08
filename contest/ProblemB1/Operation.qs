namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
        body
        {
            mutable isAllZero = true;
            for (i in 0..Length(qs) - 1)
            {
                let m = M(qs[i]);
                if m != Zero
                {
                    set isAllZero = false;
                }
            }
            if isAllZero
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