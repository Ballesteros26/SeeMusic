using System.Collections.Generic;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
	{
		protected class DropData
		{
			public int[] draggedIds;
		}

		private struct TreeItemState
		{
			public int parentId;

			public int childIndex;

			public TreeItemState(int parentId, int childIndex)
			{
				this.parentId = 0;
				this.childIndex = 0;
			}
		}

		protected DropData m_DropData;

		protected readonly UnityEngine.UIElements.Experimental.TreeView m_TreeView;

		public TreeViewReorderableDragAndDropController(UnityEngine.UIElements.Experimental.TreeView view)
			: base(null)
		{
		}

		protected override int CompareId(int id1, int id2)
		{
			return 0;
		}

		public override StartDragArgs SetupDragAndDrop(IEnumerable<int> itemIds, bool skipText = false)
		{
			return default(StartDragArgs);
		}

		public override DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args)
		{
			return default(DragVisualMode);
		}

		public override void OnDrop(IListDragAndDropArgs args)
		{
		}

		public override void DragCleanup()
		{
		}
	}
}
