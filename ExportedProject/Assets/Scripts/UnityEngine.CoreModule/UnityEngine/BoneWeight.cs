using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[Serializable]
	[UsedByNativeCode]
	public struct BoneWeight : IEquatable<BoneWeight>
	{
		[SerializeField]
		private float m_Weight0;

		[SerializeField]
		private float m_Weight1;

		[SerializeField]
		private float m_Weight2;

		[SerializeField]
		private float m_Weight3;

		[SerializeField]
		private int m_BoneIndex0;

		[SerializeField]
		private int m_BoneIndex1;

		[SerializeField]
		private int m_BoneIndex2;

		[SerializeField]
		private int m_BoneIndex3;

		public float weight0 => 0f;

		public float weight1 => 0f;

		public float weight2 => 0f;

		public float weight3 => 0f;

		public int boneIndex0 => 0;

		public int boneIndex1 => 0;

		public int boneIndex2 => 0;

		public int boneIndex3 => 0;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(BoneWeight other)
		{
			return false;
		}
	}
}
