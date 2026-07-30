using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class CType
	{
		public bool IsWindowsRuntimeType => false;

		[ExcludeFromCodeCoverage]
		public virtual Type AssociatedSystemType => null;

		public TypeKind TypeKind { get; }

		public virtual CType BaseOrParameterOrElementType => null;

		public virtual FUNDTYPE FundamentalType => default(FUNDTYPE);

		public virtual ConstValKind ConstValKind => default(ConstValKind);

		public virtual bool IsDelegateType => false;

		public virtual bool IsSimpleType => false;

		public virtual bool IsSimpleOrEnum => false;

		public virtual bool IsSimpleOrEnumOrString => false;

		public virtual bool IsNumericType => false;

		public virtual bool IsStructType => false;

		public virtual bool IsEnumType => false;

		public virtual bool IsInterfaceType => false;

		public virtual bool IsClassType => false;

		[ExcludeFromCodeCoverage]
		public virtual AggregateType UnderlyingEnumType => null;

		public virtual bool IsPredefined => false;

		[ExcludeFromCodeCoverage]
		public virtual PredefinedType PredefinedType => default(PredefinedType);

		public virtual bool IsStaticClass => false;

		public virtual bool IsValueType => false;

		public virtual bool IsNonNullableValueType => false;

		public virtual bool IsReferenceType => false;

		private protected CType(TypeKind kind)
		{
		}

		public CType GetNakedType(bool fStripNub)
		{
			return null;
		}

		public virtual CType StripNubs()
		{
			return null;
		}

		public virtual CType StripNubs(out bool wasNullable)
		{
			wasNullable = default(bool);
			return null;
		}

		public virtual bool IsUnsafe()
		{
			return false;
		}

		public virtual bool IsPredefType(PredefinedType pt)
		{
			return false;
		}

		[ExcludeFromCodeCoverage]
		public virtual AggregateType GetAts()
		{
			return null;
		}
	}
}
