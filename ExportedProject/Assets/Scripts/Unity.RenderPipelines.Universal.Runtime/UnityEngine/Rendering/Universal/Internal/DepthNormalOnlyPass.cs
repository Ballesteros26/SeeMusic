using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthNormalOnlyPass : ScriptableRenderPass
	{
		private FilteringSettings m_FilteringSettings;

		private int m_RendererMSAASamples;

		private static readonly List<ShaderTagId> k_DepthNormals;

		internal RenderTextureDescriptor normalDescriptor { get; set; }

		internal RenderTextureDescriptor depthDescriptor { get; set; }

		internal bool allocateDepth { get; set; }

		internal bool allocateNormal { get; set; }

		internal List<ShaderTagId> shaderTagIds { get; set; }

		private RenderTargetHandle depthHandle { get; set; }

		private RenderTargetHandle normalHandle { get; set; }

		public DepthNormalOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthHandle, RenderTargetHandle normalHandle)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}
	}
}
