using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal class CMemberLookupResults
	{
		public class CMethodIterator
		{
			private readonly AggregateSymbol _context;

			private readonly TypeArray _containingTypes;

			private readonly CType _qualifyingType;

			private readonly Name _name;

			private readonly int _arity;

			private readonly symbmask_t _mask;

			private readonly EXPRFLAG _flags;

			private readonly ArgInfos _nonTrailingNamedArguments;

			private int _currentTypeIndex;

			public MethodOrPropertySymbol CurrentSymbol { get; private set; }

			public AggregateType CurrentType { get; private set; }

			public bool IsCurrentSymbolInaccessible { get; private set; }

			public bool IsCurrentSymbolBogus { get; private set; }

			public bool IsCurrentSymbolMisnamed { get; private set; }

			public bool AtEnd => false;

			public bool CanUseCurrentSymbol => false;

			public CMethodIterator(Name name, TypeArray containingTypes, CType qualifyingType, AggregateSymbol context, int arity, EXPRFLAG flags, symbmask_t mask, ArgInfos nonTrailingNamedArguments)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			private bool CheckArgumentNames()
			{
				return false;
			}

			private bool FindNextMethod()
			{
				return false;
			}

			private bool FindNextTypeForInstanceMethods()
			{
				return false;
			}
		}

		private readonly Name _pName;

		private TypeArray ContainingTypes { get; }

		public CMemberLookupResults(TypeArray containingTypes, Name name)
		{
		}

		public CMethodIterator GetMethodIterator(CType qualifyingType, AggregateSymbol context, int arity, EXPRFLAG flags, symbmask_t mask, ArgInfos nonTrailingNamedArguments)
		{
			return null;
		}
	}
}
