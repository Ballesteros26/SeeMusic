using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[RequireComponent(typeof(AudioSource))]
	[AddComponentMenu("AVPro Video/Audio Output", 400)]
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	public class AudioOutput : MonoBehaviour
	{
		public enum AudioOutputMode
		{
			OneToAllChannels = 0,
			MultipleChannels = 1
		}

		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[SerializeField]
		private AudioOutputMode _audioOutputMode;

		[SerializeField]
		[HideInInspector]
		private int _channelMask;

		[SerializeField]
		private bool _supportPositionalAudio;

		private AudioSource _audioSource;

		public MediaPlayer Player
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AudioOutputMode OutputMode
		{
			get
			{
				return default(AudioOutputMode);
			}
			set
			{
			}
		}

		public int ChannelMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnAudioConfigurationChanged(bool deviceChanged)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public AudioSource GetAudioSource()
		{
			return null;
		}

		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		private void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}

		private static void ApplyAudioSettings(MediaPlayer player, AudioSource audioSource)
		{
		}

		private void OnAudioFilterRead(float[] audioData, int channelCount)
		{
		}
	}
}
