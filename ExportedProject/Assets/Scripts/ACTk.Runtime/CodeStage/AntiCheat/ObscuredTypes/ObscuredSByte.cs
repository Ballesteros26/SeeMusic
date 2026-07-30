using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IObscuredType, IFormattable, IEquatable<ObscuredSByte>, IComparable<ObscuredSByte>, IComparable<sbyte>, IComparable
	{
		private sbyte currentCryptoKey;

		private sbyte hiddenValue;

		private bool inited;

		private sbyte fakeValue;

		private bool fakeValueActive;

		private ObscuredSByte(sbyte value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			inited = false;
			fakeValue = 0;
			fakeValueActive = false;
		}

		public static sbyte Encrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		public static sbyte Decrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		public static ObscuredSByte FromEncrypted(sbyte encrypted, sbyte key)
		{
			return default(ObscuredSByte);
		}

		public static sbyte GenerateKey()
		{
			return 0;
		}

		public sbyte GetEncrypted(out sbyte key)
		{
			key = default(sbyte);
			return 0;
		}

		public void SetEncrypted(sbyte encrypted, sbyte key)
		{
		}

		public sbyte GetDecrypted()
		{
			return 0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private sbyte InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredSByte(sbyte value)
		{
			return default(ObscuredSByte);
		}

		public static implicit operator sbyte(ObscuredSByte value)
		{
			return 0;
		}

		public static ObscuredSByte operator ++(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		public static ObscuredSByte operator --(ObscuredSByte input)
		{
			return default(ObscuredSByte);
		}

		private static ObscuredSByte Increment(ObscuredSByte input, int increment)
		{
			return default(ObscuredSByte);
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

		public bool Equals(ObscuredSByte obj)
		{
			return false;
		}

		public int CompareTo(ObscuredSByte other)
		{
			return 0;
		}

		public int CompareTo(sbyte other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(sbyte newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static sbyte EncryptDecrypt(sbyte value)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static sbyte EncryptDecrypt(sbyte value, sbyte key)
		{
			return 0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredSByte FromEncrypted(sbyte encrypted)
		{
			return default(ObscuredSByte);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public sbyte GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(sbyte encrypted)
		{
		}
	}
}
