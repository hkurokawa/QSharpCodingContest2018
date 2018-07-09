#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (x : Qubit[], y : Qubit) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Operation.qs", 153L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumPrimitiveCCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (x,y) = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Operation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((x[0L], x[1L], y));
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Operation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((x[1L], x[2L], y));
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Operation.qs"
            MicrosoftQuantumPrimitiveCCNOT.Apply((x[0L], x[2L], y));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CCNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }
}