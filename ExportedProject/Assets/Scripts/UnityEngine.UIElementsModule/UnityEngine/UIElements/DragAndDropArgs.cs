using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements
{
	internal struct DragAndDropArgs : IListDragAndDropArgs
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private object _003Ctarget_003Ek__BackingField;

		public object target
		{
			[CompilerGenerated]
			set
			{
				_003Ctarget_003Ek__BackingField = value;
			}
		}

		public int insertAtIndex { get; set; }

		public int parentId { get; set; }

		public int childIndex { get; set; }

		public DragAndDropPosition dragAndDropPosition { get; set; }

		public IDragAndDropData dragAndDropData { get; set; }
	}
}
