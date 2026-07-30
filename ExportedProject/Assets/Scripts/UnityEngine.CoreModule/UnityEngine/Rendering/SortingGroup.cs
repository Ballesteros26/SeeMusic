using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[RequireComponent(typeof(Transform))]
	[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
	public sealed class SortingGroup : Behaviour
	{
		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static int invalidSortingGroupID => 0;

		public int sortingLayerID => 0;

		public int sortingOrder => 0;

		[StaticAccessor("SortingGroup", StaticAccessorType.DoubleColon)]
		internal static SortingGroup GetSortingGroupByIndex(int index)
		{
			return null;
		}
	}
}
