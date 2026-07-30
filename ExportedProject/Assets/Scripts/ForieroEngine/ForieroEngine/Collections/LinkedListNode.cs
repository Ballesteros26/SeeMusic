namespace ForieroEngine.Collections
{
	internal class LinkedListNode<T> where T : class
	{
		internal LinkedList<T> List;

		internal LinkedListNode<T> NextInternal;

		internal LinkedListNode<T> PrevInternal;

		public T Value { get; set; }

		public LinkedListNode<T> Next => null;

		public LinkedListNode<T> Prev => null;

		public void Invalidate()
		{
		}
	}
}
