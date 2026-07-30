using System;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class TypeParameterType : CType
	{
		public TypeParameterSymbol Symbol { get; }

		public ParentSymbol OwningSymbol => null;

		public Name Name => null;

		public bool Covariant => false;

		public bool Invariant => false;

		public bool Contravariant => false;

		public override bool IsValueType => false;

		public override bool IsReferenceType => false;

		public override bool IsNonNullableValueType => false;

		public bool HasNewConstraint => false;

		public bool HasRefConstraint => false;

		public bool HasValConstraint => false;

		public bool IsMethodTypeParameter => false;

		public int IndexInOwnParameters => 0;

		public int IndexInTotalParameters => 0;

		public TypeArray Bounds => null;

		public override Type AssociatedSystemType => null;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		public TypeParameterType(TypeParameterSymbol symbol)
			: base(default(TypeKind))
		{
		}
	}
}
