#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("ProblemH", "Operation () : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemH/Operation.qs", 136L, 7L, 5L)]
#line hidden
namespace ProblemH
{
    public class Operation : Operation<QVoid, QVoid>, ICallable
    {
        public Operation(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Operation";
        String ICallable.FullName => "ProblemH.Operation";
        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Operation, QVoid, QVoid>(QVoid.Instance);
        }
    }
}