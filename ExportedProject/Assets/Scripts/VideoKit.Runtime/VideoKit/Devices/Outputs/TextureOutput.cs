using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace VideoKit.Devices.Outputs
{
	public sealed class TextureOutput : CameraOutput
	{
		public class ConversionOptions : PixelBufferOutput.ConversionOptions
		{
		}

		public readonly Texture2D texture;

		private readonly PixelBufferOutput pixelBufferOutput;

		private readonly TaskCompletionSource<Texture2D> taskCompletionSource;

		private readonly object fence;

		public ScreenOrientation orientation
		{
			get
			{
				return default(ScreenOrientation);
			}
			set
			{
			}
		}

		public event Action<TextureOutput> OnFrame
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

		public Task<Texture2D> NextFrame()
		{
			return null;
		}

		public override void Dispose()
		{
		}

		private void OnPixelBuffer()
		{
		}
	}
}
