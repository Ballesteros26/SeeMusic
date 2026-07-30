using System;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpInvokeMemberBinder : InvokeMemberBinder, ICSharpInvokeOrInvokeMemberBinder, ICSharpBinder
	{
		private readonly CSharpArgumentInfo[] _argumentInfo;

		private readonly RuntimeBinder _binder;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		bool ICSharpInvokeOrInvokeMemberBinder.StaticCall => false;

		public CSharpCallFlags Flags { get; }

		public Type CallingContext { get; }

		public Type[] TypeArguments { get; }

		bool ICSharpInvokeOrInvokeMemberBinder.ResultDiscarded => false;

		string ICSharpBinder.Name => null;

		public Expr DispatchPayload(RuntimeBinder runtimeBinder, ArgumentObject[] arguments, LocalVariableSymbol[] locals)
		{
			return null;
		}

		public void PopulateSymbolTableWithName(Type callingType, ArgumentObject[] arguments)
		{
		}

		public CSharpArgumentInfo GetArgumentInfo(int index)
		{
			return null;
		}

		public CSharpArgumentInfo[] ArgumentInfoArray()
		{
			return null;
		}

		public CSharpInvokeMemberBinder(CSharpCallFlags flags, string name, Type callingContext, IEnumerable<Type> typeArguments, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(null, ignoreCase: false, null)
		{
		}

		public override DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion)
		{
			return null;
		}

		public override DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
