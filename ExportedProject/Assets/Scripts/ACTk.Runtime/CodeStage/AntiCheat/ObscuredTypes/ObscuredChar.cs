using System;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredChar : IObscuredType, IEquatable<ObscuredChar>, IComparable<ObscuredChar>, IComparable<char>, IComparable
	{
		private char currentCryptoKey;

		private char hiddenValue;

		private bool inited;

		private char fakeValue;

		private bool fakeValueActive;

		private ObscuredChar(char value)
		{
			currentCryptoKey = '\0';
			hiddenValue = '\0';
			inited = false;
			fakeValue = '\0';
			fakeValueActive = false;
		}

		public static char Encrypt(char value, char key)
		{
			return '\0';
		}

		public static char Decrypt(char value, char key)
		{
			return '\0';
		}

		public static ObscuredChar FromEncrypted(char encrypted, char key)
		{
			return default(ObscuredChar);
		}

		public static char GenerateKey()
		{
			return '\0';
		}

		public char GetEncrypted(out char key)
		{
			key = default(char);
			return '\0';
		}

		public void SetEncrypted(char encrypted, char key)
		{
		}

		public char GetDecrypted()
		{
			return '\0';
		}

		public void RandomizeCryptoKey()
		{
		}

		private char InternalDecrypt()
		{
			return '\0';
		}

		public static implicit operator ObscuredChar(char value)
		{
			return default(ObscuredChar);
		}

		public static implicit operator char(ObscuredChar value)
		{
			return '\0';
		}

		public static ObscuredChar operator ++(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		public static ObscuredChar operator --(ObscuredChar input)
		{
			return default(ObscuredChar);
		}

		private static ObscuredChar Increment(ObscuredChar input, int increment)
		{
			return default(ObscuredChar);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredChar obj)
		{
			return false;
		}

		public int CompareTo(ObscuredChar other)
		{
			return 0;
		}

		public int CompareTo(char other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(char newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static char EncryptDecrypt(char value)
		{
			return '\0';
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static char EncryptDecrypt(char value, char key)
		{
			return '\0';
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredChar FromEncrypted(char encrypted)
		{
			return default(ObscuredChar);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public char GetEncrypted()
		{
			return '\0';
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(char encrypted)
		{
		}
	}
}
