using System;
using VideoKit.Devices;
using VideoKit.Recorders.Clocks;

namespace VideoKit.Recorders.Inputs
{
	public sealed class AudioDeviceInput : IDisposable
	{
		private readonly MediaRecorder recorder;

		private readonly IClock clock;

		private readonly VideoKitAudioManager audioManager;

		public AudioDeviceInput(MediaRecorder recorder, IClock clock, VideoKitAudioManager audioManager)
		{
		}

		public AudioDeviceInput(MediaRecorder recorder, VideoKitAudioManager audioManager)
		{
		}

		public void Dispose()
		{
		}

		private void OnAudioBuffer(AudioBuffer audioBuffer)
		{
		}
	}
}
