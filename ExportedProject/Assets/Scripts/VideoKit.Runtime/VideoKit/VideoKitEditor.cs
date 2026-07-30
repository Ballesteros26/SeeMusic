using System;
using UnityEngine;

namespace VideoKit
{
	[DisallowMultipleComponent]
	[HelpURL("https://docs.videokit.ai/videokit/api/videokiteditor")]
	[AddComponentMenu(null)]
	[Tooltip("VideoKit editor for editing videos.")]
	internal sealed class VideoKitEditor : MonoBehaviour
	{
		[Flags]
		public enum Capabilities
		{
			Captions = 1
		}

		public bool autoPlay;

		public bool mute;
	}
}
