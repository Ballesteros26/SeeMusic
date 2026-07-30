using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[StaticAccessor("TexturePlayableOutputBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Director/TexturePlayableOutput.bindings.h")]
	[NativeHeader("Runtime/Graphics/Director/TexturePlayableOutput.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public struct TexturePlayableOutput : IPlayableOutput
	{
		private PlayableOutputHandle m_Handle;

		public PlayableOutputHandle GetHandle()
		{
			return default(PlayableOutputHandle);
		}
	}
}
