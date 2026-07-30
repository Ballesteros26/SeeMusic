using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	public sealed class CropTextureInput : TextureInput, ITextureInput
	{
		public RectInt rect;

		private readonly TextureInput input;

		public override (int width, int height) frameSize => default((int, int));

		public CropTextureInput(MediaRecorder recorder)
			: base(null)
		{
		}

		public CropTextureInput(TextureInput input)
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
