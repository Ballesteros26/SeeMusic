using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public class ListView : BaseVerticalCollectionView
	{
		public new class UxmlFactory : UxmlFactory<ListView, UxmlTraits>
		{
		}

		public new class UxmlTraits : BindableElement.UxmlTraits
		{
			private readonly UxmlIntAttributeDescription m_FixedItemHeight;

			private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod;

			private readonly UxmlBoolAttributeDescription m_ShowBorder;

			private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

			private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

			private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader;

			private readonly UxmlStringAttributeDescription m_HeaderTitle;

			private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter;

			private readonly UxmlBoolAttributeDescription m_Reorderable;

			private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode;

			private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize;

			private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}
		}

		private bool m_ShowBoundCollectionSize;

		private bool m_ShowFoldoutHeader;

		private string m_HeaderTitle;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> itemsAdded;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<IEnumerable<int>> itemsRemoved;

		private Label m_EmptyListLabel;

		private Foldout m_Foldout;

		private TextField m_ArraySizeField;

		private VisualElement m_Footer;

		private Button m_AddButton;

		private Button m_RemoveButton;

		private Action<IEnumerable<int>> m_ItemAddedCallback;

		private Action<IEnumerable<int>> m_ItemRemovedCallback;

		private Action m_ItemsSourceSizeChangedCallback;

		private ListViewController m_ListViewController;

		private ListViewReorderMode m_ReorderMode;

		public new static readonly string ussClassName;

		public new static readonly string itemUssClassName;

		public static readonly string emptyLabelUssClassName;

		public static readonly string reorderableUssClassName;

		public static readonly string reorderableItemUssClassName;

		public static readonly string reorderableItemContainerUssClassName;

		public static readonly string reorderableItemHandleUssClassName;

		public static readonly string reorderableItemHandleBarUssClassName;

		public static readonly string footerUssClassName;

		public static readonly string foldoutHeaderUssClassName;

		public static readonly string arraySizeFieldUssClassName;

		public static readonly string listViewWithHeaderUssClassName;

		public static readonly string listViewWithFooterUssClassName;

		public static readonly string scrollViewWithFooterUssClassName;

		internal static readonly string footerAddButtonName;

		internal static readonly string footerRemoveButtonName;

		public bool showBoundCollectionSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override bool sourceIncludesArraySize => false;

		public bool showFoldoutHeader
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string headerTitle
		{
			set
			{
			}
		}

		public bool showAddRemoveFooter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal new ListViewController viewController => null;

		public ListViewReorderMode reorderMode
		{
			get
			{
				return default(ListViewReorderMode);
			}
			set
			{
			}
		}

		private void SetupArraySizeField()
		{
		}

		private void EnableFooter(bool enabled)
		{
		}

		private void AddItems(int itemCount)
		{
		}

		private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
		{
		}

		private void UpdateArraySizeField()
		{
		}

		private void UpdateEmpty()
		{
		}

		private void OnAddClicked()
		{
		}

		private void OnRemoveClicked()
		{
		}

		private protected override void CreateVirtualizationController()
		{
		}

		private protected override void CreateViewController()
		{
		}

		internal void SetViewController(ListViewController controller)
		{
		}

		private void OnItemAdded(IEnumerable<int> indices)
		{
		}

		private void OnItemsRemoved(IEnumerable<int> indices)
		{
		}

		private void OnItemsSourceSizeChanged()
		{
		}

		internal override ListViewDragger CreateDragger()
		{
			return null;
		}

		internal override ICollectionDragAndDropController CreateDragAndDropController()
		{
			return null;
		}

		private protected override void PostRefresh()
		{
		}
	}
}
