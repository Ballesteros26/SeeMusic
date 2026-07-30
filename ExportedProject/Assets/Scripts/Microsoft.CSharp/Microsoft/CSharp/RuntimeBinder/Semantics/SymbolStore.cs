using System;
using System.Collections.Generic;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class SymbolStore
	{
		private readonly struct Key : IEquatable<Key>
		{
			private readonly Name _name;

			private readonly ParentSymbol _parent;

			public Key(Name name, ParentSymbol parent)
			{
				_name = null;
				_parent = null;
			}

			public bool Equals(Key other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private static readonly Dictionary<Key, Symbol> s_dictionary;

		public static Symbol LookupSym(Name name, ParentSymbol parent, symbmask_t kindmask)
		{
			return null;
		}

		public static void InsertChild(ParentSymbol parent, Symbol child)
		{
		}

		private static void InsertChildNoGrow(Symbol child)
		{
		}

		private static Symbol FindCorrectKind(Symbol sym, symbmask_t kindmask)
		{
			return null;
		}
	}
}
