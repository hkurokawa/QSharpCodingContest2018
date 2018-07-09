#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (x : Qubit[], y : Qubit, b : Int[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs", 164L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (x,y,b) = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
            var m = M.Apply(y);
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
            if ((m == Result.One))
            {
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(y);
            }

#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
            foreach (var i in new Range(0L, (b.Count - 1L)))
            {
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[i], y));
#line 18 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
                if ((b[i] == 0L))
                {
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD2/Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(y);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y, QArray<Int64> b)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Qubit,QArray<Int64>), QVoid>((x, y, b));
        }
    }
}