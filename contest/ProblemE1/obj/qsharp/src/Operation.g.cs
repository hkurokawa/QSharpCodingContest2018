#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Int[]", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs", 172L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<(Int64,ICallable), QArray<Int64>>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,ICallable)>, IApplyData
        {
            public In((Int64,ICallable) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumCanonApplyToEach
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), QArray<Int64>> Body => (__in) =>
        {
            var (N,Uf) = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            var b = new QArray<Int64>(N);
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            var qs = Allocate.Apply((N + 1L));
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            var x = qs?.Slice(new Range(0L, (N - 1L)));
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            var y = qs[N];
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(y);
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qs));
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            Uf.Apply((x, y));
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), x));
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            foreach (var i in new Range(0L, (N - 1L)))
            {
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
                var m = M.Apply(qs[i]);
#line 23 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
                if ((m == Result.One))
                {
#line 25 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
                    b[i] = 1L;
                }
            }

#line 29 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line 31 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemE1/Operation.qs"
            return b;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Solve, (Int64,ICallable), QArray<Int64>>((N, Uf));
        }
    }
}