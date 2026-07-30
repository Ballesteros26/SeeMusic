using System;
using Unity.Collections;

namespace VideoKit.Devices
{
	public readonly struct CameraImage
	{
		public enum Format
		{
			Unknown = 0,
			YCbCr420 = 1,
			RGBA8888 = 2,
			BGRA8888 = 3
		}

		public readonly struct Plane
		{
			public readonly NativeArray<byte> buffer;

			public readonly int width;

			public readonly int height;

			public readonly int rowStride;

			public readonly int pixelStride;

			public Plane(NativeArray<byte> buffer, int width, int height, int rowStride, int pixelStride)
			{
				this.buffer = default(NativeArray<byte>);
				this.width = 0;
				this.height = 0;
				this.rowStride = 0;
				this.pixelStride = 0;
			}
		}

		public readonly CameraDevice device;

		public readonly NativeArray<byte> pixelBuffer;

		public readonly Format format;

		public readonly int width;

		public readonly int height;

		public readonly int rowStride;

		public readonly long timestamp;

		public readonly bool verticallyMirrored;

		public readonly Plane[] planes;

		public readonly float[] intrinsics;

		public readonly float? exposureBias;

		public readonly float? exposureDuration;

		public readonly float? ISO;

		public readonly float? focalLength;

		public readonly float? fNumber;

		public readonly float? brightness;

		internal readonly IntPtr nativeImage;

		public CameraImage Clone()
		{
			return default(CameraImage);
		}

		internal CameraImage(CameraDevice device, IntPtr image)
		{
			this.device = null;
			pixelBuffer = default(NativeArray<byte>);
			format = default(Format);
			width = 0;
			height = 0;
			rowStride = 0;
			timestamp = 0L;
			verticallyMirrored = false;
			planes = null;
			intrinsics = null;
			exposureBias = null;
			exposureDuration = null;
			ISO = null;
			focalLength = null;
			fNumber = null;
			brightness = null;
			nativeImage = (IntPtr)0;
		}

		private CameraImage(CameraDevice device, NativeArray<byte> pixelBuffer, Format format, int width, int height, int rowStride, long timestamp, bool mirrored, Plane[] planes = null, float[] intrinsics = null, float? exposureBias = null, float? exposureDuration = null, float? ISO = null, float? focalLength = null, float? fNumber = null, float? brightness = null, IntPtr nativeImage = default(IntPtr))
		{
			this.device = null;
			this.pixelBuffer = default(NativeArray<byte>);
			this.format = default(Format);
			this.width = 0;
			this.height = 0;
			this.rowStride = 0;
			this.timestamp = 0L;
			verticallyMirrored = false;
			this.planes = null;
			this.intrinsics = null;
			this.exposureBias = null;
			this.exposureDuration = null;
			this.ISO = null;
			this.focalLength = null;
			this.fNumber = null;
			this.brightness = null;
			this.nativeImage = (IntPtr)0;
		}
	}
}
