using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal interface ITreeViewItem
	{
		int id { get; }

		IEnumerable<ITreeViewItem> children { get; }

		bool hasChildren { get; }
	}
}
