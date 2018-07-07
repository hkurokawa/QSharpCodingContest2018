namespace Solution
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;

    operation Solve (qs : Qubit[]) : ()
    {
        body
        {
            ApplyToEach(H, qs);
        }
    }
}
