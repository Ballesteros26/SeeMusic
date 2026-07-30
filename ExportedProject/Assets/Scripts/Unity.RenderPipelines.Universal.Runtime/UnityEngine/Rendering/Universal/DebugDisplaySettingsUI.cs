using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal
{
	public class DebugDisplaySettingsUI : IDebugData
	{
		private IEnumerable<IDebugDisplaySettingsPanelDisposable> m_DisposablePanels;

		private DebugDisplaySettings m_Settings;

		private void Reset()
		{
		}

		public void RegisterDebug(DebugDisplaySettings settings)
		{
		}

		public void UnregisterDebug()
		{
		}

		public Action GetReset()
		{
			return null;
		}
	}
}
