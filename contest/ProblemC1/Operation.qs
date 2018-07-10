namespace Solution {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Extensions.Math;

    operation Solve (q : Qubit) : Int
    {
        body
        {
            Ry(0.25 * PI(), q);
            let m = M(q);
            if m == Zero
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

