#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test (N : Int) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Test.qs", 183L, 7L, 5L)]
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

        protected ICallable<QArray<Qubit>, QVoid> Solve
        {
            get;
            set;
        }

        public override Func<Int64, QVoid> Body => (__in) =>
        {
            var N = __in;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Test.qs"
            var qs = Allocate.Apply(N);
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Test.qs"
            Solve.Apply(qs);
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Test.qs"
            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("qs.txt", qs?.Slice(new Range(0L, (N - 1L)))));
#line 14 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Test.qs"
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
            this.Solve = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Solution.Solve));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 N)
        {
            return __m__.Run<Test, Int64, QVoid>(N);
        }
    }
}