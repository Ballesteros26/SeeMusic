using UnityEngine;

namespace VideoKit.Recorders.Inputs
{
	internal interface ITextureInput
	{
		void CommitFrame(Texture source, RenderTexture destination);
	}
}
