using System;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal abstract class ExprWithType : Expr
	{
		protected ExprWithType(ExpressionKind kind, CType type)
			: base(default(ExpressionKind))
		{
		}

		protected static bool TypesAreEqual(Type t1, Type t2)
		{
			return false;
		}
	}
}
