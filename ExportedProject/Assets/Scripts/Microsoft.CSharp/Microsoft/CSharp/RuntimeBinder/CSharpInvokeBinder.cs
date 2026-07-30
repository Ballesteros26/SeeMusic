using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpInvokeBinder : InvokeBinder, ICSharpInvokeOrInvokeMemberBinder, ICSharpBinder
	{
		private readonly CSharpCallFlags _flags;

		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		bool ICSharpInvokeOrInvokeMemberBinder.StaticCall => false;

		string ICSharpBinder.Name => null;

		Type[] ICSharpInvokeOrInvokeMemberBinder.TypeArguments => null;

		CSharpCallFlags ICSharpInvokeOrInvokeMemberBinder.Flags => default(CSharpCallFlags);

		bool ICSharpInvokeOrInvokeMemberBinder.ResultDiscarded => false;

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

		public CSharpInvokeBinder(CSharpCallFlags flags, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(null)
		{
		}

		public override DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
