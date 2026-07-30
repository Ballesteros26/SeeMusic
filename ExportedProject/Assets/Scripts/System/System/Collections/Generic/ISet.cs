namespace System.Collections.Generic
{
	/// <summary>Provides the base interface for the abstraction of sets.</summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		/// <summary>Adds an element to the current set and returns a value to indicate if the element was successfully added. </summary>
		/// <returns>true if the element is added to the set; false if the element is already in the set.</returns>
		/// <param name="item">The element to add to the set.</param>
		new bool Add(T item);
	}
}
