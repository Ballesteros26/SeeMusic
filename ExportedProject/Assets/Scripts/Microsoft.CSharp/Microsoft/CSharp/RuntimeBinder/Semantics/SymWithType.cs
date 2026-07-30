using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal class SymWithType
	{
		private AggregateType _ats;

		private Symbol _sym;

		public AggregateType Ats => null;

		public Symbol Sym => null;

		public SymWithType()
		{
		}

		public SymWithType(Symbol sym, AggregateType ats)
		{
		}

		public virtual void Clear()
		{
		}

		public new AggregateType GetType()
		{
			return null;
		}

		public static bool operator ==(SymWithType swt1, SymWithType swt2)
		{
			return false;
		}

		public static bool operator !=(SymWithType swt1, SymWithType swt2)
		{
			return false;
		}

		[ExcludeFromCodeCoverage]
		public override bool Equals(object obj)
		{
			return false;
		}

		[ExcludeFromCodeCoverage]
		public override int GetHashCode()
		{
			return 0;
		}

		public static implicit operator bool(SymWithType swt)
		{
			return false;
		}

		public MethodOrPropertySymbol MethProp()
		{
			return null;
		}

		public MethodSymbol Meth()
		{
			return null;
		}

		public PropertySymbol Prop()
		{
			return null;
		}

		public FieldSymbol Field()
		{
			return null;
		}

		public EventSymbol Event()
		{
			return null;
		}

		public void Set(Symbol sym, AggregateType ats)
		{
		}
	}
}
