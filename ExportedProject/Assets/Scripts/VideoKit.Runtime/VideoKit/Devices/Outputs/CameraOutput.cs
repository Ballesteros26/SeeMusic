using System;

namespace VideoKit.Devices.Outputs
{
	public abstract class CameraOutput
	{
		public CameraImage image { get; protected set; }

		public long timestamp => 0L;

		public abstract void Update(CameraImage image);

		public virtual void Dispose()
		{
		}

		public static implicit operator Action<CameraImage>(CameraOutput output)
		{
			return null;
		}
	}
}
