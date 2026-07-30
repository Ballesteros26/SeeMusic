using System.Reflection;

namespace Namotion.Reflection
{
	public class ContextualFieldInfo : ContextualAccessorInfo
	{
		private string? _name;

		public FieldInfo FieldInfo { get; }

		public override MemberInfo MemberInfo => null;

		public override ContextualType AccessorType => null;

		public ContextualType FieldType { get; private set; }

		public override string Name => null;

		internal ContextualFieldInfo(FieldInfo fieldInfo, ref int nullableFlagsIndex, byte[]? nullableFlags)
		{
		}

		public override object? GetValue(object? obj)
		{
			return null;
		}

		public override void SetValue(object? obj, object? value)
		{
		}
	}
}
