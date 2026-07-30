using System;
using UnityEngine.Bindings;
using UnityEngine.Profiling;
using UnityEngine.Rendering.RendererUtils;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Export/Graphics/RenderingCommandBuffer.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/RayTracingShader.h")]
	[NativeType("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	public class CommandBuffer : IDisposable
	{
		internal IntPtr m_Ptr;

		public string name
		{
			set
			{
			}
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetSinglePassStereo", HasExplicitThis = true)]
		private void Internal_SetSinglePassStereo(SinglePassStereoMode mode)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::InitBuffer")]
		private static IntPtr InitBuffer()
		{
			return (IntPtr)0;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::CreateGPUFence_Internal", HasExplicitThis = true)]
		private IntPtr CreateGPUFence_Internal(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return (IntPtr)0;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::WaitOnGPUFence_Internal", HasExplicitThis = true)]
		private void WaitOnGPUFence_Internal(IntPtr fencePtr, SynchronisationStageFlags stage)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseBuffer", HasExplicitThis = true, IsThreadSafe = true)]
		private void ReleaseBuffer()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeFloatParam", HasExplicitThis = true)]
		public void SetComputeFloatParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, float val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeIntParam", HasExplicitThis = true)]
		public void SetComputeIntParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, int val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeMatrixParam", HasExplicitThis = true)]
		public void SetComputeMatrixParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, Matrix4x4 val)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeFloats", HasExplicitThis = true)]
		private void Internal_SetComputeFloats([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] float[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeInts", HasExplicitThis = true)]
		private void Internal_SetComputeInts([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, [Unmarshalled] int[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_SetComputeTextureParam", HasExplicitThis = true)]
		private void Internal_SetComputeTextureParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, ref RenderTargetIdentifier rt, int mipLevel, RenderTextureSubElement element)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeGraphicsBufferParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetComputeConstantBufferParam", HasExplicitThis = true)]
		private void Internal_SetComputeConstantComputeBufferParam([NotNull("ArgumentNullException")] ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DispatchCompute", HasExplicitThis = true, ThrowsException = true)]
		private void Internal_DispatchCompute([NotNull("ArgumentNullException")] ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		[NativeMethod("ClearCommands")]
		public void Clear()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMesh", HasExplicitThis = true)]
		private void Internal_DrawMesh([NotNull("ArgumentNullException")] Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		[NativeMethod("AddDrawRenderer")]
		private void Internal_DrawRenderer([NotNull("ArgumentNullException")] Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
		}

		[NativeMethod("AddDrawRendererList")]
		private void Internal_DrawRendererList(RendererList rendererList)
		{
		}

		[NativeMethod("AddDrawProcedural")]
		private void Internal_DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawMeshInstanced", HasExplicitThis = true)]
		private void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, [Unmarshalled] Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Internal_DrawOcclusionMesh", HasExplicitThis = true)]
		private void Internal_DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetRandomWriteTarget_Buffer", HasExplicitThis = true, ThrowsException = true)]
		private void SetRandomWriteTarget_GraphicsBuffer(int index, GraphicsBuffer uav, bool preserveCounterValue)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ClearRandomWriteTargets", HasExplicitThis = true, ThrowsException = true)]
		public void ClearRandomWriteTargets()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetViewport", HasExplicitThis = true, ThrowsException = true)]
		public void SetViewport(Rect pixelRect)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		public void EnableScissorRect(Rect scissor)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableScissorRect", HasExplicitThis = true, ThrowsException = true)]
		public void DisableScissorRect()
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Texture", HasExplicitThis = true)]
		private void Blit_Texture(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::Blit_Identifier", HasExplicitThis = true)]
		private void Blit_Identifier(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, Vector2 scale, Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::GetTemporaryRTWithDescriptor", HasExplicitThis = true)]
		private void GetTemporaryRTWithDescriptor(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		public void GetTemporaryRT(int nameID, RenderTextureDescriptor desc)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ReleaseTemporaryRT", HasExplicitThis = true)]
		public void ReleaseTemporaryRT(int nameID)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ClearRenderTarget", HasExplicitThis = true)]
		public void ClearRenderTarget(RTClearFlags clearFlags, Color backgroundColor, float depth, uint stencil)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		public void ClearRenderTarget(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloat", HasExplicitThis = true)]
		public void SetGlobalFloat(int nameID, float value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInt", HasExplicitThis = true)]
		public void SetGlobalInt(int nameID, int value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalInteger", HasExplicitThis = true)]
		public void SetGlobalInteger(int nameID, int value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVector", HasExplicitThis = true)]
		public void SetGlobalVector(int nameID, Vector4 value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalColor", HasExplicitThis = true)]
		public void SetGlobalColor(int nameID, Color value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrix", HasExplicitThis = true)]
		public void SetGlobalMatrix(int nameID, Matrix4x4 value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EnableShaderKeyword", HasExplicitThis = true)]
		public void EnableShaderKeyword(string keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::DisableShaderKeyword", HasExplicitThis = true)]
		public void DisableShaderKeyword(string keyword)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetViewProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
		public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 proj)
		{
		}

		[NativeMethod("AddSetGlobalDepthBias")]
		public void SetGlobalDepthBias(float bias, float slopeBias)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
		public void SetExecutionFlags(CommandBufferExecutionFlags flags)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::ValidateAgainstExecutionFlags", HasExplicitThis = true, ThrowsException = true)]
		private bool ValidateAgainstExecutionFlags(CommandBufferExecutionFlags requiredFlags, CommandBufferExecutionFlags invalidFlags)
		{
			return false;
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalFloatArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalFloatArray(int nameID, [Unmarshalled] float[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalVectorArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalVectorArray(int nameID, [Unmarshalled] Vector4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalMatrixArray", HasExplicitThis = true, ThrowsException = true)]
		public void SetGlobalMatrixArray(int nameID, [Unmarshalled] Matrix4x4[] values)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetLateLatchProjectionMatrices", HasExplicitThis = true, ThrowsException = true)]
		public void SetLateLatchProjectionMatrices([Unmarshalled] Matrix4x4[] projectionMat)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::MarkLateLatchMatrixShaderPropertyID", HasExplicitThis = true)]
		public void MarkLateLatchMatrixShaderPropertyID(CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::UnmarkLateLatchMatrix", HasExplicitThis = true)]
		public void UnmarkLateLatchMatrix(CameraLateLatchMatrixType matrixPropertyType)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalTexture_Impl", HasExplicitThis = true)]
		private void SetGlobalTexture_Impl(int nameID, ref RenderTargetIdentifier rt, RenderTextureSubElement element)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalBuffer", HasExplicitThis = true)]
		private void SetGlobalBufferInternal(int nameID, ComputeBuffer value)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample", HasExplicitThis = true)]
		public void BeginSample(string name)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EndSample", HasExplicitThis = true)]
		public void EndSample(string name)
		{
		}

		public void BeginSample(CustomSampler sampler)
		{
		}

		public void EndSample(CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::BeginSample_CustomSampler", HasExplicitThis = true)]
		private void BeginSample_CustomSampler([NotNull("ArgumentNullException")] CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::EndSample_CustomSampler", HasExplicitThis = true)]
		private void EndSample_CustomSampler([NotNull("ArgumentNullException")] CustomSampler sampler)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::IssuePluginEventAndDataInternal", HasExplicitThis = true)]
		private void IssuePluginEventAndDataInternal(IntPtr callback, int eventID, IntPtr data)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetGlobalConstantBuffer", HasExplicitThis = true)]
		private void SetGlobalConstantBufferInternal(ComputeBuffer buffer, int nameID, int offset, int size)
		{
		}

		[FreeFunction("RenderingCommandBuffer_Bindings::SetInstanceMultiplier", HasExplicitThis = true)]
		public void SetInstanceMultiplier(uint multiplier)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier rt, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		public void SetRenderTarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		private void SetRenderTargetSingle_Internal(RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		private void SetRenderTargetColorDepth_Internal(RenderTargetIdentifier color, RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private void SetRenderTargetMultiSubtarget(RenderTargetIdentifier[] colors, RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}

		public void SetBufferData(ComputeBuffer buffer, Array data)
		{
		}

		[FreeFunction(Name = "RenderingCommandBuffer_Bindings::InternalSetGraphicsBufferData", HasExplicitThis = true, ThrowsException = true)]
		private void InternalSetComputeBufferData([NotNull("ArgumentNullException")] ComputeBuffer buffer, Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize)
		{
		}

		~CommandBuffer()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public void Release()
		{
		}

		public GraphicsFence CreateAsyncGraphicsFence()
		{
			return default(GraphicsFence);
		}

		public GraphicsFence CreateGraphicsFence(GraphicsFenceType fenceType, SynchronisationStageFlags stage)
		{
			return default(GraphicsFence);
		}

		public void WaitOnAsyncGraphicsFence(GraphicsFence fence)
		{
		}

		public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStage stage)
		{
		}

		public void WaitOnAsyncGraphicsFence(GraphicsFence fence, SynchronisationStageFlags stage)
		{
		}

		public void SetComputeFloatParams(ComputeShader computeShader, int nameID, params float[] values)
		{
		}

		public void SetComputeIntParams(ComputeShader computeShader, int nameID, params int[] values)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, string name, RenderTargetIdentifier rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt)
		{
		}

		public void SetComputeTextureParam(ComputeShader computeShader, int kernelIndex, int nameID, RenderTargetIdentifier rt, int mipLevel)
		{
		}

		public void SetComputeBufferParam(ComputeShader computeShader, int kernelIndex, int nameID, GraphicsBuffer buffer)
		{
		}

		public void SetComputeConstantBufferParam(ComputeShader computeShader, int nameID, ComputeBuffer buffer, int offset, int size)
		{
		}

		public void DispatchCompute(ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex)
		{
		}

		public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex, int shaderPass)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material, int submeshIndex)
		{
		}

		public void DrawRenderer(Renderer renderer, Material material)
		{
		}

		public void DrawRendererList(RendererList rendererList)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount)
		{
		}

		public void DrawProcedural(Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount)
		{
		}

		public void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, int shaderPass, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties)
		{
		}

		public void DrawOcclusionMesh(RectInt normalizedCamViewport)
		{
		}

		public void SetRandomWriteTarget(int index, GraphicsBuffer buffer, bool preserveCounterValue)
		{
		}

		public void Blit(Texture source, RenderTargetIdentifier dest)
		{
		}

		public void Blit(Texture source, RenderTargetIdentifier dest, Material mat)
		{
		}

		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest)
		{
		}

		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat)
		{
		}

		public void Blit(RenderTargetIdentifier source, RenderTargetIdentifier dest, Material mat, int pass)
		{
		}

		public void SetGlobalFloat(string name, float value)
		{
		}

		public void SetGlobalInteger(string name, int value)
		{
		}

		public void SetGlobalVector(string name, Vector4 value)
		{
		}

		public void SetGlobalTexture(string name, RenderTargetIdentifier value)
		{
		}

		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value)
		{
		}

		public void SetGlobalTexture(int nameID, RenderTargetIdentifier value, RenderTextureSubElement element)
		{
		}

		public void SetGlobalBuffer(int nameID, ComputeBuffer value)
		{
		}

		public void SetGlobalConstantBuffer(ComputeBuffer buffer, int nameID, int offset, int size)
		{
		}

		public void SetGlobalConstantBuffer(ComputeBuffer buffer, string name, int offset, int size)
		{
		}

		public void SetSinglePassStereo(SinglePassStereoMode mode)
		{
		}

		public void IssuePluginEventAndData(IntPtr callback, int eventID, IntPtr data)
		{
		}

		private void SetComputeMatrixParam_Injected(ComputeShader computeShader, int nameID, ref Matrix4x4 val)
		{
		}

		private void Internal_DrawMesh_Injected(Mesh mesh, ref Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
		{
		}

		private void Internal_DrawRendererList_Injected(ref RendererList rendererList)
		{
		}

		private void Internal_DrawProcedural_Injected(ref Matrix4x4 matrix, Material material, int shaderPass, MeshTopology topology, int vertexCount, int instanceCount, MaterialPropertyBlock properties)
		{
		}

		private void Internal_DrawOcclusionMesh_Injected(ref RectInt normalizedCamViewport)
		{
		}

		private void SetViewport_Injected(ref Rect pixelRect)
		{
		}

		private void EnableScissorRect_Injected(ref Rect scissor)
		{
		}

		private void Blit_Texture_Injected(Texture source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		private void Blit_Identifier_Injected(ref RenderTargetIdentifier source, ref RenderTargetIdentifier dest, Material mat, int pass, ref Vector2 scale, ref Vector2 offset, int sourceDepthSlice, int destDepthSlice)
		{
		}

		private void GetTemporaryRTWithDescriptor_Injected(int nameID, ref RenderTextureDescriptor desc, FilterMode filter)
		{
		}

		private void ClearRenderTarget_Injected(RTClearFlags clearFlags, ref Color backgroundColor, float depth, uint stencil)
		{
		}

		private void SetGlobalVector_Injected(int nameID, ref Vector4 value)
		{
		}

		private void SetGlobalColor_Injected(int nameID, ref Color value)
		{
		}

		private void SetGlobalMatrix_Injected(int nameID, ref Matrix4x4 value)
		{
		}

		private void SetViewProjectionMatrices_Injected(ref Matrix4x4 view, ref Matrix4x4 proj)
		{
		}

		private void SetRenderTargetSingle_Internal_Injected(ref RenderTargetIdentifier rt, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction)
		{
		}

		private void SetRenderTargetColorDepth_Internal_Injected(ref RenderTargetIdentifier color, ref RenderTargetIdentifier depth, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, RenderTargetFlags flags)
		{
		}

		private void SetRenderTargetMultiSubtarget_Injected(RenderTargetIdentifier[] colors, ref RenderTargetIdentifier depth, RenderBufferLoadAction[] colorLoadActions, RenderBufferStoreAction[] colorStoreActions, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int mipLevel, CubemapFace cubemapFace, int depthSlice)
		{
		}
	}
}
