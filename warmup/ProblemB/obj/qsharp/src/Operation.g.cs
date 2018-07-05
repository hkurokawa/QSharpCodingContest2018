#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (count : Int, index : Int) : Int[]", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs", 159L, 7L, 5L)]
[assembly: OperationDeclaration("Solution", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs", 1418L, 48L, 5L)]
[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[], index : Int) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs", 1649L, 60L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<(Int64,Int64), QArray<Int64>>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Test";
        String ICallable.FullName => "Solution.Test";
        protected Allocate Allocate
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

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,Int64), QVoid> Solve
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (count,index) = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            var numCounts = new QArray<Int64>(4L);
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            var qubits = Allocate.Apply(2L);
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            foreach (var test in new Range(1L, count))
            {
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                Set.Apply((Result.Zero, qubits[0L]));
#line 16 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                Set.Apply((Result.Zero, qubits[1L]));
#line 18 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                Solve.Apply((qubits, index));
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                var res0 = M.Apply(qubits[0L]);
#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                var res1 = M.Apply(qubits[1L]);
#line 23 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                if (((res0 == Result.Zero) && (res1 == Result.Zero)))
                {
#line 25 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                    numCounts[0L] = (numCounts[0L] + 1L);
                }
                else if (((res0 == Result.Zero) && (res1 == Result.One)))
                {
#line 29 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                    numCounts[1L] = (numCounts[1L] + 1L);
                }
                else if (((res0 == Result.One) && (res1 == Result.Zero)))
                {
#line 33 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                    numCounts[2L] = (numCounts[2L] + 1L);
                }
                else
                {
#line 37 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                    numCounts[3L] = (numCounts[3L] + 1L);
                }
            }

#line 40 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            Set.Apply((Result.Zero, qubits[0L]));
#line 41 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            Set.Apply((Result.Zero, qubits[1L]));
#line hidden
            Release.Apply(qubits);
#line 43 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            return numCounts;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Solution.Set));
            this.Solve = this.Factory.Get<ICallable<(QArray<Qubit>,Int64), QVoid>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 count, Int64 index)
        {
            return __m__.Run<Test, (Int64,Int64), QArray<Int64>>((count, index));
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
#line 51 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            var current = M.Apply(q1);
#line 52 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            if ((desired != current))
            {
#line 54 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
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

    public class Solve : Operation<(QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
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

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (qs,index) = __in;
#line 63 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
            if ((index == 0L))
            {
#line 65 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 66 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
            }
            else if ((index == 1L))
            {
#line 70 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 71 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 72 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qs[1L]);
#line 73 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
            }
            else if ((index == 2L))
            {
#line 77 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                Set.Apply((Result.One, qs[1L]));
#line 78 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 79 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
            }
            else
            {
#line 83 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                Set.Apply((Result.One, qs[1L]));
#line 84 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
#line 85 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qs[1L]);
#line 86 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/warmup/ProblemB/Operation.qs"
                MicrosoftQuantumPrimitiveCNOT.Apply((qs[0L], qs[1L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Solution.Set));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, Int64 index)
        {
            return __m__.Run<Solve, (QArray<Qubit>,Int64), QVoid>((qs, index));
        }
    }
}