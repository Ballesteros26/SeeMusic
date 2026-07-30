using UnityEngine;

namespace RenderHeads.Media.AVProVideo
{
	[HelpURL("https://www.renderheads.com/products/avpro-video/")]
	[AddComponentMenu("AVPro Video/Audio Channel Mixer", 401)]
	public class AudioChannelMixer : MonoBehaviour
	{
		private const int MaxChannels = 8;

		[SerializeField]
		[Range(0f, 1f)]
		private float[] _channels;

		public float[] Channel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Reset()
		{
		}

		private void ChangeChannelCount(int numChannels)
		{
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
		}
	}
}
