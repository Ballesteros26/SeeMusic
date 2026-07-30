using UnityEngine;
using UnityEngine.UI;

namespace RenderHeads.Media.AVProVideo
{
	[HelpURL("http://renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Subtitles uGUI", 201)]
	public class SubtitlesUGUI : MonoBehaviour
	{
		[SerializeField]
		private MediaPlayer _mediaPlayer;

		[SerializeField]
		private Text _text;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private int _backgroundHorizontalPadding;

		[SerializeField]
		private int _backgroundVerticalPadding;

		[Range(-1f, 1024f)]
		[SerializeField]
		private int _maxCharacters;

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

		public Text Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void ChangeMediaPlayer(MediaPlayer newPlayer)
		{
		}

		private void SetText(string text)
		{
		}

		private string PrepareText(string text)
		{
			return null;
		}

		private void UpdateBackgroundRect()
		{
		}

		private void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}
	}
}
