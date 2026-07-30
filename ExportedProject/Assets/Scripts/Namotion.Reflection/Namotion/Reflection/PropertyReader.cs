using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	internal static class PropertyReader
	{
		private static Type GenericTypeDefinition;

		public static IPropertyReader Create(Type objectType, Type valueType, PropertyInfo propertyInfo)
		{
			return null;
		}
	}
	internal sealed class PropertyReader<TObject, TValue> : IPropertyReader
	{
		private readonly PropertyInfo _propertyInfo;

		private Func<TObject?, TValue?>? _getter;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public TValue? GetValue(TObject? obj)
		{
			return default(TValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		object? IPropertyReader.GetValue(object? obj)
		{
			return null;
		}
	}
}
