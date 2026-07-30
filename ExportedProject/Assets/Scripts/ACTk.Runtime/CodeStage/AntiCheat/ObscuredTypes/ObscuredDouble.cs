using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IObscuredType, IFormattable, IEquatable<ObscuredDouble>, IComparable<ObscuredDouble>, IComparable<double>, IComparable
	{
		[StructLayout((LayoutKind)2)]
		private struct DoubleLongBytesUnion
		{
			[FieldOffset(0)]
			internal double d;

			[FieldOffset(0)]
			internal long l;

			[FieldOffset(0)]
			internal ACTkByte8 b8;

			internal static long Migrate(long value, byte fromVersion, byte toVersion)
			{
				return 0L;
			}

			internal static long XorDoubleToLong(double value, long key)
			{
				return 0L;
			}

			internal static double XorLongToDouble(long value, long key)
			{
				return 0.0;
			}

			private static DoubleLongBytesUnion FromDouble(double value)
			{
				return default(DoubleLongBytesUnion);
			}

			private static DoubleLongBytesUnion FromLong(long value)
			{
				return default(DoubleLongBytesUnion);
			}

			private DoubleLongBytesUnion Shuffle(long key)
			{
				return default(DoubleLongBytesUnion);
			}

			private DoubleLongBytesUnion UnShuffle(long key)
			{
				return default(DoubleLongBytesUnion);
			}
		}

		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private ACTkByte8 hiddenValueOldByte8;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private double fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredDouble(double value)
		{
			currentCryptoKey = 0L;
			hiddenValue = 0L;
			hiddenValueOldByte8 = default(ACTkByte8);
			inited = false;
			fakeValue = 0.0;
			fakeValueActive = false;
		}

		public static long Encrypt(double value, long key)
		{
			return 0L;
		}

		public static double Decrypt(long value, long key)
		{
			return 0.0;
		}

		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0, byte toVersion = 2)
		{
			return 0L;
		}

		public static ObscuredDouble FromEncrypted(long encrypted, long key)
		{
			return default(ObscuredDouble);
		}

		public static long GenerateKey()
		{
			return 0L;
		}

		public long GetEncrypted(out long key)
		{
			key = default(long);
			return 0L;
		}

		public void SetEncrypted(long encrypted, long key)
		{
		}

		public double GetDecrypted()
		{
			return 0.0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private double InternalDecrypt()
		{
			return 0.0;
		}

		public static implicit operator ObscuredDouble(double value)
		{
			return default(ObscuredDouble);
		}

		public static implicit operator double(ObscuredDouble value)
		{
			return 0.0;
		}

		public static explicit operator ObscuredDouble(ObscuredFloat f)
		{
			return default(ObscuredDouble);
		}

		public static ObscuredDouble operator ++(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		public static ObscuredDouble operator --(ObscuredDouble input)
		{
			return default(ObscuredDouble);
		}

		private static ObscuredDouble Increment(ObscuredDouble input, double increment)
		{
			return default(ObscuredDouble);
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

		public bool Equals(ObscuredDouble obj)
		{
			return false;
		}

		public int CompareTo(ObscuredDouble other)
		{
			return 0;
		}

		public int CompareTo(double other)
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
		public static long Encrypt(double value)
		{
			return 0L;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static double Decrypt(long value)
		{
			return 0.0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredDouble FromEncrypted(long encrypted)
		{
			return default(ObscuredDouble);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public long GetEncrypted()
		{
			return 0L;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(long encrypted)
		{
		}
	}
}
