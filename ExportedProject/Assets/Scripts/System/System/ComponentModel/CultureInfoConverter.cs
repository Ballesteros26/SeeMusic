using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Provides a type converter to convert <see cref="T:System.Globalization.CultureInfo" /> objects to and from various other representations.</summary>
	public class CultureInfoConverter : TypeConverter
	{
		private class CultureComparer : IComparer
		{
			private CultureInfoConverter _converter;

			public CultureComparer(CultureInfoConverter cultureConverter)
			{
			}

			public int Compare(object item1, object item2)
			{
				return 0;
			}
		}

		private static class CultureInfoMapper
		{
			private static readonly Dictionary<string, string> s_cultureInfoNameMap;

			private static Dictionary<string, string> CreateMap()
			{
				return null;
			}

			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				return null;
			}
		}

		private StandardValuesCollection _values;

		private const string DefaultInvariantCultureString = "(Default)";

		private string DefaultCultureString => null;

		/// <summary>Retrieves the name of the specified culture.</summary>
		/// <returns>The name of the specified culture.</returns>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to get the name for.</param>
		protected virtual string GetCultureName(CultureInfo culture)
		{
			return null;
		}

		/// <summary>Gets a value indicating whether this converter can convert an object in the given source type to a <see cref="T:System.Globalization.CultureInfo" /> using the specified context.</summary>
		/// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="sourceType">A <see cref="T:System.Type" /> that represents the type you wish to convert from. </param>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		/// <summary>Gets a value indicating whether this converter can convert an object to the given destination type using the context.</summary>
		/// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you wish to convert to. </param>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}

		/// <summary>Converts the specified value object to a <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to which to convert.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> specifies a culture that is not valid. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		/// <summary>Converts the given value object to the specified destination type.</summary>
		/// <returns>An <see cref="T:System.Object" /> that represents the converted <paramref name="value" />.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that specifies the culture to which to convert.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to convert. </param>
		/// <param name="destinationType">The <see cref="T:System.Type" /> to convert the value to. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The conversion cannot be performed. </exception>
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		/// <summary>Gets a collection of standard values for a <see cref="T:System.Globalization.CultureInfo" /> object using the specified context.</summary>
		/// <returns>A <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> containing a standard set of valid values, or null if the data type does not support a standard set of values.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		/// <summary>Gets a value indicating whether the list of standard values returned from <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> is an exhaustive list.</summary>
		/// <returns>false because the <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" /> returned from <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> is not an exhaustive list of possible values (that is, other values are possible). This method never returns true.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Gets a value indicating whether this object supports a standard set of values that can be picked from a list using the specified context.</summary>
		/// <returns>true because <see cref="M:System.ComponentModel.CultureInfoConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" /> should be called to find a common set of values the object supports. This method never returns false.</returns>
		/// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context. </param>
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CultureInfoConverter" /> class.</summary>
		public CultureInfoConverter()
		{
		}
	}
}
