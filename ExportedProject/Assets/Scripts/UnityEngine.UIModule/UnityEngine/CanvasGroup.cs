using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	[NativeClass("UI::CanvasGroup")]
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		[NativeProperty("Alpha", false, TargetType.Function)]
		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("Interactable", false, TargetType.Function)]
		public bool interactable => false;

		[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
		public bool blocksRaycasts => false;

		[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
		public bool ignoreParentGroups => false;

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}
	}
}
