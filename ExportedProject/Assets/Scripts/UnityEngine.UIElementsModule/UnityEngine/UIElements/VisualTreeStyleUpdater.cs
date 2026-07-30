using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	internal class VisualTreeStyleUpdater : BaseVisualTreeUpdater
	{
		private HashSet<VisualElement> m_ApplyStyleUpdateList;

		private HashSet<VisualElement> m_TransitionPropertyUpdateList;

		private bool m_IsApplyingStyles;

		private uint m_Version;

		private uint m_LastVersion;

		private VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal;

		private static readonly string s_Description;

		private static readonly ProfilerMarker s_ProfilerMarker;

		public override ProfilerMarker profilerMarker => default(ProfilerMarker);

		public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
		}

		public override void Update()
		{
		}

		private void ApplyStyles()
		{
		}
	}
}
