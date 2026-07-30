using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	internal sealed class RecorderTextureInput : TextureInput
	{
		public readonly ITextureInput[] inputs;

		private readonly TextureInput input;

		public RecorderTextureInput(MediaRecorder recorder, params ITextureInput[] inputs)
			: base(null)
		{
		}

		public override void CommitFrame(Texture texture, long timestamp)
		{
		}

		public override void Dispose()
		{
		}
	}
}
