namespace System.Runtime.Serialization
{
	/// <summary>Specifies that the type defines or implements a data contract and is serializable by a serializer, such as the <see cref="T:System.Runtime.Serialization.DataContractSerializer" />. To make their type serializable, type authors must define a data contract for their type. </summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public sealed class DataContractAttribute : Attribute
	{
		private bool isReference;

		/// <summary>Gets or sets a value that indicates whether to preserve object reference data.</summary>
		/// <returns>true to keep object reference data using standard XML; otherwise, false. The default is false.</returns>
		public bool IsReference => false;
	}
}
