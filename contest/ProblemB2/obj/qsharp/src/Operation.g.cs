#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[]) : Int", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs", 144L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<QArray<Qubit>, Int64>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, Int64> Body => (__in) =>
        {
            var qs = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
            var isAllZero = true;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
            var isAllOne = true;
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
            foreach (var i in new Range(0L, (qs.Count - 1L)))
            {
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                var m = M.Apply(qs[i]);
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                if ((m == Result.Zero))
                {
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                    isAllOne = false;
                }
                else
                {
#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                    isAllZero = false;
                }
            }

#line 25 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
            if ((isAllZero || isAllOne))
            {
#line 27 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                return 0L;
            }
            else
            {
#line 31 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemB2/Operation.qs"
                return 1L;
            }
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Solve, QArray<Qubit>, Int64>(qs);
        }
    }
}