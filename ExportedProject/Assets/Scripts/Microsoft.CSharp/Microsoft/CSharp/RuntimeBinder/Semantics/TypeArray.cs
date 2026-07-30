using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class TypeArray
	{
		private readonly struct TypeArrayKey : IEquatable<TypeArrayKey>
		{
			private readonly CType[] _types;

			private readonly int _hashCode;

			public TypeArrayKey(CType[] types)
			{
				_types = null;
				_hashCode = 0;
			}

			public bool Equals(TypeArrayKey other)
			{
				return false;
			}

			[ExcludeFromCodeCoverage]
			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private static readonly Dictionary<TypeArrayKey, TypeArray> s_tableTypeArrays;

		public static readonly TypeArray Empty;

		public int Count => 0;

		public CType[] Items { get; }

		public CType this[int i] => null;

		private TypeArray(CType[] types)
		{
		}

		public void CopyItems(int i, int c, CType[] dest)
		{
		}

		public static TypeArray Allocate(int ctype, TypeArray array, int offset)
		{
			return null;
		}

		public static TypeArray Allocate(params CType[] types)
		{
			return null;
		}

		public static TypeArray Concat(TypeArray pta1, TypeArray pta2)
		{
			return null;
		}
	}
}
