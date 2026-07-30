using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class VoidType : CType
	{
		public static readonly VoidType Instance;

		private VoidType()
			: base(default(TypeKind))
		{
		}

		public override bool IsPredefType(PredefinedType pt)
		{
			return false;
		}
	}
}
