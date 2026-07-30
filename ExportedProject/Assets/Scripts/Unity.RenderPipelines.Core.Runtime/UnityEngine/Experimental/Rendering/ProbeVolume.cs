namespace UnityEngine.Experimental.Rendering
{
	[AddComponentMenu("Light/Probe Volume (Experimental)")]
	[ExecuteAlways]
	public class ProbeVolume : MonoBehaviour
	{
		public bool globalVolume;

		public Vector3 size;

		[Range(0f, 2f)]
		[HideInInspector]
		public float geometryDistanceOffset;

		public LayerMask objectLayerMask;

		[HideInInspector]
		public int lowestSubdivLevelOverride;

		[HideInInspector]
		public int highestSubdivLevelOverride;

		[HideInInspector]
		public bool overridesSubdivLevels;

		[SerializeField]
		internal bool mightNeedRebaking;

		[SerializeField]
		internal Matrix4x4 cachedTransform;

		[SerializeField]
		internal int cachedHashCode;
	}
}
