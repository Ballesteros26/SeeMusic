using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	internal abstract class TreeViewController : CollectionViewController
	{
		private Dictionary<int, TreeItem> m_TreeItems;

		private List<int> m_RootIndices;

		private List<TreeViewItemWrapper> m_ItemWrappers;

		private HashSet<int> m_TreeItemIdsWithItemWrappers;

		private List<TreeViewItemWrapper> m_WrapperInsertionList;

		private static readonly ProfilerMarker K_ExpandItemByIndex;

		private static readonly ProfilerMarker k_CreateWrappers;

		protected UnityEngine.UIElements.Experimental.TreeView treeView => null;

		public void RebuildTree()
		{
		}

		public IEnumerable<int> GetRootItemIds()
		{
			return null;
		}

		public abstract IEnumerable<int> GetAllItemIds(IEnumerable<int> rootIds = null);

		public abstract int GetParentId(int id);

		public abstract IEnumerable<int> GetChildrenIds(int id);

		public abstract void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true);

		public virtual bool HasChildren(int id)
		{
			return false;
		}

		public bool HasChildrenByIndex(int index)
		{
			return false;
		}

		public IEnumerable<int> GetChildrenIdsByIndex(int index)
		{
			return null;
		}

		public int GetChildIndexForId(int id)
		{
			return 0;
		}

		public int GetIndentationDepth(int id)
		{
			return 0;
		}

		public bool IsExpanded(int id)
		{
			return false;
		}

		public bool IsExpandedByIndex(int index)
		{
			return false;
		}

		public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true)
		{
		}

		public void ExpandItem(int id, bool expandAllChildren, bool refresh = true)
		{
		}

		internal void RegenerateWrappers()
		{
		}

		private void CreateWrappers(IEnumerable<int> treeViewItemIds, int depth, ref List<TreeViewItemWrapper> wrappers)
		{
		}

		private bool IsIndexValid(int index)
		{
			return false;
		}

		internal void RaiseItemParentChanged(int id, int newParentId)
		{
		}
	}
}
