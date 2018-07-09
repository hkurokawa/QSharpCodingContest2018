#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (b : Int[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs", 185L, 7L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<QArray<Int64>, QVoid>, ICallable
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

        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpRegister
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

        protected ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid> Solve
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Int64>, QVoid> Body => (__in) =>
        {
            var b = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            var N = b.Count;
#line 11 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            var qs = Allocate.Apply((N + 1L));
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            var x = qs?.Slice(new Range(0L, (N - 1L)));
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            var y = qs[N];
#line 15 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
#line 16 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            Solve.Apply((x, y, b));
#line 18 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("qs.txt", qs?.Slice(new Range(N, N))));
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD1/Test.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpRegister = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpRegister<>));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Solve = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit,QArray<Int64>), QVoid>>(typeof(Solution.Solve));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Int64> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Int64> b)
        {
            return __m__.Run<Test, QArray<Int64>, QVoid>(b);
        }
    }
}