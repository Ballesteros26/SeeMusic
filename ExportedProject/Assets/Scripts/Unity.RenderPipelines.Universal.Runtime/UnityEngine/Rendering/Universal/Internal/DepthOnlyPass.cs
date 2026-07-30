namespace UnityEngine.Rendering.Universal.Internal
{
	public class DepthOnlyPass : ScriptableRenderPass
	{
		private static readonly ShaderTagId k_ShaderTagId;

		private FilteringSettings m_FilteringSettings;

		private RenderTargetHandle depthAttachmentHandle { get; set; }

		internal RenderTextureDescriptor descriptor { get; set; }

		internal bool allocateDepth { get; set; }

		internal ShaderTagId shaderTagId { get; set; }

		public DepthOnlyPass(RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask)
		{
		}

		public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle depthAttachmentHandle)
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
