using System;
using UnityEngine;
using VideoKit.Recorders.Clocks;

namespace VideoKit.Recorders.Inputs
{
	public sealed class AudioInput : IDisposable
	{
		private class AudioInputAttachment : MonoBehaviour
		{
			public Action<float[]> sampleBufferDelegate;

			private void OnAudioFilterRead(float[] data, int channels)
			{
			}
		}

		private readonly MediaRecorder recorder;

		private readonly IClock clock;

		private readonly AudioInputAttachment attachment;

		public AudioInput(MediaRecorder recorder, IClock clock, AudioListener listener)
		{
		}

		public AudioInput(MediaRecorder recorder, AudioListener listener)
		{
		}

		public AudioInput(MediaRecorder recorder, IClock clock, AudioSource source)
		{
		}

		public AudioInput(MediaRecorder recorder, AudioSource source)
		{
		}

		public void Dispose()
		{
		}

		private AudioInput(MediaRecorder recorder, IClock clock, GameObject gameObject)
		{
		}

		private void OnSampleBuffer(float[] data)
		{
		}
	}
}
