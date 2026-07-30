using System;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class MemberLookup
	{
		private CType _typeSrc;

		private CType _typeQual;

		private ParentSymbol _symWhere;

		private Name _name;

		private int _arity;

		private MemLookFlags _flags;

		private readonly List<AggregateType> _rgtypeStart;

		private List<AggregateType> _prgtype;

		private int _csym;

		private readonly SymWithType _swtFirst;

		private readonly List<MethPropWithType> _methPropWithTypeList;

		private readonly SymWithType _swtAmbig;

		private readonly SymWithType _swtInaccess;

		private readonly SymWithType _swtBad;

		private readonly SymWithType _swtBogus;

		private readonly SymWithType _swtBadArity;

		private bool _fMulti;

		private void RecordType(AggregateType type, Symbol sym)
		{
		}

		private bool SearchSingleType(AggregateType typeCur, out bool pfHideByName)
		{
			pfHideByName = default(bool);
			return false;
		}

		private static bool IsDynamicMember(Symbol sym)
		{
			return false;
		}

		private bool LookupInClass(AggregateType typeStart, ref AggregateType ptypeEnd)
		{
			return false;
		}

		private bool LookupInInterfaces(AggregateType typeStart, TypeArray types)
		{
			return false;
		}

		private static RuntimeBinderException ReportBogus(SymWithType swt)
		{
			return null;
		}

		private static bool IsDelegateType(CType pSrcType, AggregateType pAggType)
		{
			return false;
		}

		public bool Lookup(CType typeSrc, Expr obj, ParentSymbol symWhere, Name name, int arity, MemLookFlags flags)
		{
			return false;
		}

		private bool FError()
		{
			return false;
		}

		public SymWithType SwtFirst()
		{
			return null;
		}

		public Exception ReportErrors()
		{
			return null;
		}
	}
}
