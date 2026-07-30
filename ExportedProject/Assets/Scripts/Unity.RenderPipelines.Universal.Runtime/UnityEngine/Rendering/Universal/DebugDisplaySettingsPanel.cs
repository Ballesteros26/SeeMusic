using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public abstract class DebugDisplaySettingsPanel : IDebugDisplaySettingsPanelDisposable, IDebugDisplaySettingsPanel, IDisposable
	{
		private readonly List<DebugUI.Widget> m_Widgets;

		public abstract string PanelName { get; }

		public DebugUI.Widget[] Widgets => null;

		protected void AddWidget(DebugUI.Widget widget)
		{
		}

		public void Dispose()
		{
		}
	}
}
