using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredVector3Int : IObscuredType
	{
		[Serializable]
		public struct RawEncryptedVector3Int
		{
			public int x;

			public int y;

			public int z;
		}

		private static readonly Vector3Int Zero;

		[SerializeField]
		private int currentCryptoKey;

		[SerializeField]
		private RawEncryptedVector3Int hiddenValue;

		[SerializeField]
		private bool inited;

		[SerializeField]
		private Vector3Int fakeValue;

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

		public int z
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

		private ObscuredVector3Int(Vector3Int value)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedVector3Int);
			inited = false;
			fakeValue = default(Vector3Int);
			fakeValueActive = false;
		}

		public ObscuredVector3Int(int x, int y, int z)
		{
			currentCryptoKey = 0;
			hiddenValue = default(RawEncryptedVector3Int);
			inited = false;
			fakeValue = default(Vector3Int);
			fakeValueActive = false;
		}

		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key)
		{
			return default(RawEncryptedVector3Int);
		}

		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key)
		{
			return default(Vector3Int);
		}

		public static ObscuredVector3Int FromEncrypted(RawEncryptedVector3Int encrypted, int key)
		{
			return default(ObscuredVector3Int);
		}

		public static int GenerateKey()
		{
			return 0;
		}

		public RawEncryptedVector3Int GetEncrypted(out int key)
		{
			key = default(int);
			return default(RawEncryptedVector3Int);
		}

		public void SetEncrypted(RawEncryptedVector3Int encrypted, int key)
		{
		}

		public Vector3Int GetDecrypted()
		{
			return default(Vector3Int);
		}

		public void RandomizeCryptoKey()
		{
		}

		private Vector3Int InternalDecrypt()
		{
			return default(Vector3Int);
		}

		public static implicit operator ObscuredVector3Int(Vector3Int value)
		{
			return default(ObscuredVector3Int);
		}

		public static implicit operator Vector3Int(ObscuredVector3Int value)
		{
			return default(Vector3Int);
		}

		public static implicit operator Vector3(ObscuredVector3Int value)
		{
			return default(Vector3);
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b)
		{
			return default(ObscuredVector3Int);
		}

		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d)
		{
			return default(ObscuredVector3Int);
		}

		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs)
		{
			return false;
		}

		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs)
		{
			return false;
		}

		public override bool Equals(object other)
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
		public static RawEncryptedVector3Int Encrypt(Vector3Int value)
		{
			return default(RawEncryptedVector3Int);
		}

		[Obsolete("Please use new Decrypt(value, key) API instead.", true)]
		public static Vector3Int Decrypt(RawEncryptedVector3Int value)
		{
			return default(Vector3Int);
		}

		[Obsolete("Please use new GetEncrypted(out key) API instead.", true)]
		public RawEncryptedVector3Int GetEncrypted()
		{
			return default(RawEncryptedVector3Int);
		}

		[Obsolete("Please use new SetEncrypted(encrypted, key) API instead.", true)]
		public void SetEncrypted(RawEncryptedVector3Int encrypted)
		{
		}
	}
}
