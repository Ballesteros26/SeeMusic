using System;

namespace VideoKit.Devices.Outputs
{
	public abstract class AudioOutput
	{
		public AudioBuffer buffer { get; protected set; }

		public long timestamp => 0L;

		public abstract void Update(AudioBuffer audioBuffer);

		public virtual void Dispose()
		{
		}

		public static implicit operator Action<AudioBuffer>(AudioOutput output)
		{
			return null;
		}
	}
}
