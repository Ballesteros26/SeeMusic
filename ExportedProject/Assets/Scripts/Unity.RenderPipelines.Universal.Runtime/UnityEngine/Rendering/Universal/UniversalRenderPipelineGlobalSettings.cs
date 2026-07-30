using System;

namespace UnityEngine.Rendering.Universal
{
	internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, ISerializationCallbackReceiver
	{
		[SerializeField]
		private int k_AssetVersion;

		private static UniversalRenderPipelineGlobalSettings cachedInstance;

		public static readonly string defaultAssetName;

		[NonSerialized]
		private string[] m_RenderingLayerNames;

		[NonSerialized]
		private string[] m_PrefixedRenderingLayerNames;

		[NonSerialized]
		private string[] m_PrefixedLightLayerNames;

		private static readonly string[] k_DefaultLightLayerNames;

		public string lightLayerName0;

		public string lightLayerName1;

		public string lightLayerName2;

		public string lightLayerName3;

		public string lightLayerName4;

		public string lightLayerName5;

		public string lightLayerName6;

		public string lightLayerName7;

		[NonSerialized]
		private string[] m_LightLayerNames;

		[SerializeField]
		private bool m_StripDebugVariants;

		[SerializeField]
		private bool m_StripUnusedPostProcessingVariants;

		[SerializeField]
		private bool m_StripUnusedVariants;

		[Obsolete("Please use stripRuntimeDebugShaders instead.", false)]
		public bool supportRuntimeDebugDisplay;

		public static UniversalRenderPipelineGlobalSettings instance => null;

		private string[] renderingLayerNames => null;

		private string[] prefixedRenderingLayerNames => null;

		public string[] renderingLayerMaskNames => null;

		public string[] prefixedRenderingLayerMaskNames => null;

		public string[] prefixedLightLayerNames => null;

		public string[] lightLayerNames => null;

		public bool stripDebugVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stripUnusedPostProcessingVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool stripUnusedVariants
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		internal static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings)
		{
		}

		private void Reset()
		{
		}

		internal void UpdateRenderingLayerNames()
		{
		}

		internal void ResetRenderingLayerNames()
		{
		}
	}
}
