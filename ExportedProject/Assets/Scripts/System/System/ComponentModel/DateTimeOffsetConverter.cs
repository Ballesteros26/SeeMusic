using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.DateTimeOffset" /> structures to and from various other representations.</summary>
	public class DateTimeOffsetConverter : TypeConverter
	{
		/// <summary>Returns a value that indicates whether an object of the specified source type can be converted to a <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>true if the specified type can be converted to a <see cref="T:System.DateTimeOffset" />; otherwise, false.</returns>
		/// <param name="context">The date format context.</param>
		/// <param name="sourceType">The source type to check.</param>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		/// <summary>Returns a value that indicates whether a <see cref="T:System.DateTimeOffset" /> can be converted to an object of the specified type.</summary>
		/// <returns>true if a <see cref="T:System.DateTimeOffset" /> can be converted to the specified type; otherwise, false.</returns>
		/// <param name="context">The date format context.</param>
		/// <param name="destinationType">The destination type to check.</param>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}

		/// <summary>Converts the specified object to a <see cref="T:System.DateTimeOffset" />.</summary>
		/// <returns>A <see cref="T:System.DateTimeOffset" /> that represents the specified object.</returns>
		/// <param name="context">The date format context.</param>
		/// <param name="culture">The date culture.</param>
		/// <param name="value">The object to be converted.</param>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		/// <summary>Converts a <see cref="T:System.DateTimeOffset" /> to an object of the specified type.</summary>
		/// <returns>An object of the specified type that represents the <see cref="T:System.DateTimeOffset" />. </returns>
		/// <param name="context">The date format context.</param>
		/// <param name="culture">The date culture.</param>
		/// <param name="value">The <see cref="T:System.DateTimeOffset" /> to be converted.</param>
		/// <param name="destinationType">The type to convert to.</param>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed.</exception>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.DateTimeOffsetConverter" /> class. </summary>
		public DateTimeOffsetConverter()
		{
		}
	}
}
