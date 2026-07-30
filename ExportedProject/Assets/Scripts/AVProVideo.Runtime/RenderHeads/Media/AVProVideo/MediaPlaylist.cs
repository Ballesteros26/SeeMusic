using System;
using System.Collections.Generic;
using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public class MediaPlaylist
	{
		[Serializable]
		public class MediaItem
		{
			public enum SourceType
			{
				AVProVideoPlayer = 0
			}

			[SerializeField]
			public string name;

			[SerializeField]
			public SourceType sourceType;

			[SerializeField]
			public MediaPath mediaPath;

			[SerializeField]
			public Texture2D texture;

			[SerializeField]
			public float textureDuration;

			[SerializeField]
			public bool loop;

			[SerializeField]
			public PlaylistMediaPlayer.StartMode startMode;

			[SerializeField]
			public PlaylistMediaPlayer.ProgressMode progressMode;

			[SerializeField]
			public float progressTimeSeconds;

			[SerializeField]
			public bool isOverrideTransition;

			[SerializeField]
			public PlaylistMediaPlayer.Transition overrideTransition;

			[SerializeField]
			public float overrideTransitionDuration;

			[SerializeField]
			public PlaylistMediaPlayer.Easing.Preset overrideTransitionEasing;
		}

		[SerializeField]
		private List<MediaItem> _items;

		public List<MediaItem> Items => null;

		public bool HasItemAt(int index)
		{
			return false;
		}
	}
}
