using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredULong : IObscuredType, IFormattable, IEquatable<ObscuredULong>, IComparable<ObscuredULong>, IComparable<ulong>, IComparable
	{
		[SerializeField]
		private ulong currentCryptoKey;

		[SerializeField]
		private ulong hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private ulong fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredULong(ulong value)
		{
			currentCryptoKey = 0uL;
			hiddenValue = 0uL;
			inited = false;
			fakeValue = 0uL;
			fakeValueActive = false;
		}

		public static ulong Encrypt(ulong value, ulong key)
		{
			return 0uL;
		}

		public static ulong Decrypt(ulong value, ulong key)
		{
			return 0uL;
		}

		public static ObscuredULong FromEncrypted(ulong encrypted, ulong key)
		{
			return default(ObscuredULong);
		}

		public static ulong GenerateKey()
		{
			return 0uL;
		}

		public ulong GetEncrypted(out ulong key)
		{
			key = default(ulong);
			return 0uL;
		}

		public void SetEncrypted(ulong encrypted, ulong key)
		{
		}

		public ulong GetDecrypted()
		{
			return 0uL;
		}

		public void RandomizeCryptoKey()
		{
		}

		private ulong InternalDecrypt()
		{
			return 0uL;
		}

		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		public static implicit operator ulong(ObscuredULong value)
		{
			return 0uL;
		}

		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		private static ObscuredULong Increment(ObscuredULong input, int increment)
		{
			return default(ObscuredULong);
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

		public bool Equals(ObscuredULong obj)
		{
			return false;
		}

		public int CompareTo(ObscuredULong other)
		{
			return 0;
		}

		public int CompareTo(ulong other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static ulong Encrypt(ulong value)
		{
			return 0uL;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static ulong Decrypt(ulong value)
		{
			return 0uL;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredULong FromEncrypted(ulong encrypted)
		{
			return default(ObscuredULong);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public ulong GetEncrypted()
		{
			return 0uL;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(ulong encrypted)
		{
		}
	}
}
