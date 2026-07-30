namespace UnityEngine.Rendering.Universal
{
	public interface IDebugDisplaySettingsData : IDebugDisplaySettingsQuery
	{
		IDebugDisplaySettingsPanelDisposable CreatePanel();
	}
}
