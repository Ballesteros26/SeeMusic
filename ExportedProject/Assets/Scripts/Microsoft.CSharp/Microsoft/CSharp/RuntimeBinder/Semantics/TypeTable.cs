using System;
using System.Collections.Generic;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class TypeTable
	{
		private readonly struct KeyPair<TKey1, TKey2> : IEquatable<KeyPair<TKey1, TKey2>>
		{
			private readonly TKey1 _pKey1;

			private readonly TKey2 _pKey2;

			public KeyPair(TKey1 pKey1, TKey2 pKey2)
			{
				_pKey1 = default(TKey1);
				_pKey2 = default(TKey2);
			}

			public bool Equals(KeyPair<TKey1, TKey2> other)
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

		private static readonly Dictionary<KeyPair<AggregateSymbol, KeyPair<AggregateType, TypeArray>>, AggregateType> s_aggregateTable;

		private static readonly Dictionary<KeyPair<CType, int>, ArrayType> s_arrayTable;

		private static readonly Dictionary<KeyPair<CType, bool>, ParameterModifierType> s_parameterModifierTable;

		private static readonly Dictionary<CType, PointerType> s_pointerTable;

		private static readonly Dictionary<CType, NullableType> s_nullableTable;

		private static KeyPair<TKey1, TKey2> MakeKey<TKey1, TKey2>(TKey1 key1, TKey2 key2)
		{
			return default(KeyPair<TKey1, TKey2>);
		}

		public static AggregateType LookupAggregate(AggregateSymbol aggregate, AggregateType outer, TypeArray args)
		{
			return null;
		}

		public static void InsertAggregate(AggregateSymbol aggregate, AggregateType outer, TypeArray args, AggregateType ats)
		{
		}

		public static ArrayType LookupArray(CType elementType, int rankNum)
		{
			return null;
		}

		public static void InsertArray(CType elementType, int rankNum, ArrayType pArray)
		{
		}

		public static ParameterModifierType LookupParameterModifier(CType elementType, bool isOut)
		{
			return null;
		}

		public static void InsertParameterModifier(CType elementType, bool isOut, ParameterModifierType parameterModifier)
		{
		}

		public static PointerType LookupPointer(CType elementType)
		{
			return null;
		}

		public static void InsertPointer(CType elementType, PointerType pointer)
		{
		}

		public static NullableType LookupNullable(CType underlyingType)
		{
			return null;
		}

		public static void InsertNullable(CType underlyingType, NullableType nullable)
		{
		}
	}
}
