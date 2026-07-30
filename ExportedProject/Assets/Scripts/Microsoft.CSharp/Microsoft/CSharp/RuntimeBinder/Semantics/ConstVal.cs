namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal readonly struct ConstVal
	{
		private static readonly object s_false;

		private static readonly object s_true;

		private static readonly object s_zeroInt32;

		public object ObjectVal { get; }

		public bool BooleanVal => false;

		public sbyte SByteVal => 0;

		public byte ByteVal => 0;

		public short Int16Val => 0;

		public ushort UInt16Val => 0;

		public int Int32Val => 0;

		public uint UInt32Val => 0u;

		public long Int64Val => 0L;

		public ulong UInt64Val => 0uL;

		public float SingleVal => 0f;

		public double DoubleVal => 0.0;

		public decimal DecimalVal => default(decimal);

		public char CharVal => '\0';

		public string StringVal => null;

		public bool IsNullRef => false;

		private ConstVal(object value)
		{
			ObjectVal = null;
		}

		public bool IsZero(ConstValKind kind)
		{
			return false;
		}

		private static T SpecialUnbox<T>(object o)
		{
			return default(T);
		}

		private static bool IsDefault(object o)
		{
			return false;
		}

		public static ConstVal GetDefaultValue(ConstValKind kind)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(bool value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(int value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(uint value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(decimal value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(string value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(float value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(double value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(long value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(ulong value)
		{
			return default(ConstVal);
		}

		public static ConstVal Get(object p)
		{
			return default(ConstVal);
		}
	}
}
