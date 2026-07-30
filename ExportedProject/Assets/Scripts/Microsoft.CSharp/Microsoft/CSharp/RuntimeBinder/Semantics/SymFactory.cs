using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class SymFactory
	{
		private static Symbol NewBasicSymbol(SYMKIND kind, Name name, ParentSymbol parent)
		{
			return null;
		}

		public static NamespaceSymbol CreateNamespace(Name name, NamespaceSymbol parent)
		{
			return null;
		}

		public static AggregateSymbol CreateAggregate(Name name, NamespaceOrAggregateSymbol parent)
		{
			return null;
		}

		public static FieldSymbol CreateMemberVar(Name name, AggregateSymbol parent)
		{
			return null;
		}

		public static LocalVariableSymbol CreateLocalVar(Name name, Scope parent, CType type)
		{
			return null;
		}

		public static MethodSymbol CreateMethod(Name name, AggregateSymbol parent)
		{
			return null;
		}

		public static PropertySymbol CreateProperty(Name name, AggregateSymbol parent)
		{
			return null;
		}

		public static EventSymbol CreateEvent(Name name, AggregateSymbol parent)
		{
			return null;
		}

		public static TypeParameterSymbol CreateMethodTypeParameter(Name pName, MethodSymbol pParent, int index, int indexTotal)
		{
			return null;
		}

		public static TypeParameterSymbol CreateClassTypeParameter(Name pName, AggregateSymbol pParent, int index, int indexTotal)
		{
			return null;
		}

		public static Scope CreateScope()
		{
			return null;
		}

		public static IndexerSymbol CreateIndexer(Name name, ParentSymbol parent)
		{
			return null;
		}
	}
}
