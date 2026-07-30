namespace System.ComponentModel
{
	/// <summary>Specifies the default value for a property.</summary>
	[AttributeUsage(AttributeTargets.All)]
	public class DefaultValueAttribute : Attribute
	{
		private object _value;

		/// <summary>Gets the default value of the property this attribute is bound to.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the default value of the property this attribute is bound to.</returns>
		public virtual object Value => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 32-bit signed integer.</summary>
		/// <param name="value">A 32-bit signed integer that is the default value. </param>
		public DefaultValueAttribute(int value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a 64-bit signed integer.</summary>
		/// <param name="value">A 64-bit signed integer that is the default value. </param>
		public DefaultValueAttribute(long value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a double-precision floating point number.</summary>
		/// <param name="value">A double-precision floating point number that is the default value. </param>
		public DefaultValueAttribute(double value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.Boolean" /> value.</summary>
		/// <param name="value">A <see cref="T:System.Boolean" /> that is the default value. </param>
		public DefaultValueAttribute(bool value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class using a <see cref="T:System.String" />.</summary>
		/// <param name="value">A <see cref="T:System.String" /> that is the default value. </param>
		public DefaultValueAttribute(string value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DefaultValueAttribute" /> class.</summary>
		/// <param name="value">An <see cref="T:System.Object" /> that represents the default value. </param>
		public DefaultValueAttribute(object value)
		{
		}

		/// <summary>Returns whether the value of the given object is equal to the current <see cref="T:System.ComponentModel.DefaultValueAttribute" />.</summary>
		/// <returns>true if the value of the given object is equal to that of the current; otherwise, false.</returns>
		/// <param name="obj">The object to test the value equality of. </param>
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
