using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal.Internal
{
	internal sealed class MotionVectorRendering
	{
		private static MotionVectorRendering s_Instance;

		private Dictionary<Camera, PreviousFrameData> m_CameraFrameData;

		private uint m_FrameCount;

		private float m_LastTime;

		private float m_Time;

		public static MotionVectorRendering instance => null;

		private MotionVectorRendering()
		{
		}

		public void Clear()
		{
		}

		public PreviousFrameData GetMotionDataForCamera(Camera camera, CameraData camData)
		{
			return null;
		}

		private void CalculateTime()
		{
		}

		private void UpdateMotionData(Camera camera, CameraData cameraData, PreviousFrameData motionData)
		{
		}
	}
}
