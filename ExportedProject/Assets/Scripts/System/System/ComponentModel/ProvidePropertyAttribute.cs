namespace System.ComponentModel
{
	/// <summary>Specifies the name of the property that an implementer of <see cref="T:System.ComponentModel.IExtenderProvider" /> offers to other components. This class cannot be inherited</summary>
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		/// <summary>Gets the name of a property that this class provides.</summary>
		/// <returns>The name of a property that this class provides.</returns>
		public string PropertyName { get; }

		/// <summary>Gets the name of the data type this property can extend.</summary>
		/// <returns>The name of the data type this property can extend.</returns>
		public string ReceiverTypeName { get; }
	}
}
