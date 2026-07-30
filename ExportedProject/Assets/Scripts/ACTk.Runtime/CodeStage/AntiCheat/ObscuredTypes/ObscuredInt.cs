using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredInt : IObscuredType, IFormattable, IEquatable<ObscuredInt>, IComparable<ObscuredInt>, IComparable<int>, IComparable
	{
		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredInt(int value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			inited = false;
			fakeValue = 0;
			fakeValueActive = false;
		}

		public static int Encrypt(int value, int key)
		{
			return 0;
		}

		public static int Decrypt(int value, int key)
		{
			return 0;
		}

		public static ObscuredInt FromEncrypted(int encrypted, int key)
		{
			return default(ObscuredInt);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		public int GetEncrypted(out int key)
		{
			key = default(int);
			return 0;
		}

		public void SetEncrypted(int encrypted, int key)
		{
		}

		public int GetDecrypted()
		{
			return 0;
		}

		public void RandomizeCryptoKey()
		{
		}

		private int InternalDecrypt()
		{
			return 0;
		}

		public static implicit operator ObscuredInt(int value)
		{
			return default(ObscuredInt);
		}

		public static implicit operator int(ObscuredInt value)
		{
			return 0;
		}

		public static implicit operator ObscuredFloat(ObscuredInt value)
		{
			return default(ObscuredFloat);
		}

		public static implicit operator ObscuredDouble(ObscuredInt value)
		{
			return default(ObscuredDouble);
		}

		public static explicit operator ObscuredUInt(ObscuredInt value)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredInt operator ++(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		public static ObscuredInt operator --(ObscuredInt input)
		{
			return default(ObscuredInt);
		}

		private static ObscuredInt Increment(ObscuredInt input, int increment)
		{
			return default(ObscuredInt);
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

		public bool Equals(ObscuredInt obj)
		{
			return false;
		}

		public int CompareTo(ObscuredInt other)
		{
			return 0;
		}

		public int CompareTo(int other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static int Encrypt(int value)
		{
			return 0;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static int Decrypt(int value)
		{
			return 0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredInt FromEncrypted(int encrypted)
		{
			return default(ObscuredInt);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public int GetEncrypted()
		{
			return 0;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(int encrypted)
		{
		}
	}
}
