using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class ExpressionTreeCallRewriter : ExprVisitorBase
	{
		private sealed class ExpressionExpr : Expr
		{
			public readonly Expression Expression;

			public ExpressionExpr(Expression e)
				: base(default(ExpressionKind))
			{
			}
		}

		private readonly Dictionary<ExprCall, Expression> _DictionaryOfParameters;

		private readonly Expression[] _ListOfParameters;

		private int _currentParameterIndex;

		private ExpressionTreeCallRewriter(Expression[] listOfParameters)
		{
		}

		public static Expression Rewrite(ExprBinOp binOp, Expression[] listOfParameters)
		{
			return null;
		}

		protected override Expr VisitSAVE(ExprBinOp pExpr)
		{
			return null;
		}

		protected override Expr VisitCALL(ExprCall pExpr)
		{
			return null;
		}

		protected override Expr VisitWRAP(ExprWrap pExpr)
		{
			return null;
		}

		private Expr GenerateLambda(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateCall(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateArrayIndex(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateConvert(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateProperty(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateField(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateInvoke(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateNew(ExprCall pExpr)
		{
			return null;
		}

		private static Expression GenerateConstantType(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateAssignment(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateBinaryOperator(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateUserDefinedBinaryOperator(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateUnaryOperator(ExprCall pExpr)
		{
			return null;
		}

		private Expression GenerateUserDefinedUnaryOperator(ExprCall pExpr)
		{
			return null;
		}

		private Expression GetExpression(Expr pExpr)
		{
			return null;
		}

		private Expression[] GetArgumentsFromArrayInit(ExprArrayInit arrinit)
		{
			return null;
		}
	}
}
