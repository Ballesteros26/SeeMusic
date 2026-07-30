using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	internal static class PropertyWriter
	{
		private static Type GenericTypeDefinition;

		public static IPropertyWriter Create(Type objectType, Type valueType, PropertyInfo propertyInfo)
		{
			return null;
		}
	}
	internal sealed class PropertyWriter<TObject, TValue> : IPropertyWriter
	{
		private readonly PropertyInfo _propertyInfo;

		private Action<TObject?, TValue?>? _setter;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetValue(TObject? obj, TValue? value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		void IPropertyWriter.SetValue(object? obj, object? value)
		{
		}
	}
}
