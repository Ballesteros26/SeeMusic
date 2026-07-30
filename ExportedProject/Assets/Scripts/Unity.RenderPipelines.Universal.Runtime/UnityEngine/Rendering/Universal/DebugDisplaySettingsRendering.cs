namespace UnityEngine.Rendering.Universal
{
	internal class DebugDisplaySettingsRendering : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
	{
		private enum WireframeMode
		{
			None = 0,
			Wireframe = 1,
			SolidWireframe = 2,
			ShadedWireframe = 3
		}

		private static class Strings
		{
			public const string RangeValidationSettingsContainerName = "Pixel Range Settings";

			public static readonly DebugUI.Widget.NameAndTooltip MapOverlays;

			public static readonly DebugUI.Widget.NameAndTooltip MapSize;

			public static readonly DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;

			public static readonly DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;

			public static readonly DebugUI.Widget.NameAndTooltip Overdraw;

			public static readonly DebugUI.Widget.NameAndTooltip PostProcessing;

			public static readonly DebugUI.Widget.NameAndTooltip MSAA;

			public static readonly DebugUI.Widget.NameAndTooltip HDR;

			public static readonly DebugUI.Widget.NameAndTooltip PixelValidationMode;

			public static readonly DebugUI.Widget.NameAndTooltip Channels;

			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMin;

			public static readonly DebugUI.Widget.NameAndTooltip ValueRangeMax;
		}

		internal static class WidgetFactory
		{
			internal static DebugUI.Widget CreateMapOverlays(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMapOverlaySize(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateAdditionalWireframeShaderViews(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateWireframeNotSupportedWarning(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateOverdraw(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePostProcessing(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateMSAA(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreateHDR(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValidationMode(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValidationChannels(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValueRangeMin(DebugDisplaySettingsRendering data)
			{
				return null;
			}

			internal static DebugUI.Widget CreatePixelValueRangeMax(DebugDisplaySettingsRendering data)
			{
				return null;
			}
		}

		private class SettingsPanel : DebugDisplaySettingsPanel
		{
			public override string PanelName => null;

			public SettingsPanel(DebugDisplaySettingsRendering data)
			{
			}
		}

		private WireframeMode m_WireframeMode;

		private bool m_Overdraw;

		private WireframeMode wireframeMode
		{
			get
			{
				return default(WireframeMode);
			}
			set
			{
			}
		}

		private bool overdraw
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal DebugFullScreenMode debugFullScreenMode { get; private set; }

		internal int debugFullScreenModeOutputSizeScreenPercent { get; private set; }

		internal DebugSceneOverrideMode debugSceneOverrideMode { get; private set; }

		internal DebugMipInfoMode debugMipInfoMode { get; private set; }

		internal DebugPostProcessingMode debugPostProcessingMode { get; private set; }

		internal bool enableMsaa { get; private set; }

		internal bool enableHDR { get; private set; }

		internal DebugValidationMode validationMode { get; private set; }

		internal PixelValidationChannels validationChannels { get; private set; }

		internal float ValidationRangeMin { get; private set; }

		internal float ValidationRangeMax { get; private set; }

		public bool AreAnySettingsActive => false;

		public bool IsPostProcessingAllowed => false;

		public bool IsLightingActive => false;

		private void UpdateDebugSceneOverrideMode()
		{
		}

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
