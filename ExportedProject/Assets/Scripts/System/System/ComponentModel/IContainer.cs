namespace System.ComponentModel
{
	/// <summary>Provides functionality for containers. Containers are objects that logically contain zero or more components.</summary>
	public interface IContainer : IDisposable
	{
		/// <summary>Gets all the components in the <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <returns>A collection of <see cref="T:System.ComponentModel.IComponent" /> objects that represents all the components in the <see cref="T:System.ComponentModel.IContainer" />.</returns>
		ComponentCollection Components { get; }

		/// <summary>Removes a component from the <see cref="T:System.ComponentModel.IContainer" />.</summary>
		/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to remove. </param>
		void Remove(IComponent component);
	}
}
