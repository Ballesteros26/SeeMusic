using Microsoft.CSharp.RuntimeBinder.Semantics;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Errors
{
	internal class ErrArg
	{
		public ErrArgKind eak;

		public ErrArgFlags eaf;

		internal int n;

		internal SYMKIND sk;

		internal Name name;

		internal Symbol sym;

		internal string psz;

		internal CType pType;

		internal MethPropWithInstMemo mpwiMemo;

		internal SymWithTypeMemo swtMemo;

		public ErrArg()
		{
		}

		public ErrArg(int n)
		{
		}

		public ErrArg(Name name)
		{
		}

		public ErrArg(string psz)
		{
		}

		public ErrArg(CType pType)
		{
		}

		public ErrArg(CType pType, ErrArgFlags eaf)
		{
		}

		public ErrArg(Symbol pSym)
		{
		}

		private ErrArg(Symbol pSym, ErrArgFlags eaf)
		{
		}

		public ErrArg(SymWithType swt)
		{
		}

		public ErrArg(MethPropWithInst mpwi)
		{
		}

		public static implicit operator ErrArg(int n)
		{
			return null;
		}

		public static implicit operator ErrArg(CType type)
		{
			return null;
		}

		public static implicit operator ErrArg(string psz)
		{
			return null;
		}

		public static implicit operator ErrArg(Name name)
		{
			return null;
		}

		public static implicit operator ErrArg(Symbol pSym)
		{
			return null;
		}

		public static implicit operator ErrArg(SymWithType swt)
		{
			return null;
		}

		public static implicit operator ErrArg(MethPropWithInst mpwi)
		{
			return null;
		}
	}
}
