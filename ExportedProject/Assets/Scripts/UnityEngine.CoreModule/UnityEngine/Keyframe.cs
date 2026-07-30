using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	public struct Keyframe
	{
		private float m_Time;

		private float m_Value;

		private float m_InTangent;

		private float m_OutTangent;

		private int m_WeightedMode;

		private float m_InWeight;

		private float m_OutWeight;

		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float value => 0f;

		public float inTangent => 0f;

		public float outTangent => 0f;

		public Keyframe(float time, float value)
		{
			m_Time = 0f;
			m_Value = 0f;
			m_InTangent = 0f;
			m_OutTangent = 0f;
			m_WeightedMode = 0;
			m_InWeight = 0f;
			m_OutWeight = 0f;
		}

		public Keyframe(float time, float value, float inTangent, float outTangent)
		{
			m_Time = 0f;
			m_Value = 0f;
			m_InTangent = 0f;
			m_OutTangent = 0f;
			m_WeightedMode = 0;
			m_InWeight = 0f;
			m_OutWeight = 0f;
		}
	}
}
