namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class MethodGroupType : CType
	{
		public static readonly MethodGroupType Instance;

		private MethodGroupType()
			: base(default(TypeKind))
		{
		}
	}
}
