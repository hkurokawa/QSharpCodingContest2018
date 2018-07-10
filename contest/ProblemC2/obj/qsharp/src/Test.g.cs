#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (count : Int, flag : Int) : (Int, Int, Int)", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs", 212L, 7L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<(Int64,Int64), (Int64,Int64,Int64)>, ICallable
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

        public class Out : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public Out((Int64,Int64,Int64) data) : base(data)
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

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
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

        protected ICallable<Qubit, Int64> Solve
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), (Int64,Int64,Int64)> Body => (__in) =>
        {
            var (count,flag) = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            var numZeros = 0L;
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            var numOnes = 0L;
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            var numNegatives = 0L;
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            var qs = Allocate.Apply(1L);
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            foreach (var i in new Range(1L, count))
            {
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                if ((flag == 1L))
                {
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qs[0L]);
                }

#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                var result = Solve.Apply(qs[0L]);
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                if ((result == 0L))
                {
#line 24 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                    numZeros = (numZeros + 1L);
                }
                else if ((result == 1L))
                {
#line 28 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                    numOnes = (numOnes + 1L);
                }
                else
                {
#line 32 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                    numNegatives = (numNegatives + 1L);
                }

#line 34 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
                ResetAll.Apply(qs);
            }

#line hidden
            Release.Apply(qs);
#line 37 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Test.qs"
            return (numZeros, numOnes, numNegatives);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Solve = this.Factory.Get<ICallable<Qubit, Int64>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut((Int64,Int64,Int64) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Int64,Int64,Int64)> Run(IOperationFactory __m__, Int64 count, Int64 flag)
        {
            return __m__.Run<Test, (Int64,Int64), (Int64,Int64,Int64)>((count, flag));
        }
    }
}