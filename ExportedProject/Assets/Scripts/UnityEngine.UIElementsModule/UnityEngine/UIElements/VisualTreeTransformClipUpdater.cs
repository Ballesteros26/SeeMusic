using Unity.Profiling;

namespace UnityEngine.UIElements
{
	internal class VisualTreeTransformClipUpdater : BaseVisualTreeUpdater
	{
		private uint m_Version;

		private uint m_LastVersion;

		private static readonly string s_Description;

		private static readonly ProfilerMarker s_ProfilerMarker;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		private static void DirtyHierarchy(VisualElement ve, bool mustDirtyWorldTransform, bool mustDirtyWorldClip)
		{
		}

		private static void DirtyBoundingBoxHierarchy(VisualElement ve)
		{
		}

		public override void Update()
		{
		}
	}
}
