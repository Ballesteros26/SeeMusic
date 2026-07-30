using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpSetIndexBinder : SetIndexBinder, ICSharpBinder
	{
		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		public string Name => null;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		internal bool IsCompoundAssignment { get; }

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

		public CSharpSetIndexBinder(bool isCompoundAssignment, bool isChecked, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(null)
		{
		}

		public override DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
