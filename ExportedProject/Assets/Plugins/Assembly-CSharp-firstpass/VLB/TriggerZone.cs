using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[DisallowMultipleComponent]
	public class TriggerZone : MonoBehaviour
	{
		public bool setIsTrigger;

		public float rangeMultiplier;

		private const int kMeshColliderNumSides = 8;

		private Mesh m_Mesh;

		private void Update()
		{
		}
	}
}
