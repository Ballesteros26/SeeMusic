namespace System.ComponentModel
{
	/// <summary>Provides contextual information about a component, such as its container and property descriptor.</summary>
	public interface ITypeDescriptorContext : IServiceProvider
	{
		/// <summary>Gets the container representing this <see cref="T:System.ComponentModel.TypeDescriptor" /> request.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.IContainer" /> with the set of objects for this <see cref="T:System.ComponentModel.TypeDescriptor" />; otherwise, null if there is no container or if the <see cref="T:System.ComponentModel.TypeDescriptor" /> does not use outside objects.</returns>
		IContainer Container { get; }
	}
}
