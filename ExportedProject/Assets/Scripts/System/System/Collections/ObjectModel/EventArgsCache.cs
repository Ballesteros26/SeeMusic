using System.Collections.Specialized;
using System.ComponentModel;

namespace System.Collections.ObjectModel
{
	internal static class EventArgsCache
	{
		internal static readonly PropertyChangedEventArgs CountPropertyChanged;

		internal static readonly PropertyChangedEventArgs IndexerPropertyChanged;

		internal static readonly NotifyCollectionChangedEventArgs ResetCollectionChanged;
	}
}
