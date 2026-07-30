using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpBinaryOperationBinder : BinaryOperationBinder, ICSharpBinder
	{
		private readonly CSharpBinaryOperationFlags _binopFlags;

		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		[ExcludeFromCodeCoverage]
		public string Name => null;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		internal bool IsLogicalOperation => false;

		public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		public void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments)
		{
		}

		CSharpArgumentInfo ICSharpBinder.GetArgumentInfo(int index)
		{
			return null;
		}

		public CSharpBinaryOperationBinder(ExpressionType operation, bool isChecked, CSharpBinaryOperationFlags binaryOperationFlags, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(default(ExpressionType))
		{
		}

		public override DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
