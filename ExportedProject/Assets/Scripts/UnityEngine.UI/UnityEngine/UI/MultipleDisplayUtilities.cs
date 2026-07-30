using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	internal static class MultipleDisplayUtilities
	{
		public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
		{
			return false;
		}

		public static Vector3 RelativeMouseAtScaled(Vector2 position)
		{
			return default(Vector3);
		}
	}
}
