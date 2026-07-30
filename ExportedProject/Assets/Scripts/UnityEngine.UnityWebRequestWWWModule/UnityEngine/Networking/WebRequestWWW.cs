using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	[NativeHeader("Modules/UnityWebRequestAudio/Public/DownloadHandlerAudioClip.h")]
	internal static class WebRequestWWW
	{
		[FreeFunction("UnityWebRequestCreateAudioClip")]
		internal static AudioClip InternalCreateAudioClipUsingDH(DownloadHandler dh, string url, bool stream, bool compressed, AudioType audioType)
		{
			return null;
		}
	}
}
