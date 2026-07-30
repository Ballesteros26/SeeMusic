using System;
using Unity.Collections;

namespace VideoKit.Devices
{
	public readonly struct AudioBuffer
	{
		public readonly AudioDevice device;

		public readonly NativeArray<float> sampleBuffer;

		public readonly int sampleRate;

		public readonly int channelCount;

		public readonly long timestamp;

		internal readonly IntPtr nativeBuffer;

		public AudioBuffer Clone()
		{
			return default(AudioBuffer);
		}

		internal AudioBuffer(AudioDevice device, IntPtr audioBuffer)
		{
			this.device = null;
			sampleBuffer = default(NativeArray<float>);
			sampleRate = 0;
			channelCount = 0;
			timestamp = 0L;
			nativeBuffer = (IntPtr)0;
		}

		private AudioBuffer(AudioDevice device, NativeArray<float> sampleBuffer, int sampleRate, int channelCount, long timestamp)
		{
			this.device = null;
			this.sampleBuffer = default(NativeArray<float>);
			this.sampleRate = 0;
			this.channelCount = 0;
			this.timestamp = 0L;
			nativeBuffer = (IntPtr)0;
		}

		private unsafe static NativeArray<float> Wrap(float* buffer, int size)
		{
			return default(NativeArray<float>);
		}

		private static NativeArray<float> Wrap(float[] buffer)
		{
			return default(NativeArray<float>);
		}
	}
}
