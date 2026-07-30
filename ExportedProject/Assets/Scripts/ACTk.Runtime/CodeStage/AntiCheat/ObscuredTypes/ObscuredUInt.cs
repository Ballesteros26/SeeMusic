using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUInt : IObscuredType, IFormattable, IEquatable<ObscuredUInt>, IComparable<ObscuredUInt>, IComparable<uint>, IComparable
	{
		[SerializeField]
		private uint currentCryptoKey;

		[SerializeField]
		private uint hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private uint fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredUInt(uint value)
		{
			currentCryptoKey = 0u;
			hiddenValue = 0u;
			inited = false;
			fakeValue = 0u;
			fakeValueActive = false;
		}

		public static uint Encrypt(uint value, uint key)
		{
			return 0u;
		}

		public static uint Decrypt(uint value, uint key)
		{
			return 0u;
		}

		public static ObscuredUInt FromEncrypted(uint encrypted, uint key)
		{
			return default(ObscuredUInt);
		}

		public static uint GenerateKey()
		{
			return 0u;
		}

		public uint GetEncrypted(out uint key)
		{
			key = default(uint);
			return 0u;
		}

		public void SetEncrypted(uint encrypted, uint key)
		{
		}

		public uint GetDecrypted()
		{
			return 0u;
		}

		public void RandomizeCryptoKey()
		{
		}

		private uint InternalDecrypt()
		{
			return 0u;
		}

		public static implicit operator ObscuredUInt(uint value)
		{
			return default(ObscuredUInt);
		}

		public static implicit operator uint(ObscuredUInt value)
		{
			return 0u;
		}

		public static explicit operator ObscuredInt(ObscuredUInt value)
		{
			return default(ObscuredInt);
		}

		public static ObscuredUInt operator ++(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		public static ObscuredUInt operator --(ObscuredUInt input)
		{
			return default(ObscuredUInt);
		}

		private static ObscuredUInt Increment(ObscuredUInt input, int increment)
		{
			return default(ObscuredUInt);
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

		public bool Equals(ObscuredUInt obj)
		{
			return false;
		}

		public int CompareTo(ObscuredUInt other)
		{
			return 0;
		}

		public int CompareTo(uint other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(uint newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static int Encrypt(uint value)
		{
			return 0;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static int Decrypt(uint value)
		{
			return 0;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredUInt FromEncrypted(uint encrypted)
		{
			return default(ObscuredUInt);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public uint GetEncrypted()
		{
			return 0u;
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(uint encrypted)
		{
		}
	}
}
