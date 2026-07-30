using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a base type converter for nonfloating-point numerical types.</summary>
	public abstract class BaseNumberConverter : TypeConverter
	{
		internal virtual bool AllowHex => false;

		internal abstract Type TargetType { get; }

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.BaseNumberConverter" /> class.</summary>
		internal BaseNumberConverter()
		{
		}

		internal abstract object FromString(string value, int radix);

		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		/// <summary>Determines if this converter can convert an object in the given source type to the native type of the converter.</summary>
		/// <returns>true if this converter can perform the operation; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type from which you want to convert. </param>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		/// <summary>Converts the given object to the converter's native type.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the number. </param>
		/// <param name="value">The object to convert. </param>
		/// <exception cref="T:System.Exception">
		///   <paramref name="value" /> is not a valid value for the target type.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		/// <summary>Converts the specified object to another type.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to represent the number. </param>
		/// <param name="value">The object to convert. </param>
		/// <param name="destinationType">The type to convert the object to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> is null.</exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		/// <summary>Returns a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <returns>true if this converter can perform the operation; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="t">A <see cref="T:System.Type" /> that represents the type to which you want to convert. </param>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}
	}
}
