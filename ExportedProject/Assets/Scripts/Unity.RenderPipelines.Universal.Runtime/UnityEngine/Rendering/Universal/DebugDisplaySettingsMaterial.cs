namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		internal enum AlbedoDebugValidationPreset
		{
			DefaultLuminance = 0,
			BlackAcrylicPaint = 1,
			DarkSoil = 2,
			WornAsphalt = 3,
			DryClaySoil = 4,
			GreenGrass = 5,
			OldConcrete = 6,
			RedClayTile = 7,
			DrySand = 8,
			NewConcrete = 9,
			WhiteAcrylicPaint = 10,
			FreshSnow = 11,
			BlueSky = 12,
			Foliage = 13
		}

		private struct AlbedoDebugValidationPresetData
		{
			public string name;

			public Color color;

			public float minLuminance;

			public float maxLuminance;
		}

		private static class Strings
		{
			public const string AlbedoSettingsContainerName = "Albedo Settings";

			public const string MetallicSettingsContainerName = "Metallic Settings";

			public static readonly DebugUI.Widget.NameAndTooltip MaterialOverride;

			public static readonly DebugUI.Widget.NameAndTooltip VertexAttribute;

			public static readonly DebugUI.Widget.NameAndTooltip MaterialValidationMode;

			public static readonly DebugUI.Widget.NameAndTooltip ValidationPreset;

			public static readonly DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;

			public static readonly DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;

			public static readonly DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;

			public static readonly DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;

			public static readonly DebugUI.Widget.NameAndTooltip MetallicMinValue;

			public static readonly DebugUI.Widget.NameAndTooltip MetallicMaxValue;
		}

		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateMaterialOverride(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateVertexAttribute(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMaterialValidationMode(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAlbedoPreset(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAlbedoMinLuminance(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAlbedoMaxLuminance(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAlbedoHueTolerance(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAlbedoSaturationTolerance(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMetallicMinValue(DebugDisplaySettingsMaterial data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMetallicMaxValue(DebugDisplaySettingsMaterial data)
			{
				return null;
			}
		}

		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public override string PanelName => null;

			public SettingsPanel(DebugDisplaySettingsMaterial data)
			{
			}
		}

		private AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;

		private AlbedoDebugValidationPreset m_AlbedoDebugValidationPreset;

		internal float AlbedoMinLuminance;

		internal float AlbedoMaxLuminance;

		private float m_AlbedoHueTolerance;

		private float m_AlbedoSaturationTolerance;

		internal Color AlbedoCompareColor;

		internal float MetallicMinValue;

		internal float MetallicMaxValue;

		internal DebugMaterialValidationMode MaterialValidationMode;

		internal AlbedoDebugValidationPreset albedoDebugValidationPreset
		{
			get
			{
				return default(AlbedoDebugValidationPreset);
			}
			set
			{
			}
		}

		internal float AlbedoHueTolerance
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		internal float AlbedoSaturationTolerance
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		internal DebugMaterialMode DebugMaterialModeData { get; private set; }

		internal DebugVertexAttributeMode DebugVertexAttributeIndexData { get; private set; }

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		public bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}

		public IDebugDisplaySettingsPanelDisposable CreatePanel()
		{
			return null;
		}
	}
}
