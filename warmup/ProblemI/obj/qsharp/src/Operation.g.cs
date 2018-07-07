#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (N : Int) : Bool", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs", 138L, 7L, 5L)]
[assembly: OperationDeclaration("Solution", "Constant (x : Qubit[], y : Qubit) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs", 318L, 16L, 5L)]
[assembly: OperationDeclaration("Solution", "CountOnes (x : Qubit[], y : Qubit) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs", 530L, 28L, 5L)]
[assembly: OperationDeclaration("Solution", "Solve (N : Int, Uf : ((Qubit[], Qubit) => ())) : Bool", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs", 754L, 39L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<Int64, Boolean>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Test";
        String ICallable.FullName => "Solution.Test";
        protected ICallable<(QArray<Qubit>,Qubit), QVoid> Constant
        {
            get;
            set;
        }

        protected ICallable<(Int64,ICallable), Boolean> Solve
        {
            get;
            set;
        }

        public override Func<Int64, Boolean> Body => (__in) =>
        {
            var N = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var result = Solve.Apply((N, ((ICallable)Constant)));
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Constant = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), QVoid>>(typeof(Solution.Constant));
            this.Solve = this.Factory.Get<ICallable<(Int64,ICallable), Boolean>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<Test, Int64, Boolean>(N);
        }
    }

    public class Constant : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public Constant(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Constant";
        String ICallable.FullName => "Solution.Constant";
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

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (x,y) = __in;
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var v = M.Apply(y);
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            if ((v != Result.One))
            {
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(y);
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

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<Constant, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class CountOnes : Operation<(QArray<Qubit>,Qubit), QVoid>, ICallable
    {
        public CountOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Qubit)>, IApplyData
        {
            public In((QArray<Qubit>,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CountOnes";
        String ICallable.FullName => "Solution.CountOnes";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Qubit), QVoid> Body => (__in) =>
        {
            var (x,y) = __in;
#line 31 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            foreach (var i in new Range(0L, (x.Count - 1L)))
            {
#line 33 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((x[i], y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Qubit y)
        {
            return __m__.Run<CountOnes, (QArray<Qubit>,Qubit), QVoid>((x, y));
        }
    }

    public class Solve : Operation<(Int64,ICallable), Boolean>, ICallable
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

        protected ICallable<Qubit, Result> MicrosoftQuantumCanonMResetZ
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Int64,ICallable), Boolean> Body => (__in) =>
        {
            var (N,Uf) = __in;
#line 42 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var result = true;
#line 43 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var qs = Allocate.Apply((N + 1L));
#line 45 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var x = qs?.Slice(new Range(0L, (N - 1L)));
#line 46 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            var y = qs[N];
#line 48 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            MicrosoftQuantumPrimitiveX.Apply(y);
#line 49 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), qs));
#line 51 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            Uf.Apply((x, y));
#line 52 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            MicrosoftQuantumCanonApplyToEach.Apply((((ICallable)MicrosoftQuantumPrimitiveH), x));
#line 54 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            foreach (var i in new Range(0L, (N - 1L)))
            {
#line 56 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
                if ((MicrosoftQuantumCanonMResetZ.Apply(x[i]) == Result.One))
                {
#line 58 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
                    result = false;
                }
            }

#line 61 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            Reset.Apply(y);
#line hidden
            Release.Apply(qs);
#line 63 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemI/Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonApplyToEach = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Canon.ApplyToEach<>));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,ICallable) data) => new In(data);
        public override IApplyData __dataOut(Boolean data) => new QTuple<Boolean>(data);
        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__, Int64 N, ICallable Uf)
        {
            return __m__.Run<Solve, (Int64,ICallable), Boolean>((N, Uf));
        }
    }
}