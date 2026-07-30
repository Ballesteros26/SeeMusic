using UnityEngine;

namespace RenderHeads.Media.AVProMovieCapture
{
	public class CaptureAudioFromAudioClip : MonoBehaviour
	{
		[SerializeField]
		private CaptureBase _capture;

		[SerializeField]
		public AudioClip _audioClip;

		private int _videoOffsetInSamples;

		private int _committedFrames;

		private int __committedSamples;

		private int _last_committedSample;

		private float[] _frameBuffer;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void CommitSamples(float[] samples)
		{
		}
	}
}
