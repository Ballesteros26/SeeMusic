using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector2Int : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector2Int
		{
			public int x;

			public int y;
		}

		private static readonly Vector2Int Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector2Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector2Int fakeValue;

		[SerializeField]
		private bool fakeValueActive;

		public int x
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int y
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int this[int index]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private ObscuredVector2Int(Vector2Int value)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedVector2Int);
			inited = false;
			fakeValue = default(Vector2Int);
			fakeValueActive = false;
		}

		public ObscuredVector2Int(int x, int y)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedVector2Int);
			inited = false;
			fakeValue = default(Vector2Int);
			fakeValueActive = false;
		}

		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		public static RawEncryptedVector2Int Encrypt(int x, int y, int key)
		{
			return default(RawEncryptedVector2Int);
		}

		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key)
		{
			return default(Vector2Int);
		}

		public static ObscuredVector2Int FromEncrypted(RawEncryptedVector2Int encrypted, int key)
		{
			return default(ObscuredVector2Int);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		public RawEncryptedVector2Int GetEncrypted(out int key)
		{
			key = default(int);
			return default(RawEncryptedVector2Int);
		}

		public void SetEncrypted(RawEncryptedVector2Int encrypted, int key)
		{
		}

		public Vector2Int GetDecrypted()
		{
			return default(Vector2Int);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector2Int InternalDecrypt()
		{
			return default(Vector2Int);
		}

		public static implicit operator ObscuredVector2Int(Vector2Int value)
		{
			return default(ObscuredVector2Int);
		}

		public static implicit operator Vector2Int(ObscuredVector2Int value)
		{
			return default(Vector2Int);
		}

		public static implicit operator Vector2(ObscuredVector2Int value)
		{
			return default(Vector2);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
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
		public static RawEncryptedVector2Int Encrypt(Vector2Int value)
		{
			return default(RawEncryptedVector2Int);
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static Vector2Int Decrypt(RawEncryptedVector2Int value)
		{
			return default(Vector2Int);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public RawEncryptedVector2Int GetEncrypted()
		{
			return default(RawEncryptedVector2Int);
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(RawEncryptedVector2Int encrypted)
		{
		}
	}
}
