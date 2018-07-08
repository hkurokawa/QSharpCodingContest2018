#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs", 143L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
            // your code here
            ;
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(qs);
        }
    }
}