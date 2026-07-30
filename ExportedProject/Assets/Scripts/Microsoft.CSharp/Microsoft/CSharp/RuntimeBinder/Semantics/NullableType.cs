using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class NullableType : CType
	{
		private AggregateType _ats;

		public CType UnderlyingType { get; }

		public override bool IsValueType => false;

		public override bool IsStructType => false;

		public override Type AssociatedSystemType => null;

		public override CType BaseOrParameterOrElementType => null;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		[ExcludeFromCodeCoverage]
		public override ConstValKind ConstValKind => default(ConstValKind);

		public NullableType(CType underlyingType)
			: base(default(TypeKind))
		{
		}

		public override AggregateType GetAts()
		{
			return null;
		}

		public override CType StripNubs()
		{
			return null;
		}

		public override CType StripNubs(out bool wasNullable)
		{
			wasNullable = default(bool);
			return null;
		}
	}
}
