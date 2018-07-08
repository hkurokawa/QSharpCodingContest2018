namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Solve (qs : Qubit[]) : Int
    {
        body
        {
            mutable isAllZero = true;
            mutable isAllOne = true;

            for (i in 0..Length(qs) - 1)
            {
                let m = M(qs[i]);
                if m == Zero
                {
                    set isAllOne = false;
                }
                else
                {
                    set isAllZero = false;
                }
            }

            if isAllZero || isAllOne
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
