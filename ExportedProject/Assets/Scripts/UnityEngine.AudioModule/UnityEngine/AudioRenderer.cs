using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioRenderer.bindings.h")]
	public class AudioRenderer
	{
		public static bool Start()
		{
			return false;
		}

		public static bool Stop()
		{
			return false;
		}

		public static int GetSampleCountForCaptureFrame()
		{
			return 0;
		}

		public static bool Render(NativeArray<float> buffer)
		{
			return false;
		}

		internal static bool Internal_AudioRenderer_Start()
		{
			return false;
		}

		internal static bool Internal_AudioRenderer_Stop()
		{
			return false;
		}

		internal static int Internal_AudioRenderer_GetSampleCountForCaptureFrame()
		{
			return 0;
		}

		internal unsafe static bool Internal_AudioRenderer_Render(void* ptr, int length)
		{
			return false;
		}
	}
}
