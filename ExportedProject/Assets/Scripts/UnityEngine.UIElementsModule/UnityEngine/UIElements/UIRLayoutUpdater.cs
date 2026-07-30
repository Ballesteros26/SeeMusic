using Unity.Profiling;

namespace UnityEngine.UIElements
{
	internal class UIRLayoutUpdater : BaseVisualTreeUpdater
	{
		private static readonly string s_Description;

		private static readonly ProfilerMarker s_ProfilerMarker;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		public override void Update()
		{
		}

		private void UpdateSubTree(VisualElement ve, int currentLayoutPass, bool isDisplayed = true)
		{
		}
	}
}
