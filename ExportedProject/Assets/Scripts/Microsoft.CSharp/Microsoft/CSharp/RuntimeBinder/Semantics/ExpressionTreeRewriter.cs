using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal sealed class ExpressionTreeRewriter : ExprVisitorBase
	{
		public static ExprBinOp Rewrite(ExprBoundLambda expr)
		{
			return null;
		}

		protected override Expr Dispatch(Expr expr)
		{
			return null;
		}

		protected override Expr VisitASSIGNMENT(ExprAssignment assignment)
		{
			return null;
		}

		protected override Expr VisitMULTIGET(ExprMultiGet pExpr)
		{
			return null;
		}

		protected override Expr VisitMULTI(ExprMulti pExpr)
		{
			return null;
		}

		private ExprBinOp VisitBoundLambda(ExprBoundLambda anonmeth)
		{
			return null;
		}

		protected override Expr VisitCONSTANT(ExprConstant expr)
		{
			return null;
		}

		protected override Expr VisitLOCAL(ExprLocal local)
		{
			return null;
		}

		protected override Expr VisitFIELD(ExprField expr)
		{
			return null;
		}

		protected override Expr VisitUSERDEFINEDCONVERSION(ExprUserDefinedConversion expr)
		{
			return null;
		}

		protected override Expr VisitCAST(ExprCast pExpr)
		{
			return null;
		}

		protected override Expr VisitCONCAT(ExprConcat expr)
		{
			return null;
		}

		protected override Expr VisitBINOP(ExprBinOp expr)
		{
			return null;
		}

		protected override Expr VisitUNARYOP(ExprUnaryOp pExpr)
		{
			return null;
		}

		protected override Expr VisitARRAYINDEX(ExprArrayIndex pExpr)
		{
			return null;
		}

		protected override Expr VisitCALL(ExprCall expr)
		{
			return null;
		}

		protected override Expr VisitPROP(ExprProperty expr)
		{
			return null;
		}

		protected override Expr VisitARRINIT(ExprArrayInit expr)
		{
			return null;
		}

		protected override Expr VisitZEROINIT(ExprZeroInit expr)
		{
			return null;
		}

		protected override Expr VisitTYPEOF(ExprTypeOf expr)
		{
			return null;
		}

		private Expr GenerateDelegateInvoke(ExprCall expr)
		{
			return null;
		}

		private Expr GenerateBuiltInBinaryOperator(ExprBinOp expr)
		{
			return null;
		}

		private Expr GenerateBuiltInUnaryOperator(ExprUnaryOp expr)
		{
			return null;
		}

		private Expr GenerateUserDefinedBinaryOperator(ExprBinOp expr)
		{
			return null;
		}

		private Expr GenerateUserDefinedUnaryOperator(ExprUnaryOp expr)
		{
			return null;
		}

		private Expr GenerateUserDefinedComparisonOperator(ExprBinOp expr)
		{
			return null;
		}

		private Expr GenerateConversion(Expr arg, CType CType, bool bChecked)
		{
			return null;
		}

		private static Expr GenerateConversionWithSource(Expr pTarget, CType pType, bool bChecked)
		{
			return null;
		}

		private Expr GenerateValueAccessConversion(Expr pArgument)
		{
			return null;
		}

		private Expr GenerateUserDefinedConversion(Expr arg, CType type, MethWithInst method)
		{
			return null;
		}

		private static Expr GenerateUserDefinedConversion(Expr arg, CType CType, Expr target, MethWithInst method)
		{
			return null;
		}

		private Expr GenerateUserDefinedConversion(ExprUserDefinedConversion pExpr, Expr pArgument)
		{
			return null;
		}

		private static Expr GenerateParameter(string name, CType CType)
		{
			return null;
		}

		private static MethodSymbol GetPreDefMethod(PREDEFMETH pdm)
		{
			return null;
		}

		private static ExprTypeOf CreateTypeOf(CType type)
		{
			return null;
		}

		private static Expr CreateWraps(ExprBoundLambda anonmeth)
		{
			return null;
		}

		private Expr GenerateConstructor(ExprCall expr)
		{
			return null;
		}

		private Expr GenerateArgsList(Expr oldArgs)
		{
			return null;
		}

		private Expr GenerateIndexList(Expr oldIndices)
		{
			return null;
		}

		private static Expr GenerateConstant(Expr expr)
		{
			return null;
		}

		private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1)
		{
			return null;
		}

		private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2)
		{
			return null;
		}

		private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2, Expr arg3)
		{
			return null;
		}

		private static ExprCall GenerateCall(PREDEFMETH pdm, Expr arg1, Expr arg2, Expr arg3, Expr arg4)
		{
			return null;
		}

		private static ExprArrayInit GenerateParamsArray(Expr args, PredefinedType pt)
		{
			return null;
		}

		private static void FixLiftedUserDefinedBinaryOperators(ExprBinOp expr, ref Expr pp1, ref Expr pp2)
		{
		}

		private static bool IsNullableValueType(CType pType)
		{
			return false;
		}

		private static bool IsNullableValueAccess(Expr pExpr, Expr pObject)
		{
			return false;
		}

		private static bool isEnumToDecimalConversion(CType argtype, CType desttype)
		{
			return false;
		}
	}
}
