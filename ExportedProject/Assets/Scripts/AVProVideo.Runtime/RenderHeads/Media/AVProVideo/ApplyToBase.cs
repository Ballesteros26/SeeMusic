using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	public abstract class ApplyToBase : MonoBehaviour
	{
		[SerializeField]
		[Header("Media Source")]
		[Space(8f)]
		protected MediaPlayer _media;

		[Space(8f)]
		[SerializeField]
		[Header("Display")]
		private bool _automaticStereoPacking;

		[SerializeField]
		private StereoPacking _overrideStereoPacking;

		[SerializeField]
		private bool _stereoRedGreenTint;

		protected bool _isDirty;

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

		public bool AutomaticStereoPacking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public StereoPacking OverrideStereoPacking
		{
			get
			{
				return default(StereoPacking);
			}
			set
			{
			}
		}

		public bool StereoRedGreenTint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void ChangeMediaPlayer(MediaPlayer player, bool force = false)
		{
		}

		private void OnMediaPlayerEvent(MediaPlayer mp, MediaPlayerEvent.EventType et, ErrorCode errorCode)
		{
		}

		public void ForceUpdate()
		{
		}

		private void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void SaveProperties()
		{
		}

		protected virtual void RestoreProperties()
		{
		}

		public abstract void Apply();
	}
}
