using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public class KeyAuthData : ISerializationCallbackReceiver
	{
		public string keyServerToken;

		[Multiline]
		[SerializeField]
		private string overrideDecryptionKeyBase64;

		public byte[] overrideDecryptionKey;

		public bool IsModified()
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
