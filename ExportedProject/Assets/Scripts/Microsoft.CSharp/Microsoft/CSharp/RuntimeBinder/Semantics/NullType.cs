namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class NullType : CType
	{
		public static readonly NullType Instance;

		public override bool IsReferenceType => false;

		public override FUNDTYPE FundamentalType => default(FUNDTYPE);

		public override ConstValKind ConstValKind => default(ConstValKind);

		private NullType()
			: base(default(TypeKind))
		{
		}
	}
}
