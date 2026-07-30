using System.Reflection;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class Symbol
	{
		private SYMKIND _kind;

		private ACCESS _access;

		public Name name;

		public ParentSymbol parent;

		public Symbol nextChild;

		public Symbol nextSameName;

		public bool isStatic => false;

		public Symbol LookupNext(symbmask_t kindmask)
		{
			return null;
		}

		public ACCESS GetAccess()
		{
			return default(ACCESS);
		}

		public void SetAccess(ACCESS access)
		{
		}

		public SYMKIND getKind()
		{
			return default(SYMKIND);
		}

		public void setKind(SYMKIND kind)
		{
		}

		public symbmask_t mask()
		{
			return default(symbmask_t);
		}

		public CType getType()
		{
			return null;
		}

		private Assembly GetAssembly()
		{
			return null;
		}

		private bool InternalsVisibleTo(Assembly assembly)
		{
			return false;
		}

		public bool SameAssemOrFriend(Symbol sym)
		{
			return false;
		}

		public bool IsOverride()
		{
			return false;
		}

		public bool IsHideByName()
		{
			return false;
		}

		public bool isUserCallable()
		{
			return false;
		}
	}
}
