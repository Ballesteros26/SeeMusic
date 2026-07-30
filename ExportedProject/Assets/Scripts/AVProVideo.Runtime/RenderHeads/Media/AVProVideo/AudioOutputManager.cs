using System.Collections.Generic;

namespace RenderHeads.Media.AVProVideo
{
	public class AudioOutputManager
	{
		protected class PlayerInstance
		{
			public HashSet<AudioOutput> outputs;

			public float[] pcmData;

			public bool isPcmDataReady;
		}

		private static AudioOutputManager _instance;

		private Dictionary<MediaPlayer, PlayerInstance> _instances;

		public static AudioOutputManager Instance => null;

		private AudioOutputManager()
		{
		}

		public void RequestAudio(AudioOutput outputComponent, MediaPlayer mediaPlayer, float[] audioData, int audioChannelCount, int channelMask, AudioOutput.AudioOutputMode audioOutputMode, bool supportPositionalAudio)
		{
		}

		private void ZeroAudio(float[] audioData, int startPosition)
		{
		}

		private bool GrabAudio(MediaPlayer player, float[] audioData, int channelCount)
		{
			return false;
		}
	}
}
