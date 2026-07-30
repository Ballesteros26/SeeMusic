namespace UnityEngine.UIElements
{
	internal interface IListDragAndDropArgs
	{
		int insertAtIndex { get; }

		int parentId { get; }

		int childIndex { get; }

		IDragAndDropData dragAndDropData { get; }

		DragAndDropPosition dragAndDropPosition { get; }
	}
}
