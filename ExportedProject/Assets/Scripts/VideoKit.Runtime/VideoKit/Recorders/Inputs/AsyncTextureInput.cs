using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	public sealed class AsyncTextureInput : TextureInput
	{
		private bool commit;

		public AsyncTextureInput(MediaRecorder recorder)
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
