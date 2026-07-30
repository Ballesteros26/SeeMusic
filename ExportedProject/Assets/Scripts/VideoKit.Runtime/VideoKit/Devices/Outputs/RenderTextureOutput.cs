using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using VideoKit.Utilities;

namespace VideoKit.Devices.Outputs
{
	public sealed class RenderTextureOutput : CameraOutput
	{
		public sealed class ConversionOptions : PixelBufferOutput.ConversionOptions
		{
		}

		private struct ImageBuffer
		{
			public CameraImage image;

			public byte[] pixelBuffer;

			public bool mirror;

			public ScreenOrientation orientation;
		}

		public readonly RenderTexture texture;

		public ScreenOrientation orientation;

		private readonly ComputeShader shader;

		private readonly LifecycleHelper lifecycleHelper;

		private readonly IReadOnlyDictionary<CameraImage.Format, int> conversionKernelMap;

		private readonly IReadOnlyDictionary<ScreenOrientation, int> rotationKernelMap;

		private readonly int[] conversionOffset;

		private readonly int[] conversionStride;

		private readonly TaskCompletionSource<RenderTexture> taskCompletionSource;

		private readonly object fence;

		private byte[] pixelBuffer;

		private ImageBuffer imageBuffer;

		private ComputeBuffer conversionBuffer;

		private static ScreenOrientation DefaultOrientation => default(ScreenOrientation);

		public event Action<RenderTextureOutput> OnFrame
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

		public override void Update(CameraImage image)
		{
		}

		public void Update(CameraImage image, ConversionOptions options)
		{
		}

		public Task<RenderTexture> NextFrame()
		{
			return null;
		}

		public override void Dispose()
		{
		}

		private void OnImageBuffer()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void CopyImage(in CameraImage image, byte[] buffer, int[] offset, int[] stride)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void CopyImageRGBA8888(in CameraImage image, byte[] buffer, int[] offset, int[] stride)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void CopyImageYUV420p(in CameraImage image, byte[] buffer, int[] offset, int[] stride)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void CopyImageYUV420sp(in CameraImage image, byte[] buffer, int[] offset, int[] stride)
		{
		}

		private static ScreenOrientation GetAdjustedOrientation(in ImageBuffer imageBuffer)
		{
			return default(ScreenOrientation);
		}
	}
}
