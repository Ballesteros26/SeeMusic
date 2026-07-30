namespace UnityEngine.Rendering.Universal.Internal
{
	internal sealed class PreviousFrameData
	{
		private bool m_IsFirstFrame;

		private int m_LastFrameActive;

		private Matrix4x4 m_viewProjectionMatrix;

		private Matrix4x4 m_PreviousViewProjectionMatrix;

		private Matrix4x4[] m_ViewProjectionMatrixStereo;

		private Matrix4x4[] m_PreviousViewProjectionMatrixStereo;

		internal bool isFirstFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal int lastFrameActive
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal Matrix4x4 viewProjectionMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		internal Matrix4x4 previousViewProjectionMatrix
		{
			get
			{
				return default(Matrix4x4);
			}
			set
			{
			}
		}

		internal Matrix4x4[] previousViewProjectionMatrixStereo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Matrix4x4[] viewProjectionMatrixStereo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal PreviousFrameData()
		{
		}
	}
}
