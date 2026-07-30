using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredShort : IObscuredType, IFormattable, IEquatable<ObscuredShort>, IComparable<ObscuredShort>, IComparable<short>, IComparable
	{
		[SerializeField]
		private short currentCryptoKey;

		[SerializeField]
		private short hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private short fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredShort(short value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			inited = false;
			fakeValue = 0;
			fakeValueActive = false;
		}

		public static short Encrypt(short value, short key)
		{
			return 0;
		}

		public static short Decrypt(short value, short key)
		{
			return 0;
		}

		public static ObscuredShort FromEncrypted(short encrypted, short key)
		{
			return default(ObscuredShort);
		}

		public static short GenerateKey()
		{
			return 0;
		}

		public short GetEncrypted(out short key)
		{
			key = default(short);
			return 0;
		}

		public void SetEncrypted(short encrypted, short key)
		{
		}

		public short GetDecrypted()
		{
			return 0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private short InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredShort(short value)
		{
			return default(ObscuredShort);
		}

		public static implicit operator short(ObscuredShort value)
		{
			return 0;
		}

		public static ObscuredShort operator ++(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		public static ObscuredShort operator --(ObscuredShort input)
		{
			return default(ObscuredShort);
		}

		private static ObscuredShort Increment(ObscuredShort input, int increment)
		{
			return default(ObscuredShort);
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

		public bool Equals(ObscuredShort obj)
		{
			return false;
		}

		public int CompareTo(ObscuredShort other)
		{
			return 0;
		}

		public int CompareTo(short other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(short newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static short EncryptDecrypt(short value)
		{
			return 0;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static short EncryptDecrypt(short value, short key)
		{
			return 0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredShort FromEncrypted(short encrypted)
		{
			return default(ObscuredShort);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public short GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(short encrypted)
		{
		}
	}
}
