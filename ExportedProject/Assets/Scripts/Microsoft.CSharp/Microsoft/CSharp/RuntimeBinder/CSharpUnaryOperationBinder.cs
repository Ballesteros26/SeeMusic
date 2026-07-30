using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq.Expressions;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpUnaryOperationBinder : UnaryOperationBinder, ICSharpBinder
	{
		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		[ExcludeFromCodeCoverage]
		public string Name => null;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

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

		public CSharpUnaryOperationBinder(ExpressionType operation, bool isChecked, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(default(ExpressionType))
		{
		}

		public override DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
