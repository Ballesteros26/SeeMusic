using System.Collections.Generic;

namespace UnityEngine.UIElements.Experimental
{
	internal class TreeView : BaseVerticalCollectionView
	{
		public new static readonly string ussClassName;

		public new static readonly string itemUssClassName;

		public static readonly string itemToggleUssClassName;

		public static readonly string itemIndentsContainerUssClassName;

		public static readonly string itemIndentUssClassName;

		public static readonly string itemContentContainerUssClassName;

		[SerializeField]
		private List<int> m_ExpandedItemIds;

		internal new TreeViewController viewController => null;

		internal List<int> expandedItemIds => null;

		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		public bool IsExpanded(int id)
		{
			return false;
		}
	}
}
