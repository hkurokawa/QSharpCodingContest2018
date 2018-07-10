#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Solution", "Solve (qs : Qubit[]) : ()", new string[] { }, "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs", 143L, 6L, 5L)]
#line hidden
namespace Solution
{
    public class Solve : Operation<QArray<Qubit>, QVoid>, ICallable
    {
        public Solve(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Solve";
        String ICallable.FullName => "Solution.Solve";
        protected Allocate Allocate
        {
            get;
            set;
        }

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

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 9 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
            var N = qs.Count;
#line 10 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
            if ((N == 1L))
            {
#line 12 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qs[0L]);
            }
            else
            {
#line 16 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                var K = (N / 2L);
#line 17 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                ((ICallable)this).Apply(qs?.Slice(new Range(0L, (K - 1L))));
#line 18 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                var temp = Allocate.Apply(1L);
#line 20 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                var aux = temp[0L];
#line 21 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(aux);
#line 22 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                foreach (var i in new Range(0L, (K - 1L)))
                {
#line 24 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                    MicrosoftQuantumPrimitiveSWAP.Controlled.Apply((new QArray<Qubit>()
                    {aux}, (qs[i], qs[(K + i)])));
#line 25 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qs[(K + i)], aux));
                }

#line 27 "/home/hiroshi/git/github.com/hkurokawa/QSharpCodingContest2018/contest/ProblemA4/Operation.qs"
                Reset.Apply(aux);
#line hidden
                Release.Apply(temp);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Reset = this.Factory.Get<ICallable<Qubit, QVoid>>(typeof(Microsoft.Quantum.Primitive.Reset));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<Solve, QArray<Qubit>, QVoid>(qs);
        }
    }
}