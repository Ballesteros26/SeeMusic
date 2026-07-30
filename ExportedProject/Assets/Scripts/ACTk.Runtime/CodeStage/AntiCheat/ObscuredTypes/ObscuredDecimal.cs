using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IObscuredType, IFormattable, IEquatable<ObscuredDecimal>, IComparable<ObscuredDecimal>, IComparable<decimal>, IComparable
	{
		[StructLayout((LayoutKind)2)]
		private struct DecimalLongBytesUnion
		{
			[FieldOffset(0)]
			private decimal d;

			[FieldOffset(0)]
			private long l1;

			[FieldOffset(8)]
			private long l2;

			[FieldOffset(0)]
			private ACTkByte16 b16;

			internal static decimal XorDecimalToDecimal(decimal value, long key)
			{
				return default(decimal);
			}

			internal static ACTkByte16 XorDecimalToB16(decimal value, long key)
			{
				return default(ACTkByte16);
			}

			internal static decimal XorB16ToDecimal(ACTkByte16 value, long key)
			{
				return default(decimal);
			}

			internal static decimal ConvertB16ToDecimal(ACTkByte16 value)
			{
				return default(decimal);
			}

			internal static ACTkByte16 ConvertDecimalToB16(decimal value)
			{
				return default(ACTkByte16);
			}

			private static DecimalLongBytesUnion FromDecimal(decimal value)
			{
				return default(DecimalLongBytesUnion);
			}

			private static DecimalLongBytesUnion FromB16(ACTkByte16 value)
			{
				return default(DecimalLongBytesUnion);
			}

			private DecimalLongBytesUnion XorLongs(long key)
			{
				return default(DecimalLongBytesUnion);
			}
		}

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private ACTkByte16 hiddenValue;

		[SerializeField]
		private bool inited;

		private decimal fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDecimal(decimal value)
		{
			currentCryptoKey = 0L;
			hiddenValue = default(ACTkByte16);
			inited = false;
			fakeValue = default(decimal);
			fakeValueActive = false;
		}

		public static decimal Encrypt(decimal value, long key)
		{
			return default(decimal);
		}

		public static decimal Decrypt(decimal value, long key)
		{
			return default(decimal);
		}

		public static ObscuredDecimal FromEncrypted(decimal encrypted, long key)
		{
			return default(ObscuredDecimal);
		}

		public static long GenerateKey()
		{
			return 0L;
		}

		public decimal GetEncrypted(out long key)
		{
			key = default(long);
			return default(decimal);
		}

		public void SetEncrypted(decimal encrypted, long key)
		{
		}

		public decimal GetDecrypted()
		{
			return default(decimal);
		}

		public void RandomizeCryptoKey()
		{
		}

		private static ACTkByte16 InternalEncrypt(decimal value, long key)
		{
			return default(ACTkByte16);
		}

		private decimal InternalDecrypt()
		{
			return default(decimal);
		}

		public static implicit operator ObscuredDecimal(decimal value)
		{
			return default(ObscuredDecimal);
		}

		public static implicit operator decimal(ObscuredDecimal value)
		{
			return default(decimal);
		}

		public static explicit operator ObscuredDecimal(ObscuredFloat f)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator ++(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		public static ObscuredDecimal operator --(ObscuredDecimal input)
		{
			return default(ObscuredDecimal);
		}

		private static ObscuredDecimal Increment(ObscuredDecimal input, decimal increment)
		{
			return default(ObscuredDecimal);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredDecimal obj)
		{
			return false;
		}

		public int CompareTo(ObscuredDecimal other)
		{
			return 0;
		}

		public int CompareTo(decimal other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(long newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static decimal Encrypt(decimal value)
		{
			return default(decimal);
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static decimal Decrypt(decimal value)
		{
			return default(decimal);
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredDecimal FromEncrypted(decimal encrypted)
		{
			return default(ObscuredDecimal);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public decimal GetEncrypted()
		{
			return default(decimal);
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(decimal encrypted)
		{
		}
	}
}
