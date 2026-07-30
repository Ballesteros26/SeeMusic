using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IObscuredType, IFormattable, IEquatable<ObscuredLong>, IComparable<ObscuredLong>, IComparable<long>, IComparable
	{
		[SerializeField]
		private long currentCryptoKey;

		[SerializeField]
		private long hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private long fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredLong(long value)
		{
			currentCryptoKey = 0L;
			hiddenValue = 0L;
			inited = false;
			fakeValue = 0L;
			fakeValueActive = false;
		}

		public static long Encrypt(long value, long key)
		{
			return 0L;
		}

		public static long Decrypt(long value, long key)
		{
			return 0L;
		}

		public static ObscuredLong FromEncrypted(long encrypted, long key)
		{
			return default(ObscuredLong);
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

		public long GetDecrypted()
		{
			return 0L;
		}

		public void RandomizeCryptoKey()
		{
		}

		private long InternalDecrypt()
		{
			return 0L;
		}

		public static implicit operator ObscuredLong(long value)
		{
			return default(ObscuredLong);
		}

		public static implicit operator long(ObscuredLong value)
		{
			return 0L;
		}

		public static ObscuredLong operator ++(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		public static ObscuredLong operator --(ObscuredLong input)
		{
			return default(ObscuredLong);
		}

		private static ObscuredLong Increment(ObscuredLong input, int increment)
		{
			return default(ObscuredLong);
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

		public bool Equals(ObscuredLong obj)
		{
			return false;
		}

		public int CompareTo(ObscuredLong other)
		{
			return 0;
		}

		public int CompareTo(long other)
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
		public static long Encrypt(long value)
		{
			return 0L;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static long Decrypt(long value)
		{
			return 0L;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredLong FromEncrypted(long encrypted)
		{
			return default(ObscuredLong);
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
