using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder.Semantics;

namespace Microsoft.CSharp.RuntimeBinder
{
	internal sealed class CSharpGetMemberBinder : GetMemberBinder, ICSharpBinder
	{
		private readonly CSharpArgumentInfo[] _argumentInfo;

		[CompilerGenerated]
		private readonly bool _003CResultIndexed_003Ek__BackingField;

		private readonly RuntimeBinder _binder;

		public BindingFlag BindingFlags => default(BindingFlag);

		public bool IsBinderThatCanHaveRefReceiver => false;

		string ICSharpBinder.Name => null;

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

		public CSharpGetMemberBinder(string name, bool resultIndexed, Type callingContext, IEnumerable<CSharpArgumentInfo> argumentInfo)
			: base(null, ignoreCase: false)
		{
		}

		public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return null;
		}
	}
}
