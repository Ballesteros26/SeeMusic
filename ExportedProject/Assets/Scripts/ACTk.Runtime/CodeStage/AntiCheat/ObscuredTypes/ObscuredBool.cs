using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IObscuredType, IEquatable<ObscuredBool>, IComparable<ObscuredBool>, IComparable<bool>, IComparable
	{
		[SerializeField]
		private byte currentCryptoKey;

		[SerializeField]
		private int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private bool fakeValue;

		[FormerlySerializedAs("fakeValueChanged")]
		[SerializeField]
		private bool fakeValueActive;

		private ObscuredBool(bool value)
		{
			currentCryptoKey = 0;
			hiddenValue = 0;
			inited = false;
			fakeValue = false;
			fakeValueActive = false;
		}

		public static int Encrypt(bool value, byte key)
		{
			return 0;
		}

		public static bool Decrypt(int value, byte key)
		{
			return false;
		}

		public static ObscuredBool FromEncrypted(int encrypted, byte key)
		{
			return default(ObscuredBool);
		}

		public static byte GenerateKey()
		{
			return 0;
		}

		public int GetEncrypted(out byte key)
		{
			key = default(byte);
			return 0;
		}

		public void SetEncrypted(int encrypted, byte key)
		{
		}

		public bool GetDecrypted()
		{
			return false;
		}

		public void RandomizeCryptoKey()
		{
		}

		private bool InternalDecrypt()
		{
			return false;
		}

		public static implicit operator ObscuredBool(bool value)
		{
			return default(ObscuredBool);
		}

		public static implicit operator bool(ObscuredBool value)
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

		public bool Equals(ObscuredBool obj)
		{
			return false;
		}

		public int CompareTo(ObscuredBool other)
		{
			return 0;
		}

		public int CompareTo(bool other)
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

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static int Encrypt(bool value)
		{
			return 0;
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static bool Decrypt(int value)
		{
			return false;
		}

		[Obsolete("Please use new FromEncrypted(encrypted, key) API instead.", true)]
		public static ObscuredBool FromEncrypted(int encrypted)
		{
			return default(ObscuredBool);
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
