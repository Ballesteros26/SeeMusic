using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
	internal static class ExprFactory
	{
		public static ExprCall CreateCall(EXPRFLAG flags, CType type, Expr arguments, ExprMemberGroup memberGroup, MethWithInst method)
		{
			return null;
		}

		public static ExprField CreateField(CType type, Expr optionalObject, FieldWithType field)
		{
			return null;
		}

		public static ExprArrayInit CreateArrayInit(CType type, Expr arguments, Expr argumentDimensions, int[] dimSizes, int dimSize)
		{
			return null;
		}

		public static ExprProperty CreateProperty(CType type, Expr optionalObjectThrough, Expr arguments, ExprMemberGroup memberGroup, PropWithType property, MethWithType setMethod)
		{
			return null;
		}

		public static ExprMemberGroup CreateMemGroup(EXPRFLAG flags, Name name, TypeArray typeArgs, SYMKIND symKind, CType parentType, Expr obj, CMemberLookupResults memberLookupResults)
		{
			return null;
		}

		public static ExprMemberGroup CreateMemGroup(Expr obj, MethPropWithInst method)
		{
			return null;
		}

		public static ExprUserDefinedConversion CreateUserDefinedConversion(Expr arg, Expr call, MethWithInst method)
		{
			return null;
		}

		public static ExprCast CreateCast(CType type, Expr argument)
		{
			return null;
		}

		public static ExprCast CreateCast(EXPRFLAG flags, CType type, Expr argument)
		{
			return null;
		}

		public static ExprLocal CreateLocal(LocalVariableSymbol local)
		{
			return null;
		}

		public static ExprBoundLambda CreateAnonymousMethod(AggregateType delegateType, Scope argumentScope, Expr expression)
		{
			return null;
		}

		public static ExprMethodInfo CreateMethodInfo(MethPropWithInst mwi)
		{
			return null;
		}

		public static ExprMethodInfo CreateMethodInfo(MethodSymbol method, AggregateType methodType, TypeArray methodParameters)
		{
			return null;
		}

		public static ExprPropertyInfo CreatePropertyInfo(PropertySymbol prop, AggregateType propertyType)
		{
			return null;
		}

		public static ExprFieldInfo CreateFieldInfo(FieldSymbol field, AggregateType fieldType)
		{
			return null;
		}

		public static ExprTypeOf CreateTypeOf(CType sourceType)
		{
			return null;
		}

		public static ExprUserLogicalOp CreateUserLogOp(CType type, Expr trueFalseCall, ExprCall operatorCall)
		{
			return null;
		}

		public static ExprConcat CreateConcat(Expr first, Expr second)
		{
			return null;
		}

		public static ExprConstant CreateStringConstant(string str)
		{
			return null;
		}

		public static ExprMultiGet CreateMultiGet(EXPRFLAG flags, CType type, ExprMulti multi)
		{
			return null;
		}

		public static ExprMulti CreateMulti(EXPRFLAG flags, CType type, Expr left, Expr op)
		{
			return null;
		}

		public static Expr CreateZeroInit(CType type)
		{
			return null;
		}

		public static ExprConstant CreateConstant(CType type, ConstVal constVal)
		{
			return null;
		}

		public static ExprConstant CreateIntegerConstant(int x)
		{
			return null;
		}

		public static ExprConstant CreateBoolConstant(bool b)
		{
			return null;
		}

		public static ExprArrayIndex CreateArrayIndex(CType type, Expr array, Expr index)
		{
			return null;
		}

		public static ExprBinOp CreateBinop(ExpressionKind exprKind, CType type, Expr left, Expr right)
		{
			return null;
		}

		public static ExprUnaryOp CreateUnaryOp(ExpressionKind exprKind, CType type, Expr operand)
		{
			return null;
		}

		public static ExprOperator CreateOperator(ExpressionKind exprKind, CType type, Expr arg1, Expr arg2)
		{
			return null;
		}

		public static ExprBinOp CreateUserDefinedBinop(ExpressionKind exprKind, CType type, Expr left, Expr right, Expr call, MethPropWithInst userMethod)
		{
			return null;
		}

		public static ExprUnaryOp CreateUserDefinedUnaryOperator(ExpressionKind exprKind, CType type, Expr operand, ExprCall call, MethPropWithInst userMethod)
		{
			return null;
		}

		public static ExprUnaryOp CreateNeg(EXPRFLAG flags, Expr operand)
		{
			return null;
		}

		public static ExprBinOp CreateSequence(Expr first, Expr second)
		{
			return null;
		}

		public static ExprAssignment CreateAssignment(Expr left, Expr right)
		{
			return null;
		}

		public static ExprNamedArgumentSpecification CreateNamedArgumentSpecification(Name name, Expr value)
		{
			return null;
		}

		public static ExprWrap CreateWrap(Expr expression)
		{
			return null;
		}

		public static ExprBinOp CreateSave(ExprWrap wrap)
		{
			return null;
		}

		public static ExprConstant CreateNull()
		{
			return null;
		}

		public static void AppendItemToList(Expr newItem, ref Expr first, ref Expr last)
		{
		}

		public static ExprList CreateList(Expr op1, Expr op2)
		{
			return null;
		}

		public static ExprList CreateList(Expr op1, Expr op2, Expr op3)
		{
			return null;
		}

		public static ExprList CreateList(Expr op1, Expr op2, Expr op3, Expr op4)
		{
			return null;
		}

		public static ExprClass CreateClass(CType type)
		{
			return null;
		}
	}
}
