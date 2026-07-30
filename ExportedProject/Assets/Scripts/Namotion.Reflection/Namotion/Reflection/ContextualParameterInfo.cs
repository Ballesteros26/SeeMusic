using System;
using System.Reflection;

namespace Namotion.Reflection
{
	public class ContextualParameterInfo : ContextualType
	{
		private string? _name;

		public ParameterInfo ParameterInfo { get; }

		public string Name => null;

		internal unsafe ContextualParameterInfo(ParameterInfo parameterInfo, ref int nullableFlagsIndex, byte[]? nullableFlags)
			: base(null, null, null, ref *(int*)null, null, null)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static Attribute[] GetContextualAttributes(ParameterInfo parameterInfo)
		{
			return null;
		}
	}
}
