namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ArgumentListType : CType
	{
		public static readonly ArgumentListType Instance;

		private ArgumentListType()
			: base(default(TypeKind))
		{
		}
	}
}
