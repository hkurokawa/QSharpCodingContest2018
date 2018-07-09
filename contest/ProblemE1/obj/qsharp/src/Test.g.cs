#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (b : Int[]) : Int[]", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs", 188L, 7L, 5L)]
[assembly: OperationDeclaration("Solution", "ScalarProduct (x : Qubit[], y : Qubit, b : Int[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs", 420L, 17L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<QArray<Int64>, QArray<Int64>>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Test";
        String ICallable.FullName => "Solution.Test";
        protected ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> ScalarProduct
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), QArray<Int64>> Solve
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, QArray<Int64>> Body => (__in) =>
        {
            var b = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
            var N = b.Count;
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
            var answer = Solve.Apply((N, ((ICallable)ScalarProduct.Partial(new Func<(QArray<Qubit>,Qubit), (QArray<Qubit>,Qubit,QArray<Int64>)>((_arg1) => (_arg1.Item1, _arg1.Item2, b))))));
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
            return answer;
        }

        ;
        public override void Init()
        {
            this.ScalarProduct = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>>(typeof(Solution.ScalarProduct));
            this.Solve = this.Factory.Get<ICallable<(Int64,ICallable), QArray<Int64>>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Int64> b)
        {
            return __m__.Run<Test, QArray<Int64>, QArray<Int64>>(b);
        }
    }

    public class ScalarProduct : Operation<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>, ICallable
    {
        public ScalarProduct(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit,QArray<Int64>)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit,QArray<Int64>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ScalarProduct";
        String ICallable.FullName => "Solution.ScalarProduct";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Body => (__in) =>
        {
            var (x,y,b) = __in;
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
            foreach (var i in new Range(0L, (b.Count - 1L)))
            {
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
                if ((b[i] == 1L))
                {
#line 24 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Test.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((x[i], y));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit,QArray<Int64>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y, QArray<Int64> b)
        {
            return __m__.Run<ScalarProduct, (QArray<Qubit>,Qubit,QArray<Int64>), QVoid>((x, y, b));
        }
    }
}