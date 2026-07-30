using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using VideoKit.Devices;
using VideoKit.Recorders.Clocks;
using VideoKit.Utilities;

namespace VideoKit.Recorders.Inputs
{
	internal sealed class AudioMixerInput : IDisposable
	{
		private class AudioMixerInputAttachment : MonoBehaviour
		{
			public event Action<float[]> OnSampleBuffer
			{
				[CompilerGenerated]
				add
				{
				}
				[CompilerGenerated]
				remove
				{
				}
			}

			private void OnAudioFilterRead(float[] data, int channels)
			{
			}
		}

		public float audioDeviceGain;

		private readonly MediaRecorder recorder;

		private readonly IClock clock;

		private readonly VideoKitAudioManager audioManager;

		private readonly AudioMixerInputAttachment attachment;

		private readonly RingBuffer<float> deviceRingBuffer;

		private readonly RingBuffer<float> unityRingBuffer;

		private readonly float[] deviceSampleBuffer;

		private readonly float[] unitySampleBuffer;

		private readonly float[] mixedBuffer;

		private readonly SharedSignal signal;

		private readonly object deviceFence;

		private readonly object unityFence;

		private const int RingBufferSize = 16384;

		private const int MixBufferSize = 1024;

		public AudioMixerInput(MediaRecorder recorder, IClock clock, VideoKitAudioManager audioManager, AudioListener audioListener)
		{
		}

		public AudioMixerInput(MediaRecorder recorder, VideoKitAudioManager audioManager, AudioListener audioListener)
		{
		}

		public void Dispose()
		{
		}

		private void ClearBuffers()
		{
		}

		private void MixBuffers()
		{
		}

		private void OnDeviceSampleBuffer(AudioBuffer audioBuffer)
		{
		}

		private void OnUnitySampleBuffer(float[] sampleBuffer)
		{
		}

		private void Mix(float[] srcA, float[] srcB, float[] dst)
		{
		}
	}
}
