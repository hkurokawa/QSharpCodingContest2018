#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (bits0 : Bool[], bits1 : Bool[]) : Bool[]", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs", 163L, 6L, 5L)]
[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[], bits0 : Bool[], bits1 : Bool[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs", 770L, 29L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<(QArray<Boolean>,QArray<Boolean>), QArray<Boolean>>, ICallable
    {
        public Test(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Boolean>,QArray<Boolean>) data) : base(data)
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

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid> Solve
        {
            get;
            set;
        }

        public override Func<(QArray<Boolean>,QArray<Boolean>), QArray<Boolean>> Body => (__in) =>
        {
            var (bits0,bits1) = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var N = bits0.Count;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var result = new QArray<Boolean>(N);
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var qs = Allocate.Apply(N);
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            Solve.Apply((qs, bits0, bits1));
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            foreach (var i in new Range(0L, (N - 1L)))
            {
#line 16 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                var m = M.Apply(qs[i]);
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                if ((m == Result.One))
                {
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                    result[i] = true;
                }
            }

#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line 24 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            return result;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Solve = this.Factory.Get<ICallable<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn((QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<Test, (QArray<Boolean>,QArray<Boolean>), QArray<Boolean>>((bits0, bits1));
        }
    }

    public class Solve : Operation<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>)>, IApplyData
        {
            public In((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) : base(data)
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid> Body => (__in) =>
        {
            var (qs,bits0,bits1) = __in;
#line 32 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var idx = -(1L);
#line 33 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var b0 = bits0;
#line 34 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            var b1 = bits1;
#line 35 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            foreach (var j in new Range(0L, (bits0.Count - 1L)))
            {
#line 37 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                if (((idx < 0L) && (bits0[j] != bits1[j])))
                {
#line 39 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                    idx = j;
#line 40 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                    if ((bits1[j] == false))
                    {
#line 42 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                        b0 = bits1;
#line 43 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                        b1 = bits0;
                    }
                }
            }

#line 48 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            MicrosoftQuantumPrimitiveH.Apply(qs[idx]);
#line 49 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
            foreach (var j in new Range(0L, (b0.Count - 1L)))
            {
#line 51 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                if (b0[j])
                {
#line 53 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                    MicrosoftQuantumPrimitiveX.Apply(qs[j]);
                }

#line 55 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                if (((j != idx) && (b0[j] != b1[j])))
                {
#line 57 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA3/Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qs[idx], qs[j]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((QArray<Qubit>,QArray<Boolean>,QArray<Boolean>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs, QArray<Boolean> bits0, QArray<Boolean> bits1)
        {
            return __m__.Run<Solve, (QArray<Qubit>,QArray<Boolean>,QArray<Boolean>), QVoid>((qs, bits0, bits1));
        }
    }
}