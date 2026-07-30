using System;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ArrayType : CType
	{
		public int Rank { get; }

		public bool IsSZArray { get; }

		public CType ElementType { get; }

		public CType BaseElementType => null;

		public override bool IsReferenceType => false;

		public override Type AssociatedSystemType => null;

		public override CType BaseOrParameterOrElementType => null;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		public override ConstValKind ConstValKind => default(ConstValKind);

		public ArrayType(CType elementType, int rank, bool isSZArray)
			: base(default(TypeKind))
		{
		}

		public override bool IsUnsafe()
		{
			return false;
		}

		public override AggregateType GetAts()
		{
			return null;
		}
	}
}
