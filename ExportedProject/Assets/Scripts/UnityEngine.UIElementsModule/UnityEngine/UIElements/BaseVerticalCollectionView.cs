using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private Action<IEnumerable<int>> onSelectedIndicesChange;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action<int, int> itemIndexChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Action itemsSourceChanged;

		private Func<int, int> m_GetItemId;

		private Func<VisualElement> m_MakeItem;

		private Action<VisualElement, int> m_BindItem;

		private SelectionType m_SelectionType;

		[SerializeField]
		internal SerializedVirtualizationData serializedVirtualizationData;

		private static readonly List<ReusableCollectionItem> k_EmptyItems;

		private bool m_HorizontalScrollingEnabled;

		[SerializeField]
		private AlternatingRowBackground m_ShowAlternatingRowBackgrounds;

		internal static readonly int s_DefaultItemHeight;

		internal float m_FixedItemHeight;

		internal bool m_ItemHeightIsInline;

		private CollectionVirtualizationMethod m_VirtualizationMethod;

		private readonly ScrollView m_ScrollView;

		private CollectionViewController m_ViewController;

		private CollectionVirtualizationController m_VirtualizationController;

		private KeyboardNavigationManipulator m_NavigationManipulator;

		[SerializeField]
		internal Vector2 m_ScrollOffset;

		[SerializeField]
		private readonly List<int> m_SelectedIds;

		private readonly List<int> m_SelectedIndices;

		private readonly List<object> m_SelectedItems;

		private float m_LastHeight;

		private bool m_IsRangeSelectionDirectionUp;

		private ListViewDragger m_Dragger;

		internal static CustomStyleProperty<int> s_ItemHeightProperty;

		private Action<int, int> m_ItemIndexChangedCallback;

		private Action m_ItemsSourceChangedCallback;

		public static readonly string ussClassName;

		public static readonly string borderUssClassName;

		public static readonly string itemUssClassName;

		public static readonly string dragHoverBarUssClassName;

		public static readonly string dragHoverMarkerUssClassName;

		public static readonly string itemDragHoverUssClassName;

		public static readonly string itemSelectedVariantUssClassName;

		public static readonly string itemAlternativeBackgroundUssClassName;

		public static readonly string listScrollViewUssClassName;

		internal static readonly string backgroundFillUssClassName;

		private Vector3 m_TouchDownPosition;

		internal Func<int, int> getItemId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IList itemsSource
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal virtual bool sourceIncludesArraySize => false;

		public Func<VisualElement> makeItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<VisualElement, int> bindItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Action<VisualElement, int> unbindItem { get; set; }

		public Action<VisualElement> destroyItem { get; }

		public override VisualElement contentContainer => null;

		public SelectionType selectionType
		{
			get
			{
				return default(SelectionType);
			}
			set
			{
			}
		}

		public int selectedIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public IEnumerable<int> selectedIndices => null;

		internal List<int> selectedIds => null;

		internal IEnumerable<ReusableCollectionItem> activeItems => null;

		internal ScrollView scrollView => null;

		internal ListViewDragger dragger => null;

		internal CollectionViewController viewController => null;

		internal CollectionVirtualizationController virtualizationController => null;

		public bool showBorder
		{
			set
			{
			}
		}

		public bool reorderable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool horizontalScrollingEnabled
		{
			set
			{
			}
		}

		public AlternatingRowBackground showAlternatingRowBackgrounds
		{
			get
			{
				return default(AlternatingRowBackground);
			}
			set
			{
			}
		}

		public CollectionVirtualizationMethod virtualizationMethod
		{
			get
			{
				return default(CollectionVirtualizationMethod);
			}
			set
			{
			}
		}

		public float fixedItemHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal float lastHeight => 0f;

		public event Action<IEnumerable<object>> onItemsChosen
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<IEnumerable<object>> onSelectionChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal float ResolveItemHeight(float height = -1f)
		{
			return 0f;
		}

		private protected virtual void CreateVirtualizationController()
		{
		}

		internal CollectionVirtualizationController GetOrCreateVirtualizationController()
		{
			return null;
		}

		internal void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
		{
		}

		internal CollectionViewController GetOrCreateViewController()
		{
			return null;
		}

		private protected virtual void CreateViewController()
		{
		}

		internal void SetViewController(CollectionViewController controller)
		{
		}

		internal virtual ListViewDragger CreateDragger()
		{
			return null;
		}

		internal void InitializeDragAndDropController(bool enableReordering)
		{
		}

		internal abstract ICollectionDragAndDropController CreateDragAndDropController();

		public BaseVerticalCollectionView()
		{
		}

		public VisualElement GetRootElementForId(int id)
		{
			return null;
		}

		internal bool HasValidDataAndBindings()
		{
			return false;
		}

		private void OnItemIndexChanged(int srcIndex, int dstIndex)
		{
		}

		private void OnItemsSourceChanged()
		{
		}

		public void RefreshItems()
		{
		}

		public void Rebuild()
		{
		}

		private void RefreshSelection()
		{
		}

		private protected virtual void PostRefresh()
		{
		}

		public void ScrollToItem(int index)
		{
		}

		private void OnScroll(Vector2 offset)
		{
		}

		private void Resize(Vector2 size)
		{
		}

		private void OnAttachToPanel(AttachToPanelEvent evt)
		{
		}

		private void OnDetachFromPanel(DetachFromPanelEvent evt)
		{
		}

		private bool Apply(KeyboardNavigationOperation op, bool shiftKey)
		{
			return false;
		}

		private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
		{
		}

		private void OnPointerMove(PointerMoveEvent evt)
		{
		}

		private void OnPointerDown(PointerDownEvent evt)
		{
		}

		private void OnPointerCancel(PointerCancelEvent evt)
		{
		}

		private void OnPointerUp(PointerUpEvent evt)
		{
		}

		private void ProcessPointerDown(IPointerEvent evt)
		{
		}

		private void ProcessPointerUp(IPointerEvent evt)
		{
		}

		private void DoSelect(Vector2 localPosition, int clickCount, bool actionKey, bool shiftKey)
		{
		}

		private void DoRangeSelection(int rangeSelectionFinalIndex)
		{
		}

		private void ProcessSingleClick(int clickedIndex)
		{
		}

		internal void SelectAll()
		{
		}

		public void AddToSelection(int index)
		{
		}

		internal void AddToSelection(IList<int> indexes)
		{
		}

		private void AddToSelectionWithoutValidation(int index)
		{
		}

		public void RemoveFromSelection(int index)
		{
		}

		private void RemoveFromSelectionWithoutValidation(int index)
		{
		}

		public void SetSelection(int index)
		{
		}

		public void SetSelection(IEnumerable<int> indices)
		{
		}

		public void SetSelectionWithoutNotify(IEnumerable<int> indices)
		{
		}

		internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
		{
		}

		private void NotifyOfSelectionChange()
		{
		}

		public void ClearSelection()
		{
		}

		private void ClearSelectionWithoutValidation()
		{
		}

		internal override void OnViewDataReady()
		{
		}

		protected override void ExecuteDefaultAction(EventBase evt)
		{
		}

		private void OnSizeChanged(GeometryChangedEvent evt)
		{
		}

		private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
