using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	internal class InternalTreeView : VisualElement
	{
		public new class UxmlFactory : UxmlFactory<InternalTreeView, UxmlTraits>
		{
		}

		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			private readonly UxmlIntAttributeDescription m_ItemHeight;

			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private struct TreeViewItemWrapper
		{
			public int depth;

			public ITreeViewItem item;

			public int id => 0;
		}

		private static readonly string s_ListViewName;

		private static readonly string s_ItemToggleName;

		private static readonly string s_ItemIndentsContainerName;

		private static readonly string s_ItemIndentName;

		private static readonly string s_ItemContentContainerName;

		public static readonly string itemUssClassName;

		private Func<VisualElement> m_MakeItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<ITreeViewItem>> onItemsChosen;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<ITreeViewItem>> onSelectionChange;

		private List<ITreeViewItem> m_SelectedItems;

		private Action<VisualElement, ITreeViewItem> m_BindItem;

		private IList<ITreeViewItem> m_RootItems;

		[SerializeField]
		private List<int> m_ExpandedItemIds;

		private List<TreeViewItemWrapper> m_ItemWrappers;

		private readonly ListView m_ListView;

		internal readonly ScrollView m_ScrollView;

		public Action<VisualElement, ITreeViewItem> unbindItem { get; }

		public int itemHeight
		{
			set
			{
			}
		}

		public bool showBorder
		{
			set
			{
			}
		}

		public SelectionType selectionType
		{
			set
			{
			}
		}

		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			set
			{
			}
		}

		public void RefreshItems()
		{
		}

		public void Rebuild()
		{
		}

		internal override void OnViewDataReady()
		{
		}

		public static IEnumerable<ITreeViewItem> GetAllItems(IEnumerable<ITreeViewItem> rootItems)
		{
			return null;
		}

		public void OnKeyDown(KeyDownEvent evt)
		{
		}

		private void ListViewRefresh()
		{
		}

		private void OnItemsChosen(IEnumerable<object> chosenItems)
		{
		}

		private void OnSelectionChange(IEnumerable<object> selectedListItems)
		{
		}

		private void OnTreeViewMouseUp(MouseUpEvent evt)
		{
		}

		private void OnItemMouseUp(MouseUpEvent evt)
		{
		}

		private VisualElement MakeTreeItem()
		{
			return null;
		}

		private void UnbindTreeItem(VisualElement element, int index)
		{
		}

		private void BindTreeItem(VisualElement element, int index)
		{
		}

		internal int GetItemId(int index)
		{
			return 0;
		}

		private bool IsExpandedByIndex(int index)
		{
			return false;
		}

		private void CollapseItemByIndex(int index)
		{
		}

		private void ExpandItemByIndex(int index)
		{
		}

		private void ToggleExpandedState(ChangeEvent<bool> evt)
		{
		}

		private void CreateWrappers(IEnumerable<ITreeViewItem> treeViewItems, int depth, ref List<TreeViewItemWrapper> wrappers)
		{
		}

		private void RegenerateWrappers()
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}
	}
}
