using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	public sealed class WatermarkTextureInput : TextureInput, ITextureInput
	{
		public Texture watermark;

		public RectInt rect;

		private readonly TextureInput input;

		public override (int width, int height) frameSize => default((int, int));

		public WatermarkTextureInput(MediaRecorder recorder)
			: base(null)
		{
		}

		public WatermarkTextureInput(TextureInput input)
			: base(null)
		{
		}

		public override void CommitFrame(Texture texture, long timestamp)
		{
		}

		public override void Dispose()
		{
		}

		void ITextureInput.CommitFrame(Texture source, RenderTexture destination)
		{
		}
	}
}
