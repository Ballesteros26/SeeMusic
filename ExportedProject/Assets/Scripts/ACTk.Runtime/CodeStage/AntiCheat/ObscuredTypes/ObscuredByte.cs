using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredByte : IObscuredType, IFormattable, IEquatable<ObscuredByte>, IComparable<ObscuredByte>, IComparable<byte>, IComparable
	{
		private byte currentCryptoKey;

		private byte hiddenValue;

		private bool inited;

		private byte fakeValue;

		private bool fakeValueActive;

		private ObscuredByte(byte value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			inited = false;
			fakeValue = 0;
			fakeValueActive = false;
		}

		public static byte Encrypt(byte value, byte key)
		{
			return 0;
		}

		public static void Encrypt(byte[] value, byte key)
		{
		}

		public static byte Decrypt(byte value, byte key)
		{
			return 0;
		}

		public static void Decrypt(byte[] value, byte key)
		{
		}

		public static ObscuredByte FromEncrypted(byte encrypted, byte key)
		{
			return default(ObscuredByte);
		}

		public static byte GenerateKey()
		{
			return 0;
		}

		public byte GetEncrypted(out byte key)
		{
			key = default(byte);
			return 0;
		}

		public void SetEncrypted(byte encrypted, byte key)
		{
		}

		public byte GetDecrypted()
		{
			return 0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private byte InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredByte(byte value)
		{
			return default(ObscuredByte);
		}

		public static implicit operator byte(ObscuredByte value)
		{
			return 0;
		}

		public static ObscuredByte operator ++(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		public static ObscuredByte operator --(ObscuredByte input)
		{
			return default(ObscuredByte);
		}

		private static ObscuredByte Increment(ObscuredByte input, int increment)
		{
			return default(ObscuredByte);
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

		public bool Equals(ObscuredByte obj)
		{
			return false;
		}

		public int CompareTo(ObscuredByte other)
		{
			return 0;
		}

		public int CompareTo(byte other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(byte newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static byte EncryptDecrypt(byte value)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static byte EncryptDecrypt(byte[] value)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static byte EncryptDecrypt(byte value, byte key)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static void EncryptDecrypt(byte[] value, byte key)
		{
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredByte FromEncrypted(byte encrypted)
		{
			return default(ObscuredByte);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public byte GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(byte encrypted)
		{
		}
	}
}
