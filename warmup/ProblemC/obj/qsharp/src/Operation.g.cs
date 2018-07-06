#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (N : Int) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs", 137L, 7L, 5L)]
[assembly: OperationDeclaration("Solution", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs", 578L, 28L, 5L)]
[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs", 796L, 40L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<Int64, QVoid>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Test";
        String ICallable.FullName => "Solution.Test";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> Solve
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var N = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            var qubits = Allocate.Apply(N);
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            foreach (var i in new Range(0L, (N - 1L)))
            {
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
                Set.Apply((Result.Zero, qubits[i]));
            }

#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            Solve.Apply(qubits);
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            foreach (var i in new Range(0L, (N - 1L)))
            {
#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
                Set.Apply((Result.Zero, qubits[i]));
            }

#line hidden
            Release.Apply(qubits);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Solution.Set));
            this.Solve = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<Test, Int64, QVoid>(N);
        }
    }

    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Solution.Set";
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

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (desired,q1) = __in;
#line 31 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            var current = M.Apply(q1);
#line 32 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            if ((desired != current))
            {
#line 34 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class Solve : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 43 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            foreach (var i in new Range(0L, (qs.Count - 2L)))
            {
#line 45 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qs[i], qs[(i + 1L)]));
            }

#line 47 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemC/Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(qs);
        }
    }
}