using System;
using UnityEngine.Internal;

namespace UnityEngine.Rendering
{
	public struct FilteringSettings : IEquatable<FilteringSettings>
	{
		private RenderQueueRange m_RenderQueueRange;

		private int m_LayerMask;

		private uint m_RenderingLayerMask;

		private int m_ExcludeMotionVectorObjects;

		private SortingLayerRange m_SortingLayerRange;

		public RenderQueueRange renderQueueRange
		{
			set
			{
			}
		}

		public int layerMask
		{
			set
			{
			}
		}

		public uint renderingLayerMask
		{
			set
			{
			}
		}

		public bool excludeMotionVectorObjects
		{
			set
			{
			}
		}

		public SortingLayerRange sortingLayerRange
		{
			set
			{
			}
		}

		public FilteringSettings([DefaultValue("RenderQueueRange.all")] RenderQueueRange? renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = uint.MaxValue, int excludeMotionVectorObjects = 0)
		{
			m_RenderQueueRange = default(RenderQueueRange);
			m_LayerMask = 0;
			m_RenderingLayerMask = 0u;
			m_ExcludeMotionVectorObjects = 0;
			m_SortingLayerRange = default(SortingLayerRange);
		}

		public bool Equals(FilteringSettings other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
