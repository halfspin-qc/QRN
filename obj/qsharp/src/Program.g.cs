//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QRN\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QRN\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QRN\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"max\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QRN\",\"Name\":\"SampleRandomNumberInRange\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":19,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":36}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QRN\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":32,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QRN\",\"Name\":\"SampleRandomNumber\"},\"Attributes\":[],\"SourceFile\":\"C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs\",\"Position\":{\"Item1\":33,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"Documentation\":[]}")]
#line hidden
namespace QRN
{
    [SourceLocation("C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs", OperationFunctor.Body, 9, 20)]
    public partial class GenerateRandomBit : Operation<QVoid, Result>, ICallable
    {
        public GenerateRandomBit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateRandomBit";
        String ICallable.FullName => "QRN.GenerateRandomBit";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumMeasurementMResetZ
        {
            get;
            set;
        }

        public override Func<QVoid, Result> Body => (__in__) =>
        {
#line hidden
            {
#line 11 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                var q = Allocate.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 13 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                    MicrosoftQuantumIntrinsicH.Apply(q);
#line 16 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                    return MicrosoftQuantumMeasurementMResetZ.Apply(q);
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release.Apply(q);
                    }
                }
            }
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumMeasurementMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Measurement.MResetZ));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<GenerateRandomBit, QVoid, Result>(QVoid.Instance);
        }
    }

    [SourceLocation("C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs", OperationFunctor.Body, 20, 34)]
    public partial class SampleRandomNumberInRange : Operation<Int64, Int64>, ICallable
    {
        public SampleRandomNumberInRange(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumberInRange";
        String ICallable.FullName => "QRN.SampleRandomNumberInRange";
        protected ICallable<Int64, Int64> MicrosoftQuantumMathBitSizeI
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> GenerateRandomBit
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, Int64> MicrosoftQuantumConvertResultArrayAsInt
        {
            get;
            set;
        }

        public override Func<Int64, Int64> Body => (__in__) =>
        {
            var max = __in__;
#line 21 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            var output = 0L;
#line 22 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            while (true)
            {
#line 23 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                var bits = QArray<Result>.Create(0L);
#line 24 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                foreach (var idxBit in new QRange(1L, MicrosoftQuantumMathBitSizeI.Apply(max)))
#line hidden
                {
#line 25 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                    bits = QArray<Result>.Add(bits, new QArray<Result>(GenerateRandomBit.Apply(QVoid.Instance)));
                }

#line 27 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                output = MicrosoftQuantumConvertResultArrayAsInt.Apply(bits?.Copy());
                if ((output <= max))
                {
                    break;
                }
                else
                {
                }
            }

#line 29 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            return output;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumMathBitSizeI = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Math.BitSizeI));
            this.GenerateRandomBit = this.Factory.Get<ICallable<QVoid, Result>>(typeof(GenerateRandomBit));
            this.MicrosoftQuantumConvertResultArrayAsInt = this.Factory.Get<ICallable<IQArray<Result>, Int64>>(typeof(Microsoft.Quantum.Convert.ResultArrayAsInt));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 max)
        {
            return __m__.Run<SampleRandomNumberInRange, Int64, Int64>(max);
        }
    }

    [SourceLocation("C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs", OperationFunctor.Body, 34, -1)]
    public partial class SampleRandomNumber : Operation<QVoid, Int64>, ICallable
    {
        public SampleRandomNumber(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SampleRandomNumber";
        String ICallable.FullName => "QRN.SampleRandomNumber";
        public static EntryPointInfo<QVoid, Int64> Info => new EntryPointInfo<QVoid, Int64>(typeof(SampleRandomNumber));
        protected ICallable<String, QVoid> MicrosoftQuantumIntrinsicMessage
        {
            get;
            set;
        }

        protected ICallable<Int64, Int64> SampleRandomNumberInRange
        {
            get;
            set;
        }

        public override Func<QVoid, Int64> Body => (__in__) =>
        {
#line 35 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            var min = 40L;
#line 36 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            var max = 60L;
#line 37 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            MicrosoftQuantumIntrinsicMessage.Apply(String.Format("Sampling a random number between {0} and {1}: ", min, max));
#line 38 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            var output2 = 0L;
#line 39 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            while (true)
            {
#line 40 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
                output2 = SampleRandomNumberInRange.Apply(max);
                if ((output2 >= min))
                {
                    break;
                }
                else
                {
                }
            }

#line 43 "C:/Users/sbrahme/Documents/Python/QDK/QRN/Program.qs"
            return output2;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicMessage = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Intrinsic.Message));
            this.SampleRandomNumberInRange = this.Factory.Get<ICallable<Int64, Int64>>(typeof(SampleRandomNumberInRange));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<SampleRandomNumber, QVoid, Int64>(QVoid.Instance);
        }
    }
}