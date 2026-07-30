using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using VideoKit.Utilities;

namespace VideoKit.Devices.Outputs
{
	public sealed class PixelBufferOutput : CameraOutput
	{
		public class ConversionOptions
		{
			public ScreenOrientation orientation;

			public bool mirror;
		}

		public ScreenOrientation orientation;

		internal readonly LifecycleHelper lifecycleHelper;

		private readonly object fence;

		private NativeArray<byte> convertedBuffer;

		private NativeArray<byte> tempBuffer;

		private static readonly List<RuntimePlatform> OrientationSupport;

		public NativeArray<byte> pixelBuffer => default(NativeArray<byte>);

		public int width { get; private set; }

		public int height { get; private set; }

		public override void Update(CameraImage image)
		{
		}

		public void Update(CameraImage image, ConversionOptions options)
		{
		}

		public override void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void EnsureCapacity(ref NativeArray<byte> buffer, int capacity)
		{
		}
	}
}
