#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Test () : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs", 176L, 7L, 5L)]
#line hidden
namespace Solution
{
    public class Test : Operation<QVoid, QVoid>, ICallable
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

        protected ICallable<(QArray<Qubit>,Qubit), QVoid> Solve
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            var qs = Allocate.Apply(4L);
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            var x = qs?.Slice(new Range(0L, 2L));
#line 13 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            var y = qs[3L];
            //X(qs[0]);
            //X(qs[1]);
#line 16 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[2L]);
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            Solve.Apply((x, y));
#line 18 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
            MicrosoftQuantumExtensionsDiagnosticsDumpRegister.Apply(("qs.txt", qs?.Slice(new Range(3L, 3L))));
#line 19 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemD3/Test.qs"
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
            this.Solve = this.Factory.Get<ICallable<(QArray<Qubit>,Qubit), QVoid>>(typeof(Solution.Solve));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Test, QVoid, QVoid>(QVoid.Instance);
        }
    }
}