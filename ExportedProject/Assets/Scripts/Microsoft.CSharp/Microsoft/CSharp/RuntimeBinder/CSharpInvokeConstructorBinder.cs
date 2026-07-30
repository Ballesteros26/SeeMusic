using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpInvokeConstructorBinder : DynamicMetaObjectBinder, ICSharpInvokeOrInvokeMemberBinder, ICSharpBinder
	{
		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		public CSharpCallFlags Flags { get; }

		public bool StaticCall => false;

		public Type[] TypeArguments => null;

		public string Name => null;

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

		public CSharpInvokeConstructorBinder(CSharpCallFlags flags, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
		{
		}

		public override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args)
		{
			return null;
		}
	}
}
