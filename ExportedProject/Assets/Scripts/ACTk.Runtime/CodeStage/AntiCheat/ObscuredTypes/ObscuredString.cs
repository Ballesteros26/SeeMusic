using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public sealed class ObscuredString : IObscuredType, IComparable<ObscuredString>, IComparable<string>, IComparable
	{
		[SerializeField]
		private string currentCryptoKey;

		[SerializeField]
		private byte[] hiddenValue;

		[SerializeField]
		private char[] cryptoKey;

		[SerializeField]
		private char[] hiddenChars;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private string fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int Length => 0;

		public char this[int index] => '\0';

		private ObscuredString()
		{
		}

		private ObscuredString(string value)
		{
		}

		public static char[] Encrypt(string value, string key)
		{
			return null;
		}

		public static char[] Encrypt(string value, char[] key)
		{
			return null;
		}

		public static char[] Encrypt(char[] value, char[] key)
		{
			return null;
		}

		public static string Decrypt(char[] value, string key)
		{
			return null;
		}

		public static string Decrypt(char[] value, char[] key)
		{
			return null;
		}

		public static ObscuredString FromEncrypted(char[] encrypted, char[] key)
		{
			return null;
		}

		[Obsolete("Use this only to decrypt data encrypted with previous ACTk versions. Please use FromEncrypted(char[], char[]) in other cases.")]
		public static ObscuredString FromEncrypted(string encrypted, string key = "4441")
		{
			return null;
		}

		public static char[] GenerateKey()
		{
			return null;
		}

		public static void GenerateKey(ref char[] arrayToFill)
		{
		}

		[Obsolete("Please use version with ref argument or without arguments instead.")]
		public static char[] GenerateKey(char[] arrayToFill)
		{
			return null;
		}

		internal static char[] InternalEncryptDecrypt(char[] value, char[] key)
		{
			return null;
		}

		internal static string EncryptDecryptObsolete(string value, string key)
		{
			return null;
		}

		public char[] GetEncrypted(out char[] key)
		{
			key = null;
			return null;
		}

		public void SetEncrypted(char[] encrypted, char[] key)
		{
		}

		[Obsolete("Use this only to decrypt data encrypted with previous ACTk versions. Please use SetEncrypted(char[], char[]) in other cases.")]
		public void SetEncrypted(string encrypted, string key)
		{
		}

		public string GetDecrypted()
		{
			return null;
		}

		public char[] GetDecryptedToChars()
		{
			return null;
		}

		public void RandomizeCryptoKey()
		{
		}

		private string InternalDecryptToString()
		{
			return null;
		}

		private char[] InternalDecrypt()
		{
			return null;
		}

		private bool CompareCharsToString(char[] chars, string s)
		{
			return false;
		}

		internal void MigrateFromACTkV1()
		{
		}

		public static implicit operator ObscuredString(string value)
		{
			return null;
		}

		public static implicit operator string(ObscuredString value)
		{
			return null;
		}

		public static bool operator ==(ObscuredString a, ObscuredString b)
		{
			return false;
		}

		public static bool operator !=(ObscuredString a, ObscuredString b)
		{
			return false;
		}

		public string Substring(int startIndex)
		{
			return null;
		}

		public string Substring(int startIndex, int length)
		{
			return null;
		}

		public bool StartsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture)
		{
			return false;
		}

		public bool EndsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredString value)
		{
			return false;
		}

		public bool Equals(ObscuredString value, StringComparison comparisonType)
		{
			return false;
		}

		public int CompareTo(ObscuredString other)
		{
			return 0;
		}

		public int CompareTo(string other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(string newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) API instead.", true)]
		public static string EncryptDecrypt(string value)
		{
			return null;
		}

		[Obsolete("Please use new Encrypt(value, key) or Decrypt(value, key) APIs instead. This API will be removed in future updates.")]
		public static string EncryptDecrypt(string value, string key)
		{
			return null;
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public string GetEncrypted()
		{
			return null;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(string encrypted)
		{
		}

		internal static string GetStringObsolete(byte[] bytes)
		{
			return null;
		}

		internal static byte[] GetBytesObsolete(string str)
		{
			return null;
		}

		private static bool ArraysEquals(char[] a1, char[] a2)
		{
			return false;
		}
	}
}
