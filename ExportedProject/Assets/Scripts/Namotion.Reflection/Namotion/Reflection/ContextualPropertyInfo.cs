using System.Reflection;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	public class ContextualPropertyInfo : ContextualAccessorInfo
	{
		private string? _name;

		private IPropertyReader? _propertyReader;

		private IPropertyWriter? _propertyWriter;

		public PropertyInfo PropertyInfo { get; }

		public override ContextualType AccessorType => null;

		public ContextualType PropertyType { get; private set; }

		public override string Name => null;

		public override MemberInfo MemberInfo => null;

		internal ContextualPropertyInfo(PropertyInfo propertyInfo, ref int nullableFlagsIndex, byte[]? nullableFlags)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override object? GetValue(object? obj)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void SetValue(object? obj, object? value)
		{
		}
	}
}
