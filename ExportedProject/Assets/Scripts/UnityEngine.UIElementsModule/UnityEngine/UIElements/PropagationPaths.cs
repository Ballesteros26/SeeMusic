using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class PropagationPaths
	{
		[Flags]
		public enum Type
		{
			None = 0,
			TrickleDown = 1,
			BubbleUp = 2
		}

		private static readonly ObjectPool<PropagationPaths> s_Pool;

		public readonly List<VisualElement> trickleDownPath;

		public readonly List<VisualElement> targetElements;

		public readonly List<VisualElement> bubbleUpPath;

		private const int k_DefaultPropagationDepth = 16;

		private const int k_DefaultTargetCount = 4;

		internal static PropagationPaths Copy(PropagationPaths paths)
		{
			return null;
		}

		public static PropagationPaths Build(VisualElement elem, EventBase evt, Type pathTypesRequested)
		{
			return null;
		}

		public void Release()
		{
		}
	}
}
