using System;
using System.Dynamic;
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder.Semantics;
using Microsoft.CSharp.RuntimeBinder.Syntax;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal readonly struct RuntimeBinder
	{
		private static readonly object s_bindLock;

		private readonly ExpressionBinder _binder;

		public RuntimeBinder(Type contextType, bool isChecked = false)
		{
			_binder = default(ExpressionBinder);
		}

		public Expression Bind(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args, out DynamicMetaObject deferredBinding)
		{
			deferredBinding = null;
			return null;
		}

		private Expression BindCore(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args, out DynamicMetaObject deferredBinding)
		{
			deferredBinding = null;
			return null;
		}

		private bool DeferBinding(ICSharpBinder payload, ArgumentObject[] arguments, DynamicMetaObject[] args, LocalVariableSymbol[] locals, out DynamicMetaObject deferredBinding)
		{
			deferredBinding = null;
			return false;
		}

		private static Expression CreateExpressionTreeFromResult(Expression[] parameters, Scope pScope, Expr pResult)
		{
			return null;
		}

		private Type GetArgumentType(ICSharpBinder p, CSharpArgumentInfo argInfo, Expression param, DynamicMetaObject arg, int index)
		{
			return null;
		}

		private ArgumentObject[] CreateArgumentArray(ICSharpBinder payload, Expression[] parameters, DynamicMetaObject[] args)
		{
			return null;
		}

		internal static void PopulateSymbolTableWithPayloadInformation(ICSharpInvokeOrInvokeMemberBinder callOrInvoke, Type callingType, ArgumentObject[] arguments)
		{
		}

		private static void AddConversionsForArguments(ArgumentObject[] arguments)
		{
		}

		internal ExprWithArgs DispatchPayload(ICSharpInvokeOrInvokeMemberBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		private static LocalVariableSymbol[] PopulateLocalScope(ICSharpBinder payload, Scope pScope, ArgumentObject[] arguments, Expression[] parameterExpressions)
		{
			return null;
		}

		private static ExprBoundLambda GenerateBoundLambda(Scope pScope, Expr call)
		{
			return null;
		}

		private Expr CreateLocal(Type type, bool isOut, LocalVariableSymbol local)
		{
			return null;
		}

		internal Expr CreateArgumentListEXPR(ArgumentObject[] arguments, LocalVariableSymbol[] locals, int startIndex, int endIndex)
		{
			return null;
		}

		private Expr CreateArgumentEXPR(ArgumentObject argument, LocalVariableSymbol local)
		{
			return null;
		}

		private static ExprMemberGroup CreateMemberGroupExpr(string Name, Type[] typeArguments, Expr callingObject, SYMKIND kind)
		{
			return null;
		}

		private Expr CreateProperty(SymWithType swt, Expr callingObject, BindingFlag flags)
		{
			return null;
		}

		private ExprWithArgs CreateIndexer(SymWithType swt, Expr callingObject, Expr arguments, BindingFlag bindFlags)
		{
			return null;
		}

		private Expr CreateArray(Expr callingObject, Expr optionalIndexerArguments)
		{
			return null;
		}

		private Expr CreateField(SymWithType swt, Expr callingObject)
		{
			return null;
		}

		private Expr CreateCallingObjectForCall(ICSharpInvokeOrInvokeMemberBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		private ExprWithArgs BindCall(ICSharpInvokeOrInvokeMemberBinder payload, Expr callingObject, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		private ExprWithArgs BindWinRTEventAccessor(EventWithType ewt, Expr callingObject, ArgumentObject[] arguments, LocalVariableSymbol[] locals, bool isAddAccessor)
		{
			return null;
		}

		private static void CheckForConditionalMethodError(ExprCall call)
		{
		}

		private void ReorderArgumentsForNamedAndOptional(Expr callingObject, ExprWithArgs result)
		{
		}

		private Expr StripNamedArgument(Expr pArg)
		{
			return null;
		}

		private Expr StripNamedArguments(Expr pArg)
		{
			return null;
		}

		internal Expr BindUnaryOperation(CSharpUnaryOperationBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		internal Expr BindBinaryOperation(CSharpBinaryOperationBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		private static OperatorKind GetOperatorKind(ExpressionType p)
		{
			return default(OperatorKind);
		}

		private static OperatorKind GetOperatorKind(ExpressionType p, bool bIsLogical)
		{
			return default(OperatorKind);
		}

		internal Expr BindProperty(ICSharpBinder payload, ArgumentObject argument, LocalVariableSymbol local, Expr optionalIndexerArguments)
		{
			return null;
		}

		internal Expr BindImplicitConversion(ArgumentObject[] arguments, Type returnType, LocalVariableSymbol[] locals, bool bIsArrayCreationConversion)
		{
			return null;
		}

		internal Expr BindExplicitConversion(ArgumentObject[] arguments, Type returnType, LocalVariableSymbol[] locals)
		{
			return null;
		}

		internal Expr BindAssignment(ICSharpBinder payload, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}
	}
}
