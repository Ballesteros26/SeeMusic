using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering
{
	[AddComponentMenu("Miscellaneous/Volume")]
	[ExecuteAlways]
	public class Volume : MonoBehaviour, IVolume
	{
		[FormerlySerializedAs("isGlobal")]
		[SerializeField]
		private bool m_IsGlobal;

		[Tooltip("When multiple Volumes affect the same settings, Unity uses this value to determine which Volume to use. A Volume with the highest Priority value takes precedence.")]
		public float priority;

		[Tooltip("Sets the outer distance to start blending from. A value of 0 means no blending and Unity applies the Volume overrides immediately upon entry.")]
		public float blendDistance;

		[Tooltip("Sets the total weight of this Volume in the Scene. 0 means no effect and 1 means full effect.")]
		[Range(0f, 1f)]
		public float weight;

		public VolumeProfile sharedProfile;

		internal List<Collider> m_Colliders;

		private int m_PreviousLayer;

		private float m_PreviousPriority;

		private VolumeProfile m_InternalProfile;

		[Tooltip("When enabled, the Volume is applied to the entire Scene.")]
		public bool isGlobal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VolumeProfile profile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<Collider> colliders => null;

		internal VolumeProfile profileRef => null;

		public bool HasInstantiatedProfile()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		internal void UpdateLayer()
		{
		}
	}
}
