namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateMissingDebugShadersWarning()
			{
				return null;
			}
		}

		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			private const string k_GoToSectionString = "Go to Section...";

			public override string PanelName => null;
		}

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
