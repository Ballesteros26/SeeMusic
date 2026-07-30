using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExprMemberGroup : ExprWithType
	{
		[CompilerGenerated]
		private Expr _003COptionalLHS_003Ek__BackingField;

		public Name Name { get; }

		public TypeArray TypeArgs { get; }

		public SYMKIND SymKind { get; }

		public Expr OptionalObject { get; set; }

		public Expr OptionalLHS
		{
			[CompilerGenerated]
			set
			{
				_003COptionalLHS_003Ek__BackingField = value;
			}
		}

		public CMemberLookupResults MemberLookupResults { get; }

		public CType ParentType { get; }

		public bool IsDelegate => false;

		public ExprMemberGroup(EXPRFLAG flags, Name name, TypeArray typeArgs, SYMKIND symKind, CType parentType, Expr optionalObject, CMemberLookupResults memberLookupResults)
			: base(default(ExpressionKind), null)
		{
		}
	}
}
