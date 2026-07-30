namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprProperty : ExprWithArgs
	{
		public Expr OptionalObjectThrough { get; }

		public PropWithType PropWithTypeSlot { get; }

		public MethWithType MethWithTypeSet { get; }

		public ExprProperty(CType type, Expr pOptionalObjectThrough, Expr pOptionalArguments, ExprMemberGroup pMemberGroup, PropWithType pwtSlot, MethWithType mwtSet)
			: base(default(ExpressionKind), null)
		{
		}

		public override SymWithType GetSymWithType()
		{
			return null;
		}
	}
}
