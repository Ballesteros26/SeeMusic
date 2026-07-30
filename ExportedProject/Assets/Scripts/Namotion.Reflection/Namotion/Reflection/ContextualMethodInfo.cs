using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	public class ContextualMethodInfo : ContextualMemberInfo
	{
		[CompilerGenerated]
		private readonly ContextualParameterInfo[] _003CParameters_003Ek__BackingField;

		public MethodInfo MethodInfo { get; }

		public override string Name => null;

		public ContextualParameterInfo ReturnParameter { get; }

		public override MemberInfo MemberInfo => null;

		internal ContextualMethodInfo(MethodInfo methodInfo, ContextualParameterInfo returnParameter, IEnumerable<ContextualParameterInfo> parameters)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
