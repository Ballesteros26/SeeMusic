using System;
using System.Linq.Expressions;

namespace ForieroEngine.EnumUtilities
{
	internal static class EnumCompiledCache<T> where T : struct, IComparable, IFormattable, IConvertible
	{
		internal static readonly Func<sbyte, bool> IsDefinedSByte;

		internal static readonly Func<byte, bool> IsDefinedByte;

		internal static readonly Func<ushort, bool> IsDefinedUInt16;

		internal static readonly Func<short, bool> IsDefinedInt16;

		internal static readonly Func<uint, bool> IsDefinedUInt32;

		internal static readonly Func<int, bool> IsDefinedInt32;

		internal static readonly Func<ulong, bool> IsDefinedUInt64;

		internal static readonly Func<long, bool> IsDefinedInt64;

		internal static readonly Func<float, bool> IsDefinedSingle;

		internal static readonly Func<double, bool> IsDefinedDouble;

		internal static readonly Func<T, T, T> UnsetFlag;

		internal static readonly Func<T, T, T> BitwiseOr;

		internal static readonly Func<T, T, T> BitwiseAnd;

		internal static readonly Func<T, T, T> BitwiseExclusiveOr;

		internal static readonly Func<T, T> BitwiseNot;

		internal static readonly Func<T, T, bool> HasFlag;

		internal static readonly Func<T, ulong> ToUInt64;

		internal static readonly Func<T, long> ToInt64;

		internal static readonly Func<T, uint> ToUInt32;

		internal static readonly Func<T, int> ToInt32;

		internal static readonly Func<T, ushort> ToUInt16;

		internal static readonly Func<T, short> ToInt16;

		internal static readonly Func<T, byte> ToByte;

		internal static readonly Func<T, sbyte> ToSByte;

		internal static readonly Func<T, float> ToSingle;

		internal static readonly Func<T, double> ToDouble;

		internal static readonly Func<ulong, T> FromUInt64;

		internal static readonly Func<long, T> FromInt64;

		internal static readonly Func<uint, T> FromUInt32;

		internal static readonly Func<int, T> FromInt32;

		internal static readonly Func<ushort, T> FromUInt16;

		internal static readonly Func<short, T> FromInt16;

		internal static readonly Func<byte, T> FromByte;

		internal static readonly Func<sbyte, T> FromSByte;

		internal static readonly Func<float, T> FromSingle;

		internal static readonly Func<double, T> FromDouble;

		private static Func<T, Y> GenerateConvertTo<Y>() where Y : struct, IComparable, IFormattable, IConvertible, IComparable<Y>, IEquatable<Y>
		{
			return null;
		}

		private static Func<Y, T> GenerateConvertFrom<Y>() where Y : struct, IComparable, IFormattable, IConvertible, IComparable<Y>, IEquatable<Y>
		{
			return null;
		}

		private static Func<Y, bool> GenerateIsDefined<Y>() where Y : struct, IComparable, IFormattable, IConvertible, IComparable<Y>, IEquatable<Y>
		{
			return null;
		}

		private static Func<T, T, bool> GenerateHasFlag()
		{
			return null;
		}

		private static Func<T, T, T> BitwiseOperator(ExpressionType expressionType)
		{
			return null;
		}

		private static Func<T, T> BitwiseUnaryOperator(ExpressionType expressionType)
		{
			return null;
		}

		private static Func<T, T, T> GenerateUnsetFlag()
		{
			return null;
		}

		private static Func<T, T, T> GenerateBitwiseOr()
		{
			return null;
		}

		private static Func<T, T, T> GenerateBitwiseAnd()
		{
			return null;
		}

		private static Func<T, T, T> GenerateBitwiseExclusiveOr()
		{
			return null;
		}

		private static Func<T, T> GenerateBitwiseNot()
		{
			return null;
		}
	}
}
