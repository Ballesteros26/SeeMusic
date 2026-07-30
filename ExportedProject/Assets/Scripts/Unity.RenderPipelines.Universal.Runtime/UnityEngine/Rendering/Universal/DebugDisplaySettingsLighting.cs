namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		private static class Strings
		{
			public static readonly DebugUI.Widget.NameAndTooltip LightingDebugMode;

			public static readonly DebugUI.Widget.NameAndTooltip LightingFeatures;
		}

		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateLightingDebugMode(DebugDisplaySettingsLighting data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateLightingFeatures(DebugDisplaySettingsLighting data)
			{
				return null;
			}
		}

		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public override string PanelName => null;

			public SettingsPanel(DebugDisplaySettingsLighting data)
			{
			}
		}

		internal DebugLightingMode DebugLightingMode { get; private set; }

		internal DebugLightingFeatureFlags DebugLightingFeatureFlagsMask { get; private set; }

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
