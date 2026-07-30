namespace UnityEngine.Rendering.Universal
{
	public interface IDebugDisplaySettingsPanel
	{
		string PanelName { get; }

		DebugUI.Widget[] Widgets { get; }
	}
}
