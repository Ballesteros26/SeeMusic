using System;

namespace UnityEngine.Timeline
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TrackColorAttribute : Attribute
	{
		private Color m_Color;

		public TrackColorAttribute(float r, float g, float b)
		{
		}
	}
}
