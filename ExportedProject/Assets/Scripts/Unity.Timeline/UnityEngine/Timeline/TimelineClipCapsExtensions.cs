namespace UnityEngine.Timeline
{
	internal static class TimelineClipCapsExtensions
	{
		public static bool SupportsExtrapolation(this TimelineClip clip)
		{
			return false;
		}

		public static bool HasAny(this ClipCaps caps, ClipCaps flags)
		{
			return false;
		}
	}
}
