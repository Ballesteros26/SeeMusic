using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	public sealed class UniversalRenderPipeline : RenderPipeline
	{
		private static class Profiling
		{
			public static class Pipeline
			{
				public static class Renderer
				{
					private const string k_Name = "ScriptableRenderer";

					public static readonly ProfilingSampler setupCullingParameters;

					public static readonly ProfilingSampler setup;
				}

				public static class Context
				{
					private const string k_Name = "ScriptableRenderContext";

					public static readonly ProfilingSampler submit;
				}

				public static class XR
				{
					public static readonly ProfilingSampler mirrorView;
				}

				public static readonly ProfilingSampler beginContextRendering;

				public static readonly ProfilingSampler endContextRendering;

				public static readonly ProfilingSampler beginCameraRendering;

				public static readonly ProfilingSampler endCameraRendering;

				private const string k_Name = "UniversalRenderPipeline";

				public static readonly ProfilingSampler initializeCameraData;

				public static readonly ProfilingSampler initializeStackedCameraData;

				public static readonly ProfilingSampler initializeAdditionalCameraData;

				public static readonly ProfilingSampler initializeRenderingData;

				public static readonly ProfilingSampler initializeShadowData;

				public static readonly ProfilingSampler initializeLightData;

				public static readonly ProfilingSampler getPerObjectLightFlags;

				public static readonly ProfilingSampler getMainLightIndex;

				public static readonly ProfilingSampler setupPerFrameShaderConstants;
			}

			private static Dictionary<int, ProfilingSampler> s_HashSamplerCache;

			public static readonly ProfilingSampler unknownSampler;

			public static ProfilingSampler TryGetOrAddCameraSampler(Camera camera)
			{
				return null;
			}
		}

		public const string k_ShaderTagName = "UniversalPipeline";

		internal static XRSystem m_XRSystem;

		internal const int k_MaxVisibleAdditionalLightsMobileShaderLevelLessThan45 = 16;

		internal const int k_MaxVisibleAdditionalLightsMobile = 32;

		internal const int k_MaxVisibleAdditionalLightsNonMobile = 256;

		internal const int k_DefaultRenderingLayerMask = 1;

		private readonly DebugDisplaySettingsUI m_DebugDisplaySettingsUI;

		private UniversalRenderPipelineGlobalSettings m_GlobalSettings;

		private readonly UniversalRenderPipelineAsset pipelineAsset;

		private static Vector4 k_DefaultLightPosition;

		private static Vector4 k_DefaultLightColor;

		private static Vector4 k_DefaultLightAttenuation;

		private static Vector4 k_DefaultLightSpotDirection;

		private static Vector4 k_DefaultLightsProbeChannel;

		private static List<Vector4> m_ShadowBiasData;

		private static List<int> m_ShadowResolutionData;

		private Comparison<Camera> cameraComparison;

		private static Lightmapping.RequestLightsDelegate lightsDelegate;

		public static float maxShadowBias => 0f;

		public static float minRenderScale => 0f;

		public static float maxRenderScale => 0f;

		public static int maxPerObjectLights => 0;

		public static int maxVisibleAdditionalLights => 0;

		internal static int lightsPerTile => 0;

		internal static int maxZBins => 0;

		internal static int maxTileVec4s => 0;

		public override RenderPipelineGlobalSettings defaultSettings => null;

		public static UniversalRenderPipelineAsset asset => null;

		public override string ToString()
		{
			return null;
		}

		public UniversalRenderPipeline(UniversalRenderPipelineAsset asset)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		protected override void Render(ScriptableRenderContext renderContext, Camera[] cameras)
		{
		}

		protected override void Render(ScriptableRenderContext renderContext, List<Camera> cameras)
		{
		}

		public static void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
		{
		}

		private static bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
		{
			cullingParams = default(ScriptableCullingParameters);
			return false;
		}

		private static void RenderSingleCamera(ScriptableRenderContext context, CameraData cameraData, bool anyPostProcessingEnabled)
		{
		}

		private static void RenderCameraStack(ScriptableRenderContext context, Camera baseCamera)
		{
		}

		private static void UpdateVolumeFramework(Camera camera, UniversalAdditionalCameraData additionalCameraData)
		{
		}

		private static bool CheckPostProcessForDepth(in CameraData cameraData)
		{
			return false;
		}

		private static void SetSupportedRenderingFeatures()
		{
		}

		private static void InitializeCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, out CameraData cameraData)
		{
			cameraData = default(CameraData);
		}

		private static void InitializeStackedCameraData(Camera baseCamera, UniversalAdditionalCameraData baseAdditionalCameraData, ref CameraData cameraData)
		{
		}

		private static void InitializeAdditionalCameraData(Camera camera, UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref CameraData cameraData)
		{
		}

		private static void InitializeRenderingData(UniversalRenderPipelineAsset settings, ref CameraData cameraData, ref CullingResults cullResults, bool anyPostProcessingEnabled, out RenderingData renderingData)
		{
			renderingData = default(RenderingData);
		}

		private static void InitializeShadowData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, out ShadowData shadowData)
		{
			shadowData = default(ShadowData);
		}

		private static void InitializePostProcessingData(UniversalRenderPipelineAsset settings, out PostProcessingData postProcessingData)
		{
			postProcessingData = default(PostProcessingData);
		}

		private static void InitializeLightData(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights, int mainLightIndex, out LightData lightData)
		{
			lightData = default(LightData);
		}

		private static void CleanupLightData(ref LightData lightData)
		{
		}

		private static void UpdateCameraStereoMatrices(Camera camera, XRPass xr)
		{
		}

		private static PerObjectData GetPerObjectLightFlags(int additionalLightsCount)
		{
			return default(PerObjectData);
		}

		private static int GetMainLightIndex(UniversalRenderPipelineAsset settings, NativeArray<VisibleLight> visibleLights)
		{
			return 0;
		}

		private static void SetupPerFrameShaderConstants()
		{
		}

		private static void CheckAndApplyDebugSettings(ref RenderingData renderingData)
		{
		}

		private static ImageUpscalingFilter ResolveUpscalingFilterSelection(Vector2 imageSize, float renderScale, UpscalingFilterSelection selection)
		{
			return default(ImageUpscalingFilter);
		}

		public static bool IsGameCamera(Camera camera)
		{
			return false;
		}

		[Obsolete("Please use CameraData.xr.enabled instead.")]
		public static bool IsStereoEnabled(Camera camera)
		{
			return false;
		}

		[Obsolete("Please use CameraData.xr.singlePassEnabled instead.")]
		private static bool IsMultiPassStereoEnabled(Camera camera)
		{
			return false;
		}

		private void SortCameras(List<Camera> cameras)
		{
		}

		private static GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, bool needsAlpha)
		{
			return default(GraphicsFormat);
		}

		internal static GraphicsFormat MakeUnormRenderTextureGraphicsFormat()
		{
			return default(GraphicsFormat);
		}

		private static RenderTextureDescriptor CreateRenderTextureDescriptor(Camera camera, float renderScale, bool isHdrEnabled, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture)
		{
			return default(RenderTextureDescriptor);
		}

		public static void GetLightAttenuationAndSpotDirection(LightType lightType, float lightRange, Matrix4x4 lightLocalToWorldMatrix, float spotAngle, float? innerSpotAngle, out Vector4 lightAttenuation, out Vector4 lightSpotDir)
		{
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
		}

		public static void InitializeLightConstants_Common(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel)
		{
			lightPos = default(Vector4);
			lightColor = default(Vector4);
			lightAttenuation = default(Vector4);
			lightSpotDir = default(Vector4);
			lightOcclusionProbeChannel = default(Vector4);
		}
	}
}
