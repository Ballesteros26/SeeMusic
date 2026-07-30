using System.Text;
using Microsoft.CSharp.RuntimeBinder.Semantics;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Errors
{
	internal struct UserStringBuilder
	{
		private StringBuilder _strBuilder;

		private void BeginString()
		{
		}

		private string EndString()
		{
			return null;
		}

		private static string ErrSK(SYMKIND sk)
		{
			return null;
		}

		private void ErrAppendParamList(TypeArray @params, bool isParamArray)
		{
		}

		private void ErrAppendString(string str)
		{
		}

		private void ErrAppendChar(char ch)
		{
		}

		private void ErrAppendPrintf(string format, params object[] args)
		{
		}

		private void ErrAppendName(Name name)
		{
		}

		private void ErrAppendParentSym(Symbol sym, SubstContext pctx)
		{
		}

		private void ErrAppendParentCore(Symbol parent, SubstContext pctx)
		{
		}

		private void ErrAppendTypeParameters(TypeArray @params, SubstContext pctx)
		{
		}

		private void ErrAppendMethod(MethodSymbol meth, SubstContext pctx, bool fArgs)
		{
		}

		private void ErrAppendIndexer(IndexerSymbol indexer, SubstContext pctx)
		{
		}

		private void ErrAppendProperty(PropertySymbol prop, SubstContext pctx)
		{
		}

		private void ErrAppendId(MessageID id)
		{
		}

		private void ErrAppendSym(Symbol sym, SubstContext pctx)
		{
		}

		private void ErrAppendSym(Symbol sym, SubstContext pctx, bool fArgs)
		{
		}

		private void ErrAppendType(CType pType, SubstContext pctx)
		{
		}

		public bool ErrArgToString(out string psz, ErrArg parg, out bool fUserStrings)
		{
			psz = null;
			fUserStrings = default(bool);
			return false;
		}

		private static string ErrId(MessageID id)
		{
			return null;
		}
	}
}
