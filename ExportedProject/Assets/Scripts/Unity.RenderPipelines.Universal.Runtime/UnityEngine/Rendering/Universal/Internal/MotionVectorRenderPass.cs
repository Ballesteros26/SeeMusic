using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal sealed class MotionVectorRenderPass : ScriptableRenderPass
	{
		private const string kPreviousViewProjectionMatrix = "_PrevViewProjMatrix";

		private const string kPreviousViewProjectionMatrixStero = "_PrevViewProjMStereo";

		private const string kMotionVectorTexture = "_MotionVectorTexture";

		private const GraphicsFormat m_TargetFormat = GraphicsFormat.R16G16_SFloat;

		private static readonly string[] s_ShaderTags;

		private RenderTargetHandle m_MotionVectorHandle;

		private readonly Material m_CameraMaterial;

		private readonly Material m_ObjectMaterial;

		private PreviousFrameData m_MotionData;

		private ProfilingSampler m_ProfilingSampler;

		internal MotionVectorRenderPass(Material cameraMaterial, Material objectMaterial)
		{
		}

		internal void Setup(PreviousFrameData frameData)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private DrawingSettings GetDrawingSettings(ref RenderingData renderingData)
		{
			return default(DrawingSettings);
		}

		private void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, Camera camera)
		{
		}

		private void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		private void ExecuteCommand(ScriptableRenderContext context, CommandBuffer cmd)
		{
		}
	}
}
