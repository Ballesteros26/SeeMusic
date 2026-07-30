namespace UnityEngine.Rendering.Universal
{
	[RequireComponent(typeof(Light))]
	[DisallowMultipleComponent]
	public class UniversalAdditionalLightData : MonoBehaviour, IAdditionalData
	{
		[SerializeField]
		private int m_Version;

		[SerializeField]
		[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
		private bool m_UsePipelineSettings;

		public static readonly int AdditionalLightsShadowResolutionTierCustom;

		public static readonly int AdditionalLightsShadowResolutionTierLow;

		public static readonly int AdditionalLightsShadowResolutionTierMedium;

		public static readonly int AdditionalLightsShadowResolutionTierHigh;

		public static readonly int AdditionalLightsShadowDefaultResolutionTier;

		public static readonly int AdditionalLightsShadowDefaultCustomResolution;

		public static readonly int AdditionalLightsShadowMinimumResolution;

		[SerializeField]
		[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
		private int m_AdditionalLightsShadowResolutionTier;

		[SerializeField]
		private LightLayerEnum m_LightLayerMask;

		[SerializeField]
		private bool m_CustomShadowLayers;

		[SerializeField]
		private LightLayerEnum m_ShadowLayerMask;

		[SerializeField]
		[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
		private Vector2 m_LightCookieSize;

		[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
		[SerializeField]
		private Vector2 m_LightCookieOffset;

		internal int version => 0;

		public bool usePipelineSettings
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int additionalLightsShadowResolutionTier => 0;

		public LightLayerEnum lightLayerMask
		{
			get
			{
				return default(LightLayerEnum);
			}
			set
			{
			}
		}

		public bool customShadowLayers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LightLayerEnum shadowLayerMask
		{
			get
			{
				return default(LightLayerEnum);
			}
			set
			{
			}
		}

		public Vector2 lightCookieSize
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 lightCookieOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}
	}
}
