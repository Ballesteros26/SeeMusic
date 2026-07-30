namespace UnityEngine.Rendering.Universal
{
	internal sealed class MotionVectorsPersistentData
	{
		private readonly Matrix4x4[] m_ViewProjection;

		private readonly Matrix4x4[] m_PreviousViewProjection;

		private readonly int[] m_LastFrameIndex;

		private readonly float[] m_PrevAspectRatio;

		internal int lastFrameIndex => 0;

		internal Matrix4x4 viewProjection => default(Matrix4x4);

		internal Matrix4x4 previousViewProjection => default(Matrix4x4);

		internal Matrix4x4[] viewProjectionStereo => null;

		internal Matrix4x4[] previousViewProjectionStereo => null;

		internal MotionVectorsPersistentData()
		{
		}

		internal int GetXRMultiPassId(ref CameraData cameraData)
		{
			return 0;
		}

		public void Update(ref CameraData cameraData)
		{
		}
	}
}
