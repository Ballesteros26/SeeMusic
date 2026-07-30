namespace UnityEngine.Rendering.Universal.Internal
{
	internal sealed class RenderTargetBufferSystem
	{
		private struct SwapBuffer
		{
			public RenderTargetHandle rt;

			public int name;

			public int msaa;
		}

		private SwapBuffer m_A;

		private SwapBuffer m_B;

		private static bool m_AisBackBuffer;

		private static RenderTextureDescriptor m_Desc;

		private FilterMode m_FilterMode;

		private bool m_AllowMSAA;

		private bool m_RTisAllocated;

		private SwapBuffer backBuffer => default(SwapBuffer);

		private SwapBuffer frontBuffer => default(SwapBuffer);

		public RenderTargetBufferSystem(string name)
		{
		}

		public RenderTargetHandle GetBackBuffer()
		{
			return default(RenderTargetHandle);
		}

		public RenderTargetHandle GetBackBuffer(CommandBuffer cmd)
		{
			return default(RenderTargetHandle);
		}

		public RenderTargetHandle GetFrontBuffer(CommandBuffer cmd)
		{
			return default(RenderTargetHandle);
		}

		public void Swap()
		{
		}

		private void Initialize(CommandBuffer cmd)
		{
		}

		public void Clear(CommandBuffer cmd)
		{
		}

		public void SetCameraSettings(CommandBuffer cmd, RenderTextureDescriptor desc, FilterMode filterMode)
		{
		}

		public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode)
		{
		}

		public RenderTargetHandle GetBufferA()
		{
			return default(RenderTargetHandle);
		}

		public void EnableMSAA(bool enable)
		{
		}
	}
}
