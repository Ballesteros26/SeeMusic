namespace RenderHeads.Media.AVProVideo
{
	public class PlaybackQualityStats
	{
		private int _sameFrameCount;

		private long _lastTimeStamp;

		private BaseMediaPlayer _player;

		public int SkippedFrames { get; private set; }

		public int DuplicateFrames { get; private set; }

		public int UnityDroppedFrames { get; private set; }

		public float PerfectFramesT { get; private set; }

		public string VSyncStatus { get; private set; }

		private int PerfectFrames { get; set; }

		private int TotalFrames { get; set; }

		public bool LogIssues { get; set; }

		public void Reset()
		{
		}

		internal void Start(BaseMediaPlayer player)
		{
		}

		internal void Update()
		{
		}

		private static bool IsGameViewVSyncEnabled()
		{
			return false;
		}
	}
}
