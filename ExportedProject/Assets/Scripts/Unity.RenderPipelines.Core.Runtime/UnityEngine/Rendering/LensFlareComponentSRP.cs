namespace UnityEngine.Rendering
{
	[AddComponentMenu("Rendering/Lens Flare (SRP)")]
	[ExecuteAlways]
	public sealed class LensFlareComponentSRP : MonoBehaviour
	{
		[SerializeField]
		private LensFlareDataSRP m_LensFlareData;

		[Min(0f)]
		public float intensity;

		[Min(1E-05f)]
		public float maxAttenuationDistance;

		[Min(1E-05f)]
		public float maxAttenuationScale;

		public AnimationCurve distanceAttenuationCurve;

		public AnimationCurve scaleByDistanceCurve;

		public bool attenuationByLightShape;

		public AnimationCurve radialScreenAttenuationCurve;

		public bool useOcclusion;

		[Min(0f)]
		public float occlusionRadius;

		[Range(1f, 64f)]
		public uint sampleCount;

		public float occlusionOffset;

		[Min(0f)]
		public float scale;

		public bool allowOffScreen;

		private static float sCelestialAngularRadius;

		public LensFlareDataSRP lensFlareData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float celestialProjectedOcclusionRadius(Camera mainCam)
		{
			return 0f;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnValidate()
		{
		}
	}
}
