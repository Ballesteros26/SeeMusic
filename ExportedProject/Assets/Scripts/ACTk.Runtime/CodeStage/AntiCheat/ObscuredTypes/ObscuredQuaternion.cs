using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredQuaternion : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedQuaternion
		{
			public int x;

			public int y;

			public int z;

			public int w;
		}

		private static readonly Quaternion Identity;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedQuaternion hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Quaternion fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		private ObscuredQuaternion(Quaternion value)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedQuaternion);
			inited = false;
			fakeValue = default(Quaternion);
			fakeValueActive = false;
		}

		public ObscuredQuaternion(float x, float y, float z, float w)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedQuaternion);
			inited = false;
			fakeValue = default(Quaternion);
			fakeValueActive = false;
		}

		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key)
		{
			return default(RawEncryptedQuaternion);
		}

		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key)
		{
			return default(Quaternion);
		}

		public static ObscuredQuaternion FromEncrypted(RawEncryptedQuaternion encrypted, int key)
		{
			return default(ObscuredQuaternion);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		private static bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2)
		{
			return false;
		}

		public RawEncryptedQuaternion GetEncrypted(out int key)
		{
			key = default(int);
			return default(RawEncryptedQuaternion);
		}

		public void SetEncrypted(RawEncryptedQuaternion encrypted, int key)
		{
		}

		public Quaternion GetDecrypted()
		{
			return default(Quaternion);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Quaternion InternalDecrypt()
		{
			return default(Quaternion);
		}

		public static implicit operator ObscuredQuaternion(Quaternion value)
		{
			return default(ObscuredQuaternion);
		}

		public static implicit operator Quaternion(ObscuredQuaternion value)
		{
			return default(Quaternion);
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

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public static void SetNewCryptoKey(int newKey)
		{
		}

		[Obsolete("This API is redundant and does not perform any actions. It will be removed in future updates.")]
		public void ApplyNewCryptoKey()
		{
		}

		[Obsolete("Please use new Encrypt(value, key) API instead.", true)]
		public static RawEncryptedQuaternion Encrypt(Quaternion value)
		{
			return default(RawEncryptedQuaternion);
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static Quaternion Decrypt(RawEncryptedQuaternion value)
		{
			return default(Quaternion);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public RawEncryptedQuaternion GetEncrypted()
		{
			return default(RawEncryptedQuaternion);
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(RawEncryptedQuaternion encrypted)
		{
		}
	}
}
