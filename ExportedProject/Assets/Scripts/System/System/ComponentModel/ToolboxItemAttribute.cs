namespace System.ComponentModel
{
	/// <summary>Represents an attribute of a toolbox item.</summary>
	[AttributeUsage(AttributeTargets.All)]
	public class ToolboxItemAttribute : Attribute
	{
		private string _toolboxItemTypeName;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to the default, <see cref="T:System.Drawing.Design.ToolboxItem" />. This field is read-only.</summary>
		public static readonly ToolboxItemAttribute Default;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and sets the type to null. This field is read-only.</summary>
		public static readonly ToolboxItemAttribute None;

		/// <summary>Gets or sets the name of the type of the current <see cref="T:System.Drawing.Design.ToolboxItem" />.</summary>
		/// <returns>The fully qualified type name of the current toolbox item.</returns>
		public string ToolboxItemTypeName => null;

		/// <summary>Gets a value indicating whether the current value of the attribute is the default value for the attribute.</summary>
		/// <returns>true if the current value of the attribute is the default; otherwise, false.</returns>
		public override bool IsDefaultAttribute()
		{
			return false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class and specifies whether to use default initialization values.</summary>
		/// <param name="defaultType">true to create a toolbox item attribute for a default type; false to associate no default toolbox item support for this attribute. </param>
		public ToolboxItemAttribute(bool defaultType)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.ToolboxItemAttribute" /> class using the specified name of the type.</summary>
		/// <param name="toolboxItemTypeName">The names of the type of the toolbox item and of the assembly that contains the type. </param>
		public ToolboxItemAttribute(string toolboxItemTypeName)
		{
		}

		/// <param name="obj">The object to compare.</param>
		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
