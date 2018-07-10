#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (q : Qubit) : Int", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs", 141L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<Qubit, Int64>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
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

        protected ICallable<Int64, Int64> MicrosoftQuantumCanonRandomInt
        {
            get;
            set;
        }

        public override Func<Qubit, Int64> Body => (__in) =>
        {
            var q = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
            var r = MicrosoftQuantumCanonRandomInt.Apply(2L);
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
            if ((r == 0L))
            {
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                var m = M.Apply(q);
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                if ((m == Result.One))
                {
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                    return 1L;
                }

#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                return -(1L);
            }
            else
            {
#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(q);
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                var m = M.Apply(q);
#line 23 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                if ((m == Result.One))
                {
#line 25 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                    return 0L;
                }

#line 27 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemC2/Operation.qs"
                return -(1L);
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumCanonRandomInt = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.RandomInt));
        }

        public override IApplyData __dataIn(Qubit data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Qubit q)
        {
            return __m__.Run<Solve, Qubit, Int64>(q);
        }
    }
}