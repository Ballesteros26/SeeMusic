using System;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	[CreateAssetMenu(fileName = "MediaReference", menuName = "AVPro Video/Media Reference", order = 51)]
	public class MediaReference : ScriptableObject
	{
		[SerializeField]
		private string _alias;

		[SerializeField]
		private MediaPath _mediaPath;

		[Header("Media Hints")]
		[SerializeField]
		private MediaHints _hints;

		[SerializeField]
		[Header("Platform Overrides")]
		private MediaReference _macOS;

		[SerializeField]
		private MediaReference _windows;

		[SerializeField]
		private MediaReference _android;

		[SerializeField]
		private MediaReference _iOS;

		[SerializeField]
		private MediaReference _tvOS;

		[SerializeField]
		private MediaReference _windowsUWP;

		[SerializeField]
		private MediaReference _webGL;

		public string Alias
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MediaPath MediaPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MediaHints Hints
		{
			get
			{
				return default(MediaHints);
			}
			set
			{
			}
		}

		public MediaReference GetCurrentPlatformMediaReference()
		{
			return null;
		}

		public MediaReference GetPlatformMediaReference(Platform platform)
		{
			return null;
		}
	}
}
