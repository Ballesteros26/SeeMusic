namespace UnityEngine.UIElements
{
	internal abstract class DragAndDropData : IDragAndDropData
	{
		object IDragAndDropData.userData => null;

		public abstract object source { get; }

		public abstract object GetGenericData(string key);
	}
}
