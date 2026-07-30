using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class AggregateType : CType
	{
		[CompilerGenerated]
		private sealed class _003Cget_TypeHierarchy_003Ed__17 : IEnumerable<AggregateType>, IEnumerable, IEnumerator<AggregateType>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private AggregateType _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public AggregateType _003C_003E4__this;

			private CType[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

			private AggregateType _003Cagg_003E5__4;

			AggregateType IEnumerator<AggregateType>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_TypeHierarchy_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<AggregateType> IEnumerable<AggregateType>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private AggregateType _baseType;

		private TypeArray _ifacesAll;

		private TypeArray _winrtifacesAll;

		private Type _associatedSystemType;

		public bool? ConstraintError;

		public bool AllHidden;

		public bool DiffHidden;

		public AggregateType OuterType { get; }

		public AggregateSymbol OwningAggregate { get; }

		public AggregateType BaseClass => null;

		public IEnumerable<AggregateType> TypeHierarchy
		{
			[IteratorStateMachine(typeof(_003Cget_TypeHierarchy_003Ed__17))]
			get
			{
				return null;
			}
		}

		public TypeArray TypeArgsThis { get; }

		public TypeArray TypeArgsAll { get; }

		public TypeArray IfacesAll => null;

		private bool IsCollectionType => false;

		public TypeArray WinRTCollectionIfacesAll => null;

		public override bool IsReferenceType => false;

		public override bool IsNonNullableValueType => false;

		public override bool IsValueType => false;

		public override bool IsStaticClass => false;

		public override bool IsPredefined => false;

		public override PredefinedType PredefinedType => default(PredefinedType);

		public override bool IsDelegateType => false;

		public override bool IsSimpleType => false;

		public override bool IsSimpleOrEnum => false;

		public override bool IsSimpleOrEnumOrString => false;

		public override bool IsNumericType => false;

		public override bool IsStructType => false;

		public override bool IsEnumType => false;

		public override bool IsInterfaceType => false;

		public override bool IsClassType => false;

		public override AggregateType UnderlyingEnumType => null;

		public override Type AssociatedSystemType => null;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		public override ConstValKind ConstValKind => default(ConstValKind);

		public AggregateType(AggregateSymbol parent, TypeArray typeArgsThis, AggregateType outerType)
			: base(default(TypeKind))
		{
		}

		public override bool IsPredefType(PredefinedType pt)
		{
			return false;
		}

		private Type CalculateAssociatedSystemType()
		{
			return null;
		}

		public override AggregateType GetAts()
		{
			return null;
		}
	}
}
