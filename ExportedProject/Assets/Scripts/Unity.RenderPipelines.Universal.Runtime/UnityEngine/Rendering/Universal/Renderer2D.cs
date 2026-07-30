using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	internal class Renderer2D : ScriptableRenderer
	{
		internal const int k_DepthBufferBits = 32;

		private Render2DLightingPass m_Render2DLightingPass;

		private PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;

		private FinalBlitPass m_FinalBlitPass;

		private Light2DCullResult m_LightCullResult;

		private static readonly ProfilingSampler m_ProfilingSampler;

		private bool m_UseDepthStencilBuffer;

		private bool m_CreateColorTexture;

		private bool m_CreateDepthTexture;

		private readonly RenderTargetHandle k_ColorTextureHandle;

		private readonly RenderTargetHandle k_DepthTextureHandle;

		private Material m_BlitMaterial;

		private Material m_SamplingMaterial;

		private Renderer2DData m_Renderer2DData;

		private PostProcessPasses m_PostProcessPasses;

		internal bool createColorTexture => false;

		internal bool createDepthTexture => false;

		internal ColorGradingLutPass colorGradingLutPass => null;

		internal PostProcessPass postProcessPass => null;

		internal PostProcessPass finalPostProcessPass => null;

		internal RenderTargetHandle afterPostProcessColorHandle => default(RenderTargetHandle);

		internal RenderTargetHandle colorGradingLutHandle => default(RenderTargetHandle);

		public override int SupportedCameraStackingTypes()
		{
			return 0;
		}

		public Renderer2D(Renderer2DData data)
			: base(null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public Renderer2DData GetRenderer2DData()
		{
			return null;
		}

		private void CreateRenderTextures(ref CameraData cameraData, bool forceCreateColorTexture, FilterMode colorTextureFilterMode, CommandBuffer cmd, out RenderTargetHandle colorTargetHandle, out RenderTargetHandle depthTargetHandle)
		{
			colorTargetHandle = default(RenderTargetHandle);
			depthTargetHandle = default(RenderTargetHandle);
		}

		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		public override void FinishRendering(CommandBuffer cmd)
		{
		}
	}
}
