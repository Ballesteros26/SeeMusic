using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	public sealed class SystemInfo
	{
		[NativeProperty]
		public static float batteryLevel => 0f;

		public static string operatingSystem => null;

		public static OperatingSystemFamily operatingSystemFamily => default(OperatingSystemFamily);

		public static string processorType => null;

		public static int systemMemorySize => 0;

		public static string deviceUniqueIdentifier => null;

		public static string deviceName => null;

		public static string deviceModel => null;

		public static DeviceType deviceType => default(DeviceType);

		public static int graphicsMemorySize => 0;

		public static string graphicsDeviceName => null;

		public static string graphicsDeviceVendor => null;

		public static GraphicsDeviceType graphicsDeviceType => default(GraphicsDeviceType);

		public static bool graphicsUVStartsAtTop => false;

		public static string graphicsDeviceVersion => null;

		public static int graphicsShaderLevel => 0;

		public static bool graphicsMultiThreaded => false;

		public static bool hasHiddenSurfaceRemovalOnGPU => false;

		public static bool supportsShadows => false;

		public static CopyTextureSupport copyTextureSupport => default(CopyTextureSupport);

		public static bool supportsComputeShaders => false;

		public static bool supportsRenderTargetArrayIndexFromVertexShader => false;

		public static bool supportsInstancing => false;

		public static int supportedRenderTargetCount => 0;

		public static int supportsMultisampledTextures => 0;

		public static bool supportsMultisampleAutoResolve => false;

		public static bool usesReversedZBuffer => false;

		public static int maxTextureSize => 0;

		public static int maxCubemapSize => 0;

		internal static int maxRenderTextureSize => 0;

		public static bool supportsGraphicsFence => false;

		public static bool supportsAsyncGPUReadback => false;

		public static long maxGraphicsBufferSize => 0L;

		public static bool supportsMultiview => false;

		public static bool supportsStoreAndResolveAction => false;

		private static bool IsValidEnumValue(Enum value)
		{
			return false;
		}

		public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
		{
			return false;
		}

		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("systeminfo::GetBatteryLevel")]
		private static float GetBatteryLevel()
		{
			return 0f;
		}

		[FreeFunction("systeminfo::GetOperatingSystem")]
		private static string GetOperatingSystem()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		private static OperatingSystemFamily GetOperatingSystemFamily()
		{
			return default(OperatingSystemFamily);
		}

		[FreeFunction("systeminfo::GetProcessorType")]
		private static string GetProcessorType()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
		private static int GetPhysicalMemoryMB()
		{
			return 0;
		}

		[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
		private static string GetDeviceUniqueIdentifier()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceName")]
		private static string GetDeviceName()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceModel")]
		private static string GetDeviceModel()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceType")]
		private static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
		private static int GetGraphicsMemorySize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
		private static string GetGraphicsDeviceName()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
		private static string GetGraphicsDeviceVendor()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
		private static GraphicsDeviceType GetGraphicsDeviceType()
		{
			return default(GraphicsDeviceType);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
		private static bool GetGraphicsUVStartsAtTop()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVersion")]
		private static string GetGraphicsDeviceVersion()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
		private static int GetGraphicsShaderLevel()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMultiThreaded")]
		private static bool GetGraphicsMultiThreaded()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::HasHiddenSurfaceRemovalOnGPU")]
		private static bool HasHiddenSurfaceRemovalOnGPU()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
		private static bool SupportsShadows()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
		private static CopyTextureSupport GetCopyTextureSupport()
		{
			return default(CopyTextureSupport);
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
		private static bool SupportsComputeShaders()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsRenderTargetArrayIndexFromVertexShader")]
		private static bool SupportsRenderTargetArrayIndexFromVertexShader()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
		private static bool SupportsInstancing()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
		private static int SupportedRenderTargetCount()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledTextures")]
		private static int SupportsMultisampledTextures()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleAutoResolve")]
		private static bool SupportsMultisampleAutoResolve()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
		private static bool UsesReversedZBuffer()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
		private static bool HasRenderTextureNative(RenderTextureFormat format)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		private static bool SupportsTextureFormatNative(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
		private static int GetMaxTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxCubemapSize")]
		private static int GetMaxCubemapSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
		private static int GetMaxRenderTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsGPUFence")]
		private static bool SupportsGPUFence()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsAsyncGPUReadback")]
		private static bool SupportsAsyncGPUReadback()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
		private static long MaxGraphicsBufferSize()
		{
			return 0L;
		}

		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
		public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsMultiview")]
		private static bool SupportsMultiview()
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsStoreAndResolveAction")]
		private static bool SupportsStoreAndResolveAction()
		{
			return false;
		}

		private static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc)
		{
			return 0;
		}
	}
}
