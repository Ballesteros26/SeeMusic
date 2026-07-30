namespace UnityEngine.Rendering.Universal
{
	public interface IDebugDisplaySettingsQuery
	{
		bool AreAnySettingsActive { get; }

		bool IsPostProcessingAllowed { get; }

		bool IsLightingActive { get; }

		bool TryGetScreenClearColor(ref Color color);
	}
}
