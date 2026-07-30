namespace ForieroEngine.Collections
{
	internal class LinkedList<T> where T : class
	{
		public LinkedListNode<T> First { get; set; }

		public int Length { get; private set; }

		public void AddFirst(T value)
		{
		}

		public void AddLast(T value)
		{
		}

		public T RemoveFirst()
		{
			return null;
		}

		public T RemoveLast()
		{
			return null;
		}

		public void Remove(LinkedListNode<T> n)
		{
		}

		private void InsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
		{
		}

		private void InsertNodeToEmptyList(LinkedListNode<T> node)
		{
		}
	}
}
