using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Video/BaseWebCamTexture.h")]
	[NativeHeader("Runtime/Video/ScriptBindings/WebCamTexture.bindings.h")]
	[NativeHeader("AudioScriptingClasses.h")]
	public sealed class WebCamTexture : Texture
	{
		public void Stop()
		{
		}

		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			return null;
		}

		[FreeFunction("WebCamTextureBindings::Internal_GetPixels32", HasExplicitThis = true, ThrowsException = true)]
		public Color32[] GetPixels32([Unmarshalled][DefaultValue("null")] Color32[] colors)
		{
			return null;
		}
	}
}
