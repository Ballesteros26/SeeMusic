using System.IO;
using UnityEngine;

namespace VideoKit.Devices.Outputs
{
	public sealed class AudioClipOutput : AudioOutput
	{
		private readonly MemoryStream sampleBuffer;

		private readonly object fence;

		private int sampleRate;

		private int channelCount;

		public override void Update(AudioBuffer audioBuffer)
		{
		}

		public override void Dispose()
		{
		}

		public AudioClip ToClip()
		{
			return null;
		}
	}
}
