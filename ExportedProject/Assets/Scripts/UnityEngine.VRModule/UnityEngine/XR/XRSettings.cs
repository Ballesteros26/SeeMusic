using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.XR
{
	[NativeHeader("Modules/VR/VRModule.h")]
	[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
	[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeConditional("ENABLE_VR")]
	public static class XRSettings
	{
		public enum StereoRenderingMode
		{
			MultiPass = 0,
			SinglePass = 1,
			SinglePassInstanced = 2,
			SinglePassMultiview = 3
		}

		public static bool enabled
		{
			[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
			get
			{
				return false;
			}
		}

		[NativeName("Active")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static bool isDeviceActive => false;

		[NativeName("RenderScale")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static float eyeTextureResolutionScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureWidth => 0;

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static int eyeTextureHeight => 0;

		[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeName("IntermediateEyeTextureDesc")]
		public static RenderTextureDescriptor eyeTextureDesc => default(RenderTextureDescriptor);

		public static float renderViewportScale => 0f;

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		[NativeName("RenderViewportScale")]
		internal static float renderViewportScaleInternal => 0f;

		[NativeName("DeviceName")]
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static string loadedDeviceName => null;

		public static string[] supportedDevices => null;

		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		public static StereoRenderingMode stereoRenderingMode => default(StereoRenderingMode);

		[SpecialName]
		private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
		{
			ret = default(RenderTextureDescriptor);
		}
	}
}
