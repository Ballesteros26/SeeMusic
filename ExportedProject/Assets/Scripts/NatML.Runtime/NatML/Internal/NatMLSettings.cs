using System;
using UnityEngine;

namespace NatML.Internal
{
	[DefaultExecutionOrder(int.MinValue)]
	internal sealed class NatMLSettings : ScriptableObject
	{
		[Serializable]
		internal class Embed
		{
			public string fingerprint;

			public byte[] data;
		}

		[HideInInspector]
		[SerializeField]
		internal string accessKey;

		[HideInInspector]
		[SerializeField]
		internal Embed[] embeds;

		internal static NatMLSettings Instance;

		private void OnEnable()
		{
		}
	}
}
