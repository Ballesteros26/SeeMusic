using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/VFX/Public/VFXManager.h")]
	[RequiredByNativeCode]
	public static class VFXManager
	{
		private static readonly VFXCameraXRSettings kDefaultCameraXRSettings;

		internal static ScriptableObject runtimeResources => null;

		public static void PrepareCamera(Camera cam)
		{
		}

		public static void PrepareCamera([NotNull("NullExceptionObject")] Camera cam, VFXCameraXRSettings camXRSettings)
		{
		}

		public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd)
		{
		}

		public static void ProcessCameraCommand([NotNull("NullExceptionObject")] Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings)
		{
		}

		private static void PrepareCamera_Injected(Camera cam, ref VFXCameraXRSettings camXRSettings)
		{
		}

		private static void ProcessCameraCommand_Injected(Camera cam, CommandBuffer cmd, ref VFXCameraXRSettings camXRSettings)
		{
		}
	}
}
