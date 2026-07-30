namespace System.ComponentModel
{
	/// <summary>Specifies the installer for a type that installs components.</summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		private string _typeName;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> class with the name of the component's installer type.</summary>
		/// <param name="typeName">The name of a <see cref="T:System.Type" /> that represents the installer for the component this attribute is bound to. This class must implement <see cref="T:System.ComponentModel.Design.IDesigner" />. </param>
		public InstallerTypeAttribute(string typeName)
		{
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
		public override bool Equals(object obj)
		{
			return false;
		}

		/// <summary>Returns the hashcode for this object.</summary>
		/// <returns>A hash code for the current <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
