using System.Collections.Generic;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	public sealed class UniversalRenderer : ScriptableRenderer
	{
		private static class Profiling
		{
			private const string k_Name = "UniversalRenderer";

			public static readonly ProfilingSampler createCameraRenderTarget;
		}

		private struct RenderPassInputSummary
		{
			internal bool requiresDepthTexture;

			internal bool requiresDepthPrepass;

			internal bool requiresNormalsTexture;

			internal bool requiresColorTexture;

			internal bool requiresColorTextureCreated;

			internal bool requiresMotionVectors;

			internal RenderPassEvent requiresDepthNormalAtEvent;

			internal RenderPassEvent requiresDepthTextureEarliestEvent;
		}

		internal const int k_DepthStencilBufferBits = 32;

		private static readonly List<ShaderTagId> k_DepthNormalsOnly;

		private DepthOnlyPass m_DepthPrepass;

		private DepthNormalOnlyPass m_DepthNormalPrepass;

		private CopyDepthPass m_PrimedDepthCopyPass;

		private MotionVectorRenderPass m_MotionVectorPass;

		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		private GBufferPass m_GBufferPass;

		private CopyDepthPass m_GBufferCopyDepthPass;

		private TileDepthRangePass m_TileDepthRangePass;

		private TileDepthRangePass m_TileDepthRangeExtraPass;

		private DeferredPass m_DeferredPass;

		private DrawObjectsPass m_RenderOpaqueForwardOnlyPass;

		private DrawObjectsPass m_RenderOpaqueForwardPass;

		private DrawSkyboxPass m_DrawSkyboxPass;

		private CopyDepthPass m_CopyDepthPass;

		private CopyColorPass m_CopyColorPass;

		private TransparentSettingsPass m_TransparentSettingsPass;

		private DrawObjectsPass m_RenderTransparentForwardPass;

		private InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

		private FinalBlitPass m_FinalBlitPass;

		private CapturePass m_CapturePass;

		private XROcclusionMeshPass m_XROcclusionMeshPass;

		private CopyDepthPass m_XRCopyDepthPass;

		internal RenderTargetBufferSystem m_ColorBufferSystem;

		private RenderTargetHandle m_ActiveCameraColorAttachment;

		private RenderTargetHandle m_ColorFrontBuffer;

		private RenderTargetHandle m_ActiveCameraDepthAttachment;

		private RenderTargetHandle m_CameraDepthAttachment;

		private RenderTargetHandle m_DepthTexture;

		private RenderTargetHandle m_NormalsTexture;

		private RenderTargetHandle m_OpaqueColor;

		private RenderTargetHandle m_DepthInfoTexture;

		private RenderTargetHandle m_TileDepthInfoTexture;

		private ForwardLights m_ForwardLights;

		private DeferredLights m_DeferredLights;

		private RenderingMode m_RenderingMode;

		private DepthPrimingMode m_DepthPrimingMode;

		private CopyDepthMode m_CopyDepthMode;

		private bool m_DepthPrimingRecommended;

		private StencilState m_DefaultStencilState;

		private LightCookieManager m_LightCookieManager;

		private IntermediateTextureMode m_IntermediateTextureMode;

		private Material m_BlitMaterial;

		private Material m_CopyDepthMaterial;

		private Material m_SamplingMaterial;

		private Material m_TileDepthInfoMaterial;

		private Material m_TileDeferredMaterial;

		private Material m_StencilDeferredMaterial;

		private Material m_CameraMotionVecMaterial;

		private Material m_ObjectMotionVecMaterial;

		private PostProcessPasses m_PostProcessPasses;

		internal RenderingMode renderingMode => default(RenderingMode);

		internal RenderingMode actualRenderingMode => default(RenderingMode);

		internal bool accurateGbufferNormals => false;

		public DepthPrimingMode depthPrimingMode
		{
			get
			{
				return default(DepthPrimingMode);
			}
			set
			{
			}
		}

		internal ColorGradingLutPass colorGradingLutPass => null;

		internal PostProcessPass postProcessPass => null;

		internal PostProcessPass finalPostProcessPass => null;

		internal RenderTargetHandle colorGradingLut => default(RenderTargetHandle);

		internal DeferredLights deferredLights => null;

		public override int SupportedCameraStackingTypes()
		{
			return 0;
		}

		public UniversalRenderer(UniversalRendererData data)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void SetupFinalPassDebug(ref CameraData cameraData)
		{
		}

		private bool IsDepthPrimingEnabled(ref CameraData cameraData)
		{
			return false;
		}

		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		private void EnqueueDeferred(ref RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool applyMainShadow, bool applyAdditionalShadow)
		{
		}

		private RenderPassInputSummary GetRenderPassInputs(ref RenderingData renderingData)
		{
			return default(RenderPassInputSummary);
		}

		private bool IsGLESDevice()
		{
			return false;
		}

		private void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, bool primedDepth)
		{
		}

		private bool PlatformRequiresExplicitMsaaResolve()
		{
			return false;
		}

		private bool RequiresIntermediateColorTexture(ref CameraData cameraData)
		{
			return false;
		}

		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return false;
		}

		internal override void SwapColorBuffer(CommandBuffer cmd)
		{
		}

		internal override RenderTargetIdentifier GetCameraColorFrontBuffer(CommandBuffer cmd)
		{
			return default(RenderTargetIdentifier);
		}

		internal override void EnableSwapBufferMSAA(bool enable)
		{
		}
	}
}
