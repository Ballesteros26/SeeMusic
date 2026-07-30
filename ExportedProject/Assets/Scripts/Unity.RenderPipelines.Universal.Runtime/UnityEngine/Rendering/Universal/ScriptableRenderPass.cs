using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRenderPass
	{
		private RenderBufferStoreAction[] m_ColorStoreActions;

		private RenderBufferStoreAction m_DepthStoreAction;

		private bool[] m_OverriddenColorStoreActions;

		private bool m_OverriddenDepthStoreAction;

		internal NativeArray<int> m_ColorAttachmentIndices;

		internal NativeArray<int> m_InputAttachmentIndices;

		private RenderTargetIdentifier[] m_ColorAttachments;

		internal RenderTargetIdentifier[] m_InputAttachments;

		internal bool[] m_InputAttachmentIsTransient;

		private RenderTargetIdentifier m_DepthAttachment;

		private ScriptableRenderPassInput m_Input;

		private ClearFlag m_ClearFlag;

		private Color m_ClearColor;

		public RenderPassEvent renderPassEvent { get; set; }

		public RenderTargetIdentifier[] colorAttachments => null;

		public RenderTargetIdentifier colorAttachment => default(RenderTargetIdentifier);

		public RenderTargetIdentifier depthAttachment => default(RenderTargetIdentifier);

		public RenderBufferStoreAction[] colorStoreActions => null;

		public RenderBufferStoreAction depthStoreAction => default(RenderBufferStoreAction);

		internal bool[] overriddenColorStoreActions => null;

		internal bool overriddenDepthStoreAction => false;

		public ScriptableRenderPassInput input => default(ScriptableRenderPassInput);

		public ClearFlag clearFlag => default(ClearFlag);

		public Color clearColor => default(Color);

		protected internal ProfilingSampler profilingSampler { get; set; }

		internal bool overrideCameraTarget { get; set; }

		internal bool isBlitRenderPass { get; set; }

		internal bool useNativeRenderPass { get; set; }

		internal int renderTargetWidth { get; set; }

		internal int renderTargetHeight { get; set; }

		internal int renderTargetSampleCount { get; set; }

		internal bool depthOnly { get; set; }

		internal bool isLastPass { get; set; }

		internal int renderPassQueueIndex { get; set; }

		internal GraphicsFormat[] renderTargetFormat { get; set; }

		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void FrameCleanup(CommandBuffer cmd)
		{
		}

		internal DebugHandler GetActiveDebugHandler(RenderingData renderingData)
		{
			return null;
		}

		public ScriptableRenderPass()
		{
		}

		public void ConfigureInput(ScriptableRenderPassInput passInput)
		{
		}

		public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
		{
		}

		public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions)
		{
		}

		public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
		{
		}

		internal void ConfigureInputAttachments(RenderTargetIdentifier input, bool isTransient = false)
		{
		}

		internal void ConfigureInputAttachments(RenderTargetIdentifier[] inputs)
		{
		}

		internal void ConfigureInputAttachments(RenderTargetIdentifier[] inputs, bool[] isTransient)
		{
		}

		internal void SetInputAttachmentTransient(int idx, bool isTransient)
		{
		}

		internal bool IsInputAttachmentTransient(int idx)
		{
			return false;
		}

		public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
		{
		}

		internal void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, GraphicsFormat format)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment)
		{
		}

		internal void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, GraphicsFormat[] formats)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier colorAttachment)
		{
		}

		internal void ConfigureTarget(RenderTargetIdentifier colorAttachment, GraphicsFormat format, int width = -1, int height = -1, int sampleCount = -1, bool depth = false)
		{
		}

		public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments)
		{
		}

		public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
		{
		}

		public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public virtual void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

		public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
		{
		}

		public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
		{
		}

		public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
		{
			return default(DrawingSettings);
		}

		public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}

		public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
		{
			return false;
		}
	}
}
