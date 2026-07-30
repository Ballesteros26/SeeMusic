using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class PointerType : CType
	{
		public CType ReferentType { get; }

		public override Type AssociatedSystemType => null;

		public override CType BaseOrParameterOrElementType => null;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		[ExcludeFromCodeCoverage]
		public override ConstValKind ConstValKind => default(ConstValKind);

		public PointerType(CType referentType)
			: base(default(TypeKind))
		{
		}

		public override bool IsUnsafe()
		{
			return false;
		}
	}
}
