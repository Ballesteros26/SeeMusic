using System;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ParameterModifierType : CType
	{
		public bool IsOut { get; }

		public CType ParameterType { get; }

		public override Type AssociatedSystemType => null;

		public override CType BaseOrParameterOrElementType => null;

		public ParameterModifierType(CType parameterType, bool isOut)
			: base(default(TypeKind))
		{
		}
	}
}
