using System;

namespace UnityEngine.Timeline
{
	[AttributeUsage(AttributeTargets.Class)]
	public class TrackBindingTypeAttribute : Attribute
	{
		public readonly Type type;

		public readonly TrackBindingFlags flags;

		public TrackBindingTypeAttribute(Type type)
		{
		}
	}
}
