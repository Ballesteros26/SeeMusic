using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace RenderHeads.Media.AVProVideo
{
	[Serializable]
	public class MediaPlayerEvent : UnityEvent<MediaPlayer, MediaPlayerEvent.EventType, ErrorCode>
	{
		public enum EventType
		{
			MetaDataReady = 0,
			ReadyToPlay = 1,
			Started = 2,
			FirstFrameReady = 3,
			FinishedPlaying = 4,
			Closing = 5,
			Error = 6,
			SubtitleChange = 7,
			Stalled = 8,
			Unstalled = 9,
			ResolutionChanged = 10,
			StartedSeeking = 11,
			FinishedSeeking = 12,
			StartedBuffering = 13,
			FinishedBuffering = 14,
			PropertiesChanged = 15,
			PlaylistItemChanged = 16,
			PlaylistFinished = 17,
			TextTracksChanged = 18,
			Paused = 19,
			Unpaused = 20,
			TextCueChanged = 7
		}

		private List<UnityAction<MediaPlayer, EventType, ErrorCode>> _listeners;

		public bool HasListeners()
		{
			return false;
		}

		public new void AddListener(UnityAction<MediaPlayer, EventType, ErrorCode> call)
		{
		}

		public new void RemoveListener(UnityAction<MediaPlayer, EventType, ErrorCode> call)
		{
		}

		public new void RemoveAllListeners()
		{
		}
	}
}
